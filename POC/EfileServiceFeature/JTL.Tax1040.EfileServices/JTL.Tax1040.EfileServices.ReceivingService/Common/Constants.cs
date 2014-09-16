using System;
using System.Collections.Generic;
using System.Text;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public static class Constants
    {
        public const string Country_USA = "USA";
        public const string USAddress = "USAddress";
        public const string ZeroIPIN = "000000";
        public const string ZeroPIN = "00000";
        public const string NinePIN = "99999";
        public const string NineZeros = "000000000";
        public const string NineNines = "999999999";

        public const int PhoneNumerLength = 10;
        public const int SSNLength = 9;
        public const string TaxPreparer = "M";
        public const string BusinessOwner = "S";
        public const string ERO = "E";
        public const string strFourteen = "14";
        public const string EncryptionKey = "EncryptionKey";

        public const decimal DecimalZero = 0;
        public const decimal DecimalZeroAmount = 0.00M;
        public const string StringZero = "0";
        public const string StringNine = "9";
        public const string NaturalNumbers = "123456789";
        public const int InvalidSsnAreaCodeRange = 772;
        public const int InvalidSsnAreaCode1 = 666;
        public const string InvalidSsnAreaCode2 = "000";

        public const string InvalidSsnGroupCode = "00";
        public const string InvalidSsnSerialNo = "0000";

        public const int intOne = 1;
        public const int intTwo = 2;
        public const int intZero = 0;

        //App Settings Key
        public const string AppKey_practitioner_PIN = "practitioner_PIN";


        public const double ConstDoubleZero = 0.0;
        public const decimal ConstDecimalZero = 0;
        public const int ConstIntZero = 0;
        public const int ConstIntTwo = 2;
        public const int ConstIntTwoHundred = 200;
        public const int ConstIntHundred = 100;
        public const int ConstIntThree = 3;
        public const int ConstIntFour = 4;
        public const int ConstIntSix = 6;
        public const int ConstIntTwenty = 20;
        public const int ConstIntHundredMillion = 100000000;
        public const string ConstStringCurrentYear = "CurrentYear";
        public const string ConstStringTaxYear2008 = "TaxYear2008";
        public const string ConstStringBVALTaxYear2290 = "BVALTaxYear2290";
        public const string ConstTypeForeignAddress = "Efile.IRSSchemaConverter.DataEntity.IRSSchema.ForeignAddressType";
        public const string ConstTypeUSAddress = "Efile.IRSSchemaConverter.DataEntity.IRSSchema.USAddressType";
        public const string ConstString00800 = "00800";
        public const string ConstString20500 = "20500";
        public const string ConstString34000 = "34000";
        public const string ConstString00600 = "00600";
        public const string ConstString96100 = "96100";
        public const string ConstString96900 = "96900";
        public const string ConstString00 = "00";
        public const char ConstCharZero = '0';
        public const char ConstCharNine = '9';

        public const string AttachmentDesc = "8453 Signature Document";
        public const string ConstCityAPO = "APO";
        public const string ConstCityFPO = "FPO";

        public const string ConstCountryUS = "US";
        public const string ConstStateAA = "AA";
        public const string ConstStateAE = "AE";
        public const string ConstStateAP = "AP";
        public const string ConstStringP = "P";
        public const string ConstHypen = "-";
        public const string ConstLeftBracket = "(";
        public const string ConstRightBracket = ")";
        public const string ConstString340 = "340";

    }

    public static class FormType
    {
        public const string Form7004 = "7004";
        public const string Form8868 = "8868";
        public const string Form4868 = "4868";
        public const string Form2350 = "2350";
        public const string Form1040EZ = "Form1040EZ";
        public const string Form1040A = "1040A";
        public const string Form1040 = "1040";
    }



    public static class TaxYear
    {
        public const string Year2007 = "2007";
        public const string Year2008 = "2008";
        public const string Year2009 = "2009";
        public const string Year2010 = "2010";
        public const string Year2011 = "2011";
        public const string Year2012 = "2012";
        public const string Year2013 = "2013";
        public const string Year2014 = "2014";
    }
}