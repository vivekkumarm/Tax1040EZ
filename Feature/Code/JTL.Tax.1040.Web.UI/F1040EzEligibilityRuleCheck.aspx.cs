using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using JTL.Tax1040.BusinessObject;
using System.Activities;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.Core.Process;

namespace Tax1040Web
{
    public partial class Startup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            MessagesRepository messageRepository = new MessagesRepository();

            var tax1040 = new Tax1040();
            tax1040.ErrorMessages = new List<ErrorMessage>();
            tax1040.Income = new Income();
            tax1040.Income.W2Wages = new List<W2>();
            tax1040.Income.Form1099INT = new List<Form1099INT>();
            tax1040.Income.Form1099OID = new List<Form1099OID>();
            tax1040.Income.Form1099G = new List<Form1099G>();
            tax1040.PersonalDetails = new PersonalDetails();
            tax1040.PersonalDetails.PrimaryTaxPayer = new PrimaryTaxPayer();
            tax1040.PersonalDetails.PrimaryTaxPayer.Person = new Person();           

            tax1040.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent = chkHasClaimedAsDependent.Checked;
            tax1040.PersonalDetails.PrimaryTaxPayer.Person.IsBankruptcyDebtor = chkIsBankruptcyDebtor.Checked;
            tax1040.PersonalDetails.PrimaryTaxPayer.FilingStatus = (FilingStatus)ddlFilingStatus.SelectedIndex;
            tax1040.PersonalDetails.Spouse = new Spouse();
            tax1040.PersonalDetails.Spouse.Person = new Person();

            if (!string.IsNullOrEmpty(txttaxpayer.Text))
                tax1040.PersonalDetails.Spouse.Person.DateOfBirth = Convert.ToDateTime(txttaxpayer.Text);

            if (!string.IsNullOrEmpty(txtSpouseDOB.Text))
                tax1040.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth = Convert.ToDateTime(txtSpouseDOB.Text);

            tax1040.PersonalDetails.PrimaryTaxPayer.Person.IsLegallyBlind = chktaxpayerblind.Checked;
            tax1040.PersonalDetails.Spouse.Person.IsLegallyBlind = chkspouseblind.Checked;
            tax1040.Deductions = new Deductions();
            tax1040.Deductions.HasAGIDeductions = chkHasAGIDeductions.Checked;          
            tax1040.Deductions.HasItemizedDeductions = chkHasItemizedDeductions.Checked;

            tax1040.Credits = new Credits();            
            tax1040.Credits.HasCreditsToClaim = chkHasCreditsToClaim.Checked;
            tax1040.Credits.HasEstimatedTaxPayments = chkHasEstimatedTaxPayments.Checked;            
            tax1040.Credits.HasEstimatedTaxPayments = chkHasEstimatedTaxPayments.Checked;

            tax1040.TaxesAndPenalties = new TaxesAndPenalties();
            tax1040.TaxesAndPenalties.HasAlternativeMinimumTax = chkHasAlternativeMinimumTax.Checked;
            tax1040.TaxesAndPenalties.HasOwedHouseholdEmploymentTax = chkHasOwedHouseholdEmploymentTax.Checked;

            tax1040.Income.HasIncomeFromOtherSources = chkHasIncomeFromOtherSources.Checked;

            //var errorMessageCollection = messageRepository.GetErrorMessages();
            var errorMessageCollection = HttpRuntime.Cache["ErrorMessageCollection"] as Dictionary<string, ErrorMessage>;
             ErrorMessages errormessages = new ErrorMessages(errorMessageCollection);
            dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();

            tax1040.ErrorMessages = new List<ErrorMessage>() {
            
            new ErrorMessage(){
            ErrorType = "Error",
            ErrorText = "Sample Error1"
            },
            new ErrorMessage(){
            ErrorType = "Error",
            ErrorText = "Sample Error2"
            },
            new ErrorMessage(){
            ErrorType = "Error",
            ErrorText = "Sample Error3"
            },

            
            };
            input.Tax1040Object = tax1040;
            input.ErrorMessages = errormessages;
           
            Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EzEligibilityRuleCheck(), input));

            

            if (tax1040.ErrorMessages.Any())
            {
                foreach (var message in tax1040.ErrorMessages)
                {
                    ValidationError.Display(message.ErrorType +" : " + message.ErrorText);
                }
                lblError.Visible = true;
            }

        }

        #region Validation 
        public class ValidationError : IValidator
        {
            private ValidationError(string message)
            {
                ErrorMessage = message;
                IsValid = false;
            }

            public string ErrorMessage { get; set; }

            public bool IsValid { get; set; }

            public void Validate()
            {
                // no action required
            }


            public static void Display(string message)
            {
                Page currentPage = HttpContext.Current.Handler as Page;
                currentPage.Validators.Add(new ValidationError(message));
            }

        }
        #endregion
    }
}