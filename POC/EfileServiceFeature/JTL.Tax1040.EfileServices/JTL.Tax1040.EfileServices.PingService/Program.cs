using System.ServiceProcess;

namespace JTL.Tax1040.EfileServices.PingService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new GetAck() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
