using iTextSharp.text.pdf;
using System.IO;

namespace JTL.Tax1040.PDFBinding
{
    public class F8879PDFBinding
    {
        public byte[] F8879Page1Binding(BusinessObject.Tax1040 tax1040Object)
        {
            var pdfReader = new PdfReader(PDFTemplates.F8879OutPutForm);
            using (var memoryStream = new MemoryStream())
            {
                var stamper = new PdfStamper(pdfReader, memoryStream);
                stamper.Writer.SetPdfVersion(PdfWriter.PDF_VERSION_1_4);
                var pdfFormFields = stamper.AcroFields;

                pdfFormFields.SetField("txtF8879SID", "xzvgdzs4545");
                pdfFormFields.SetField("txtF8879TaxpayerName", "David");
                pdfFormFields.SetField("txtF8879TaxpayerSSN", "123456879");
                pdfFormFields.SetField("txtF8879SpouseName", "Jessica");
                pdfFormFields.SetField("txtF8879SpouseSSN", "123456789");
                pdfFormFields.SetField("txtF8879AdjustedGrossIncome",tax1040Object.OutputForms.Tax1040EZPage1.AdjustedGrossIncome.ToString());
                pdfFormFields.SetField("txtF8879TotalTax", tax1040Object.OutputForms.Tax1040EZPage1.TaxAmount.ToString());
                pdfFormFields.SetField("txtF8879FederalIncomeTaxWithheld", tax1040Object.OutputForms.Tax1040EZPage1.FederalTaxWithholdingAmount.ToString());
                pdfFormFields.SetField("txtF8879RefundAmount", tax1040Object.OutputForms.Tax1040EZPage1.RefundAmount.ToString());
                pdfFormFields.SetField("txtF8879AmountYouOwe", tax1040Object.OutputForms.Tax1040EZPage1.TaxOweAmount.ToString());
                pdfFormFields.SetField("txtF8879TaxpayerEROFirmName", "xxxxxxxxx");
                pdfFormFields.SetField("txtF8879TaxpayerPINPart1", "1");
                pdfFormFields.SetField("txtF8879TaxpayerPINPart2", "2");
                pdfFormFields.SetField("txtF8879TaxpayerPINPart3", "3");
                pdfFormFields.SetField("txtF8879TaxpayerPINPart4", "4");
                pdfFormFields.SetField("txtF8879TaxpayerPINPart5", "5");
                pdfFormFields.SetField("txtF8879SpouseEROFirmName", "vdshvk");
                pdfFormFields.SetField("txtF8879SpousePINPart1", "6");
                pdfFormFields.SetField("txtF8879SpousePINPart2", "6");
                pdfFormFields.SetField("txtF8879SpousePINPart3", "2");
                pdfFormFields.SetField("txtF8879SpousePINPart4", "2");
                pdfFormFields.SetField("txtF8879SpousePINPart5", "1");
                pdfFormFields.SetField("chkF8879TaxpayerAuthorize", "Yes");
                pdfFormFields.SetField("chkF8879TaxpayerSignature", "Yes");
                pdfFormFields.SetField("chkF8879SpouseAuthorize", "Yes");
                pdfFormFields.SetField("chkF8879SpouseSignature", "Yes");
                pdfFormFields.SetField("txtF8879PractitionerPINPart1", "1");
                pdfFormFields.SetField("txtF8879PractitionerPINPart2", "2");
                pdfFormFields.SetField("txtF8879PractitionerPINPart3", "3");
                pdfFormFields.SetField("txtF8879PractitionerPINPart4", "4");
                pdfFormFields.SetField("txtF8879PractitionerPINPart5", "5");
                pdfFormFields.SetField("txtF8879PractitionerPINPart6", "6");
                pdfFormFields.SetField("txtF8879PractitionerPINPart7", "7");
                pdfFormFields.SetField("txtF8879PractitionerPINPart8", "8");
                pdfFormFields.SetField("txtF8879PractitionerPINPart9", "9");
                pdfFormFields.SetField("txtF8879PractitionerPINPart10","0");
                pdfFormFields.SetField("txtF8879PractitionerPINPart11","4");
               
                stamper.Writer.CloseStream = false;
                // set pdf into read only
                stamper.FormFlattening = true;
                // close the pdf
                stamper.Close();
                pdfReader.Close();
                File.WriteAllBytes(@" D:\OutputForm1.pdf", memoryStream.ToArray());
                byte[] F8879Page1 = memoryStream.GetBuffer();
                return F8879Page1;
            }

        }
    }
}
