using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StringManipulation
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okBtn_Click(object sender, EventArgs e)
        {
            // resultLbl.Text = "<p style=\"color: red;\">Hi</p>";

            string value = textTxt.Text;

            // access any specific character
            // resultLbl.Text = value[2].ToString();


            //startwith endwith or contains
            /*
            if (value.StartsWith("A")) resultLbl.Text = "Value starts with an: A";

            if (value.EndsWith(".")) resultLbl.Text += "<br />Value ends with a '.'";

            if (value.Contains("good")) resultLbl.Text += "<br />Value contains 'good'";
            */

            //Indexof postion of char
            int index = value.IndexOf("good");
            // resultLbl.Text = "'good' begins at index of " + index.ToString();

            //Knowing index lets me use insert or remove 
            // resultLbl.Text = value.Insert(index, "christmas "); 
            // resultLbl.Text = value.Remove(index, value.Length - index);

            //Substring - pullback char at index or length
            //resultLbl.Text = value.Substring(index, value.Length - index - 1); // the -1 removes the period

            //trim, trimstart trimend
            //resultLbl.Text = String.Format("length before: {0}<br />Length after: {1}", value.Length, value.Trim().Length);

            // padleft or padright
            // resultLbl.Text = value.PadLeft(10, '*');

            //toupper tolower
            /*
            if (textTxt.Text.Trim().ToUpper() == "BOB") resultLbl.Text = "the same";
            else resultLbl.Text = "Different";
            */

            //replace() - when cleaning data
            //string template = "[NAME] said it would be okay. Maybe your should speak with [NAME]";
            //resultLbl.Text = template.Replace("[NAME]", textTxt.Text);

            //Split 
            /*
            string result = "";
            string[] values = textTxt.Text.Split(',');
            for (int i=0; i<values.Length; i++)
            {
                result += values[i] + " : " + values[i].Length + "<br />";
            }
            resultLbl.Text = result;
            */

            //dot net has a better way - stringbuilder - more memory efficient with optimisations for large sets
            StringBuilder sb = new StringBuilder();
            string[] values = textTxt.Text.Split(',');
            for (int i = 0; i < values.Length; i++)
            {
                sb.Append(values[i]);
                sb.Append(" : ");
                sb.Append(values[i].Length);
                sb.Append("<br />");
            }
            resultLbl.Text = sb.ToString();
        }
    }
}