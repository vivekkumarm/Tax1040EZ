using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace JTL1040CustomControlLibrary
{ 
    public class JTLTextbox : TextBox
    {
        public readonly static DependencyProperty CaptionProperty = DependencyProperty.Register("Caption", typeof(string), typeof(JTLTextbox), new PropertyMetadata(""));
        public readonly static DependencyProperty FormatProperty = DependencyProperty.Register("Format", typeof(string), typeof(JTLTextbox), new PropertyMetadata(""));

        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }
        public string Format
        {
            get { return (string)GetValue(FormatProperty); }
            set { SetValue(FormatProperty, value); }
        }
        public string Html
        {
            get;
            set;
        }

        /// <summary>
        /// Build the html control using dependencyProperty.
        /// </summary>
        /// <param name="drawingContext">The drawing instructions for a specific element. This context is provided to the layout system.</param>
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            Html = string.Format("<input type=\"text\" caption=\"{0}\" name=\"{1}\" id=\"{2}\" format=\"{3}\" />", this.Caption, this.Name, this.Name, this.Format);
        }
    }



    public class JTLCheckBox : CheckBox
    {
        public readonly static DependencyProperty CaptionProperty = DependencyProperty.Register("Caption", typeof(string), typeof(JTLCheckBox), new PropertyMetadata(""));

        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }
        public string Html
        {
            get;
            set;
        }
        /// <summary>
        /// Build the html control using dependencyProperty.
        /// </summary>
        /// <param name="drawingContext">The drawing instructions for a specific element. This context is provided to the layout system.</param>
        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            Html = string.Format("<input type=\"checkbox\" caption=\"{0}\" name=\"{1}\" id=\"{2}\" />", this.Caption, this.Name, this.Name);
        }

    }
    public class JTLDropDownList : ComboBox
    {

        public readonly static DependencyProperty ModelProperty = DependencyProperty.Register("Caption", typeof(Dictionary<string,int>), typeof(JTLDropDownList), new UIPropertyMetadata(new Dictionary<string,int>()));

        public Dictionary<string,int> Model
        {
            get { return (Dictionary<string, int>)GetValue(ModelProperty); }
            set { SetValue(ModelProperty, value); }
        }

        public string Html
        {
            get;
            set;
        }

        /// <summary>
        /// Build the html control using dependencyProperty.
        /// </summary>
        /// <param name="drawingContext">The drawing instructions for a specific element. This context is provided to the layout system.</param>
        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            StringBuilder sb = new StringBuilder();
            if (sb.Length == 0)
            {
                sb.Append("<select>");
                foreach (var options in this.Model)
                { 
                    sb.Append(string.Format("<option value=\"{0}\">{1}</option>", options.Value, options.Key));
                }
                sb.Append("</select>");
            }
            Html = sb.ToString();
        }

    }
    public class JTLGrid : Grid
    {
        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);
        }
    }

    /// <summary>
    /// TODO:Need to investigate on this.
    /// </summary>
    public class JTLObjectCollection : Dictionary<string, int> { }
}
