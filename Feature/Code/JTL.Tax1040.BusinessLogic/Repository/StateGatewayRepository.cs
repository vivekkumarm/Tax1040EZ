/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : StateGatewayRepository.cs
Description                 : State repository
Author                      : Swapnesh.P
Created Date                : 20 March 2014
 * 
 * 10Jul2014 Sathish changed references of state id/ country id to refer state/country
 * 24July2014 Ashok Kumar added method to retrieve only the supporting states of Tax1040product
 * 23 July 2014 Bhavani - Removed un used variables or objects messageRepository
*/

using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JTL.Tax1040.DataAccess;

namespace JTL.Tax1040.BusinessLogic
{
    public class StateGatewayRepository : IStateGatewayRepository
    {
        #region Local variable declaration
        IPersonalInfoDataService personalInfoDataService;
        private readonly MessagesRepository messageRepository;
        IPersonalInfoRepository personalInfoRepository;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="StateGatewayRepository"/> class.
        /// </summary>
        public StateGatewayRepository()
        {
            personalInfoDataService = new PersonalInfoDataService();
            messageRepository = new MessagesRepository();
            personalInfoRepository = new PersonalInfoRepository();
        }
        #endregion

        //08Aug2014 Sathish return user data id after persist
        public long PersisttaxableState(List<FilerState> taxableState, long userId, long userDataId)
        {
            try
            {
                if (taxableState != null)
                {
                    var taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);
                    if (taxObject.StateBO == null)
                    {
                        taxObject.StateBO = new StateBO();
                    }

                    if (taxObject.StateBO.FilerStates == null)
                    {
                        taxObject.StateBO.FilerStates = new List<FilerState>();
                    }

                    //   FilerState state = taxableState.Where(a => a.ResidentType == ResidentType.Resident.ToString()).FirstOrDefault();

                    taxObject.StateBO.FilerStates = taxableState;
                    if (taxObject.ErrorMessages == null)
                    {
                        taxObject.ErrorMessages = new List<ErrorMessage>();
                    }
                    //08Aug2014 Sathish return user data id after persist
                    userDataId = Utilities.PersistTaxObject(userId, userDataId, taxObject);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:StateGatewayRepository,Method Name:GetAddressByUserIdAndUserDataId", ex);
            }

            return userDataId;

        }


        //08Aug2014 Sathish return user data id after persist
        public long PersistResidentTypeConfirmation(FilerState residentTypeconfirmation, long userId, long userDataId)
        {
            try
            {
                if (residentTypeconfirmation != null)
                {
                    var taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);
                    if (taxObject.StateBO == null)
                    {
                        taxObject.StateBO = new StateBO();
                    }

                    if (taxObject.StateBO.FilerStates == null)
                    {
                        taxObject.StateBO.FilerStates = new List<FilerState>();
                    }

                    taxObject.StateBO.FilerStates.Where(a => a.State.StateId == residentTypeconfirmation.State.StateId).FirstOrDefault().IsReviewed = true;
                    taxObject.StateBO.FilerStates.Where(a => a.State.StateId == residentTypeconfirmation.State.StateId).FirstOrDefault().ResidentType = residentTypeconfirmation.ResidentType;


                   // taxObject.StateBO.FilerStates = taxableState;
                    if (taxObject.ErrorMessages == null)
                    {
                        taxObject.ErrorMessages = new List<ErrorMessage>();
                    }
                    //08Aug2014 Sathish return user data id after persist
                    userDataId = Utilities.PersistTaxObject(userId, userDataId, taxObject);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:StateGatewayRepository,Method Name:PersistResidentType", ex);
            }

            return userDataId;

        }


        /// <summary>
        /// Gets the Address by UserId and UserDataId.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userDataId"></param>
        /// <returns></returns>
        public dynamic GetAddressByUserIdAndUserDataId(long userId, long userDataId)
        {
            dynamic personalDetails = new ExpandoObject();
            try
            {
                BusinessObject.Tax1040 taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);
                if (taxObject.PersonalDetails == null)
                {
                    taxObject.PersonalDetails = new PersonalDetails()
                    {
                        PrimaryTaxPayer = new PrimaryTaxPayer()
                        {
                            Person = new Person()
                        }
                    };
                }

                if (taxObject.PersonalDetails.PrimaryTaxPayer == null)
                {
                    taxObject.PersonalDetails.PrimaryTaxPayer = new PrimaryTaxPayer()
                    {
                        Person = new Person()
                    };
                }

                if (taxObject.PersonalDetails.PrimaryTaxPayer.Person == null)
                {
                    taxObject.PersonalDetails.PrimaryTaxPayer.Person = new Person();
                }

                if (taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address == null)
                {
                    taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address = new Address();
                }

                if (taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState == null)
                {
                    taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState = new State();
                }

                if (taxObject.StateBO == null)
                {
                    taxObject.StateBO = new StateBO();
                }

                var taxPayerName = Constants.DEFAULT_TAX_PAYER_NAME;

                if (!string.IsNullOrEmpty(taxObject.PersonalDetails.PrimaryTaxPayer.Person.NickName))
                    taxPayerName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.NickName;
                else if (!string.IsNullOrEmpty(taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName))
                    taxPayerName = taxObject.PersonalDetails.PrimaryTaxPayer.Person.FirstName;

                personalDetails.Address = taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address;
                personalDetails.FilingStatus = taxObject.PersonalDetails.PrimaryTaxPayer.FilingStatus;
                personalDetails.TaxPayerName = taxPayerName;
                personalDetails.ResidenceState = taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState;

                if (taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateName == TypeDescriptor.GetConverter(typeof(StateList)).ConvertToString(StateList.NewYork)
                    || taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateName == TypeDescriptor.GetConverter(typeof(StateList)).ConvertToString(StateList.Missouri)
                    || taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateName == TypeDescriptor.GetConverter(typeof(StateList)).ConvertToString(StateList.Illinois)
                   || taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateName == TypeDescriptor.GetConverter(typeof(StateList)).ConvertToString(StateList.California)
                     || taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateName == TypeDescriptor.GetConverter(typeof(StateList)).ConvertToString(StateList.NewJersey)
                    )
                {
                    personalDetails.SupportingState = true;
                }
                else
                {
                    personalDetails.SupportingState = false;
                }

                if (taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateName == TypeDescriptor.GetConverter(typeof(StateList)).ConvertToString(StateList.Alaska)
                   || taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateName == TypeDescriptor.GetConverter(typeof(StateList)).ConvertToString(StateList.Florida)
                   || taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateName == TypeDescriptor.GetConverter(typeof(StateList)).ConvertToString(StateList.Texas)
                  || taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateName == TypeDescriptor.GetConverter(typeof(StateList)).ConvertToString(StateList.SouthDakota)
                    || taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateName == TypeDescriptor.GetConverter(typeof(StateList)).ConvertToString(StateList.Wyoming)
                                      || taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateName == TypeDescriptor.GetConverter(typeof(StateList)).ConvertToString(StateList.Washington)
                                                         || taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateName == TypeDescriptor.GetConverter(typeof(StateList)).ConvertToString(StateList.Nevada)
                    )
                {
                    personalDetails.TaxExcemptionState = true;
                }
                else
                {
                    personalDetails.TaxExcemptionState = false;
                }


                personalDetails.Taxablestate = taxObject.StateBO.FilerStates;

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:StateGatewayRepository,Method Name:GetAddressByUserIdAndUserDataId", ex);
            }

            return personalDetails;

        }

        /// <summary>
        /// Get All the Supporting States
        /// </summary>
        /// <returns></returns>
        public List<State> GetAllSupportingState()
        {
            return personalInfoDataService.GetAllSupportingState();
        }

    }
}
