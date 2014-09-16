/*
Copyright   : Copyright Jeevan Technologies
File Name   : BusinessValidationRepository.cs 
Description : Business Validation. 
 * 
 * Modification History:
* 27 March 2014  BalaSubramanian Added for Business Logic Validation
* 08Apr2014 Added new method to validate zip code, ssn 
 * 16Apr2014 Sathish Added new method to check boolean value is true
 * 08May2014 Sathish added new method for date comparison
 * 26May2014 Thileep Changed AssertIsWithinRange
 * 28May2014 Thileep Added AssertIsWithinPhoneNoRange method
 * 27May2014 Sathish added new method to compare date is lesser
 * 02Jun2014 Sathish added new method for zip validaiton
*/
using System;
using JTL.Tax1040.Core.Object;

namespace JTL.Tax1040.Core.Process
{
    public class BusinessValidationRepository : IBusinessValidationRepository
    {
        /// <summary>
        /// Compare date
        /// </summary>
        /// <param name="sourceValue">The Source Darget Date</param>
        /// <param name="targetedValue">The Targeted DAte</param>
        /// <param name="errorCode">The Error code</param>
        /// <param name="errorMessages">The Error Message </param>
        /// <returns>Error message if not valid</returns>
        public static ErrorMessage AssertIsEqual(DateTime sourceValue, DateTime targetedValue, string errorCode, ErrorMessages errorMessages)
        {
            return sourceValue.ToShortDateString() == targetedValue.ToShortDateString() ? errorMessages[errorCode] : null; 
        }

        /// <summary>
        /// Validation used to determine if a given datetime is MinValue then throws an exception if so.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsNotNull(DateTime value, string errorCode, ErrorMessages errorMessages)
        {
            return value == DateTime.MinValue ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// Validation used to determine if a given object value is null then throws an exception if so.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsNotNull(object value, string errorCode, ErrorMessages errorMessages)
        {
            return value == null ? errorMessages[errorCode] : null;

        }

        /// <summary>
        /// Validation used to determine if a given object value is curent year 2014
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsCurrentYear(int value, string errorCode, ErrorMessages errorMessages)
        {
            return value != DateTime.Now.Year ? errorMessages[errorCode] : null;

        }

        /// <summary>
        /// Validation used to determine if a given integer representing a
        /// database integer key is null (value=0 OR int.MinValue) and throws an exception if so.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsNotNull(int value, string errorCode, ErrorMessages errorMessages)
        {
            return (value == 0 || value == int.MinValue) ? errorMessages[errorCode] : null;

        }

        /// <summary>
        /// Validation used to determine if a given integer is set to  int.MinValue
        /// and throws and exception if so.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsNotMinValue(char value, string errorCode, ErrorMessages errorMessages)
        {

            return (value == char.MinValue) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// Validation used to determine if a given integer is set to  int.MinValue
        /// and throws and exception if so.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsNotMinValue(int value, string errorCode, ErrorMessages errorMessages)
        {
            return (value == int.MinValue) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// Validation used to determine if a given decimal is set to decimal.MinValue.
        /// </summary>
        /// <param name="value">The decimal value to assert.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsNotMinValue(decimal value, string errorCode, ErrorMessages errorMessages)
        {
            return (value == decimal.MinValue) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        ///  Validation used to determine if a given integer value is  greated than zero.
        /// </summary>
        /// <param name="value">The integer value to assert.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertGreaterThanZero(int value, string errorCode, ErrorMessages errorMessages)
        {
            return (value <= 0) ? errorMessages[errorCode] : null;
        }


        /// <summary>
        ///  Validation used to determine if a given integer value is  greated than zero.
        /// </summary>
        /// <param name="value">The integer value to assert.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertGreaterThanZero(long value, string errorCode, ErrorMessages errorMessages)
        {
            return (value <= 0) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        ///  Validation used to determine if a given integer value is  greated than zero.
        /// </summary>
        /// <param name="value">The integer value to assert.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertGreaterThanZero(Double value, string errorCode, ErrorMessages errorMessages)
        {
            return (value <= 0) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// Validation used to determine if a given integer value is  not negative number.
        /// </summary>
        /// <param name="value">The integer value to assert.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsNotNegativeNumber(int value, string errorCode, ErrorMessages errorMessages)
        {
            return (value < 0) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// Validation used to determine if a given string is null
        /// and throws an exception if so.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">Friendly parameter or property name</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsNotNullOrEmpty(string value, string errorCode, ErrorMessages errorMessages)
        {
            return (string.IsNullOrEmpty(value)) ? errorMessages[errorCode] : null;
        }

        
        /// <summary>
        /// Validation used to determine if a given string is null
        /// and throws an exception if so.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">Friendly parameter or property name</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsOnlyAlphapet(string value, string errorCode, ErrorMessages errorMessages)
        {
           
            return (!string.IsNullOrEmpty(value))?(!Utilities.IsAlphabet(value) ? errorMessages[errorCode] : null):null;
        }

        /// <summary>
        /// Validation for the address 
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errorCode">Friendly parameter or property name</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns></returns>
        public static ErrorMessage AssertIsNumbersLettersAndHyphen(string value, string errorCode, ErrorMessages errorMessages)
        {
            return (!Utilities.IsValidRegexPattern(value, @"[ A-Za-z0-9_@./-]*$")) ? errorMessages[errorCode] : null;
        }
        /// <summary>
        /// Validation used to determine if a given string is null
        /// and throws an exception if so.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">Friendly parameter or property name</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsOnlyAlphapet(char value, string errorCode, ErrorMessages errorMessages)
        {
            return (value != ' ')?(!Utilities.IsAlphabet(value) ? errorMessages[errorCode] : null) : null;
        }

        /// <summary>
        /// Check assert valud is
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>Error message if not valid</returns>
        public static ErrorMessage AssertIsTrue(bool value, string errorCode, ErrorMessages errorMessages)
        {
            return (value) ?  null : errorMessages[errorCode];
        }

        /// <summary>
        /// Asserts the greaterDate is greater than the compareDate.
        /// </summary>
        /// <param name="compareDate">Date to compare.</param>
        /// <param name="greaterDate">The greater date.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertDateIsGreater(DateTime compareDate, DateTime greaterDate, string errorCode,
            ErrorMessages errorMessages)
        {

            return (compareDate != DateTime.MaxValue && compareDate < greaterDate) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// Asserts the Compare date is greater .
        /// </summary>
        /// <param name="compareDate">Date to compare.</param>
        /// <param name="greaterDate">The greater date.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertDateIsLesser(DateTime compareDate, DateTime greaterDate, string errorCode,
            ErrorMessages errorMessages)
        {

            return (compareDate != DateTime.MaxValue && compareDate > greaterDate) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// Used to determine if a value equals a specific long value.
        /// </summary>
        /// <param name="actualvalue"></param>
        /// <param name="targetvalue"></param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsEqualToLongValue(long actualvalue, long targetvalue, string errorCode,
            ErrorMessages errorMessages)
        {
            return (actualvalue == targetvalue) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// Used to determine if a value equals a specific integer value.
        /// </summary>
        /// <param name="actualvalue"></param>
        /// <param name="targetvalue"></param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsEqualToIntegerValue(int actualvalue, int targetvalue, string errorCode,
            ErrorMessages errorMessages)
        {
            return (actualvalue != targetvalue) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// Used to determine if a value equals a specific integer value.
        /// </summary>
        /// <param name="actualvalue"></param>
        /// <param name="targetvalue"></param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsLessthenIntegerValue(int actualvalue, int targetvalue, string errorCode,
            ErrorMessages errorMessages)
        {
            return (actualvalue >= targetvalue) ? errorMessages[errorCode] : null;
        }



        /// <summary>
        /// Validation to determine if a string is less than or equal the maximum
        /// size allowed and throws an exception if not
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="maxLength">Maximum size for string</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsWithinMaxLength(string value, int maxLength, string errorCode,
            ErrorMessages errorMessages)
        {
            return (value.Length > maxLength) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// To determine the string is valid SSN
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>Error message if not valid</returns>
        public static ErrorMessage IsValidSSN(string value, string errorCode,
            ErrorMessages errorMessages)
        {

            return (!Utilities.IsValidSSN(value)) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// To determine valid zip code
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>Error message if not valid</returns>
        public static ErrorMessage IsValidZipCode(string value, string errorCode,
                                                ErrorMessages errorMessages)
        {
            return (!Utilities.IsValidZipCode(value)) ? errorMessages[errorCode] : null;
        }


        /// <summary>
        /// Validation to check if a given integer is within the range specified and
        /// throws and exception if not
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minValue">The min value.</param>
        /// <param name="maxValue">The max value.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>

        public static ErrorMessage AssertIsWithinRange(int value, int minValue, int maxValue, string errorCode,
            ErrorMessages errorMessages)
        {
            return (value < minValue || value > maxValue) ? errorMessages[errorCode] : null;
        }


        /// <summary>
        /// Validation to check if a given string is within the range specified and
        /// throws and exception if not
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minValue">The min value.</param>
        /// <param name="maxValue">The max value.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>

        public static ErrorMessage AssertIsWithinRange(string value, int minValue, int maxValue, string errorCode,
            ErrorMessages errorMessages)
        {
            return (value.Length < minValue || value.Length > maxValue) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// Validation to check if a given string is within the range specified and
        /// throws and exception if not
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minValue">The min value.</param>
        /// <param name="maxValue">The max value.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>

        public static ErrorMessage AssertIsWithinPhoneNoRange(string value, int minValue, int maxValue, string errorCode,
            ErrorMessages errorMessages)
        {
            return (value.Length < minValue || value.Length > maxValue || (!Utilities.IsValidPhone(value))) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// Asserts the date is not in future.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errorCode">The error code.</param>
        /// <param name="errorMessages">The error messages.</param>
        /// <returns></returns>
        public static ErrorMessage AssertDateIsNotInFuture(DateTime value, string errorCode, ErrorMessages errorMessages)
        {
            return (value.Date > DateTime.Now.Date) ? errorMessages[errorCode] : null;
        }



        /// <summary>
        /// Validation to check if a given integer is within the range specified and
        /// throws and exception if not
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minValue">The min value.</param>
        /// <param name="maxValue">The max value.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsWithinRange(decimal value, decimal minValue, decimal maxValue,
            string errorCode, ErrorMessages errorMessages)
        {
            return (value < minValue || value > maxValue) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// Validation to check if a given integer is within th range specified and
        /// throws and exception if not.  The range check is inclusive.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minValue">The min value.</param>
        /// <param name="maxValue">The max value.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsWithinRangeInclusive(
            int value,
            int minValue,
            int maxValue,
            string errorCode, ErrorMessages errorMessages)
        {
            return (!(value >= minValue) || !(value <= maxValue)) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// Validation to check if a given integer is within the range specified and
        /// throws and exception if not
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="minValue">The min value.</param>
        /// <param name="maxValue">The max value.</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsWithinRangeInclusive(decimal value, decimal minValue, decimal maxValue,
            string errorCode, ErrorMessages errorMessages)
        {
            return (value < minValue || value > maxValue) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// Validation to check the given assert is greater that Targeted Value
        /// </summary>
        /// <param name="value">The Value.</param>
        /// <param name="targetedValue">The Targeted Valud</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsGreater(double value, double targetedValue, string errorCode, ErrorMessages errorMessages)
        {
            return (value > targetedValue) ? errorMessages[errorCode] : null;
        }


        /// <summary>
        /// Validation used to determine if a given string is null
        /// and throws an exception if so.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">Friendly parameter or property name</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsOnlyNumeric(string value, string errorCode, ErrorMessages errorMessages)
        {
            return (!Utilities.IsNumeric(value)) ? errorMessages[errorCode] : null;
        }

        //Validation of Bank Name - If needed can be used in Future ...By Ashok
        /// <summary>
        /// Determines whether [is valid bank name].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errorCode">The error code.</param>
        /// <param name="errorMessages">The error messages.</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        //public static ErrorMessage AssertIsValidBankName(string value, string errorCode,
        //                                ErrorMessages errorMessages)
        //{
        //    return (Utilities.IsValidRegexPattern(value, @"[0-9a-zA-Z &,]{0,50}")) ? errorMessages[errorCode] : null;
        //}

        /// <summary>
        /// Determines whether [is valid account number].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errorCode">The error code.</param>
        /// <param name="errorMessages">The error messages.</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsValidAccountNumber(string value, string errorCode,
                                       ErrorMessages errorMessages)
        {
            return (!Utilities.IsValidRegexPattern(value, @"[A-Za-z0-9\\-]+")) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorMessages"></param>
        /// <returns></returns>
        public static ErrorMessage AssertIsAlphapetOrNumber(string value, string errorCode,
                                       ErrorMessages errorMessages)
        {
            return (!Utilities.IsValidRegexPattern(value, @"[A-Za-z0-9_@./#&+-]*$")) ? errorMessages[errorCode] : null;
        }

        /// <summary>
        /// Determines whether [is valid RTN].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errorCode">The error code.</param>
        /// <param name="errorMessages">The error messages.</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsValidRTN(string value, string errorCode,
                                       ErrorMessages errorMessages)
        {
            return (!Utilities.IsValidRegexPattern(value, @"(01|02|03|04|05|06|07|08|09|10|11|12|20|21|22|23|24|25|26|27|28|29|30|31|32)[0-9]{7}")) ? errorMessages[errorCode] : null;
        }


        /// <summary>
        /// Validation used to determine if a given string is null
        /// and throws an exception if so.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">Friendly parameter or property name</param>
        /// <param name="errorCode">The error code</param>
        /// <param name="errorMessages">The error message collection</param>
        /// <returns>
        /// Error message if not valid
        /// </returns>
        public static ErrorMessage AssertIsAccountNumber(string value, string errorCode, ErrorMessages errorMessages)
        {
            return (!Utilities.IsValidRegexPattern(value, @"[0-9]{4,17}")) ? errorMessages[errorCode] : null;

        }


        public static ErrorMessage IsValidCreditCardNumber(CardType cardType, string creditCardNumber,string errorCode,ErrorMessages errorMessages)
        {
            string validateRegex = string.Empty;
            switch (cardType)
            {
                case CardType.AmericanExpress:
                    validateRegex = Constants.REGEX_AMEX_CARD;
                    break;
                case CardType.Discover:
                    validateRegex = Constants.REGEX_DISCOVER_CARD;
                    break;
                case CardType.MasterCard:
                    validateRegex = Constants.REGEX_MASTER_CARD;
                    break;
                case CardType.Visa:
                    validateRegex = Constants.REGEX_VISA_CARD;
                    break;
            }
            if (validateRegex != string.Empty)
                return (!Utilities.IsValidRegexPattern(creditCardNumber, validateRegex)) ? errorMessages[errorCode] : null;
            else
                return null;
        }
        




    }
}
