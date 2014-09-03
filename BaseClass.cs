using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HelperClass.Base; // Namespace to make use of BasePage class

namespace HelperClass.Base
{
    public class BaseClass
    {
        public void HelperFunction()
        {
            BasePage.Instance.NavigateToPage("MainPage.xaml"); // Pass the name of the page as String to navigate to that page

            string result = BasePage.Instance.ReadFile("TextFileName.txt"); // Pass the name of the text file to read data

            // Validation of Number - text box.
            // You can enter only numbers from 1 - 9 and back key in this validation.
            // Cannot insert special characters like . even when Input Scope in Number.
            TextBox.KeyDown += new KeyEventHandler(BasePage.Instance.NumberValidation);

            // Validation of Text - text box.
            // You can enter only alphabets from a - z, space & back key in this validation.
            // Cannot insert special characters like ., $ anything apart from that.
            TextBox.KeyDown += new KeyEventHandler(BasePage.Instance.TextValidation);

            BasePage.Instance.NotifyPropertyChanged("PropertyName"); // Just pass the name of the Property to notify change in property.

            // You can save the string value and retrieve back anywhere in your project in single session
            BasePage.Instance.SaveStringValue("name", "BalasubramaniM"); // String "BalasubramaniM" is saved in key value called "name"

            string name = BasePage.Instance.GetStringValue("name"); // retrieve the value by passing its key value

            BasePage.Instance.MessageBoxPrint("Text to be printed in Message Box"); // Just pass the string to get printed in MessageBox

            BasePage.Instance.DebugPrint("Text to be printed in Console(debug) window"); // Pass the string to get displayed in the console(debug or output) window.
        }
    }
}
