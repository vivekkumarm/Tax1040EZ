/*
Copyright                   : Copyright Jeevan Technologies
File Name                   : TaxReturnController.cs
Description                 : Tax Return Controller.
Author                      : Saravanan N
Created Date                : 14th April, 2014
 
Modification History:
---------------------
 * 28 Apr 2014 - Vincent-Added GetIncomeandErrorList method for income summary
 * 30 Apr 2014 - Vincent-Made a changes to GetIncomeandErrorList method for income summary
 * 30 Apr 2014 - Bala, Added Cmmn method to get Eligibility Diagnostics ErrorList.
 * 28 May 2014 - Ashok Kumar modified GetEligibilityDiagnosticsErrorList to return Error in 2 list. 
 * 06Jun2014 Sathish returns elgibility error count for each tab used to disable breadcrum menu
 * Thileep - 18th July,2014 Changed GetEligibilityDiagnosticsErrorList To get focus on EZ Eligibility for Wages,INT,OID section
 * 28 July 2014 Swapnesh - Changes done to display all Income diagnostics
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using JTL.Tax1040.BusinessLogic;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;
using System.IO;

namespace JTL.Tax1040.WebApi.Controllers
{
    /// <summary>
    /// Controller contains Tax Object related methods.
    /// </summary>
    public class TaxReturnController : ApiController
    {
        #region Private variables
        private readonly ITaxReturnRepository taxReturnRepository;
        #endregion

        #region Constructor
        public TaxReturnController()
        {
            taxReturnRepository = new TaxReturnRepository();
        }
        #endregion

        #region Controller Methods
        //Persist Session Data into Tax Object
        [HttpPost]
        public void PersistSessionData(dynamic userData)
        {
            long userId = 0;
            long.TryParse(userData.userId.ToString(), out userId);

            long userDataId = 0;
            long.TryParse(userData.userDataId.ToString(), out userDataId);

            string sessionData = userData.lastVisitedUrl.ToString();

            taxReturnRepository.PersistSessionData(userId, userDataId, sessionData);
        }
        #endregion

        #region Get Income

        [HttpPost]
        // 18Jun2014 Sathish Return returned selected income to show or hide 
        public System.Tuple<double, double, double, double, string, System.Tuple<bool, bool, bool, bool>, IEnumerable<ErrorMessage>> GetIncomeSummary(dynamic userInputData)
        {
            long userDataId = 0;
            long.TryParse(userInputData.UserDataId.ToString(), out userDataId);

            long userId = 0;
            long.TryParse(userInputData.UserId.ToString(), out userId);

            return taxReturnRepository.GetIncomeSummary(userId, userDataId);
        }


        #endregion

        #region Get Eligibility Diagnostics
        [HttpPost]
        public dynamic GetEligibilityDiagnosticsErrorList(dynamic userInputData)
        {
            long w2errorCount = 0;
            long InterestIncomeerrorcount = 0;
            long OtherIncomeerrorcount = 0;
            long Unemploymenterrorcount = 0;
            long primaryFilerCount = 0;
            long spouseErrorCount = 0;
            long addressErrorCount = 0;

            List<ErrorMessage> taxObjectErrorList = null;
            // 06Jun2014 Sathish added eligibilityErrorCountBasedOnTab to get eligibility error count for menu
            Dictionary<string, int> eligibilityErrorCountBasedOnTab = null;
            List<ErrorMessage> eligibilityErrorList = null;

            //Saravanan N - 26th June, 2014 - User didn't have userDataId then to avoid error this condition added.
            if (userInputData.UserDataId == null)
            {
                userInputData.UserDataId = 0;
            }

            JTL.Tax1040.BusinessObject.Tax1040 tax1040Object = Utilities.GetTaxObjectByUserIdAndUserDataId(userInputData.UserId.Value, userInputData.UserDataId.Value);

            if (tax1040Object != null && tax1040Object.ErrorMessages != null)
            {
                primaryFilerCount = tax1040Object.ErrorMessages.Where(err => err.ErrorType == Constants.TOPIC_ERROR && err.Topic == Constants.TOPIC_PERSONAL_PRIMARYFILER).Count();
                spouseErrorCount = tax1040Object.ErrorMessages.Where(err => err.ErrorType == Constants.TOPIC_ERROR && err.Topic == Constants.TOPIC_PERSONAL_SPOUSE).Count();
                addressErrorCount = tax1040Object.ErrorMessages.Where(err => err.ErrorType == Constants.TOPIC_ERROR && err.Topic == Constants.TOPIC_PERSONAL_ADDRESS).Count();

                w2errorCount = tax1040Object.ErrorMessages.Where(err => err.ErrorType == Constants.TOPIC_ERROR && err.Topic == Constants.TOPIC_WAGES).Count();
                InterestIncomeerrorcount = tax1040Object.ErrorMessages.Where(err => err.ErrorType == Constants.TOPIC_ERROR && (err.Topic == Constants.TOPIC_FORM_INT
                                                                                    || err.Topic == Constants.TOPIC_FORM_OID
                                                                                    || err.Topic == Constants.TOPIC_INTEREST_INCOME)).Count();

                OtherIncomeerrorcount = tax1040Object.ErrorMessages.Where(err => err.ErrorType == Constants.TOPIC_ERROR && (err.Topic == Constants.TOPIC_OTHER_INCOME_SSB_RRB
                                                                            || err.Topic == Constants.TOPIC_OTHER_INCOME_Alaska
                                                                            || err.Topic == Constants.TOPIC_OTHER_INCOME_State_And_Local
                                                                            || err.Topic == Constants.TOPIC_OTHER_INCOME)).Count();
                Unemploymenterrorcount = tax1040Object.ErrorMessages.Where(err => err.ErrorType == Constants.TOPIC_ERROR && err.Topic == Constants.TOPIC_UNEMPLOYMENT_COMPENSATION).Count();

                //string topic = userInputData.Topic;
                //taxObjectErrorList = tax1040Object.ErrorMessages.FindAll(em => em.ErrorCode.StartsWith(topic.Trim() + "_ER"));
                string topic = userInputData.Topic;
                string tab = userInputData.Tab;
                // 20Jun2014 Sathish removed hard coded value in message type and used constant
                if (!string.IsNullOrEmpty(topic))
                {
                    taxObjectErrorList = tax1040Object.ErrorMessages.FindAll(em => (em.Topic == topic) && (em.MessageType == Constants.MESSAGE_TYPE_ER));
                }
                else if (!string.IsNullOrEmpty(tab))
                {
                    taxObjectErrorList = tax1040Object.ErrorMessages.FindAll(em => (em.Tab == tab) && (em.MessageType == Constants.MESSAGE_TYPE_ER));
                }
                if (tax1040Object.PersonalDetails != null && tax1040Object.PersonalDetails.PrimaryTaxPayer != null && tax1040Object.PersonalDetails.PrimaryTaxPayer.FilingStatus != FilingStatus.MarriedFilingJointly)
                {
                    topic = "Spouse";
                    if (taxObjectErrorList != null)
                    {
                        taxObjectErrorList.RemoveAll(em => em.ErrorCode.StartsWith(topic.Trim() + "_" + Constants.MESSAGE_TYPE_ER));
                    }
                }

                if (taxObjectErrorList != null)
                {
                    taxObjectErrorList.RemoveAll(em => em.Topic.StartsWith(Constants.TOPIC_EFILE));
                }
                tax1040Object.ErrorMessages.RemoveAll((em => em.Topic.StartsWith(Constants.TOPIC_EFILE)));


                // 06Jun2014 Sathish returns elgibility error count for each tab used to disable breadcrum menu
                eligibilityErrorList = tax1040Object.ErrorMessages.FindAll(em => em.MessageType.Equals(Constants.MESSAGE_TYPE_ER));

                //Thileep - 18th July,2014 To get focus  on EZ Eligibility for INT & OID
                int formId = 0;
                string controlToFocus = "";
                bool focusToINT = false;
                string messageTarget = "";
                if (tax1040Object.Income != null && tax1040Object.Income.Form1099INT != null && tax1040Object.Income.Form1099INT.Count() > 0)
                {
                    focusToINT = true;
                    //Get minimum of INT id.
                    formId = tax1040Object.Income.Form1099INT.Min(x => x.Form1099INTId);
                    //Control to focus
                    controlToFocus = "collapseOne-txtInterestIncome";
                    messageTarget = "/Income/f1099int.html";

                }
                else
                {
                    if (tax1040Object.Income != null && tax1040Object.Income.Form1099OID != null && tax1040Object.Income.Form1099OID.Count() > 0)
                    {
                        //Get minimum of OID id.
                        formId = tax1040Object.Income.Form1099OID.Min(x => x.Form1099OIDId);
                        //Control to focus
                        controlToFocus = "collapseOne-txtOriginalIssueDiscount";
                        messageTarget = "/Income/f1099oid.html";
                    }
                }

                tax1040Object.ErrorMessages.Where(err => err.ErrorCode == Constants.INTEREST_INCOME_TAXABLE_INTEREST_EXCEEDS_LIMIT);
                if (tax1040Object.ErrorMessages.Where(err => err.ErrorCode == Constants.INTEREST_INCOME_TAXABLE_INTEREST_EXCEEDS_LIMIT).Count() > 0)
                {
                    tax1040Object.ErrorMessages.Where(err => err.ErrorCode == Constants.INTEREST_INCOME_TAXABLE_INTEREST_EXCEEDS_LIMIT).Single().FormId = formId;
                    tax1040Object.ErrorMessages.Where(err => err.ErrorCode == Constants.INTEREST_INCOME_TAXABLE_INTEREST_EXCEEDS_LIMIT).Single().FieldName = controlToFocus;
                    tax1040Object.ErrorMessages.Where(err => err.ErrorCode == Constants.INTEREST_INCOME_TAXABLE_INTEREST_EXCEEDS_LIMIT).Single().MessageTarget = messageTarget;


                    if (focusToINT)
                    {
                        tax1040Object.ErrorMessages.Where(err => err.ErrorCode == Constants.INTEREST_INCOME_TAXABLE_INTEREST_EXCEEDS_LIMIT).Single().Topic = Constants.TOPIC_FORM_INT;
                    }
                    else
                    {
                        tax1040Object.ErrorMessages.Where(err => err.ErrorCode == Constants.INTEREST_INCOME_TAXABLE_INTEREST_EXCEEDS_LIMIT).Single().Topic = Constants.TOPIC_FORM_OID;
                    }
                }

                //Thileep - 18th July,2014 To get focus on EZ Eligibility for Wages section
                bool focusWages = false;
                string messageTargetWages = "";
                string controlToFocusWages = "";
                int formIdWages = 0;
                if (tax1040Object.Income != null && tax1040Object.Income.W2Wages != null && tax1040Object.Income.W2Wages.Count() > 0)
                {
                    focusWages = true;

                    //ForeignEmployment doesn't have any Wages entry field, hence exclude this W2 and get next level W2 Id in the list.
                    if (tax1040Object.Income.W2Wages.Where(x => x.EmploymentType != EmploymentType.ForeignEmployment).Count() > 0)
                    {
                        //Find the W2 and its ID, to which control has to focus.
                        formIdWages = tax1040Object.Income.W2Wages.Where(x => x.EmploymentType != EmploymentType.ForeignEmployment).Min(x => x.W2Id);
                    }


                    //Get Control based on EmployeeType.
                    if (tax1040Object.Income.W2Wages.Where(w2 => w2.W2Id == formIdWages).Count() > 0)
                    {
                        switch (tax1040Object.Income.W2Wages.Where(w2 => w2.W2Id == formIdWages).First().EmploymentType)
                        {
                            case EmploymentType.HouseholdEmployeeWages:
                                controlToFocusWages = "collapseSeven-txtHouseholdEmployeeWages";
                                break;

                            case EmploymentType.TaxableScholarshipIncome:
                                controlToFocusWages = "collapseEight-txtTaxableScholarshipAmount";
                                break;

                            default:
                                controlToFocusWages = "collapseThree-txtW2FederalWages";
                                break;
                        }
                    }



                    tax1040Object.ErrorMessages.Where(err => err.ErrorCode == Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME);


                    if (tax1040Object.ErrorMessages.Where(err => err.ErrorCode == Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME).Count() > 0)
                    {
                        messageTargetWages = "/Income/W2.html";
                        tax1040Object.ErrorMessages.Where(err => err.ErrorCode == Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME).Single().FormId = formIdWages;
                        tax1040Object.ErrorMessages.Where(err => err.ErrorCode == Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME).Single().FieldName =
                            controlToFocusWages;
                        tax1040Object.ErrorMessages.Where(err => err.ErrorCode == Constants.TAX_AND_WRAP_UP_TAXABLE_INCOME).Single().MessageTarget =
                            messageTargetWages;
                    }
                }

                if (eligibilityErrorList != null)
                {
                    eligibilityErrorCountBasedOnTab = new Dictionary<string, int>();
                    var eligibilityError = from em in eligibilityErrorList
                                           group em.Tab by em.Tab into g // Group error list by tab
                                           select new
                                           {
                                               Tab = g.Key, // Get tab name
                                               EligiblityErrorCount = g.ToList() // Get record count for each table
                                           };

                    // add Tab and EligiblityErrorCount in direcotryused in return
                    foreach (var em in eligibilityError)
                    {
                        eligibilityErrorCountBasedOnTab.Add(em.Tab, em.EligiblityErrorCount.Count);
                    }
                }

            }


            // 18Jul2014 Sathish created payment DTO for user data 
            PaymentDTO paymentDTO = new PaymentDTO()
            {
                UserDataId = userInputData.UserDataId.Value,
                UserId = userInputData.UserId.Value
            };

            System.Tuple<long, long, long, long, long, long, long> incomeLeftMenuErrorCount = new System.Tuple<long, long, long, long, long, long, long>
                                                          (w2errorCount, InterestIncomeerrorcount, OtherIncomeerrorcount, Unemploymenterrorcount
                                                          , primaryFilerCount, spouseErrorCount, addressErrorCount);

            return new System.Tuple<List<ErrorMessage>, List<ErrorMessage>, Dictionary<string, int>, bool, System.Tuple<long, long, long, long, long, long, long>>(tax1040Object.ErrorMessages,
                                                                                                        taxObjectErrorList,
                                                                                                        eligibilityErrorCountBasedOnTab,
                                                                                                        taxReturnRepository.IsOrderExistByUserDataId(paymentDTO)
                                                                                                        , incomeLeftMenuErrorCount); //18Jul2014 Sathish get order exist by user data id
        }

        #endregion

        #region GetWorksheet

        /// <summary>
        /// Get the work sheet
        /// will be removed after testing
        /// </summary>
        /// <param name="userInputData"></param>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage GetWorksheet(long userId, long userDataId, string worksheetName)
        {
            UserDTO userDTO = new UserDTO() { UserId = userId, UserDataId = userDataId };
            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            var stream = new MemoryStream(taxReturnRepository.GetWorksheet(userDTO, worksheetName));
            result.Content = new StreamContent(stream);
            result.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/pdf");
            result.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment")
            {
                FileName = worksheetName + ".pdf"
            };
            //Bind Pdf controls -- Finished//
            return result;
        }

        #endregion

        /// <summary>
        /// Calculation for tax meter
        /// </summary>
        /// <param name="UserData">The user data.</param>
        /// <returns></returns>
        [HttpPost]
        public double GetFederalSummaryDetails(UserDTO UserData)
        {
            return taxReturnRepository.GetFederalSummaryDetails(UserData);
        }

        /// <summary>
        /// Gets the tax summary.
        /// </summary>
        /// <param name="UserData">The user data.</param>
        /// <returns></returns>
        [HttpPost]
        public JTL.Tax1040.BusinessObject.Tax1040 GetTaxSummary(UserDTO UserData)
        {
            JTL.Tax1040.BusinessObject.Tax1040 tax1040Object = Utilities.GetTaxObjectByUserIdAndUserDataId(UserData.UserId, UserData.UserDataId);
            return tax1040Object;
        }

        #region UserRatingAndReferral

        //Sathish 18Jul2014 Sathish created method to get or persit user rating.

        /// <summary>
        /// Gets the user rating.
        /// </summary>
        /// <param name="userDTO">The user DTO.</param>
        /// <returns></returns>
        //22Jul2014 Sathish return user rating BO
        [HttpPost]
        public UserRating GetUserRating(UserDTO userDTO)
        {
            return taxReturnRepository.GetUserRating(userDTO);
        }

        /// <summary>
        /// Persists the user rating.
        /// </summary>
        /// <param name="userData">The user data.</param>
        [HttpPost]
        public void PersistUserRating(dynamic userData)
        {
            UserDTO userDTO = JsonConvert.DeserializeObject<UserDTO>(userData.UserDTO.ToString());
            UserRating userRating = JsonConvert.DeserializeObject<UserRating>(userData.UserRating.ToString());
            taxReturnRepository.PersistUserRating(userDTO, userRating);
        }

        /// <summary>
        /// Persists the user referral.
        /// </summary>
        /// <param name="userData">The user data.</param>
        [HttpPost]
        //22Jul2014 Sathish added jason conversation for referral rating
        public void PersistUserReferral(dynamic userData)
        {
            UserDTO userDTO = JsonConvert.DeserializeObject<UserDTO>(userData.UserDTO.ToString());
            ReferralRating referralRating = JsonConvert.DeserializeObject<ReferralRating>(userData.ReferralRating.ToString());
            taxReturnRepository.PersistUserReferral(userDTO, referralRating);
        }
        #endregion
    }
}
