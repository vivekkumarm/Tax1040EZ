
/*
 Modification History:
    ---------------------
 * 08Apr2014 Bala commented the ControlNumber field which is not used in Organization object.
 */

using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.PDFBinding;
using JTL.Tax1040.Core.Process;

namespace Tax1040Web
{
    using Tax1040WorkFlow.WorkFlow.Activities;

    public partial class F1040EZLinesCalculations : System.Web.UI.Page
    {
        private readonly MessagesRepository messagesRepository = new MessagesRepository();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            //TaxableScholarship
            var PanalDisplayTax = chkTaxableScholarship.Checked;
            if (PanalDisplayTax == true)
            {
                pnlTaxableScholarship.Visible = true;
                
            }
            else
            {
                pnlTaxableScholarship.Visible = false;
                txtTaxableScholarshipAmount.Text = string.Empty;
            }

            //Inmate Penal
            var PanalDisplayPension =chkPensionPlans.Checked;
            if (PanalDisplayPension == true)
            {
                pnlPensionPlans.Visible = true;
            }
            else
            {
                pnlPensionPlans.Visible = false;
                txtPensionPlansAmount.Text = string.Empty;
            }

            //Pension

            var PanalDisplayPenal = chkPenalInstitution.Checked;
            if (PanalDisplayPenal == true)
            {
                pnlPenalInstitution.Visible = true;
            }
            else
            {
                pnlPenalInstitution.Visible = false;
                txtPenalInstitutionAmount.Text = string.Empty;
            }
            

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var tax1040 = new Tax1040();

            tax1040.Income = new Income();
            tax1040.Income.W2Wages = new List<W2>();
            tax1040.Income.Form1099INT = new List<Form1099INT>();
            tax1040.Income.Form1099OID = new List<Form1099OID>();
            tax1040.Income.Form1099G = new List<Form1099G>();
            //tax1040.Income.OtherIncome.SocialSecurityBenefits = new List<SocialSecurityBenefits>();
            //tax1040.Income.OtherIncome.RailroadRetirementBenefits = new List<RailroadRetirementIncome>();
            
            var w21 = new W2();
            var w22 = new W2();
            var w23 = new W2();


            var form1099Int1 = new Form1099INT();
            var form1099Int2 = new Form1099INT();

            var form1099OID1 = new Form1099OID();
            var form1099OID2 = new Form1099OID();
            var form1099OID3 = new Form1099OID();

            var form1099G1 = new Form1099G();
            var form1099G2 = new Form1099G();
            var form1099G3 = new Form1099G();


            var socialSecurityBenefit = new SocialSecurityBenefits();
            var railRoadRetirement = new RailroadRetirementIncome(); //added a New Instance

            //W2
            if (!string.IsNullOrEmpty(txtW21.Text))
            {
                w21.WagesAmount = Convert.ToDouble(txtW21.Text);
            }
            if (!string.IsNullOrEmpty(txtFTW21.Text))
            {
                w21.FederalTaxWithholdingAmount = Convert.ToDouble(txtFTW21.Text);
            }

            tax1040.Income.W2Wages.Add(w21);

            if (!string.IsNullOrEmpty(txtW22.Text))
            {
                w22.WagesAmount = Convert.ToDouble(txtW22.Text);
            }
            if (!string.IsNullOrEmpty(txtFTW2.Text))
            {
                w22.FederalTaxWithholdingAmount = Convert.ToDouble(txtFTW2.Text);
            }

            tax1040.Income.W2Wages.Add(w22);

            if (!string.IsNullOrEmpty(txtW23.Text))
            {
                w23.WagesAmount = Convert.ToDouble(txtW23.Text);
            }
            if (!string.IsNullOrEmpty(txtFTW3.Text))
            {
                w23.FederalTaxWithholdingAmount = Convert.ToDouble(txtFTW3.Text);
            }

            tax1040.Income.W2Wages.Add(w23);

            if (!string.IsNullOrEmpty((txtw2Line11Amount.Text)))
            {
                w21.NonQualifiedPlansAmount = Convert.ToDouble(txtw2Line11Amount.Text);

            }

            //W2 Line 8B  

            tax1040.Income.W2Wages[0].W2EmployerCodes = new List<W2EmployerCode>();
            var W2Emp1 = new W2EmployerCode();
            W2Emp1.EmployerCode = (EmployerCode)ddlw212a.SelectedIndex;

            if (!string.IsNullOrEmpty(txtW212aAmount.Text))
            {
                W2Emp1.Amount = Convert.ToDouble(txtW212aAmount.Text);
            }            
            tax1040.Income.W2Wages[0].W2EmployerCodes.Add(W2Emp1);

            W2Emp1 = new W2EmployerCode();
            W2Emp1.EmployerCode = (EmployerCode)ddlW212b.SelectedIndex;
            if (!string.IsNullOrEmpty(txtW212bAmount.Text))
            {
                W2Emp1.Amount = Convert.ToDouble(txtW212bAmount.Text);
            }
            tax1040.Income.W2Wages[0].W2EmployerCodes.Add(W2Emp1);


            tax1040.Income.W2Wages[1].W2EmployerCodes = new List<W2EmployerCode>();

            W2Emp1 = new W2EmployerCode();
            W2Emp1.EmployerCode = (EmployerCode)ddlw2212a.SelectedIndex;

            if (!string.IsNullOrEmpty(txtW2212aAmount.Text))
            {
                W2Emp1.Amount = Convert.ToDouble(txtW2212aAmount.Text);
            }

            tax1040.Income.W2Wages[1].W2EmployerCodes.Add(W2Emp1);

            W2Emp1 = new W2EmployerCode();
            W2Emp1.EmployerCode = (EmployerCode)ddlW2212b.SelectedIndex;

            if (!string.IsNullOrEmpty(txtW2212bAmount.Text))
            {
                W2Emp1.Amount = Convert.ToDouble(txtW2212bAmount.Text);
            }
            tax1040.Income.W2Wages[1].W2EmployerCodes.Add(W2Emp1);



            tax1040.Income.W2Wages[2].W2EmployerCodes = new List<W2EmployerCode>();
            W2Emp1 = new W2EmployerCode();
            W2Emp1.EmployerCode = (EmployerCode)ddlw2312a.SelectedIndex;

            if (!string.IsNullOrEmpty(txtW2312aAmount.Text))
            {
                W2Emp1.Amount = Convert.ToDouble(txtW2312aAmount.Text);
            }

            tax1040.Income.W2Wages[2].W2EmployerCodes.Add(W2Emp1);

            W2Emp1 = new W2EmployerCode();
            W2Emp1.EmployerCode = (EmployerCode)ddlW2312b.SelectedIndex;
            if (!string.IsNullOrEmpty(txtW2312bAmount.Text))
            {
                W2Emp1.Amount = Convert.ToDouble(txtW2312bAmount.Text);
            }
            tax1040.Income.W2Wages[2].W2EmployerCodes.Add(W2Emp1); 
                                    

            //1099 INT
            if (!string.IsNullOrEmpty(txtIntrestIncome1.Text))
            {
                form1099Int1.InterestIncome = Convert.ToDouble(txtIntrestIncome1.Text);
            }
            if (!string.IsNullOrEmpty(txtFTWIntInc1.Text))
            {
                form1099Int1.FederalTaxWithHoldingAmount = Convert.ToDouble(txtFTWIntInc1.Text);
            }
            tax1040.Income.Form1099INT.Add(form1099Int1);
            if (!string.IsNullOrEmpty(txtIntrestIncome2.Text))
            {
                form1099Int2.InterestIncome = Convert.ToDouble(txtIntrestIncome2.Text);
            }
            if (!string.IsNullOrEmpty(txtFTWIntInc2.Text))
            {
                form1099Int2.FederalTaxWithHoldingAmount = Convert.ToDouble(txtFTWIntInc2.Text);
            }
            tax1040.Income.Form1099INT.Add(form1099Int2);

            //OID
            if (!string.IsNullOrEmpty(txtOID1.Text))
            {
                form1099OID1.OriginalIssueDiscount = Convert.ToDouble(txtOID1.Text);
            }
            if (!string.IsNullOrEmpty(txtFDOID1.Text))
            {
                form1099OID1.FederalTaxWithHoldingAmount = Convert.ToDouble(txtFDOID1.Text);
            }
            if (!string.IsNullOrEmpty(txtOPIOID1.Text))
            {
                form1099OID1.OtherPeriodicInterest = Convert.ToDouble(txtOPIOID1.Text);
            }
            tax1040.Income.Form1099OID.Add(form1099OID1);

            if (!string.IsNullOrEmpty(txtOID2.Text))
            {
                form1099OID2.OriginalIssueDiscount = Convert.ToDouble(txtOID2.Text);
            }
            if (!string.IsNullOrEmpty(txtFDOID2.Text))
            {
                form1099OID2.FederalTaxWithHoldingAmount = Convert.ToDouble(txtFDOID2.Text);
            }
            if (!string.IsNullOrEmpty(txtOPIOID2.Text))
            {
                form1099OID2.OtherPeriodicInterest = Convert.ToDouble(txtOPIOID2.Text);
            }
            tax1040.Income.Form1099OID.Add(form1099OID2);

            if (!string.IsNullOrEmpty(txtOID3.Text))
            {
                form1099OID3.OriginalIssueDiscount = Convert.ToDouble(txtOID3.Text);
            }
            if (!string.IsNullOrEmpty(txtFDOID3.Text))
            {
                form1099OID3.FederalTaxWithHoldingAmount = Convert.ToDouble(txtFDOID3.Text);
            }
            if (!string.IsNullOrEmpty(txtOPIOID3.Text))
            {
                form1099OID3.OtherPeriodicInterest = Convert.ToDouble(txtOPIOID3.Text);
            }
            tax1040.Income.Form1099OID.Add(form1099OID3);

            //..UnEmployment
            if (!string.IsNullOrEmpty(txtg1.Text))
            {
                form1099G1.UnEmploymentCompensation = Convert.ToDouble(txtg1.Text);
            }
            if (!string.IsNullOrEmpty(txtFDG1.Text))
            {
                form1099G1.FederalTaxWithHoldingAmount = Convert.ToDouble(txtFDG1.Text);
            }
            //if (!string.IsNullOrEmpty(txtAlaska1.Text))
            //{
            //    form1099G1.AlaskaPermanentFundDividend = Convert.ToDouble(txtAlaska1.Text);
            //}
            tax1040.Income.Form1099G.Add(form1099G1);

            if (!string.IsNullOrEmpty(txtg2.Text))
            {
                form1099G2.UnEmploymentCompensation = Convert.ToDouble(txtg2.Text);
            }
            if (!string.IsNullOrEmpty(txtFDG2.Text))
            {
                form1099G2.FederalTaxWithHoldingAmount = Convert.ToDouble(txtFDG2.Text);
            }
            //if (!string.IsNullOrEmpty(txtAlaska2.Text))
            //{
            //    form1099G2.AlaskaPermanentFundDividend = Convert.ToDouble(txtAlaska2.Text);
            //}
            tax1040.Income.Form1099G.Add(form1099G2);

            if (!string.IsNullOrEmpty(txtg3.Text))
            {
                form1099G3.UnEmploymentCompensation = Convert.ToDouble(txtg3.Text);
            }
            if (!string.IsNullOrEmpty(txtFDG3.Text))
            {

                form1099G3.FederalTaxWithHoldingAmount = Convert.ToDouble(txtFDG3.Text);
            }
            //if (!string.IsNullOrEmpty(txtAlaska3.Text))
            //{
            //    form1099G3.AlaskaPermanentFundDividend = Convert.ToDouble(txtAlaska3.Text);
            //}
            tax1040.Income.Form1099G.Add(form1099G3);


            //SSB

            if (!string.IsNullOrEmpty(txtNetBenefitSSB.Text))
            {
                socialSecurityBenefit.TaxpayerNetBenefits = Convert.ToDouble(txtNetBenefitSSB.Text);
            }
            if (!string.IsNullOrEmpty(txtFederalWithSSB.Text))
            {
                socialSecurityBenefit.TaxPayerFederalTaxWithheld = Convert.ToDouble(txtFederalWithSSB.Text);
            }
            //tax1040.Income.OtherIncome.SocialSecurityBenefits.Add(socialSecurityBenefit);

            
            //RRB
            // Modified By:Vincent Modified date:17/2/14
            //Comment: Made the changes in the instance and the Text box field.

            if (!string.IsNullOrEmpty(txtNetBenefitRRB.Text))
            {
                railRoadRetirement.TaxpayerNetBenefits = Convert.ToDouble(txtNetBenefitRRB.Text);
            }
            if (!string.IsNullOrEmpty(txtFederalWithRRB.Text))
            {
                railRoadRetirement.TaxPayerFederalTaxWithheld = Convert.ToDouble(txtFederalWithRRB.Text);
            }
           //tax1040.Income.OtherIncome.RailroadRetirementBenefits.Add(railRoadRetirement);


            tax1040.PersonalDetails = new PersonalDetails();
            tax1040.PersonalDetails.PrimaryTaxPayer = new PrimaryTaxPayer();
            tax1040.PersonalDetails.PrimaryTaxPayer.Person = new Person();
            tax1040.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent = chkHasClaimedAsDependentTP.Checked;
            //Primary Tax Payer DOB
            if (!string.IsNullOrEmpty(txtPrimaryTaxPayerDOB.Text))
            {
                tax1040.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth =
                    Convert.ToDateTime(txtPrimaryTaxPayerDOB.Text);
            }

            
            tax1040.PersonalDetails.PrimaryTaxPayer.FilingStatus = (FilingStatus)ddlFilingStatus.SelectedIndex;
            tax1040.PersonalDetails.Spouse = new Spouse();
            tax1040.PersonalDetails.Spouse.Person = new Person();

            //Spouse Tax Payer DOB
            if (!string.IsNullOrEmpty(txtSpouseDOB.Text))
            {
                tax1040.PersonalDetails.Spouse.Person.DateOfBirth = Convert.ToDateTime(txtSpouseDOB.Text);
            }

            tax1040.PersonalDetails.Spouse.Person.HasClaimedAsDependent = chkHasClaimedAsDependentS.Checked;
            
            //EIC
            tax1040.Credits=new Credits();
            tax1040.Credits.EIC=new EIC();
            tax1040.Credits.EIC.IsInUSMorethanHalfYear = chkLivedInUSStatus.Checked;
            tax1040.Credits.EIC.HasValidSSN = chkVaildSSN.Checked;
            tax1040.Credits.EIC.HasClaimedAsQualifyingChild = chkQualifyingChild.Checked;
            tax1040.Credits.EIC.HasReceivedIRSNoticeOnEICNotEligible = chkIRSNotice.Checked;
            tax1040.Credits.EIC.HasReceivedIRSNoticeOnFiling8862 = chkIRSFiling8862.Checked;
            if (!string.IsNullOrEmpty(txtTaxableScholarshipAmount.Text))
            {
                tax1040.Credits.EIC.TaxableScholarshipCredit = Convert.ToDouble(txtTaxableScholarshipAmount.Text);
            }
   
            if (!string.IsNullOrEmpty(txtPensionPlansAmount.Text))
            {
                tax1040.Credits.EIC.PensionAnnuity = Convert.ToDouble(txtPensionPlansAmount.Text);
            }

            if (!string.IsNullOrEmpty(txtPenalInstitutionAmount.Text))
            {
                tax1040.Credits.EIC.PenalInstitutionInmateWages = Convert.ToDouble(txtPenalInstitutionAmount.Text);
            }
           
          
            //Account
            tax1040.Settlement = new Settlement();
            tax1040.Settlement.IRS = new IRS();
            tax1040.Settlement.IRS.BankDetails = new BankDetails();
            tax1040.Settlement.IRS.BankDetails.AccountNumber = "12345678901234567";
            tax1040.Settlement.IRS.BankDetails.RoutingTransitNumber = "123456789";

            tax1040.ThirdPartyDesignee = new ThirdPartyDesignee();
            tax1040.PaidTaxReturnPreparers = new PaidTaxReturnPreparers();
            tax1040.PaidTaxReturnPreparers.Firm = new Organization();
            tax1040.PaidTaxReturnPreparers.Firm.Address = new Address();
            tax1040.PaidTaxReturnPreparers.Firm.Address.CompanyAddress = new CompanyAddress();
            tax1040.ThirdPartyDesignee.PIN = "12345";
            tax1040.ThirdPartyDesignee.DesigneeName = "CHARLES";
            tax1040.ThirdPartyDesignee.PhoneNumber = "1234556767";

            //spouse
            tax1040.PersonalDetails.Spouse.Person.SSN = "123456";
            tax1040.PaidTaxReturnPreparers.PTIN = "PIN";
            tax1040.PaidTaxReturnPreparers.Date = DateTime.Now;
            tax1040.PaidTaxReturnPreparers.Firm.Name = "JEEVAN";
            tax1040.PaidTaxReturnPreparers.Firm.Address.CompanyAddress.District = "NEY JERSY";
            tax1040.PaidTaxReturnPreparers.Firm.EIN = "EIN";
            //tax1040.PaidTaxReturnPreparers.Firm.ControlNumber = 1234567;

            tax1040.ThirdPartyDesignee.PhoneNumber = "123456789";

            var errorMessage = messagesRepository.GetErrorMessages();

            //Converting dictionary 
            var errorMessages = new ErrorMessages(errorMessage);
            
            dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();
            input.Tax1040Object = tax1040;
            input.ErrorMessages = errorMessages;
            //pass it to the activity no need to cast it 
            var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new F1040EZLineByLineCalculation(), input));

            if (tax1040.ErrorMessages.Any())
            {
                foreach (var message in tax1040.ErrorMessages)
                {
                    ValidationError.Display(message.ErrorType + " : " + message.ErrorText);
                }
                lblError.Visible = true;
            }
            else
            {
                Tax1040 tax1040Object = output["Tax1040Object"];
                var bind = new F1040EZPDFBinding();
                byte[] pdfData = bind.OutPutForm(tax1040Object,Constants.FORM1040EZ_BINDING);

                Response.Clear();
                Response.AddHeader("Accept-Header", pdfData.Length.ToString());
                Response.ContentType = "application/pdf";

                Response.AddHeader("Content-Disposition", "attachment; filename=  FinalBinding" + ".pdf");

                Response.AddHeader("content-length", pdfData.Length.ToString());
                Response.BinaryWrite(pdfData);
                Response.End();
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
                var currentPage = HttpContext.Current.Handler as Page;
                currentPage.Validators.Add(new ValidationError(message));
            }

        }
        #endregion
    }
}