using System;
using System.Linq;
using System.Windows;

namespace JTL1040CustomControlLibrary
{
    /// <summary>
    /// Loads the appropiate xmal from the given path.
    /// </summary>
    public sealed class PageManager : Window
    {
        /// <summary>
        /// Loads the xaml file.
        /// </summary>
        /// <param name="component">The usercontrol need to be loded</param>
        /// <param name="path">Xmal File path.</param>
        public  void LoadXaml(object component,string path)
        {
            Application.LoadComponent(component, new Uri(path, UriKind.Relative));
        }
        [Obsolete("Use this if need to pass only path and get the objec")]
        public object LoadXaml(string path)
        {
            return  Application.LoadComponent(new Uri(path, UriKind.Relative));
        }
    }
}
