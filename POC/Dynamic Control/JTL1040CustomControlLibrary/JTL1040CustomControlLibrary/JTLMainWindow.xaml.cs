using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace JTL1040CustomControlLibrary
{
    /// <summary>
    /// Interaction logic for JTLMainWindow.xaml
    /// </summary>
    public partial class JTLMainWindow : UserControl
    {
        private PageManager mPageMng = new PageManager();

        public JTLMainWindow()
        {
            InitializeComponent();
            mPageMng.LoadXaml(this, "/JeevanWpfCustomControl;component/1.xaml");
        }
        /// <summary>
        /// Find the control and generate relevant html.
        /// </summary>
        /// <param name="drawingContext">The drawing instructions for a specific element. This context is provided to the layout system.</param>
        protected override void OnRender(DrawingContext drawingContext)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html><body><h5>JTL HTML Controls</h5>");
            var grd = ((JTLGrid)
                (this.FindName("JTlGrd")));

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(grd); i++)
            {
                var child = VisualTreeHelper.GetChild(grd, i);
                var htmlValue = GetControl(child);
                if (!string.IsNullOrEmpty(htmlValue))
                    if (sb.Length > 0)
                    {
                        sb.Append("<br />" + htmlValue);
                    }
                    else
                    {
                        sb.Append(htmlValue);
                    }

            }
            sb.Append("</body></html>");
            var textHtml = sb.ToString();

            base.OnRender(drawingContext);


        }

        private string GetControl(DependencyObject control)
        {
            var jtlControl = string.Empty;
            switch (control.GetType().Name)
            {
                case "JTLTextbox":
                    var jtlTextbox = control as JTLTextbox;
                    jtlControl = jtlTextbox.Html;
                    break;
                case "JTLCheckBox":
                    var jtlCheckbox = control as JTLCheckBox;
                    jtlControl = jtlCheckbox.Html;
                    break;
                case "JTLDropDownList":
                    var jtlDropdownlist = control as JTLDropDownList;
                    jtlControl = jtlDropdownlist.Html;
                    break;
            }
            return jtlControl;
        }
    }
}
