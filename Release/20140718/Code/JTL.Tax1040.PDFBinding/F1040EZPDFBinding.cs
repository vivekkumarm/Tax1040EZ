/*14 March 2014 Praveen T Code refactring done

Modification History:
---------------------
 * 30May2014  Ashok Kumar - PDF Refactoring and  Moved all PDF binding methods related to F1040EZ to this class
*/

using JTL.Tax1040.Core.Object;
using iTextSharp.text.pdf;

namespace JTL.Tax1040.PDFBinding
{
    public class F1040EZPDFBinding
    {
        #region Local variable declaration
        string mapperXml;
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
            }
            byte[] outputForm = pDFUtilities.Mapping(pdfReader, mapperXml, tax1040Object);
            return outputForm;
        }

        #endregion
    }
}

