using JTL.Tax1040.WebApi.Security;
using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace JTL.Tax1040.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            //Create and instance of TokenInspector setting the default inner handler
            //makecert -sr CurrentUser -ss My -a sha1 -n CN=WebAPI-Token -sky exchange -pe
            TokenInspector tokenInspector = new TokenInspector() { InnerHandler = new HttpControllerDispatcher(config) };

            //Pre Login Section Starts
            #region PreLogin Config
            config.Routes.MapHttpRoute(
                name: "UserRegistration",
                routeTemplate: "user/create",
                defaults: new
                    {
                        Controller = "User",
                        action = "PersistUser"
                    }
                //,
                //constraints: null,
                //handler: tokenInspector
                );

            config.Routes.MapHttpRoute(
                name: "GetUsernameByEmaild",
                routeTemplate: "user/getusernamebyemail",
                defaults: new
                    {
                        Controller = "User",
                        action = "GetUsernameByEmail"
                    }
                );

            config.Routes.MapHttpRoute(
                name: "GetUserIdByUserDetails",
                routeTemplate: "user/getuseridbyuserdetails",
                defaults: new
                    {
                        Controller = "User",
                        action = "GetUserIdByUserDetails"
                    }
                );

            config.Routes.MapHttpRoute(
                name: "SignInUser",
                routeTemplate: "user/signin",
                defaults: new
                    {
                        Controller = "User",
                        action = "SignInUser"
                    }
                  );

            config.Routes.MapHttpRoute(
                name: "GetUserNameAndIdByUserDetails",
                routeTemplate: "user/getusernameandidbyuserdetails",
                defaults: new
                    {
                        Controller = "User",
                        action = "GetUserNameAndIdByUserDetails"
                    }
                );

            config.Routes.MapHttpRoute(
                name: "GetUserIdByUserName",
                routeTemplate: "user/getuseridbyusername",
                defaults: new
                    {
                        Controller = "User",
                        action = "GetUserIdByUserName"
                    }
             );


            config.Routes.MapHttpRoute(
                name: "UpdateEmailByUserId",
                routeTemplate: "user/updateemailbyuserid",
                defaults: new
                {
                    Controller = "User",
                    action = "UpdateEmailByUserId"
                }
                //,
                //constraints: null,
                //handler: tokenInspector
                );

            config.Routes.MapHttpRoute(
             name: "UpdatePasswordResetCode",
             routeTemplate: "user/updatepasswordresetcode",
             defaults: new
             {
                 Controller = "User",
                 action = "UpdatePasswordResetCode"
             }
             );

            config.Routes.MapHttpRoute(
             name: "ResetPassword",
             routeTemplate: "user/resetpassword",
             defaults: new
             {
                 Controller = "User",
                 action = "ResetPassword"
             }
                //,
                //constraints: null,
                //handler: tokenInspector
             );

            config.Routes.MapHttpRoute(
             name: "ValidateUserPasswordResetCode",
             routeTemplate: "user/validateuserpasswordresetcode",
             defaults: new
             {
                 Controller = "User",
                 action = "ValidateUserPasswordResetCode"
             }
                //,
                //constraints: null,
                //handler: tokenInspector
             );

            config.Routes.MapHttpRoute(
             name: "UpdateUserNamePasswordResetCodeBySecurityInfo",
             routeTemplate: "user/updateusernamepasswordresetcodebysecurityinfo",
             defaults: new
             {
                 Controller = "User",
                 action = "UpdateUserNamePasswordResetCodeBySecurityInfo"
             }
              );

            config.Routes.MapHttpRoute(
             name: "UpdateEmailBySecurityInfo",
             routeTemplate: "user/updateemailbysecurityinfo",
             defaults: new
             {
                 Controller = "User",
                 action = "UpdateEmailBySecurityInfo"
             }
                //,
                //constraints: null,
                //handler: tokenInspector
             );

            config.Routes.MapHttpRoute(
             name: "GetSecurityQuestion",
             routeTemplate: "user/getsecurityquestion",
             defaults: new
             {
                 Controller = "User",
                 action = "GetSecurityQuestion"
             }
                //,
                //constraints: null,
                //handler: tokenInspector
             );

            config.Routes.MapHttpRoute(
             name: "GetSecurityQuestionByUserId",
             routeTemplate: "user/getsecurityquestionbyuserid",
             defaults: new
             {
                 Controller = "User",
                 action = "GetSecurityQuestionByUserId"
             }

             );

            config.Routes.MapHttpRoute(
            name: "ResendEmailForForgotUsernamePassword",
            routeTemplate: "user/resendemailforforgotusernamepassword",
            defaults: new
            {
                Controller = "User",
                action = "ResendEmailForForgotUsernamePassword"
            }
                //,
                //constraints: null,
                //handler: tokenInspector
            );

            config.Routes.MapHttpRoute(
            name: "GetEmailByUserId",
            routeTemplate: "user/getemailbyuserid",
            defaults: new
            {
                Controller = "User",
                action = "GetEmailByUserId"
            }
                // ,
                //constraints: null,
                //handler: tokenInspector
            );

            config.Routes.MapHttpRoute(
            name: "ResendEmailForForgotUserName",
            routeTemplate: "user/resendemailforforgotusername",
            defaults: new
            {
                Controller = "User",
                action = "ResendEmailForForgotUserName"
            }
                //,
                //constraints: null,
                //handler: tokenInspector
            );

            config.Routes.MapHttpRoute(
            name: "GetSessionDatabyUserIdAndUserDataId",
            routeTemplate: "user/getsessiondatabyuseridanduserdataid",
            defaults: new
            {
                Controller = "User",
                action = "GetSessionDataByUserIdAndUserDataId"
            }
                // ,
                //constraints: null,
                //handler: tokenInspector
            );


            config.Routes.MapHttpRoute(
            name: "ResendEmailForForgotPassword",
            routeTemplate: "user/resendemailforforgotpassword",
            defaults: new
            {
                Controller = "User",
                action = "ResendEmailForForgotPassword"
            }
                // ,
                //constraints: null,
                //handler: tokenInspector
            );


            #endregion

            //Pre Login Section Ends
            #region Personal Info Config

            //Personal Info Starts

            config.Routes.MapHttpRoute(
            name: "CreatePersonalInfo",
            routeTemplate: "personalinfo/primarytaxpayercreate",
            defaults: new
            {
                Controller = "PersonalInfo",
                action = "PersistPrimaryTaxPayer"
            }
                 ,
                constraints: null,
                handler: tokenInspector
            );

            config.Routes.MapHttpRoute(
            name: "CreateAddress",
            routeTemplate: "personalinfo/addresscreate",
            defaults: new
            {
                Controller = "PersonalInfo",
                action = "PersistAddress"
            }
                 ,
                constraints: null,
                handler: tokenInspector
            );

            //Added by vivek for spouse insert
            config.Routes.MapHttpRoute(
            name: "CreateSpouse",
            routeTemplate: "personalinfo/spouse",
            defaults: new
            {
                Controller = "PersonalInfo",
                action = "PersistSpouse"
            }
                 ,
                constraints: null,
                handler: tokenInspector
            );
            //Added by vivek for eligiblity
            config.Routes.MapHttpRoute(
         name: "GetEligiblity",
         routeTemplate: "personalinfo/eligibility",
         defaults: new
         {
             Controller = "PersonalInfo",
             action = "EzEligibilityPersist"
         }
                ,
                constraints: null,
                handler: tokenInspector
         );

            #region Get Methods
            //config.Routes.MapHttpRoute(
            //   name: "GetPersonInfo",
            //   routeTemplate: "user/getpersonalinfobyid",
            //   defaults: new
            //   {
            //       Controller = "PersonalInfo",
            //       action = "GetPersonalInfoByPersonalInfoId"
            //   }
            //    //,
            //    //constraints: null,
            //    //handler: tokenInspector
            //   );

            config.Routes.MapHttpRoute(
            name: "GetState",
            routeTemplate: "personalinfo/getstate",
            defaults: new
            {
                Controller = "PersonalInfo",
                action = "GetAllState"
            }
                           );

            config.Routes.MapHttpRoute(
             name: "GetAllLivingStates",
             routeTemplate: "personalinfo/getalllivingstates",
             defaults: new
             {
                 Controller = "PersonalInfo",
                 action = "GetAllLivingStates"
             }

             );

            config.Routes.MapHttpRoute(
            name: "GetCountry",
            routeTemplate: "personalinfo/getcountry",
            defaults: new
            {
                Controller = "PersonalInfo",
                action = "GetAllCountry"
            }

            );

            config.Routes.MapHttpRoute(
                  name: "GetPersonInfo",
                  routeTemplate: "personalinfo/getprimarytaxpayer",
                  defaults: new
                  {
                      Controller = "PersonalInfo",
                      action = "GetPrimaryTaxPayerByUserIdAndUserDataId"
                  }
                ,
                constraints: null,
                handler: tokenInspector
                  );

            config.Routes.MapHttpRoute(
                       name: "GetSpouseInfo",
                       routeTemplate: "personalinfo/getspouseinfo",
                       defaults: new
                       {
                           Controller = "PersonalInfo",
                           action = "GetSpouseByUserIdAndUserDataId"
                       }
                 ,
                constraints: null,
                handler: tokenInspector
                       );

            config.Routes.MapHttpRoute(
                       name: "GetAddress",
                       routeTemplate: "personalinfo/getaddress",
                       defaults: new
                       {
                           Controller = "PersonalInfo",
                           action = "GetAddressByUserIdAndUserDataId"
                       }
                 ,
                constraints: null,
                handler: tokenInspector
                       );

            config.Routes.MapHttpRoute(
                             name: "GetPersonalDetailsInfo",
                             routeTemplate: "personalinfo/getpersonaldetailsbyuseridanduserdataid",
                             defaults: new
                             {
                                 Controller = "PersonalInfo",
                                 action = "GetPersonalDetailsByUserIdAndUserDataId"
                             }
                 ,
                constraints: null,
                handler: tokenInspector
                             );

            config.Routes.MapHttpRoute(
                                       name: "GetUserDataIdByUserId",
                                       routeTemplate: "personalinfo/getuserdataidbyuserid",
                                       defaults: new
                                       {
                                           Controller = "PersonalInfo",
                                           action = "GetUserDataIdByUserId"
                                       }
                 ,
                constraints: null,
                handler: tokenInspector
                                       );

            config.Routes.MapHttpRoute(
                                      name: "GetPersonId",
                                      routeTemplate: "personalinfo/getpersonidbyuseridanduserdataid",
                                      defaults: new
                                      {
                                          Controller = "PersonalInfo",
                                          action = "GetPersonIdByUserIdAndUserDataId"
                                      }
                 ,
                constraints: null,
                handler: tokenInspector
                                      );


            #endregion
            //Personal Info Ends

            #endregion

            #region Income Section

            #region IncomeGateway
            config.Routes.MapHttpRoute(
                           name: "GetIncomeGatewayData",
                           routeTemplate: "incomegateway/getincomegatewaydata",
                           defaults: new
                           {
                               Controller = "IncomeGateway",
                               action = "GetIncomeGatewayData"
                           },
                constraints: null,
                handler: tokenInspector);

            config.Routes.MapHttpRoute(
               name: "PersistIncomeGateway",
               routeTemplate: "incomegateway/persistincomegateway",
               defaults: new
               {
                   Controller = "IncomeGateway",
                   action = "PersistIncomeGateway"
               }
                 ,
                constraints: null,
                handler: tokenInspector
               );
            #endregion

            #region W2

            config.Routes.MapHttpRoute(
             name: "PersistW2Data",
             routeTemplate: "w2/persistw2data",
             defaults: new
             {
                 Controller = "W2",
                 action = "PersistW2Data"
             }
                 ,
                constraints: null,
                handler: tokenInspector
             );


            config.Routes.MapHttpRoute(
                           name: "GetW2Data",
                           routeTemplate: "w2/getw2data",
                           defaults: new
                           {
                               Controller = "W2",
                               action = "GetW2Data"
                           }
                  ,
                constraints: null,
                handler: tokenInspector
                           );

            config.Routes.MapHttpRoute(
                               name: "GetW2ListandErrorList",
                               routeTemplate: "w2/getw2listanderrorlist",
                               defaults: new
                               {
                                   Controller = "W2",
                                   action = "GetW2ListandErrorList"
                               }
                 ,
                constraints: null,
                handler: tokenInspector
                               );

            config.Routes.MapHttpRoute(
                           name: "GetEmployeeCode",
                           routeTemplate: "w2/getemployeecode",
                           defaults: new
                           {
                               Controller = "W2",
                               action = "GetEmployeeCode"
                           }
                 ,
                constraints: null,
                handler: tokenInspector
                           );

            config.Routes.MapHttpRoute(
                 name: "DeleteW2ById",
                 routeTemplate: "w2/deletew2byid",
                                          defaults: new
                                          {
                                              Controller = "W2",
                                              action = "DeleteW2ById"
                                          }
                ,
                constraints: null,
                handler: tokenInspector
                                          );

            config.Routes.MapHttpRoute(
                               name: "GetW2OtherCode",
                               routeTemplate: "w2/getw2othercode",
                               defaults: new
                               {
                                   Controller = "W2",
                                   action = "GetW2OtherCode"
                               }
                 ,
                constraints: null,
                handler: tokenInspector
                               );
            #endregion

            #region Form1099G - Unemployment Income
            config.Routes.MapHttpRoute(
                 name: "PersistUnemployment",
                 routeTemplate: "unemployment/persistunemployment",
                               defaults: new
                               {
                                   Controller = "Unemployment",
                                   action = "PersistUnemployment"
                               }
                 ,
                constraints: null,
                handler: tokenInspector
                               );


            config.Routes.MapHttpRoute(
                             name: "GetUnemploymentById",
                             routeTemplate: "unemployment/getunemploymentbyid",
                           defaults: new
                           {
                               Controller = "Unemployment",
                               action = "GetUnemploymentById"
                           }
                ,
                constraints: null,
                handler: tokenInspector
                           );

            config.Routes.MapHttpRoute(
                name: "GetAllUnemployment",
                routeTemplate: "unemployment/getallunemployment",
                defaults: new
                {
                    Controller = "Unemployment",
                    action = "GetAllUnemployment"
                }
                  ,
                constraints: null,
                handler: tokenInspector
                );

            config.Routes.MapHttpRoute(
            name: "DeleteUnemploymentById",
            routeTemplate: "unemployment/deleteunemploymentbyid",
                                     defaults: new
                                     {
                                         Controller = "Unemployment",
                                         action = "DeleteUnemploymentById"
                                     }
                 ,
                constraints: null,
                handler: tokenInspector
                                     );


            #endregion

            #region Interest Income
            #region F1099INT


            config.Routes.MapHttpRoute(
        name: "CreateUserForm1099INTData",
    routeTemplate: "F1099INT/F1099INTinfocreate",
                            defaults: new
                            {
                                Controller = "InterestIncome",
                                action = "PersistTaxReturnForm1099INTData"
                            }
                  ,
                constraints: null,
                handler: tokenInspector
                            );

            config.Routes.MapHttpRoute(
                    name: "GetTax1099INTData",
                    routeTemplate: "F1099INT/F1099INTgettaxdata",
                            defaults: new
                            {
                                Controller = "InterestIncome",
                                action = "GetTaxReturn1099INTData"
                            }
                 ,
                constraints: null,
                handler: tokenInspector
                            );


            config.Routes.MapHttpRoute(
                                name: "GetTaxReturnErrorList",
                                routeTemplate: "F1099INT/GetTaxReturn1099INTListandErrorList",
                                defaults: new
                                {
                                    Controller = "InterestIncome",
                                    action = "GetTaxReturn1099INTListandErrorList"
                                }
                ,
                constraints: null,
                handler: tokenInspector
                                );


            config.Routes.MapHttpRoute(
            name: "DeleteForm1099INTById",
            routeTemplate: "F1099INT/deleteform1099INTbyid",
                                    defaults: new
                                    {
                                        Controller = "InterestIncome",
                                        action = "DeleteForm1099INTById"
                                    }
              ,
                constraints: null,
                handler: tokenInspector
                                    );





            #endregion

            #region F1099OID

            // Have to review by vivek.

            config.Routes.MapHttpRoute(
      name: "CreateTaxReturnForm1099OIDData",
      routeTemplate: "InterestIncome/F1099OIDinfocreate",
                               defaults: new
                               {
                                   Controller = "InterestIncome",
                                   action = "PersistTaxReturnForm1099OIDData"
                               }
                  ,
                constraints: null,
                handler: tokenInspector
                               );

            config.Routes.MapHttpRoute(
                   name: "GettingTaxReturn1099OIDData",
                   routeTemplate: "InterestIncome/F1099OIDgettaxdata",
                           defaults: new
                           {
                               Controller = "InterestIncome",
                               action = "GetTaxReturn1099OIDData"
                           }
                 ,
                constraints: null,
                handler: tokenInspector
                           );

            config.Routes.MapHttpRoute(
                               name: "GettingTaxReturnErrorList",
                               routeTemplate: "InterestIncome/GetTaxReturn1099OIDListandErrorList",
                           defaults: new
                           {
                               Controller = "InterestIncome",
                               action = "GetTaxReturn1099OIDListandErrorList"
                           }
                  ,
                constraints: null,
                handler: tokenInspector
                           );

            config.Routes.MapHttpRoute(
                 name: "DeleteForm1099OIDById",
                 routeTemplate: "InterestIncome/deleteform1099OIDbyid",
                                          defaults: new
                                          {
                                              Controller = "InterestIncome",
                                              action = "DeleteForm1099OIDById"
                                          }
                 ,
                constraints: null,
                handler: tokenInspector
                                          );



            config.Routes.MapHttpRoute(
                   name: "GetAllInterestIncome",
                   routeTemplate: "InterestIncome/getallinterestincome",
                           defaults: new
                           {
                               Controller = "InterestIncome",
                               action = "GetAllInterestIncome"
                           }
                 ,
                constraints: null,
                handler: tokenInspector
                           );

            #endregion

            #region InterestIncome Eligibility


            config.Routes.MapHttpRoute(
      name: "CreateTaxReturnInterestIncomeEligibilityData",
      routeTemplate: "interestincome/persistinterestincomeeligibilitydata",
                               defaults: new
                               {
                                   Controller = "InterestIncome",
                                   action = "PersistTaxReturnInterestIncomeEligibilityData"
                               }
                 ,
                constraints: null,
                handler: tokenInspector
                               );

            config.Routes.MapHttpRoute(
                   name: "GetTaxReturnInterestIncomeEligibilityData",
                   routeTemplate: "interestincome/getinterestincomeeligibilitydata",
                           defaults: new
                           {
                               Controller = "InterestIncome",
                               action = "GetTaxReturnInterestIncomeEligibilityData"
                           }
                 ,
                constraints: null,
                handler: tokenInspector
                           );
            #endregion
            #endregion

            #region Other Income
            config.Routes.MapHttpRoute(
      name: "PersistOtherIncome",
      routeTemplate: "otherincome/persistotherincome",
      defaults: new
      {
          Controller = "OtherIncome",
          action = "PersistOtherIncome"
      }
                ,
                constraints: null,
                handler: tokenInspector
      );

            config.Routes.MapHttpRoute(
            name: "GetOtherIncome",
            routeTemplate: "otherincome/getotherincome",
            defaults: new
            {
                Controller = "OtherIncome",
                action = "GetOtherIncome"
            }
                ,
                constraints: null,
                handler: tokenInspector
            );

            config.Routes.MapHttpRoute(
            name: "GetOtherIncomeSummary",
            routeTemplate: "otherincome/getotherincomesummary",
            defaults: new
            {
                Controller = "OtherIncome",
                action = "GetOtherIncomeSummary"
            }
                 ,
                constraints: null,
                handler: tokenInspector
            );

            config.Routes.MapHttpRoute(
           name: "DeleteOtherIncome",
           routeTemplate: "otherincome/deleteotherincome",
           defaults: new
           {
               Controller = "OtherIncome",
               action = "DeleteOtherIncome"
           }
                ,
                constraints: null,
                handler: tokenInspector
           );
            #endregion

            #endregion

            #region TaxReturn Controller related methods.

            config.Routes.MapHttpRoute(
            name: "PersistSessionData",
            routeTemplate: "taxreturn/persistsessiondata",
            defaults: new
            {
                Controller = "TaxReturn",
                action = "PersistSessionData"
            }
                //,
                //constraints: null,
                //handler: tokenInspector
           );

            config.Routes.MapHttpRoute(
            name: "GetIncomeSummary",
            routeTemplate: "taxreturn/getincomesummary",
            defaults: new
            {
                Controller = "TaxReturn",
                action = "GetIncomeSummary"
            }
                 ,
                constraints: null,
                handler: tokenInspector
           );

            config.Routes.MapHttpRoute(
            name: "GetEligibilityDiagnosticsErrorList",
            routeTemplate: "taxreturn/geteligibilitydiagnosticserrorlist",
            defaults: new
            {
                Controller = "TaxReturn",
                action = "GetEligibilityDiagnosticsErrorList"
            }
               ,
                constraints: null,
                handler: tokenInspector
           );

            #endregion

            #region Default
            config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/{controller}/{id}",
    defaults: new { id = RouteParameter.Optional }
          );

            config.Formatters.Remove(config.Formatters.XmlFormatter);
            System.Net.Http.Formatting.JsonMediaTypeFormatter jsonMediaFormatter = config.Formatters.JsonFormatter;
            jsonMediaFormatter.Indent = true;
            //jsonMediaFormatter.SerializerSettings.Converters.Add(new IsoDateTimeConverter { DateTimeFormat = "MM/dd/yyyy" });
            config.Formatters.Add(jsonMediaFormatter);
            #endregion

            #region Deduction

            config.Routes.MapHttpRoute(
                           name: "GetDeductionSummary",
                           routeTemplate: "deduction/getdeductionsummary",
                           defaults: new
                           {
                               Controller = "Deduction",
                               action = "GetDeductionSummary"
                           }
                 ,
                constraints: null,
                handler: tokenInspector
                           );
            #endregion

            #region EIC
            config.Routes.MapHttpRoute(
                           name: "GetEarnedIncomeCredit",
                           routeTemplate: "earnedincomecredit/getearnedincomecredit",
                           defaults: new
                           {
                               Controller = "EarnedIncomeCredit",
                               action = "GetEarnedIncomeCredit"
                           },
                constraints: null,
                handler: tokenInspector
                           );

            config.Routes.MapHttpRoute(
                           name: "PersistEarnedIncomeCredit",
                           routeTemplate: "earnedincomecredit/persistearnedincomecredit",
                           defaults: new
                           {
                               Controller = "EarnedIncomeCredit",
                               action = "PersistEarnedIncomeCredit"
                           },
                constraints: null,
                handler: tokenInspector
                           );

            config.Routes.MapHttpRoute(
                           name: "GetCreditSummary",
                           routeTemplate: "earnedincomecredit/getcreditsummary",
                           defaults: new
                           {
                               Controller = "EarnedIncomeCredit",
                               action = "GetCreditSummary"
                           },
                constraints: null,
                handler: tokenInspector
                           );


            #endregion

            #region Manage Account
            //<summary>
            //Get User Details By User Id
            //</summary>        
            // <returns>User Details of A Particular Id</returns>        
            config.Routes.MapHttpRoute(
            name: "GetUserDetailsByUserId",
            routeTemplate: "user/getuserdetailsbyuserid",
            defaults: new
            {
                Controller = "User",
                action = "GetUserDetailsByUserId"
            },
                constraints: null,
                handler: tokenInspector
            );

            //<summary>
            //Update User Details By User Id
            //</summary>        
            //<returns>Status</returns>
            config.Routes.MapHttpRoute(
            name: "UpdateUserDetailsByUserId",
            routeTemplate: "user/updateuserdetailsbyuserid",
            defaults: new
            {
                Controller = "User",
                action = "UpdateUserDetailsByUserId"
            },
                constraints: null,
                handler: tokenInspector
            );

            //<summary>
            //Validate User password By User Id
            //</summary>        
            //<returns>int</returns>
            config.Routes.MapHttpRoute(
            name: "ValidateUserPasswordByUserId",
            routeTemplate: "user/validatepasswordbyuserid",
            defaults: new
            {
                Controller = "User",
                action = "ValidateUserPasswordByUserId"
            },
                constraints: null,
                handler: tokenInspector
            );
            #endregion

            #region Tax And wrap-up
            config.Routes.MapHttpRoute(
            name: "PersistTaxesAndWrapUpData",
            routeTemplate: "taxesandwrapup/persisttaxesandwrapupdata",
            defaults: new
            {
                Controller = "TaxesAndWrapUp",
                action = "PersistTaxesAndWrapUpData"
            },
                constraints: null,
                handler: tokenInspector
            );

            #region Get
            config.Routes.MapHttpRoute(
                 name: "GetTaxAndWrapup",
                 routeTemplate: "taxesandwrapup/gettaxandwrapup",
                 defaults: new
                 {
                     Controller = "TaxesAndWrapUp",
                     action = "GetTaxAndWrapup"
                 },
                    constraints: null,
                    handler: tokenInspector
            );

            config.Routes.MapHttpRoute(
              name: "GetFederalTaxSummary",
              routeTemplate: "taxesandwrapup/getfederaltaxsummary",
              defaults: new
              {
                  Controller = "TaxesAndWrapUp",
                  action = "GetFederalTaxSummary"
              }
             ,
             constraints: null,
             handler: tokenInspector
              );

            //Vincent-26/06/14- Genernating 1040EZ Output Form
            config.Routes.MapHttpRoute(
              name: "Genernate1040EZForm",
              routeTemplate: "taxesandwrapup/genernate1040ezform",
              defaults: new
              {
                  Controller = "TaxesAndWrapUp",
                  action = "Genernate1040EZForm"
              }
             ,
             constraints: null,
             handler: tokenInspector
              );

            //config.Routes.MapHttpRoute(
            //  name: "TaxableIncomeEligibilityCheck",
            //  routeTemplate: "taxesandwrapup/taxableincomeeligibilitycheck",
            //  defaults: new
            //  {
            //      Controller = "TaxesAndWrapUp",
            //      action = "TaxableIncomeEligibilityCheck"
            //  }
            // ,
            // constraints: null,
            // handler: tokenInspector
            //  );

            #endregion


            #endregion


            #region State GateWay
            config.Routes.MapHttpRoute(
                    name: "PersistTaxablestate",
                    routeTemplate: "stategateway/persistTaxablestate",
                   defaults: new
                            {
                                Controller = "StateGateway",
                                action = "PersisttaxableState"
                            }
                ,
                constraints: null,
                handler: tokenInspector
                 );


            config.Routes.MapHttpRoute(
                name: "GetTaxablestateandAddress",
                routeTemplate: "stategateway/getaddress",
                defaults: new
                        {
                            Controller = "StateGateway",
                            action = "GetAddressByUserIdAndUserDataId"
                        },
                constraints: null,
                handler: tokenInspector
            );



            #endregion

            #region Payment

            #region Get

            config.Routes.MapHttpRoute(
                name: "GetPaymentDetails",
                routeTemplate: "payment/getpaymentdetails",
                defaults: new
                {
                    Controller = "Payment",
                    action = "GetPaymentDetails"
                }
                //,
                //constraints: null,
                //handler: tokenInspector
                );

            config.Routes.MapHttpRoute(
            name: "GetOrderAmount",
            routeTemplate: "payment/getorderamount",
            defaults: new
            {
                Controller = "Payment",
                action = "GetOrderAmount"
            }
                //,
                //constraints: null,
                //handler: tokenInspector
            );

            config.Routes.MapHttpRoute(
                    name: "GetIRSPaymentOption",
                    routeTemplate: "payment/getirspaymentoption",
                    defaults: new
                    {
                        Controller = "Payment",
                        action = "GetIRSPaymentOption"
                    }
                //,
                //constraints: null,
                //handler: tokenInspector
                    );

            config.Routes.MapHttpRoute(
                    name: "GetOrderByOrderId",
                    routeTemplate: "payment/getorderbyorderid",
                    defaults: new
                    {
                        Controller = "Payment",
                        action = "GetOrderByOrderId"
                    }
                //,
                //constraints: null,
                //handler: tokenInspector
                    );

            //Added By yogalakshmi on 15th May 2014
            config.Routes.MapHttpRoute(
                    name: "GetAllProductSKU",
                    routeTemplate: "payment/getallproductsku",
                    defaults: new
                    {
                        Controller = "Payment",
                        action = "GetAllProductSKU"
                    }
                //,
                //constraints: null,
                //handler: tokenInspector
                    );

            config.Routes.MapHttpRoute(
                 name: "GetAllCreditCardType",
                 routeTemplate: "payment/getallcreditcardtype",
                 defaults: new
                 {
                     Controller = "Payment",
                     action = "GetAllCreditCardType"
                 }
                //,
                //constraints: null,
                //handler: tokenInspector
                 );

            config.Routes.MapHttpRoute(
                    name: "GetProductSKUbyStateIDs",
                    routeTemplate: "payment/getproductskubystateids",
                    defaults: new
                    {
                        Controller = "Payment",
                        action = "GetProductSKUbyStateIDs"
                    }
                //,
                //constraints: null,
                //handler: tokenInspector
                    );
            #endregion Get

            #region Persist

            config.Routes.MapHttpRoute(
                    name: "PersitIRSPaymentOption",
                    routeTemplate: "payment/persitirspaymentoption",
                    defaults: new
                    {
                        Controller = "Payment",
                        action = "PersitIRSPaymentOption"
                    }
                //,
                //constraints: null,
                //handler: tokenInspector
                    );

            config.Routes.MapHttpRoute(
                    name: "OrderPersist",
                    routeTemplate: "payment/orderpersist",
                    defaults: new
                    {
                        Controller = "Payment",
                        action = "OrderPersist"
                    }
                //,
                //constraints: null,
                //handler: tokenInspector
                    );

            config.Routes.MapHttpRoute(
                name: "CheckOutSummaryPersist",
                routeTemplate: "payment/checkoutsummarypersist",
                defaults: new
                {
                    Controller = "Payment",
                    action = "CheckOutSummaryPersist"
                }
                        //,
                        //constraints: null,
                        //handler: tokenInspector
                );

            #endregion

            #endregion

            #region EFile
            config.Routes.MapHttpRoute(
             name: "GetPersonAndIRSTransmission",
             routeTemplate: "efile/getpersonandirstransmission",
             defaults: new
             {
                 Controller = "EFile",
                 action = "GetPersonAndIRSTransmission"
             }
                //,
                //constraints: null,
                //handler: tokenInspector
             );

            config.Routes.MapHttpRoute(
             name: "GetIRSTranmission",
             routeTemplate: "efile/getirstranmission",
             defaults: new
             {
                 Controller = "EFile",
                 action = "GetIRSTranmission"
             }
                //,
                //constraints: null,
                //handler: tokenInspector
             );
            #endregion

            #region PDF
            config.Routes.MapHttpRoute(
              name: "GetWorksheet",
              routeTemplate: "taxreturn/getworksheet/{userId}/{userDataId}/{worksheetName}",
              defaults: new
              {
                  Controller = "TaxReturn",
                  action = "GetWorksheet"
              }
                        //,
                        //constraints: null,
                        //handler: tokenInspector
              );
            #endregion
        }
    }
}
