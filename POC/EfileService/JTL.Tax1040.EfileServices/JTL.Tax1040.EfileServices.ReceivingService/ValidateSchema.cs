using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.IO;
using System.Configuration;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public class ValidateSchema
    {
        #region Declarations
        List<MessagesDE> lstMessagesDE = new List<MessagesDE>();
        MessagesDE messageDE = null;
        #endregion

        #region ValidateXML
        public List<MessagesDE> ValidateXML(string strXml, string strNamespace, string strXsdPath)
        {
            XmlReader reader = null;
            XmlSchemaSet xmlSet = new XmlSchemaSet();
            try
            {
                XmlParserContext context = new XmlParserContext(null, null, "", XmlSpace.None);
                if (!string.IsNullOrEmpty(strXsdPath) && !string.IsNullOrEmpty(strXml) && !string.IsNullOrEmpty(strNamespace))
                {
                    xmlSet.Add(strNamespace, strXsdPath);
                    StringReader str = new StringReader(strXml);
                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.ValidationType = ValidationType.Schema;
                    settings.ValidationEventHandler += new ValidationEventHandler(ReaderSettings_ValidationEventHandler);
                    settings.Schemas.Add(xmlSet);
                    reader = XmlReader.Create(str, settings, context);
                    while (reader.Read())
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
            return lstMessagesDE;
        }
        #endregion

        #region Validation
        private void ReaderSettings_ValidationEventHandler(object sender, ValidationEventArgs args)
        {
            messageDE = new MessagesDE();
            messageDE.ErrorMessage = args.Message;
            lstMessagesDE.Add(messageDE);
        }
        #endregion
    }
}