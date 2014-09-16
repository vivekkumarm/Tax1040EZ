using iTextSharp.text.pdf;
using System.IO;

namespace JTL.Tax1040.PDFBinding
{
   public class F8862PDFBinding
    {
       public byte[] F8862Page1Binding(BusinessObject.Tax1040 tax1040Object)
       {
           var pdfReader = new PdfReader(PDFTemplates.F8862OutPutForm);
           using (var memoryStream = new MemoryStream())
           {
               var stamper = new PdfStamper(pdfReader, memoryStream);
               stamper.Writer.SetPdfVersion(PdfWriter.PDF_VERSION_1_4);
               var pdfFormFields = stamper.AcroFields;

               //TO:DO : all the fields for f8862
               //pdfFormFields.SetField("txtF8862MarriedFilingReturnPart3", tax1040Object.OutputForms.Tax8862Page1.IsChild1Child3SameAddress);
               
               //Personal details 
               pdfFormFields.SetField("txtF8862TaxpayerName", "David");
               pdfFormFields.SetField("txtF8862TaxpayerSSN", "123456789");

               //Part I Filers
                  //line 1
               pdfFormFields.SetField("txtF8862FilerYearPart1", "1");//year
               pdfFormFields.SetField("txtF8862FilerYearPart2", "9");
               pdfFormFields.SetField("txtF8862FilerYearPart3", "8");
               pdfFormFields.SetField("txtF8862FilerYearPart4", "7");
                  //Line 2
               pdfFormFields.SetField("chkF8862FilersEarnedIncomeYes", "Yes");
               pdfFormFields.SetField("chkF8862FilersEarnedIncomeNo", "No");
                  //Line 3
               pdfFormFields.SetField("chkF8862SpouseFilingJointlyYes", "Yes");
               pdfFormFields.SetField("chkF8862SpouseFilingJointlyNo", "No");
               
               
               //Part II Filers with a Qualifying child

                  //Line 4a
               pdfFormFields.SetField("txtF8862QualifyingChild1Part1", "1");
               pdfFormFields.SetField("txtF8862QualifyingChild1Part2", "3");
               pdfFormFields.SetField("txtF8862QualifyingChild1Part3", "4");
                  //Line 4b
               pdfFormFields.SetField("txtF8862QualifyingChild2Part1", "1");
               pdfFormFields.SetField("txtF8862QualifyingChild2Part2", "2");
               pdfFormFields.SetField("txtF8862QualifyingChild2Part3", "3");
                  //Line 4c
               pdfFormFields.SetField("txtF8862QualifyingChild3Part1", "1");//number of days
               pdfFormFields.SetField("txtF8862QualifyingChild3Part2", "1");
               pdfFormFields.SetField("txtF8862QualifyingChild3Part3", "1");

                 //Line 5a (MM/DD)  child month & DOB
               pdfFormFields.SetField("txtF8862QualifyingChild1MonthDOBPart1", "1");//month
               pdfFormFields.SetField("txtF8862QualifyingChild1MonthDOBPart2", "2");//month
               pdfFormFields.SetField("txtF8862QualifyingChild1MonthDOBPart3", "2");//day   
               pdfFormFields.SetField("txtF8862QualifyingChild1MonthDOBPart4", "2");//day
                 //Line 5b (MM/DD)
               pdfFormFields.SetField("txtF8862QualifyingChild2MonthDOBPart1", "0");
               pdfFormFields.SetField("txtF8862QualifyingChild2MonthDOBPart2", "5");
               pdfFormFields.SetField("txtF8862QualifyingChild2MonthDOBPart3", "1");
               pdfFormFields.SetField("txtF8862QualifyingChild2MonthDOBPart4", "2");
                 //Line 5c (MM/DD)
               pdfFormFields.SetField("txtF8862QualifyingChild3MonthDOBPart1", "0");
               pdfFormFields.SetField("txtF8862QualifyingChild3MonthDOBPart2", "2");
               pdfFormFields.SetField("txtF8862QualifyingChild3MonthDOBPart3", "1");
               pdfFormFields.SetField("txtF8862QualifyingChild3MonthDOBPart4", "4");

                 //Line 5a (MM/DD) Child month & day of death 
               pdfFormFields.SetField("txtF8862QualifyingChild1MonthDayOfDeathPart1", "1");
               pdfFormFields.SetField("txtF8862QualifyingChild1MonthDayOfDeathPart2", "0");
               pdfFormFields.SetField("txtF8862QualifyingChild1MonthDayOfDeathPart3", "1");
               pdfFormFields.SetField("txtF8862QualifyingChild1MonthDayOfDeathPart4", "2");
                 //Line 5b (MM/DD)
               pdfFormFields.SetField("txtF8862QualifyingChild2MonthDayOfDeathPart1", "1");
               pdfFormFields.SetField("txtF8862QualifyingChild2MonthDayOfDeathPart2", "1");
               pdfFormFields.SetField("txtF8862QualifyingChild2MonthDayOfDeathPart3", "0");
               pdfFormFields.SetField("txtF8862QualifyingChild2MonthDayOfDeathPart4", "1");
                //Line 5c (MM/DD) 
               pdfFormFields.SetField("txtF8862QualifyingChild3MonthDayOfDeathPart1", "1");
               pdfFormFields.SetField("txtF8862QualifyingChild3MonthDayOfDeathPart2", "0");
               pdfFormFields.SetField("txtF8862QualifyingChild3MonthDayOfDeathPart3", "1");
               pdfFormFields.SetField("txtF8862QualifyingChild3MonthDayOfDeathPart4", "2");
                //Line 6a
               pdfFormFields.SetField("txtF8862QualifyingChild1Address1", "xxxxx");
               pdfFormFields.SetField("txtF8862QualifyingChild1Address2", "xxxxxx");
                //Line 6b
               pdfFormFields.SetField("txtF8862QualifyingChild2Address1", "xxxxx");
               pdfFormFields.SetField("txtF8862QualifyingChild2Address2", "xxxxxxx");
               pdfFormFields.SetField("chkF8862FilersAddressChild1", "Yes");
                //Line 6c
               pdfFormFields.SetField("chkF8862FilersAddressSameChild3", "Yes");
               pdfFormFields.SetField("chkF8862FilersAddressDifferentChild3", "Yes");
               pdfFormFields.SetField("txtF8862QualifyingChild3Address1", "xcxxxx");
               pdfFormFields.SetField("txtF8862QualifyingChild3Address2", "vxcvxzvzv");
                //Line 7
               pdfFormFields.SetField("chkF8862FilersOtherPersonYes", "Yes");
               pdfFormFields.SetField("chkF8862FilersOtherPersonNo", "No");
                //Line 7a
               pdfFormFields.SetField("txtF8862QualifyingOtherPersonChild1Name", "xcvzdxvz");
               pdfFormFields.SetField("txtF8862QualifyingOtherPersonChild1Relationship", "xcdvzv");
                //Line 7b
               pdfFormFields.SetField("txtF8862QualifyingOtherPersonChild2Name", "dfhbdfdh");
               pdfFormFields.SetField("txtF8862QualifyingOtherPersonChild2Relationship", "dfhgdfhh");
               pdfFormFields.SetField("chkF8862NameRelationshipChild1", "Yes");
              
                //Line 7c
               pdfFormFields.SetField("chkF8862NameRelationshipSameChild3", "Yes");
               pdfFormFields.SetField("chkF8862NameRelationshipDifferentChild3", "No");
               pdfFormFields.SetField("txtF8862QualifyingOtherPersonChild3Name", "xvxvds");
               pdfFormFields.SetField("txtF8862QualifyingOtherPersonChild3Relationship", "sdvgsgd");

              //Part III Filers without qualifying child
               //number of days
               pdfFormFields.SetField("txtF8862WithoutQualifyingChildNoDaysPart1", "1");
               pdfFormFields.SetField("txtF8862WithoutQualifyingChildNoDaysPart2", "2");
               pdfFormFields.SetField("txtF8862WithoutQualifyingChildNoDaysPart3", "3");
               //Married filing Jointly return
               pdfFormFields.SetField("txtF8862MarriedFilingReturnPart1", "");
               pdfFormFields.SetField("txtF8862MarriedFilingReturnPart2", "");
               pdfFormFields.SetField("txtF8862MarriedFilingReturnPart3", "");

               


               stamper.Writer.CloseStream = false;
               // set pdf into read only
               stamper.FormFlattening = true;
               // close the pdf
               stamper.Close();
               pdfReader.Close();
               File.WriteAllBytes(@" D:\OutputForm1.pdf", memoryStream.ToArray());
               byte[] F8862Page1 = memoryStream.GetBuffer();
               return F8862Page1;
           }
       
       
       }
    }
}
