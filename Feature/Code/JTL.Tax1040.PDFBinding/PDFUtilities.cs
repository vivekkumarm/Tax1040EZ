/*
Copyright       : Copyright Jeevan Technologies
File Name       : PDFUtilities.cs 
Description     : commom utility method for PDF mapping 
Author          : Ashok Kumar
Created Date    : 30 May 2014

 * Modification History:
 */
using System.Globalization;
using JTL.Tax1040.Core.Object;
using iTextSharp.text.pdf;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System;
using JTL.Tax1040.BusinessObject;

namespace JTL.Tax1040.PDFBinding
{
    public class PDFUtilities
    {
        #region Mapping

        public byte[] Mapping(PdfReader pdfReader, string mapperXml, BusinessObject.Tax1040 tax1040Object)
        {
            using (var memoryStream = new MemoryStream())
            {
                var stamper = new PdfStamper(pdfReader, memoryStream);
                stamper.Writer.SetPdfVersion(PdfWriter.PDF_VERSION_1_4);
                var pdfFormFields = stamper.AcroFields;

                XElement mappingXelements = XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(mapperXml));
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
                            string maxLength = "0";
                            string enumText = "";
                            if(fieldType == Constants.SplitReverse)
                             maxLength = xElement.Attribute("MaxLength").Value; 

                            string[] troClasses = troField.Split('.');
                            int troClassesCount = troClasses.Length;
                            string listPropertyName = string.Empty;
                            dynamic obj = tax1040Object;

                            if (fieldType == Constants.List)
                            {
                                troClassesCount = troClassesCount - 1;
                                listPropertyName = troClasses[troClassesCount];
                            }
                            else if (fieldType == Constants.EnumText)
                            {
                                enumText = xElement.Attribute("Text").Value;
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
                                    case Constants.Check:
                                        SetPdfFormCheckField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.UnCheck:
                                        SetPdfFormUnCheckField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.Split:
                                        SetPdfFormSplitField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.SplitReverse:
                                        SetPdfFormSplitReverseField(obj.ToString(), pdfField, pdfFormFields, maxLength);
                                        break;
                                    case Constants.EnumText:
                                        SetPdfFormEnumCheckboxField(obj.ToString(), pdfField, pdfFormFields, enumText);
                                        break;   
                                }
                            }
                        }
                    }
                }
                stamper.Writer.CloseStream = false;
                // set pdf into read only
                stamper.FormFlattening = true;
                stamper.Close();
                pdfReader.Close();
                byte[] OutputPage = memoryStream.GetBuffer();
                return OutputPage;
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
            //Saravanan N - 14th Aug, 2014 - Line6 in 1040EZ output form should display 0.
            if (amount > 0 || pdfControlName.Equals("txtF1040EZLine6TaxableIncome"))
            {
                string[] value = outputValue.ToString(CultureInfo.InvariantCulture).Split(".".ToCharArray());
                pdfFormFields.SetField(pdfControlName, value[0]);
            }
        }

        public static void SetPdfFormDecimalField(string outputValue, string pdfControlName, AcroFields pdfFormFields)
        {
            double amount = 0;
            double.TryParse(outputValue, out amount);
            //Saravanan N - 14th Aug, 2014 - Line6 in 1040EZ output form should display 0.
            if (amount > 0 || pdfControlName.Equals("txtF1040EZLine6TaxableIncomeDecimal"))
            {
                string[] value = outputValue.ToString(CultureInfo.InvariantCulture).Split(".".ToCharArray());
                pdfFormFields.SetField(pdfControlName, value.Length == 1 ? "00" : value[1]);
            }
        }

        //Check box binding
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
                //Yogalakshmi - 30th June 2014 - Checked for SSN length 11.
                if (outputValue.Length == 11)
                {
                    pdfFormFields.SetField((pdfControlName + "1"), outputValue.Substring(0, 3));
                    pdfFormFields.SetField((pdfControlName + "2"), outputValue.Substring(4, 2));
                    pdfFormFields.SetField((pdfControlName + "3"), outputValue.Substring(7, 4));
                }
                else if (outputValue.Length == 9)
                {
                    pdfFormFields.SetField((pdfControlName + "1"), outputValue.Substring(0, 3));
                    pdfFormFields.SetField((pdfControlName + "2"), outputValue.Substring(3, 2));
                    pdfFormFields.SetField((pdfControlName + "3"), outputValue.Substring(5, 4));
                }
            }
        }

        public static void SetPdfFormListField(dynamic outputValue, string pdfControlName, AcroFields pdfFormFields, string listPropertyName)
        {
            if (outputValue != null)
            {
                int listCount = outputValue.Count;

                for (int i = 0; i < listCount; i++)
                {
                    object listObj = GetPropertyValue(outputValue[i], listPropertyName);
                    pdfFormFields.SetField((pdfControlName + (i + 1)), listObj.ToString());
                }
            }
        }

        //Radio button binding - For Radio button Yes option
        public static void SetPdfFormCheckField(string outputValue, string pdfControlName, AcroFields pdfFormFields)
        {
            bool status = false;
            bool.TryParse(outputValue, out status);
            var bindingStatus = status ? "Yes" : "No";
            pdfFormFields.SetField(pdfControlName, bindingStatus);
        }

        //Radio button binding - For Radio button No option
        public static void SetPdfFormUnCheckField(string outputValue, string pdfControlName, AcroFields pdfFormFields)
        {
            bool status = false;
            bool.TryParse(outputValue, out status);
            var bindingStatus = status ? "No" : "Yes";
            pdfFormFields.SetField(pdfControlName, bindingStatus);
        }

        //Key Pair logic - splitted data binding - For RTN, Account No., PIN 
        public static void SetPdfFormSplitField(string outputValue, string pdfControlName, AcroFields pdfFormFields)
        {
            if (!string.IsNullOrEmpty(outputValue))
            {
                Dictionary<int, char> myValues = splitting(outputValue);
                foreach (KeyValuePair<int, char> keyPair in myValues)
                {
                    pdfFormFields.SetField((pdfControlName + (keyPair.Key+1)), keyPair.Value.ToString(CultureInfo.InvariantCulture));
                }
            }
        }
        //Bala/Ashok 27Jun14, SplitReverse method added
        public static void SetPdfFormSplitReverseField(string outputValue, string pdfControlName, AcroFields pdfFormFields,string length)
        {
            if (!string.IsNullOrEmpty(outputValue))
            {
                char[] myValues = outputValue.ToCharArray();
                int maxLength = myValues.Length;
                for (int i = maxLength-1,j = int.Parse(length); i >= 0 && j>=1; i--,j--)
                {
                    pdfFormFields.SetField((pdfControlName + j), myValues[i].ToString(CultureInfo.InvariantCulture));
                }
            }
        }

        public static void SetPdfFormEnumCheckboxField(string outputValue, string pdfControlName, AcroFields pdfFormFields, string enumText)
        {
            if (!string.IsNullOrEmpty(outputValue))
            {
                var status="No";
                if (outputValue == enumText)
                    status = "Yes";                
                pdfFormFields.SetField(pdfControlName, status);
            }
        }

        #endregion


        #region Merge PDFs

        ////Merging 2 PDFs
        //private byte[] MergePDFBytes(byte[] pdf1, byte[] pdf2)
        //{
        //    PdfReader pdfReader = null;
        //    MemoryStream ms = new MemoryStream();
        //    PdfCopyFields Copier = new PdfCopyFields(ms);

        //    pdfReader = new PdfReader(pdf1);
        //    Copier.AddDocument(new PdfReader(pdfReader));

        //    pdfReader = new PdfReader(pdf2);
        //    Copier.AddDocument(new PdfReader(pdfReader));

        //    Copier.Close();
        //    return ms.GetBuffer();
        //}

        //Merging mulitple PDFs from List
        public byte[] MergePDFBytes(List<byte[]> pdfs)
        {
            PdfReader pdfReader = null;
            MemoryStream ms = new MemoryStream();
            PdfCopyFields copyField = new PdfCopyFields(ms);
            foreach (var pdf in pdfs)
            {
                pdfReader = new PdfReader(pdf);
                copyField.AddDocument(new PdfReader(pdfReader));
            }
            copyField.Close();
            return ms.GetBuffer();
        }

        #endregion


        //Key Pair logic - splitting string data which has to be binded 
        private static Dictionary<int, char> splitting(string data)
        {
            Dictionary<int, char> myValues = new Dictionary<int, char>();
            int i = 0;
            foreach (char ch in data)
            {
                myValues.Add(i, ch);
                i++;
            }
            return myValues;
        }

        //Yogalakshmi - 15th July 2014 - Added for binding Primary Tax Payer Information
        public byte[] W2Mapping(PdfReader pdfReader, string mapperXml, W2 Wages,string primarytaxpayermapperXml, PrimaryTaxPayer primaryTaxPayer)
        {
            using (var memoryStream = new MemoryStream())
            {
                var stamper = new PdfStamper(pdfReader, memoryStream);
                stamper.Writer.SetPdfVersion(PdfWriter.PDF_VERSION_1_4);
                var pdfFormFields = stamper.AcroFields;

                //Yogalakshmi - 15th July 2014 - Added for binding Primary Tax Payer Information
                XElement mappingPrimaryTaxPayerXelements = XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(primarytaxpayermapperXml));
                IEnumerable<XElement> mapping = mappingPrimaryTaxPayerXelements.Elements();

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
                            string maxLength = "0";
                            if (fieldType == Constants.SplitReverse)
                                maxLength = xElement.Attribute("MaxLength").Value;

                            string[] troClasses = troField.Split('.');
                            int troClassesCount = troClasses.Length;
                            string listPropertyName = string.Empty;
                            dynamic obj = primaryTaxPayer;

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
                                    case Constants.Check:
                                        SetPdfFormCheckField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.UnCheck:
                                        SetPdfFormUnCheckField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.Split:
                                        SetPdfFormSplitField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.SplitReverse:
                                        SetPdfFormSplitReverseField(obj.ToString(), pdfField, pdfFormFields, maxLength);
                                        break;
                                }
                            }
                        }
                    }
                }

                XElement mappingXelements = XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(mapperXml));
                mapping = mappingXelements.Elements();

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
                            string maxLength = "0";
                            if (fieldType == Constants.SplitReverse)
                                maxLength = xElement.Attribute("MaxLength").Value;

                            string[] troClasses = troField.Split('.');
                            int troClassesCount = troClasses.Length;
                            string listPropertyName = string.Empty;
                            dynamic obj = Wages;

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
                                    case Constants.Check:
                                        SetPdfFormCheckField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.UnCheck:
                                        SetPdfFormUnCheckField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.Split:
                                        SetPdfFormSplitField(obj.ToString(), pdfField, pdfFormFields);
                                        break;
                                    case Constants.SplitReverse:
                                        SetPdfFormSplitReverseField(obj.ToString(), pdfField, pdfFormFields, maxLength);
                                        break;
                                }
                            }
                        }
                    }
                }

                if (Wages.OtherDeductsBenefits!=null && Wages.OtherDeductsBenefits.Count > 0)
                {
                    for (int j = 0; j < Wages.OtherDeductsBenefits.Count; j++)
                    {                        
                        string mapperXmlOtherDeductsBenefits = Constants.MAPPERXML_F1040EZ_FW2_OTHERDEDUCTSBENEFITS_OUTPUTFORM;
                        W2OtherDeductsBenefits(pdfReader, mapperXmlOtherDeductsBenefits, Wages.OtherDeductsBenefits[j], j + 1, pdfFormFields);
                    }
                }
                //Yogalakshmi - 14th July 2014 - XML Mapper for State Info
                if (Wages.W2StateLocalTaxInfo != null && Wages.W2StateLocalTaxInfo.Count > 0)
                {
                    for (int j = 0; j < Wages.W2StateLocalTaxInfo.Count; j++)
                    {
                        string mapperXmlStateLocalTaxInfo = Constants.MAPPERXML_F1040EZ_FW2_STATELOCALTAXINFO_OUTPUTFORM;
                        W2StateTaxInfo(pdfReader, mapperXmlStateLocalTaxInfo, Wages.W2StateLocalTaxInfo[j], j + 1, pdfFormFields);
                    }
                }
                //Yogalakshmi - 14th July 2014 - XML Mapper for Employer Code
                if (Wages.W2EmployerCodes != null && Wages.W2EmployerCodes.Count > 0)
                {
                    for (int j = 0; j < Wages.W2EmployerCodes.Count; j++)
                    {
                        string mapperXmlStateLocalTaxInfo = Constants.MAPPERXML_F1040EZ_FW2_EMPLOYERCODE_OUTPUTFORM;
                        W2EmployerCode(pdfReader, mapperXmlStateLocalTaxInfo, Wages.W2EmployerCodes[j], j + 1, pdfFormFields);
                    }
                }
                stamper.Writer.CloseStream = false;
                // set pdf into read only
                stamper.FormFlattening = true;
                stamper.Close();
                pdfReader.Close();
                byte[] OutputPage = memoryStream.GetBuffer();
                return OutputPage;
            }
        }       

        public void W2OtherDeductsBenefits(PdfReader pdfReader, string mapperXml, OtherDeductsBenefits otherDeductsBenefits, int count, AcroFields pdfFormFields)
        {
            XElement mappingXelements = XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(mapperXml));
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
                        string maxLength = "0";
                        if (fieldType == Constants.SplitReverse)
                            maxLength = xElement.Attribute("MaxLength").Value;

                        string[] troClasses = troField.Split('.');
                        int troClassesCount = troClasses.Length;
                        string listPropertyName = string.Empty;
                        dynamic obj = otherDeductsBenefits;

                        
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
                                case Constants.Check:
                                    SetPdfFormCheckField(obj.ToString(), pdfField, pdfFormFields);
                                    break;
                                case Constants.UnCheck:
                                    SetPdfFormUnCheckField(obj.ToString(), pdfField, pdfFormFields);
                                    break;
                                case Constants.Split:
                                    SetPdfFormSplitField(obj.ToString(), pdfField, pdfFormFields);
                                    break;
                                case Constants.SplitReverse:
                                    SetPdfFormSplitReverseField(obj.ToString(), pdfField, pdfFormFields, maxLength);
                                    break;
                                case Constants.ListType:
                                    pdfField = pdfField + count.ToString();
                                    pdfFormFields.SetField(pdfField, obj.ToString());
                                    break;
                            }
                        }
                    }
                }
            }           
        }

        //Yogalakshmi - 14th July 2014 - Added a method for State Tax Info
        public void W2StateTaxInfo(PdfReader pdfReader, string mapperXml, W2StateLocalTaxInfo w2StateLocalTaxInfo, int count, AcroFields pdfFormFields)
        {
            XElement mappingXelements = XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(mapperXml));
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
                        string maxLength = "0";
                        if (fieldType == Constants.SplitReverse)
                            maxLength = xElement.Attribute("MaxLength").Value;

                        string[] troClasses = troField.Split('.');
                        int troClassesCount = troClasses.Length;
                        string listPropertyName = string.Empty;
                        dynamic obj = w2StateLocalTaxInfo;


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
                                case Constants.Check:
                                    SetPdfFormCheckField(obj.ToString(), pdfField, pdfFormFields);
                                    break;
                                case Constants.UnCheck:
                                    SetPdfFormUnCheckField(obj.ToString(), pdfField, pdfFormFields);
                                    break;
                                case Constants.Split:
                                    SetPdfFormSplitField(obj.ToString(), pdfField, pdfFormFields);
                                    break;
                                case Constants.SplitReverse:
                                    SetPdfFormSplitReverseField(obj.ToString(), pdfField, pdfFormFields, maxLength);
                                    break;
                                case Constants.ListType:
                                    pdfField = pdfField + count.ToString();
                                    pdfFormFields.SetField(pdfField, obj.ToString());
                                    break;
                            }
                        }
                    }
                }
            }
            if (w2StateLocalTaxInfo.W2LocalTaxInfo!=null && w2StateLocalTaxInfo.W2LocalTaxInfo.Count > 0)
            {
                for (int j = 0; j < w2StateLocalTaxInfo.W2LocalTaxInfo.Count; j++)
                {
                    string mapperXmlStateLocalTaxInfo = Constants.MAPPERXML_F1040EZ_FW2_LOCALTAXINFO_OUTPUTFORM;
                    W2LocalTaxInfo(pdfReader, mapperXmlStateLocalTaxInfo, w2StateLocalTaxInfo.W2LocalTaxInfo[j], count, pdfFormFields);
                }
            }
        }

        //Yogalakshmi - 14th July 2014 - Added a method for Local Tax Info
        public void W2LocalTaxInfo(PdfReader pdfReader, string mapperXml, W2LocalTaxInfo w2LocalTaxInfo, int count, AcroFields pdfFormFields)
        {
            XElement mappingXelements = XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(mapperXml));
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
                        string maxLength = "0";
                        if (fieldType == Constants.SplitReverse)
                            maxLength = xElement.Attribute("MaxLength").Value;

                        string[] troClasses = troField.Split('.');
                        int troClassesCount = troClasses.Length;
                        string listPropertyName = string.Empty;
                        dynamic obj = w2LocalTaxInfo;


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
                                case Constants.Check:
                                    SetPdfFormCheckField(obj.ToString(), pdfField, pdfFormFields);
                                    break;
                                case Constants.UnCheck:
                                    SetPdfFormUnCheckField(obj.ToString(), pdfField, pdfFormFields);
                                    break;
                                case Constants.Split:
                                    SetPdfFormSplitField(obj.ToString(), pdfField, pdfFormFields);
                                    break;
                                case Constants.SplitReverse:
                                    SetPdfFormSplitReverseField(obj.ToString(), pdfField, pdfFormFields, maxLength);
                                    break;
                                case Constants.ListType:
                                    pdfField = pdfField + count.ToString();
                                    pdfFormFields.SetField(pdfField, obj.ToString());
                                    break;
                            }
                        }
                    }
                }
            }
        }

        public void W2EmployerCode(PdfReader pdfReader, string mapperXml, W2EmployerCode w2EmployerCode, int count, AcroFields pdfFormFields)
        {
            XElement mappingXelements = XElement.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream(mapperXml));
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
                        string maxLength = "0";
                        if (fieldType == Constants.SplitReverse)
                            maxLength = xElement.Attribute("MaxLength").Value;

                        string[] troClasses = troField.Split('.');
                        int troClassesCount = troClasses.Length;
                        string listPropertyName = string.Empty;
                        dynamic obj = w2EmployerCode;


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
                                case Constants.Check:
                                    SetPdfFormCheckField(obj.ToString(), pdfField, pdfFormFields);
                                    break;
                                case Constants.UnCheck:
                                    SetPdfFormUnCheckField(obj.ToString(), pdfField, pdfFormFields);
                                    break;
                                case Constants.Split:
                                    SetPdfFormSplitField(obj.ToString(), pdfField, pdfFormFields);
                                    break;
                                case Constants.SplitReverse:
                                    SetPdfFormSplitReverseField(obj.ToString(), pdfField, pdfFormFields, maxLength);
                                    break;
                                case Constants.ListType:
                                    pdfField = pdfField + count.ToString();
                                    pdfFormFields.SetField(pdfField, obj.ToString());
                                    break;
                            }
                        }
                    }
                }
            }
        }

    }
}
