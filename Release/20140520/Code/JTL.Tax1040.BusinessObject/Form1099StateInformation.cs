/*
    Copyright       :   Copyright Jeevan Technologies
    File Name       :   Form1099StateInformation.cs 
    Description     :   Business object for Form1099 state information.
    Author          :   Saravanan N. 
    Created Date    :   1st April, 2014
    Remarks         :   This BO already exists. Started this page by refactoring properties.

    Modification History:
    ---------------------
 * Saravanan N - 3rd April, 2014 - StateIdentificationNumber data type changed from long to string.
 * Sathish N - 16 April, 2014 Changed int to long for StateId
 * 25Apr2014 Bala Modified code to change double type to double?(Nulable) type.  
 */

namespace JTL.Tax1040.BusinessObject
{
    /// <summary>
    /// This class commonly being used in all Form1099_XXX form.
    /// </summary>
    public class Form1099StateInformation
    {
        public long StateId { get; set; }

        public string StateIdentificationNumber { get; set; }

        public double? StateTaxWithholdingAmount { get; set; }

    }

}

