/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   W2.cs 
    Description     :   Business object for W2. 
    Author          :   Vivek 
    Created Date    :   

    Modification History:
    ---------------------
 * 14Mar2014 Bala modified the Boolean type to Boolean nullable type.
 * 26Mar2014 Ashok kumar Added new property W2ID.
 * 08Apr2014 Bala Added new fields("NotInUseAmount","EmploymentType" and "EmployeeAddress") and commented "EmployerEIN" field.
 * 10Apr2014 Bala Removed "NotInUseAmount" field based on the updated spec.
 * 16Apr2014 Bala Modified "W2Id" type as int.
 * 22 Apr 2014 Vincent remove the W2LocalTaxInfo property and move them to W2StateLocalTaxInfo
 * 25Apr2014 Bala Modified code to change double type to double?(Nulable) type.
 */

using System.Collections.Generic;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.BusinessObject
{
    public class W2
    {
        public EmploymentType EmploymentType { get; set; }

        public int W2Id { get; set; }

        public double? WagesAmount { get; set; }

        public double? FederalTaxWithholdingAmount { get; set; }

        public double? SocialSecurityWagesAmount { get; set; }

        public double? SocialSecurityTaxWithholdingAmount { get; set; }

        public double? MedicareWagesAmount { get; set; }

        public double? MedicareTaxWithholdingAmount { get; set; }

        public double? SocialSecurityTipsAmount { get; set; }

        public double? AllocatedTipsAmount { get; set; }

        public double? DependentCareBenefitsAmount { get; set; }

        public double NonQualifiedPlansAmount { get; set; }

        public Employer Employer { get; set; }

        public bool? IsStatutoryEmployee { get; set; }

        public bool? HasRetirementPlan { get; set; }

        public bool? HasThirdPartySickPay { get; set; }

        public List<W2StateLocalTaxInfo> W2StateLocalTaxInfo { get; set; }

        public List<OtherDeductsBenefits> OtherDeductsBenefits { get; set; }

        //Bala field commented based on the discussion done with team.
        //public string EmployerEIN { get; set; }

        public List<W2EmployerCode> W2EmployerCodes { get; set; }

        public W2EmployeeAddress EmployeeAddress { get; set; }

        public OwnerType OwnerType { get; set; }

        public bool? HasEmployeeAddress { get; set; }

        public bool? IsCorrectedW2 { get; set; }

        public bool? IsNonStandardW2 { get; set; }

    }

}

