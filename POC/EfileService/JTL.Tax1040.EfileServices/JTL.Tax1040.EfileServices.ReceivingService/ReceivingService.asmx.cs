using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using JTL.Tax1040.BusinessObject;
using System.Configuration;
using JTL.Tax1040.EfileServices.BusinessObject;
using Newtonsoft.Json;
using JTL.Tax1040.EfileServices.Core.Process;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    /// <summary>
    /// Summary description for SchemaConversionAndValidation
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ReceivingService : System.Web.Services.WebService
    {
        JTL.Tax1040.BusinessObject.Tax1040 tax1040;

        [WebMethod]
        public string ReceiveService(string UserData)
        {

            #region State 1 - Receiving Return
            try
            {
                //Store the encrypted data into db.
                ReceivingServiceBL receivingServiceBL = new ReceivingServiceBL();
                TaxXMLtoIRSSchema taxXMLtoIRSSchema = new TaxXMLtoIRSSchema();
                tax1040 = JsonConvert.DeserializeObject<JTL.Tax1040.BusinessObject.Tax1040>(Security.Decrypt(UserData, ConfigurationManager.AppSettings[Constants.EncryptionKey]));

                EfileReturnData efileReturnData = new EfileReturnData();
                efileReturnData.EncryptedTaxData = UserData;
                //efileReturnData.Email = ;
                //efileReturnData.UserName = tax1040.
                efileReturnData.UserDataId = tax1040.UserDataId;
                receivingServiceBL.PersistEfileReturnData(efileReturnData);

                throw new Exception("Receiving Service Exception");
            }
            catch (Exception ex)
            {
                ExceptionHandling.LogException(tax1040.UserDataId, "Receiving Service Persist", ex);
            }
            #endregion

            #region State 2 - Schema Conversion

            //if (!string.IsNullOrEmpty(UserData))
            //{
            //    JTL.Tax1040.EfileServices.ReceivingService.TaxXMLtoIRSSchema taxXMLtoIRSSchema = new JTL.Tax1040.EfileServices.ReceivingService.TaxXMLtoIRSSchema();
            //    tax1040 = JsonConvert.DeserializeObject<JTL.Tax1040.BusinessObject.Tax1040>(UserData);
            //    taxXMLtoIRSSchema.StartService();
            //}


            //TaxXMLtoIRSSchema taxXMLtoIRSSchema = new TaxXMLtoIRSSchema();
            //taxXMLtoIRSSchema.StartService(Security.Decrypt(UserData, ConfigurationManager.AppSettings[Constants.EncryptionKey]));

            #endregion

            #region State 3 - Schema Validation
            SchemaValidation schemaValidation = new SchemaValidation();
            schemaValidation.StartValidation();
            #endregion

            #region State 4 - Schema Business Validation
            BussinessValidation businessValidation = new BussinessValidation();
            businessValidation.Validate();
            #endregion

            return "Success";
        }
    }
}
