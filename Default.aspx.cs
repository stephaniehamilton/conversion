using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace conversions
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {

            //take off the comments on these lines to test out conversion and truncation from double to int.
            // double k = 3.5;
            //this will convert the double to an int and truncate it in the process.
            //int i = (int)k;
            //use helper method to convert to string. This will remove anything after the decimal.
            //resultLabel.Text = i.ToString();

            string i = inputTextBox.Text;
            //parse helper method comes from inside of the int class and takes in a string as an input in between the method parentheses
            //the int.Parse() method will only work when the string looks exactly like a number. So you have to enter 5 and not five.
            int j = int.Parse(i);
            int k = j + 1;
            resultLabel.Text = k.ToString();
        }
    }
}