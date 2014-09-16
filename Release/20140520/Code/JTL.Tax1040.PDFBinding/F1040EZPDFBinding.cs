/*14 March 2014 Praveen T Code refactring done*/
using System.Globalization;
using JTL.Tax1040.Core.Object;
using iTextSharp.text.pdf;
using System.IO;
using System.Xml.Linq;
using System.Reflection;
using System.Collections.Generic;


namespace JTL.Tax1040.PDFBinding
{
    public class F1040EZPDFBinding
    {
        #region F1040Ez Page1 Binding
        public byte[] f1040EZPage1Binding(BusinessObject.Tax1040 tax1040Object)
        {

            var pdfReader = new PdfReader(PDFTemplates.F1040EZOutputForm);
            using (var memoryStream = new MemoryStream())
            {
                var stamper = new PdfStamper(pdfReader, memoryStream);
                stamper.Writer.SetPdfVersion(PdfWriter.PDF_VERSION_1_4);
                var pdfFormFields = stamper.AcroFields;

                XElement mappingXelements = XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream("JTL.Tax1040.PDFBinding.PdfXmlMappers.F1040EZPdfSchema.xml"));
                IEnumerable<XElement> mapping = mappingXelements.Elements();

                foreach (var map in mapping)
                {
                    var element = map.Element("PDFField");
                    if (element != null)
                    {
                        string pdfField = element.Value;
                        var xElement = map.Element("TROField");
                        if (xElement != null)
                        {
                            string troField = xElement.Value;
                            string fieldType = xElement.Attribute("Type").Value;

                            string[] troClasses = troField.Split('.');
                            int troClassesCount = troClasses.Length;
                            string listPropertyName = string.Empty;
                            dynamic obj = tax1040Object;

                            if (fieldType == Constants.List)
                            {
                                troClassesCount = troClassesCount - 1;
                                listPropertyName = troClasses[troClassesCount];                       
                            }
                            for (int i = 1; i < troClassesCount; i++)
                            {
                                obj = GetPropertyValue(obj, troClasses[i]);

                                if (obj == null)
                                    break;
                            }
                            if (obj != null)
                            {
                                switch (fieldType)
                                {
                                    case Constants.Integer:
                                        SetPdfFormNumericField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.Decimal:
                                        SetPdfFormDecimalField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.String:
                                        pdfFormFields.SetField(pdfField, obj.ToString());
                                        break;
                                    case Constants.Bool:
                                        SetPdfFormBoolField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.SSN:
                                        SetPdfFormSSNField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.RTN:
                                        SetPdfFormRTNField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.AccountNumber:
                                        SetPdfFormAccountNumberField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.PIN:
                                        SetPdfFormPINNumberField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.List:
                                        SetPdfFormListField(obj, pdfField, pdfFormFields, listPropertyName);
                                        break;
                                }
                            }
                        }
                    }
                }

                # region commented

                //TO:DO : all the fields for 1040ez(PDF)

                #endregion
                stamper.Writer.CloseStream = false;
                // set pdf into read only
                stamper.FormFlattening = true;
                // close the pdf
                stamper.Close();
                pdfReader.Close();
                //File.WriteAllBytes(@" :\OutputForm1.pdf", memoryStream.ToArray());
                byte[] Page1 = memoryStream.GetBuffer();
                return Page1;
            }

        }
        #endregion

        #region GetPropertyValue
        public static object GetPropertyValue(object obj, string propertyName)
        {
            var objType = obj.GetType();
            var prop = objType.GetProperty(propertyName);

            return prop.GetValue(obj, null);
        }
        #endregion

        #region Assign to PDF
        public static void SetPdfFormNumericField(string outputValue, string pdfControlName, AcroFields pdfFormFields)
        {
            double amount = 0;
            double.TryParse(outputValue, out amount);
            if (amount > 0)
            {
                string[] value = outputValue.ToString(CultureInfo.InvariantCulture).Split(".".ToCharArray());
                pdfFormFields.SetField(pdfControlName, value[0]);                
            }
        }

        public static void SetPdfFormDecimalField(string outputValue, string pdfControlName, AcroFields pdfFormFields)
        {
            double amount = 0;
            double.TryParse(outputValue, out amount);
            if (amount > 0)
            {
                string[] value = outputValue.ToString(CultureInfo.InvariantCulture).Split(".".ToCharArray());             
                pdfFormFields.SetField(pdfControlName, value.Length == 1 ? "00" : value[1]);
            }
        }

        public static void SetPdfFormBoolField(string outputValue, string pdfControlName, AcroFields pdfFormFields)
        {
            bool status = false;
            bool.TryParse(outputValue, out status);
            var bindingStatus = status ? "Yes" : "No";
            pdfFormFields.SetField(pdfControlName, bindingStatus);
        }

        public static void SetPdfFormRTNField(string outputValue, string pdfControlName, AcroFields pdfFormFields)
        {
            if (!string.IsNullOrEmpty(outputValue))
            {
                if (outputValue.Length == 9)
                {
                    char[] values = outputValue.ToCharArray();
                    int i = 1;
                    foreach (char c in values)
                    {
                        pdfFormFields.SetField((pdfControlName + i), c.ToString());
                        i++;
                    }                 
                }
            }
        }

        public static void SetPdfFormAccountNumberField(string outputValue, string pdfControlName, AcroFields pdfFormFields)
        {
            if (!string.IsNullOrEmpty(outputValue))
            {
                if (outputValue.Length <= 17)
                {
                    char[] values = outputValue.ToCharArray();
                    int i = 1;
                    foreach (char c in values)
                    {
                        pdfFormFields.SetField((pdfControlName + i), c.ToString(CultureInfo.InvariantCulture));
                        i++;
                    }
                }
            }
        }

        public static void SetPdfFormPINNumberField(string outputValue, string pdfControlName, AcroFields pdfFormFields)
        {
            if (!string.IsNullOrEmpty(outputValue))
            {
                if (outputValue.Length == 5)
                {
                    char[] values = outputValue.ToCharArray();
                    int i = 1;
                    foreach (char c in values)
                    {
                        pdfFormFields.SetField((pdfControlName + i), c.ToString(CultureInfo.InvariantCulture));
                        i++;
                    }
                }
            }
        }

        public static void SetPdfFormSSNField(string outputValue, string pdfControlName, AcroFields pdfFormFields)
        {
            if (!string.IsNullOrEmpty(outputValue))
            {
                if (outputValue.Length == 9)
                {
                    pdfFormFields.SetField((pdfControlName + "1"), outputValue.Substring(0,3));
                    pdfFormFields.SetField((pdfControlName + "2"), outputValue.Substring(3, 2));
                    pdfFormFields.SetField((pdfControlName + "3"), outputValue.Substring(5, 4));                
                }
            }
        }

        public static void SetPdfFormListField(dynamic outputValue, string pdfControlName, AcroFields pdfFormFields, string listPropertyName)
        {
            if (outputValue !=null)
            {
                int listCount= outputValue.Count;             

                for (int i = 0; i < listCount; i++)
                {
                    object listObj = GetPropertyValue(outputValue[i], listPropertyName);
                    pdfFormFields.SetField((pdfControlName + (i+1)), listObj.ToString());
                }    
            }
        }
        #endregion
    }
}

