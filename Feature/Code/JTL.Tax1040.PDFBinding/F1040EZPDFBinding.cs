/*14 March 2014 Praveen T Code refactring done

Modification History:
---------------------
 * 30May2014  Ashok Kumar - PDF Refactoring and  Moved all PDF binding methods related to F1040EZ to this class
*/

using JTL.Tax1040.Core.Object;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using JTL.Tax1040.BusinessObject;

namespace JTL.Tax1040.PDFBinding
{
    public class F1040EZPDFBinding
    {
        #region Local variable declaration
        string mapperXml;
        string primarytaxpayermapperXml;
        readonly PDFUtilities pDFUtilities;
        public PdfReader pdfReader;
         
        #endregion

        #region Constructor
        public F1040EZPDFBinding()
        {
            pDFUtilities = new PDFUtilities();
        }
        #endregion

        #region Output Forms

        /// <summary>
        /// Outs the put form.
        /// </summary>
        /// <param name="tax1040Object">The tax1040 object.</param>
        /// <param name="template">The template.</param>
        /// <returns></returns>
        public byte[] OutPutForm(BusinessObject.Tax1040 tax1040Object, string template)
        {
            byte[] outputForm = null;
            switch (template)
            {
                case Constants.FORM1040EZ_BINDING:
                    pdfReader = new PdfReader(PDFTemplates.F1040EZOutputForm);
                    mapperXml = Constants.MAPPERXML_F1040EZ_OUTPUTFROM;
                    break;   

                case Constants.EICWORKSHEET_BINDING:
                    pdfReader = new PdfReader(PDFTemplates.EICWorkSheetOutputForm);
                    mapperXml = Constants.MAPPERXML_F1040EZ_EIC_WORKSHEET;
                    break;

                case Constants.SSBWORKSHEET_BINDING:
                    pdfReader = new PdfReader(PDFTemplates.SSBWorkSheetOutputForm);
                    mapperXml = Constants.MAPPERXML_F1040EZ_SSB_WORKSHEET;
                    break;
                case Constants.STANDARDDEDUCTIONWORKSHEET_BINDING:
                    pdfReader = new PdfReader(PDFTemplates.StandardDeductionWorkSheetOutputForm);
                    mapperXml = Constants.MAPPERXML_F1040EZ_STANDARD_DEDUCTION_WORKSHEET;
                    break;
                //Bala - 26th June 2014 - Added for Form 8862 PDF Binding
                case Constants.FORM8862_BINDING:
                    pdfReader = new PdfReader(PDFTemplates.F8862OutPutForm);
                    mapperXml = Constants.MAPPERXML_F8862_OUTPUTFORM;
                    break;
                //Yogalakshmi - 26th June 2014 - Added for Form 8879 PDF Binding
                case Constants.FORM8879_BINDING:
                    pdfReader = new PdfReader(PDFTemplates.F8879OutPutForm);
                    mapperXml = Constants.MAPPERXML_FORM8879_OUTPUTFORM;
                    break;

                //Yogalakshmi - 26th June 2014 - Added for Form 1040 V PDF Binding 
                case Constants.FORM1040V_BINDING:
                    pdfReader = new PdfReader(PDFTemplates.F1040VOutPutForm);
                    mapperXml = Constants.MAPPERXML_FORM1040V_OUTPUTFORM;
                    break;

                case Constants.FORMW2_BINDING:
                    return outputForm = W2Mapping(tax1040Object);
            }
            outputForm = pDFUtilities.Mapping(pdfReader, mapperXml, tax1040Object);
            return outputForm;
        }

        public byte[] W2Mapping(BusinessObject.Tax1040 tax1040Object)
        {
            byte[] outputForm = null;
            List<byte[]> outputForms = new List<byte[]>();
            byte[] w2Forms = null;
            if (tax1040Object != null && tax1040Object.Income != null && tax1040Object.Income.W2Wages != null)
            {
                List<W2> W2Wages = tax1040Object.Income.W2Wages;
                W2Wages.RemoveAll(aa => aa.EmploymentType == EmploymentType.HouseholdEmployeeWages || aa.EmploymentType == EmploymentType.TaxableScholarshipIncome || aa.EmploymentType == EmploymentType.ForeignEmployment);
                PrimaryTaxPayer primaryTaxPayer = tax1040Object.PersonalDetails.PrimaryTaxPayer;
                int count = W2Wages.Count;

                for (int i = 0; i < W2Wages.Count; i++)
                {

                    //19Jul2014 Sathish Maping PersonAddress to Employee Address if HasEmployeeAddress
                    MappingPersonAddressToEmployeeAddress(tax1040Object, W2Wages[i]);

                    pdfReader = new PdfReader(PDFTemplates.FW2OutputForm);
                    mapperXml = Constants.MAPPERXML_F1040EZ_FW2_OUTPUTFORM;
                    //Yogalakshmi - 15th July 2014 - Added for binding Primary Tax Payer Information
                    primarytaxpayermapperXml = Constants.MAPPERXML_F1040EZ_FW2_PRIMARYTAXPAYER_OUTPUTFORM;
                    outputForm = pDFUtilities.W2Mapping(pdfReader, mapperXml, W2Wages[i], primarytaxpayermapperXml, primaryTaxPayer);

                    //if (W2Wages[i].OtherDeductsBenefits.Count > 0)
                    //{
                    //    for (int j = 0; j < W2Wages[i].OtherDeductsBenefits.Count; j++)
                    //    {
                    //        pdfReader = new PdfReader(outputForm);
                    //        string mapperXmlOtherDeductsBenefits = Constants.MAPPERXML_F1040EZ_FW2_OTHERDEDUCTSBENEFITS_OUTPUTFORM;
                    //        outputForm = pDFUtilities.W2OtherDeductsBenefits(pdfReader, mapperXmlOtherDeductsBenefits, W2Wages[i].OtherDeductsBenefits[j],j+1);
                    //    }
                    //}
                    outputForms.Add(outputForm);
                }
                w2Forms = pDFUtilities.MergePDFBytes(outputForms);            
            }
            
            return w2Forms;
        }

        #endregion

        #region Helper
        /// <summary>
        ///  Employee address is same as person address assign w2 employee address from person address
        /// </summary>
        /// <param name="taxObject">Tax Object</param>
        /// <param name="w2">W2</param>
        //19Jul2014 Sathish Maping PersonAddress to Employee Address if HasEmployeeAddress
        private void MappingPersonAddressToEmployeeAddress(BusinessObject.Tax1040 taxObject, W2 w2)
        {
            if (taxObject != null && taxObject.PersonalDetails != null && taxObject.PersonalDetails.PrimaryTaxPayer != null
                && taxObject.PersonalDetails.PrimaryTaxPayer.Person != null && taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address != null
                && w2 != null)
            {
                if (w2.HasEmployeeAddress.HasValue && !w2.HasEmployeeAddress.Value)
                {

                    if (taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.AddressType == AddressType.PersonalAddress
                        && taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress != null)
                    {
                        w2.EmployeeAddress = new W2EmployeeAddress()
                        {

                            StreetAddress = taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.StreetAddress,
                            City = taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.City,
                            //State = taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.State,
                              State = new State() { 
                                StateCode = taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.StateCode
                            },
                            ZipCode = taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.PersonalAddress.ZipCode
                        };
                    }
                    else if (taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.AddressType == AddressType.ForeignAddress
                        && taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress != null)
                    {
                        w2.EmployeeAddress = new W2EmployeeAddress()
                        {

                            StreetAddress = taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.StreetAddress,
                            City = taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.City,
                            //  State = taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.State, //19Aug2014 TODO: if person has foreign address we dont have state
                            ZipCode = taxObject.PersonalDetails.PrimaryTaxPayer.Person.Address.ForeignAddress.PostalCode
                        };
                    }
                }
            }
        }
        #endregion Helper
    }
}

