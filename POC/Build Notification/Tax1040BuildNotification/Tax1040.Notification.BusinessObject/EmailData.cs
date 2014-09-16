using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.BusinessObject
{
    public class EmailData
    {
        public string FromEmailID { get; set; }
        public string ToEmailID { get; set; }
        public string Subject { get; set; }
        public string TemplateName { get; set; }
        public string TemplateContent { get; set; }
    }
}
