using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace TAX1040.Admin.Web.UI.Helpers
{
    public static class CheckBoxListExtension
    {
        public static HtmlString CheckBoxListExt(this HtmlHelper htmlHelper, IEnumerable<SelectListItem> listOfValues)
        {
            var sb = new StringBuilder();

            if (listOfValues != null)
            {
                sb.Append("<table>");

                foreach (var item in listOfValues)
                {
                    sb.Append("<tr>");

                    var label = htmlHelper.Label(item.Value, HttpUtility.HtmlEncode(item.Text));
                    var checkbox = htmlHelper.CheckBox(item.Text, new { id = item.Value }).ToHtmlString();

                    sb.AppendFormat("{0}{1}", "<td>" + checkbox + "</td>", "<td>" + label + "</td>");

                    sb.Append("</tr>");
                }
            }
            sb.Append("</table>");
            return new HtmlString(sb.ToString());
        }
    }
}