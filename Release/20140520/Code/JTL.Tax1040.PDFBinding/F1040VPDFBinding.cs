using iTextSharp.text.pdf;
using System.IO;

namespace JTL.Tax1040.PDFBinding
{
    public class F1040VPDFBinding
    {
        public byte[] F1040VPage1Binding(BusinessObject.Tax1040 tax1040Object)
        {
            var pdfReader = new PdfReader(PDFTemplates.F1040VOutPutForm);
            using (var memoryStream = new MemoryStream())
            {
                var stamper = new PdfStamper(pdfReader, memoryStream);
                stamper.Writer.SetPdfVersion(PdfWriter.PDF_VERSION_1_4);
                var pdfFormFields = stamper.AcroFields;


                pdfFormFields.SetField("txtF1040VPrimaryTaxpayerSSN", "987456123");
                pdfFormFields.SetField("txtF1040VSpouseTaxpayerSSN", "123456789");
                pdfFormFields.SetField("txtF1040VAmountToPay", "1341");
                pdfFormFields.SetField("txtF1040VAmountToPayDecimal", "00");
                pdfFormFields.SetField("txtF1040VPrimaryTaxpayerFirstName", "David");
                pdfFormFields.SetField("txtF1040VPrimaryTaxpayerLastName", "Wilson");
                pdfFormFields.SetField("txtF1040VSpouseFirstName", "Shyiel");
                pdfFormFields.SetField("txtF1040VSpouseLastName", "John");
                pdfFormFields.SetField("txtF1040VHomeAddress", "asfasf");
                pdfFormFields.SetField("txtF1040VForeignAddress", "dghdfhh");
                pdfFormFields.SetField("txtF1040VApartmentNumber", "dfhdfhdh");
                pdfFormFields.SetField("txtF1040VForeignCountryName", "erhyerh");

                pdfFormFields.SetField("txtF1040VForeignProvince", "Tamil Nadu");
                pdfFormFields.SetField("txtF1040VForeignPostalCode", "600012");


                stamper.Writer.CloseStream = false;
                // set pdf into read only
                stamper.FormFlattening = true;
                // close the pdf
                stamper.Close();
                pdfReader.Close();
                File.WriteAllBytes(@" D:\OutputForm1.pdf", memoryStream.ToArray());
                byte[] F1040VPage1 = memoryStream.GetBuffer();
                return F1040VPage1;
            }
        }
    }
}
