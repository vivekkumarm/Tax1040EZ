/*
Copyright   : Copyright Jeevan Technologies
File Name   : ErrorMessage.cs 
Description : Business object for ErrorMessage 
Author      : Bala
Created Date : 31 Mar 2014

 * Modification History:
---------------------
 * 30Apr2014 Bala Added constructor to make deep copy of the Errormessage object.
 * 02May2014 Bala Added method to get common error message.
 */

using System.Collections.Generic;
using System.Linq;

namespace JTL.Tax1040.Core.Object
{
    public class ErrorMessage
    {
        public string ErrorCode { get; set; }
        public string FieldName { get; set; }
        public string FieldDescription { get; set; }
        public string Tab { get; set; }
        public string Topic { get; set; }
        public string ErrorType { get; set; }
        public string MessageType { get; set; }
        public string ErrorText { get; set; }
        public string LongErrorText { get; set; }
        public string MessageTarget { get; set; }
        public string ErrorTitle { get; set; }
        //15th Apr 2014 -Vincent- added a new property for error message navigation.
        //15th Apr 2014 -Vincent- Change the FormId property type for error message navigation.
        public long FormId { get; set; }

        public ErrorMessage()
        {
        }
        public ErrorMessage(ErrorMessage errorMessage)
        {
            ErrorCode  = errorMessage.ErrorCode;
            FieldName  = errorMessage.FieldName;
            FieldDescription  = errorMessage.FieldDescription;
            Tab  = errorMessage.Tab;
            Topic  = errorMessage.Topic;
            ErrorType  = errorMessage.ErrorType;
            MessageType  = errorMessage.MessageType;
            ErrorText  = errorMessage.ErrorText;
            LongErrorText  = errorMessage.LongErrorText;
            MessageTarget  = errorMessage.MessageTarget;
            ErrorTitle  = errorMessage.ErrorTitle;
        }
    }

    public sealed class ErrorMessages
    {
        private readonly Dictionary<string, ErrorMessage> errorMessageCollection;

        public ErrorMessages(Dictionary<string, ErrorMessage> errorMessages)
        {
            errorMessageCollection = errorMessages;
        }

        public ErrorMessages()
        {
            errorMessageCollection = new Dictionary<string, ErrorMessage>();
        }

        public ErrorMessage this[string key]
        {
            get
            {
                ErrorMessage errorMessage;

                if (errorMessageCollection.ContainsKey(key))
                {
                    errorMessage = new ErrorMessage(errorMessageCollection[key]);
                }
                else
                {
                    errorMessage = GetCommonErrorMessage(key);
                }

                return errorMessage;
            }
        }

        public List<string> GetKeys()
        {
            return errorMessageCollection.Keys.ToList();
        }

        public int GetCount()
        {
            return errorMessageCollection.Count;
        }

        public bool HasValues()
        {
            return errorMessageCollection.Any();
        }

        private ErrorMessage GetCommonErrorMessage(string errorCode)
        {
            var topic = errorCode.Split('_')[0];
            var errorMessage = new ErrorMessage()
            {
                ErrorCode = errorCode,
                Topic = topic,
                ErrorType = "Error",
                MessageType = "CR",
                ErrorText = "You have faced common issue. Please contact with TaxGarden Administrator."

            };
            return errorMessage;
        }
    }
}
