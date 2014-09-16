using JTL.Tax1040.EfileServices.ZipandSendService.SenderChannel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace JTL.Tax1040.EfileServices.ZipandSendService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //TOOD: For Testing purpose commented the below code - Saravanan N - 8th July, 2014.
            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[] 
            //{ 
            //   // new IRSSubmissionZip() 
            //    new IRSSender() 
            //};
            //ServiceBase.Run(ServicesToRun);

            //To check ZIP SERVICE uncomment the below two lines.
            IRSSubmissionZip iRSSubmissionZip = new IRSSubmissionZip();
            iRSSubmissionZip.GetEfileReturnDataId();

            //To check SEND SERVICE uncomment the below two lines.
            IRSSender irsSender = new IRSSender();
            irsSender.StartService();
        }
    }
}
