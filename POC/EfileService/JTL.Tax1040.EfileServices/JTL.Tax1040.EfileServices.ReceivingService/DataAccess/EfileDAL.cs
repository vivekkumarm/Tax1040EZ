using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;

namespace JTL.Tax1040.EfileServices.ReceivingService
{
    public abstract class EfileDAL
    {
        protected Database taxDB;
        protected DbCommand cmd;

        protected EfileDAL()
        {

        }

        protected void InitializeTaxExcise_Efile(string storedProcedureName)
        {
            taxDB = DatabaseFactory.CreateDatabase(Const.Tax1040_Efile);
            if (!string.IsNullOrEmpty(storedProcedureName))
            {
                cmd = taxDB.GetStoredProcCommand(storedProcedureName);
            }
        }

        protected void InitializeTaxExcise_Static(string storedProcedureName)
        {
            taxDB = DatabaseFactory.CreateDatabase(Const.Tax1040_Static);
            if (!string.IsNullOrEmpty(storedProcedureName))
            {
                cmd = taxDB.GetStoredProcCommand(storedProcedureName);
            }
        }
    }

    internal struct Const
    {
        public const string Tax1040_Efile = "Tax1040_Efile";
        public const string Tax1040_Static = "Tax1040_Static";
    }
}