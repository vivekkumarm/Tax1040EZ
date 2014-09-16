/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : StateGatewayRepository.cs
Description                 : State repository
Author                      : Swapnesh.P
Created Date                : 20 March 2014
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

namespace JTL.Tax1040.BusinessLogic
{
    public class StateGatewayRepository : IStateGatewayRepository
    {
        private readonly MessagesRepository messageRepository;

        public void PersisttaxableState(List<TaxableState> taxableState, long userId, long userDataId)
        {
            if (taxableState != null)
            {
                var taxObject = Utilities.GetTaxObjectByUserIdAndUserDataId(userId, userDataId);
                if (taxObject.StateBO == null)
                {
                    taxObject.StateBO = new StateBO();
                }

                if (taxObject.StateBO.TaxableStates == null)
                {
                    taxObject.StateBO.TaxableStates = new List<TaxableState>();
                }

                TaxableState state = taxableState.Where(a => a.ResidentType == ResidentType.Resident.ToString()).FirstOrDefault();

                if (state != null && taxableState.Count > 0 && !Utilities.IsStringEmpty(state.ResidentType))
                {
                    if (taxObject.PersonalDetails == null)
                    {
                        taxObject.PersonalDetails = new PersonalDetails()
                        {
                            PrimaryTaxPayer = new PrimaryTaxPayer()
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

                    taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateId = state.StateId;
                    taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ResidenceState.StateName = state.StateName;

                    taxableState.Remove(state);
                }

                taxObject.StateBO.TaxableStates = taxableState;
                if (taxObject.ErrorMessages == null)
                {
                    taxObject.ErrorMessages = new List<ErrorMessage>();
                }

                Utilities.PersistTaxObject(userId, userDataId, taxObject);
            }
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


                personalDetails.Taxablestate = taxObject.StateBO.TaxableStates;

            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(userId, "Class:StateGatewayRepository,Method Name:GetAddressByUserIdAndUserDataId", ex);
            }

            return personalDetails;

        }
    }
}
