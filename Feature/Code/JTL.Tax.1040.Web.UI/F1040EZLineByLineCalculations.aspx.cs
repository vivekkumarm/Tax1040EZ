/*//10/3/14 Vincent made the changes in input text box ID Market income discount,
            Remove addition federal withholding amount for OID,INT  
 Modification History:
    ---------------------
 * 08Apr2014 Bala commented the ControlNumber field which is not used in Organization object.
 * 22Apr2014 Vivek - Modified SSB and RRB Data Mapping - converted List Object to Normal Object.
 * Remove addition federal withholding amount for OID,INT  
 * 23Apr2014 Ashok Kumar Modified - Code changes as per Deductions and SSB workflow invoking.*/


using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using JTL.Tax1040.BusinessObject;
using JTL.Tax1040.Core.Object;
using JTL.Tax1040.PDFBinding;
using Tax1040WorkFlow.WorkFlow.Activities;
using JTL.Tax1040.Core.Process;

namespace Tax1040Web
{
    public partial class F1040EZLineByLineCalculations : System.Web.UI.Page
    {
        private readonly MessagesRepository messageRepository = new MessagesRepository();
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
            var PanalDisplayPension = chkPensionPlans.Checked;
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

            //Form 8862

            var PanalDisplayForm8862 = chkIRSFiling8862.Checked;
            if (PanalDisplayForm8862 == true)
            {

                pnlForF8862.Visible = true;
            }
            else
            {
                pnlForF8862.Visible = false;
            }

            pnlF8860Q3.Visible = chkDaysLivedInUS.Checked;
            if (!pnlF8860Q3.Visible)
            {
                chkDaysLivedInUS.Checked = false;
                txtTaxpayer8862.Text = string.Empty;
            }

            var PanalDisplayForF8862 = chkDaysLivedInUS.Checked;

            if (PanalDisplayForF8862 == true)
            {
                pnlF8860Q3.Visible = true;
            }

            pnlspouse.Visible = chkspouse.Checked;
            if (!pnlspouse.Visible)
            {
                chkspouse.Checked = false;
                txtspouse8862.Text = string.Empty;
            }
            var PanalDispaySpouse = chkspouse.Checked;

            if (PanalDispaySpouse == true)
            {
                pnlspouse.Visible = true;
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
            //Added

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

            form1099G1.Form1099StateInfo = new List<Form1099StateInformation>();
            form1099G2.Form1099StateInfo = new List<Form1099StateInformation>();
            form1099G3.Form1099StateInfo = new List<Form1099StateInformation>();

            var form1099G1StateInfo1 = new Form1099StateInformation();
            var form1099G2StateInfo2 = new Form1099StateInformation();
            var form1099G3StateInfo3 = new Form1099StateInformation();

            form1099OID1.Form1099StateInfo = new List<Form1099StateInformation>();
            form1099OID2.Form1099StateInfo = new List<Form1099StateInformation>();
            form1099OID3.Form1099StateInfo = new List<Form1099StateInformation>();

            var form1099OIDStateInfo1 = new Form1099StateInformation();
            var form1099OIDStateInfo2 = new Form1099StateInformation();
            var form1099OIDStateInfo3 = new Form1099StateInformation();

            form1099Int1.Form1099StateInfo = new List<Form1099StateInformation>();
            form1099Int2.Form1099StateInfo = new List<Form1099StateInformation>();

            var form1099IntStateInfo1 = new Form1099StateInformation();
            var form1099IntStateInfo2 = new Form1099StateInformation();

            w21.W2StateLocalTaxInfo = new List<W2StateLocalTaxInfo>();
            w22.W2StateLocalTaxInfo = new List<W2StateLocalTaxInfo>();
            w23.W2StateLocalTaxInfo = new List<W2StateLocalTaxInfo>();

            var w2StateLocalTaxInfo1 = new W2StateLocalTaxInfo();
            var w2StateLocalTaxInfo2 = new W2StateLocalTaxInfo();
            var w2StateLocalTaxInfo3 = new W2StateLocalTaxInfo();


            var socialSecurityBenefit1 = new SocialSecurityBenefits();
            var socialSecurityBenefit2 = new SocialSecurityBenefits();

            var railRoadRetirement1 = new RailroadRetirementIncome();
            var railRoadRetirement2 = new RailroadRetirementIncome(); //added a New Instance
            //tax1040.Income.OtherIncome=new OtherIncome
            //    {
            //        SocialSecurityBenefits = new List<SocialSecurityBenefits>(),
            //        RailroadRetirementBenefits = new List<RailroadRetirementIncome>()
            //    };
            tax1040.Income.OtherIncome = new OtherIncome();
            tax1040.Income.OtherIncome.RRB = new RailroadRetirementIncome();
            tax1040.Income.OtherIncome.SSB = new SocialSecurityBenefits();

            //form8862
            var form8862 = new Form8862();
            //
            var form8862Page1 = new Tax8862Page1();
            
            //W2
            if (!string.IsNullOrEmpty(txtW21.Text))
            {
                w21.WagesAmount = Convert.ToDouble(txtW21.Text);
            }
            if (!string.IsNullOrEmpty(txtFTW21.Text))
            {
                w21.FederalTaxWithholdingAmount = Convert.ToDouble(txtFTW21.Text);
            }
            if (!string.IsNullOrEmpty(txtSocialSecurityWages1.Text))
            {
                w21.SocialSecurityWagesAmount = Convert.ToDouble(txtSocialSecurityWages1.Text);
            }

            if (!string.IsNullOrEmpty(txtSocialSecurityWithholding1.Text))
            {
                w21.SocialSecurityTaxWithholdingAmount = Convert.ToDouble(txtSocialSecurityWithholding1.Text);
            }
            ////newly added by vincent for UI Input
            if (!string.IsNullOrEmpty(txtMedicareWithheld1.Text))
            {
                w21.MedicareTaxWithholdingAmount = Convert.ToDouble(txtMedicareWithheld1.Text);
            }

            if (!string.IsNullOrEmpty(txtAllocatedTips1.Text))
            {
                w21.AllocatedTipsAmount = Convert.ToDouble(txtAllocatedTips1.Text);
            }

            if (!string.IsNullOrEmpty(txtDependentCareBenefits1.Text))
            {
                w21.DependentCareBenefitsAmount = Convert.ToDouble(txtDependentCareBenefits1.Text);
            }

            if (!string.IsNullOrEmpty(txtMedicareWages1.Text))
            {
                w21.MedicareWagesAmount = Convert.ToDouble(txtMedicareWages1.Text);
            }

            tax1040.Income.W2Wages.Add(w21);


            //added
            if (!string.IsNullOrEmpty(txtStateWagesWTH1.Text))
            {
                w2StateLocalTaxInfo1.StateTaxWithholdingAmount = Convert.ToDouble(txtStateWagesWTH1.Text);

            }
            if (!string.IsNullOrEmpty(txtStateWages1.Text))
            {
                w2StateLocalTaxInfo1.StateWagesAmount = Convert.ToDouble(txtStateWages1.Text);
            }

            w21.W2StateLocalTaxInfo.Add(w2StateLocalTaxInfo1);

            //w22
            if (!string.IsNullOrEmpty(txtW22.Text))
            {
                w22.WagesAmount = Convert.ToDouble(txtW22.Text);
            }
            if (!string.IsNullOrEmpty(txtFTW2.Text))
            {
                w22.FederalTaxWithholdingAmount = Convert.ToDouble(txtFTW2.Text);
            }

            if (!string.IsNullOrEmpty(txtSocialSecurityWages2.Text))
            {
                w22.SocialSecurityWagesAmount = Convert.ToDouble(txtSocialSecurityWages2.Text);
            }

            if (!string.IsNullOrEmpty(txtSocialSecurityWithholding2.Text))
            {
                w22.SocialSecurityTaxWithholdingAmount = Convert.ToDouble(txtSocialSecurityWithholding2.Text);
            }
            ////newly added by vincent for UI Input
            if (!string.IsNullOrEmpty(txtMedicareWithheld2.Text))
            {
                w22.MedicareTaxWithholdingAmount = Convert.ToDouble(txtMedicareWithheld2.Text);
            }

            if (!string.IsNullOrEmpty(txtAllocatedTips2.Text))
            {
                w22.AllocatedTipsAmount = Convert.ToDouble(txtAllocatedTips2.Text);
            }

            if (!string.IsNullOrEmpty(txtDependentCareBenefits2.Text))
            {
                w22.DependentCareBenefitsAmount = Convert.ToDouble(txtDependentCareBenefits2.Text);
            }

            if (!string.IsNullOrEmpty(txtMedicareWages2.Text))
            {
                w22.MedicareWagesAmount = Convert.ToDouble(txtMedicareWages2.Text);
            }

            tax1040.Income.W2Wages.Add(w22);
            //added
            if (!string.IsNullOrEmpty(txtStateWagesWTH2.Text))
            {
                w2StateLocalTaxInfo2.StateTaxWithholdingAmount = Convert.ToDouble(txtStateWagesWTH2.Text);
            }
            if (!string.IsNullOrEmpty(txtStateWages2.Text))
            {
                w2StateLocalTaxInfo2.StateWagesAmount = Convert.ToDouble(txtStateWages2.Text);
            }
            w22.W2StateLocalTaxInfo.Add(w2StateLocalTaxInfo2);

            //w23
            if (!string.IsNullOrEmpty(txtW23.Text))
            {
                w23.WagesAmount = Convert.ToDouble(txtW23.Text);
            }
            if (!string.IsNullOrEmpty(txtFTW3.Text))
            {
                w23.FederalTaxWithholdingAmount = Convert.ToDouble(txtFTW3.Text);
            }


            if (!string.IsNullOrEmpty(txtSocialSecurityWages3.Text))
            {
                w23.SocialSecurityWagesAmount = Convert.ToDouble(txtSocialSecurityWages3.Text);
            }

            if (!string.IsNullOrEmpty(txtSocialSecurityWithholding3.Text))
            {
                w23.SocialSecurityTaxWithholdingAmount = Convert.ToDouble(txtSocialSecurityWithholding3.Text);
            }
            ////newly added by vincent for UI Input
            if (!string.IsNullOrEmpty(txtMedicareWithheld3.Text))
            {
                w23.MedicareTaxWithholdingAmount = Convert.ToDouble(txtMedicareWithheld3.Text);
            }

            if (!string.IsNullOrEmpty(txtAllocatedTips3.Text))
            {
                w23.AllocatedTipsAmount = Convert.ToDouble(txtAllocatedTips3.Text);
            }
            if (!string.IsNullOrEmpty(txtDependentCareBenefits3.Text))
            {
                w23.DependentCareBenefitsAmount = Convert.ToDouble(txtDependentCareBenefits3.Text);
            }

            if (!string.IsNullOrEmpty(txtMedicareWages3.Text))
            {
                w23.MedicareWagesAmount = Convert.ToDouble(txtMedicareWages3.Text);
            }


            tax1040.Income.W2Wages.Add(w23);
            //added
            if (!string.IsNullOrEmpty(txtStateWagesWTH3.Text))
            {
                w2StateLocalTaxInfo3.StateTaxWithholdingAmount = Convert.ToDouble(txtStateWagesWTH3.Text);

            }
            if (!string.IsNullOrEmpty(txtStateWages3.Text))
            {
                w2StateLocalTaxInfo3.StateWagesAmount = Convert.ToDouble(txtStateWages3.Text);
            }

            w23.W2StateLocalTaxInfo.Add(w2StateLocalTaxInfo3);

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
            //newly added by vivek from UI
            if (!string.IsNullOrEmpty(txtEarlyWithdrawalPenalty1.Text))
            {
                form1099Int1.EarlyWithdrawalPenalty = Convert.ToDouble(txtEarlyWithdrawalPenalty1.Text);
            }
            
            if (!string.IsNullOrEmpty(txtInvestment1.Text))
            {
                form1099Int1.InvestmentExpenses = Convert.ToDouble(txtInvestment1.Text);
            }
            if (!string.IsNullOrEmpty(txtForeignTaxPaid1.Text))
            {
                form1099Int1.ForeignTaxPaid = Convert.ToDouble(txtForeignTaxPaid1.Text);
            }
            tax1040.Income.Form1099INT.Add(form1099Int1);
            //added
            if (!string.IsNullOrEmpty(txtStateTaxWithHoldInt1.Text))
            {
                form1099IntStateInfo1.StateTaxWithholdingAmount = Convert.ToDouble(txtStateTaxWithHoldInt1.Text);

                form1099OID1.Form1099StateInfo.Add(form1099IntStateInfo1);
            }

            if (!string.IsNullOrEmpty(txtIntrestIncome2.Text))
            {
                form1099Int2.InterestIncome = Convert.ToDouble(txtIntrestIncome2.Text);
            }
            if (!string.IsNullOrEmpty(txtFTWIntInc2.Text))
            {
                form1099Int2.FederalTaxWithHoldingAmount = Convert.ToDouble(txtFTWIntInc2.Text);
            }
            //newly added by vivek from UI
            if (!string.IsNullOrEmpty(txtEarlyWithdrawalPenalty2.Text))
            {
                form1099Int2.EarlyWithdrawalPenalty = Convert.ToDouble(txtEarlyWithdrawalPenalty2.Text);
            }
           
            if (!string.IsNullOrEmpty(txtInvestment2.Text))
            {
                form1099Int2.InvestmentExpenses = Convert.ToDouble(txtInvestment2.Text);
            }
            if (!string.IsNullOrEmpty(txtForeignTaxPaid2.Text))
            {
                form1099Int2.ForeignTaxPaid = Convert.ToDouble(txtForeignTaxPaid2.Text);
            }
            tax1040.Income.Form1099INT.Add(form1099Int2);

            //added

            if (!string.IsNullOrEmpty(txtStateTaxWithHoldInt2.Text))
            {
                form1099IntStateInfo2.StateTaxWithholdingAmount = Convert.ToDouble(txtStateTaxWithHoldInt2.Text);

                form1099OID1.Form1099StateInfo.Add(form1099IntStateInfo2);
            }

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
            //newly added by vivek from UI
            if (!string.IsNullOrEmpty(txtWithdrawalPenalty1.Text))
            {
                form1099OID1.EarlyWithdrawalPenalty = Convert.ToDouble(txtWithdrawalPenalty1.Text);
            }
            
            //10/3/14 Vincent made the changes in input text box ID
            if (!string.IsNullOrEmpty(txtMarketDiscount1.Text))
            {
                form1099OID1.IncomeMarketDiscount = Convert.ToDouble(txtMarketDiscount1.Text);
            }
            if (!string.IsNullOrEmpty(txtUSTreasury1.Text))
            {
                form1099OID1.USTreasuryObligations = Convert.ToDouble(txtUSTreasury1.Text);
            }
            if (!string.IsNullOrEmpty(txtInvestmentExpenses1.Text))
            {
                form1099OID1.InvestmentExpenses = Convert.ToDouble(txtInvestmentExpenses1.Text);
            }
            tax1040.Income.Form1099OID.Add(form1099OID1);
            //add
            if (!string.IsNullOrEmpty(txtAcquisition1.Text))
            {

                form1099OID1.AcquisitionPremium = Convert.ToDouble(txtAcquisition1.Text);
            }

            if (!string.IsNullOrEmpty(txtStateTaxWithHoldOID1.Text))
            {
                form1099OIDStateInfo1.StateTaxWithholdingAmount = Convert.ToDouble(txtStateTaxWithHoldOID1.Text);

                form1099OID1.Form1099StateInfo.Add(form1099OIDStateInfo1);
            }


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

            //newly added by vivek from UI
            if (!string.IsNullOrEmpty(txtWithdrawalPenalty2.Text))
            {
                form1099OID2.EarlyWithdrawalPenalty = Convert.ToDouble(txtWithdrawalPenalty2.Text);
            }
            
            if (!string.IsNullOrEmpty(txtMarketDiscount2.Text))
            {
                form1099OID2.IncomeMarketDiscount = Convert.ToDouble(txtMarketDiscount2.Text);
            }
            if (!string.IsNullOrEmpty(txtUSTreasury2.Text))
            {
                form1099OID2.USTreasuryObligations = Convert.ToDouble(txtUSTreasury2.Text);
            }
            if (!string.IsNullOrEmpty(txtInvestmentExpenses2.Text))
            {
                form1099OID2.InvestmentExpenses = Convert.ToDouble(txtInvestmentExpenses2.Text);
            }
            tax1040.Income.Form1099OID.Add(form1099OID2);
            //added
            if (!string.IsNullOrEmpty(txtAcquisition2.Text))
            {

                form1099OID2.AcquisitionPremium = Convert.ToDouble(txtAcquisition2.Text);
            }

            if (!string.IsNullOrEmpty(txtStateTaxWithHoldOID2.Text))
            {
                form1099OIDStateInfo2.StateTaxWithholdingAmount = Convert.ToDouble(txtStateTaxWithHoldOID2.Text);

                form1099OID2.Form1099StateInfo.Add(form1099OIDStateInfo2);
            }

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
            //newly added by vivek from UI
            if (!string.IsNullOrEmpty(txtWithdrawalPenalty3.Text))
            {
                form1099OID3.EarlyWithdrawalPenalty = Convert.ToDouble(txtWithdrawalPenalty3.Text);
            }
            
            if (!string.IsNullOrEmpty(txtMarketDiscount3.Text))
            {
                form1099OID3.IncomeMarketDiscount = Convert.ToDouble(txtMarketDiscount3.Text);
            }
            if (!string.IsNullOrEmpty(txtUSTreasury3.Text))
            {
                form1099OID3.USTreasuryObligations = Convert.ToDouble(txtUSTreasury3.Text);
            }
            if (!string.IsNullOrEmpty(txtInvestmentExpenses3.Text))
            {
                form1099OID3.InvestmentExpenses = Convert.ToDouble(txtInvestmentExpenses3.Text);
            }
            tax1040.Income.Form1099OID.Add(form1099OID3);
            //added
            if (!string.IsNullOrEmpty(txtAcquisition3.Text))
            {

                form1099OID3.AcquisitionPremium = Convert.ToDouble(txtAcquisition3.Text);
            }

            if (!string.IsNullOrEmpty(txtStateTaxWithHoldOID3.Text))
            {
                form1099OIDStateInfo3.StateTaxWithholdingAmount = Convert.ToDouble(txtStateTaxWithHoldOID3.Text);

                form1099OID3.Form1099StateInfo.Add(form1099OIDStateInfo3);
            }

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
            //added
            //if (!string.IsNullOrEmpty(txtStateLocalTax1.Text))
            //{

            //    form1099G1.StateOrLocalIncomeTaxRefunds = Convert.ToDouble(txtStateLocalTax1.Text);
            //}

            if (!string.IsNullOrEmpty(txtStateTaxWithHold1.Text))
            {
                form1099G1StateInfo1.StateTaxWithholdingAmount = Convert.ToDouble(txtStateTaxWithHold1.Text);
                form1099G1.Form1099StateInfo.Add(form1099G1StateInfo1);
            }


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
            //added
            //if (!string.IsNullOrEmpty(txtStateLocalTax2.Text))
            //{
            //    form1099G2.StateOrLocalIncomeTaxRefunds = Convert.ToDouble(txtStateLocalTax2.Text);
            //}
            if (!string.IsNullOrEmpty(txtStateTaxWithHold2.Text))
            {
                form1099G2StateInfo2.StateTaxWithholdingAmount = Convert.ToDouble(txtStateTaxWithHold2.Text);
                form1099G2.Form1099StateInfo.Add(form1099G2StateInfo2);
            }

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

            //added
            //if (!string.IsNullOrEmpty(txtStateLocalTax3.Text))
            //{
            //    form1099G3.StateOrLocalIncomeTaxRefunds = Convert.ToDouble(txtStateLocalTax3.Text);
            //}

            if (!string.IsNullOrEmpty(txtStateTaxWithHold3.Text))
            {
                form1099G3StateInfo3.StateTaxWithholdingAmount = Convert.ToDouble(txtStateTaxWithHold3.Text);
                form1099G3.Form1099StateInfo.Add(form1099G3StateInfo3);
            }

            tax1040.Income.Form1099G.Add(form1099G3);

            ////SSB

            if (!string.IsNullOrEmpty(txtNetBenefitSSB1.Text))
            {
                socialSecurityBenefit1.TaxpayerNetBenefits = Convert.ToDouble(txtNetBenefitSSB1.Text);
            }
            if (!string.IsNullOrEmpty(txtFederalWithSSB1.Text))
            {
                socialSecurityBenefit1.TaxPayerFederalTaxWithheld = Convert.ToDouble(txtFederalWithSSB1.Text);
            }

            if (!string.IsNullOrEmpty(txtNetBenefitSSB2.Text))
            {
                socialSecurityBenefit1.SpouseNetBenefits = Convert.ToDouble(txtNetBenefitSSB2.Text);
            }
            if (!string.IsNullOrEmpty(txtFederalWithSSB2.Text))
            {
                socialSecurityBenefit1.SpouseFederalTaxWithheld = Convert.ToDouble(txtFederalWithSSB2.Text);
            }
            tax1040.Income.OtherIncome.SSB = socialSecurityBenefit1;

            ////added

            //if (!string.IsNullOrEmpty(txtNetBenefitSSB2.Text))
            //{
            //    socialSecurityBenefit2.NetBenefits = Convert.ToDouble(txtNetBenefitSSB2.Text);
            //}
            //if (!string.IsNullOrEmpty(txtFederalWithSSB2.Text))
            //{
            //    socialSecurityBenefit2.FederalTaxWithholdingAmount = Convert.ToDouble(txtFederalWithSSB2.Text);
            //}
            //tax1040.Income.OtherIncome.SocialSecurityBenefits.Add(socialSecurityBenefit2);

            //if (!string.IsNullOrEmpty(txtIntrestIncome2.Text))
            //{
            //    form1099Int2.InterestIncome = Convert.ToDouble(txtIntrestIncome2.Text);
            //}

            //RRB
            // Modified By:Vincent Modified date:17/2/14
            //Comment: Made the changes in the instance and the Text box field.
            if (!string.IsNullOrEmpty(txtNetBenefitRRB1.Text))
            {
                railRoadRetirement1.TaxpayerNetBenefits = Convert.ToDouble(txtNetBenefitRRB1.Text);
            }
            if (!string.IsNullOrEmpty(txtFederalWithRRB1.Text))
            {
                railRoadRetirement1.TaxPayerFederalTaxWithheld = Convert.ToDouble(txtFederalWithRRB1.Text);
            }

            if (!string.IsNullOrEmpty(txtNetBenefitRRB2.Text))
            {
                railRoadRetirement1.SpouseNetBenefits = Convert.ToDouble(txtNetBenefitRRB2.Text);
            }
            if (!string.IsNullOrEmpty(txtFederalWithRRB2.Text))
            {
                railRoadRetirement1.SpouseFederalTaxWithheld = Convert.ToDouble(txtFederalWithRRB2.Text);
            }

            tax1040.Income.OtherIncome.RRB= railRoadRetirement1;

            //if (!string.IsNullOrEmpty(txtNetBenefitRRB2.Text))
            //{
            //    railRoadRetirement2.NetBenefits = Convert.ToDouble(txtNetBenefitRRB2.Text);
            //}
            //if (!string.IsNullOrEmpty(txtFederalWithRRB2.Text))
            //{
            //    railRoadRetirement2.FederalTaxWithholdingAmount = Convert.ToDouble(txtFederalWithRRB2.Text);
            //}
            //tax1040.Income.OtherIncome.RailroadRetirementBenefits.Add(railRoadRetirement2);

            // //form8862
            form8862.HasEICdisallowed = chkEICdisallowed.Checked;

            form8862.HasReportedIncorrectIncome = chkReportedIncorrectIncome.Checked;

            form8862.HasDaysLivedInUS = chkDaysLivedInUS.Checked;

            //Bala, 26-Jun-14, added for Testing purpose
            form8862Page1.HasReportedIncorrectIncome = chkReportedIncorrectIncome.Checked;
            form8862Page1.HasClaimedAsQualifyingChild = chkQualifyingChild.Checked;
            form8862Page1.YearOfFiling = 2015;
            
            if (!string.IsNullOrEmpty(txtTaxpayer8862.Text))
            {
                form8862.DaysLivedInUS = Convert.ToInt32(txtTaxpayer8862.Text);
                form8862Page1.DaysTaxPayerLivedInUS = Convert.ToInt32(txtTaxpayer8862.Text);
            }

            if (!string.IsNullOrEmpty(txtspouse8862.Text))
            {
                form8862.DaysSpouseLivedInUS = Convert.ToInt32(txtspouse8862.Text);
                form8862Page1.DaysSpouseLivedInUS = Convert.ToInt32(txtspouse8862.Text);
            }
            tax1040.Income.Form8862 = form8862;

            tax1040.PersonalDetails = new PersonalDetails();
            tax1040.PersonalDetails.PrimaryTaxPayer = new PrimaryTaxPayer();
            tax1040.PersonalDetails.PrimaryTaxPayer.Person = new Person();
            tax1040.PersonalDetails.PrimaryTaxPayer.Person.HasClaimedAsDependent = chkHasClaimedAsDependentTP.Checked;

            tax1040.PersonalDetails.PrimaryTaxPayer.Person.FirstName = "Primary Tax Payer.";
            tax1040.PersonalDetails.PrimaryTaxPayer.Person.SSN = "22-344-1234";
            
            //Primary Tax Payer DOB
            if (!string.IsNullOrEmpty(txtPrimaryTaxPayerDOB.Text))
            {
                tax1040.PersonalDetails.PrimaryTaxPayer.Person.DateOfBirth =
                    Convert.ToDateTime(txtPrimaryTaxPayerDOB.Text);
            }
            //Date of death
            if (!string.IsNullOrEmpty(txtTpDateOfDeath.Text))
            {
                tax1040.PersonalDetails.PrimaryTaxPayer.Person.DateOfDeath =
                    Convert.ToDateTime(txtTpDateOfDeath.Text);
            }

            tax1040.PersonalDetails.PrimaryTaxPayer.FilingStatus = (FilingStatus)ddlFilingStatus.SelectedIndex;
            tax1040.PersonalDetails.Spouse = new Spouse();
            tax1040.PersonalDetails.Spouse.Person = new Person();

            //Spouse Tax Payer DOB
            if (!string.IsNullOrEmpty(txtSpouseDOB.Text))
            {
                tax1040.PersonalDetails.Spouse.Person.DateOfBirth = Convert.ToDateTime(txtSpouseDOB.Text);
            }

            //Spouse Date of death
            if (!string.IsNullOrEmpty(txtSpouseDateOfDeath.Text))
            {
                tax1040.PersonalDetails.Spouse.Person.DateOfDeath = Convert.ToDateTime(txtSpouseDateOfDeath.Text);
            }
            tax1040.PersonalDetails.Spouse.Person.HasClaimedAsDependent = chkHasClaimedAsDependentS.Checked;

            //EIC
            tax1040.Credits = new Credits();
            tax1040.Credits.EIC = new EIC();
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
            //25Jul2014 Sathish as discussed moved IRS to federal filing
            tax1040.Filing = new Filing();
            tax1040.Filing.FederalFiling = new FederalFiling();
            tax1040.Filing.FederalFiling.IRS = new IRS();
            tax1040.Filing.FederalFiling.IRS.BankDetails = new BankDetails();
            tax1040.Filing.FederalFiling.IRS.BankDetails.AccountNumber = "12345678901234567";
            tax1040.Filing.FederalFiling.IRS.BankDetails.RoutingTransitNumber = "123456789";

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

            //var errorMessage = messageRepository.GetErrorMessages();
            var errorMessage = HttpRuntime.Cache["ErrorMessageCollection"] as Dictionary<string, ErrorMessage>;
            //Converting dictionary 
            var errorMessages = new ErrorMessages(errorMessage);
            tax1040.ErrorMessages = new List<ErrorMessage>();
            dynamic input = new Microsoft.Activities.Extensions.WorkflowArguments();

            // Added to check the Worksheet Bindings
            tax1040.OutputForms = new OutputForms();
            //tax1040.OutputForms.Tax1040EZPage1 = new Tax1040EZPage1();
            //var tax1040EZPage1 = new Tax1040EZPage1();
            //tax1040EZPage1.TotalWages = 10000;
            //tax1040EZPage1.AdjustedGrossIncome = 15500;
            //tax1040EZPage1.TaxableInterest = 1000;
            //tax1040EZPage1.TEI = 200;
            //tax1040EZPage1.UnemploymentCompensation = 400;
            //tax1040.OutputForms.Tax1040EZPage1 = tax1040EZPage1;
            tax1040.OutputForms.Tax8862Page1 = form8862Page1;
            
            input.Tax1040Object = tax1040;

            input.ErrorMessages = errorMessages;
           // pass it to the activity no need to cast it 
            //var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new Tax1040WorkFlow.WorkFlow.Activities.F1040EZLineByLineCalculation(), input));
            //As

            var output = input;


            // Added to check the Worksheet Bindings
            //var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new Tax1040WorkFlow.WorkFlow.F1040EZStandardDeduction(), input));
            //var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new Tax1040WorkFlow.WorkFlow.Activities.Form1040EZSSBEligiblity(), input));
            //var output = Microsoft.Activities.Extensions.WorkflowArguments.FromDictionary(WorkflowInvoker.Invoke(new Tax1040WorkFlow.WorkFlow.Activities.F1040EZEarnedIncomeCreditCalculation(), input));
            if (tax1040.ErrorMessages != null && tax1040.ErrorMessages.Any())
            {
                foreach (var message in tax1040.ErrorMessages)
                {
                    ValidationError.Display(message.ErrorType + " : " + message.ErrorText);
                }

                lblError.Visible = true;

                //TODO:Have to Handle in later.

                //if (!tax1040.ErrorMessages.Any(er => er.ErrorType == Constants.ErrorTypes.ERROR))
                //{
                //    Generate1040EZForm(output);
                //}
            }
            else
                {
                    Generate1040EZForm(output);
                }

                Generate1040EZForm(output);
            }

        private void Generate1040EZForm(dynamic output)
        {
            Tax1040 tax1040Object = output["Tax1040Object"];
            
            ////Form1040EZ Binding
            //var bind = new F1040EZPDFBinding();
            //byte[] pdfData = bind.OutPutForm(tax1040Object,Constants.FORM1040EZ_BINDING);

            //Form8862 Binding
            var bind = new F1040EZPDFBinding();
            byte[] pdfData = bind.OutPutForm(tax1040Object, Constants.FORM8862_BINDING);

            ////Form8879 Binding
            //var bind = new F1040EZPDFBinding();
            //byte[] pdfData = bind.OutPutForm(tax1040Object, Constants.FORM8879_BINDING);

            ////Form1040V Binding
            //var bind = new F1040EZPDFBinding();
            //byte[] pdfData = bind.OutPutForm(tax1040Object, Constants.FORM1040V_BINDING);


            //Added to check Worksheet Binding
            //var bind = new F1040EZPDFBinding();
            //byte[] pdfData = bind.EICWorksheetBinding(tax1040Object);

            //var bind = new F1040EZPDFBinding();
            //byte[] pdfData = bind.SSBWorksheetBinding(tax1040Object);

            //var bind = new F1040EZPDFBinding();
            //byte[] pdfData = bind.StandardDeductionWorksheetBinding(tax1040Object);


          //  ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "newWindow", "window.open('frmComplaintRevision.aspx?ID=" + _cId + "','_blank','status=1,toolbar=0,menubar=0,location=1,scrollbars=1,resizable=1,width=30,height=30');", true);

            Response.Clear();
            Response.AddHeader("Accept-Header", pdfData.Length.ToString());
            Response.ContentType = "application/pdf";

            Response.AddHeader("Content-Disposition", "attachment; filename=  FinalBinding" + ".pdf");

            Response.AddHeader("content-length", pdfData.Length.ToString());
            Response.BinaryWrite(pdfData);
            Response.End();
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
                currentPage.Validators.Add(new F1040EZLineByLineCalculations.ValidationError(message));
            }
        }
        #endregion
    }
    
}