using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testweb
{
    public partial class bingo_game : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var numbers = TextBox1.Text.Split(',').Select(Int32.Parse).ToList();
           if (checkH(numbers) || checkV(numbers))
            {
                Label1.Text = "Bingo";
            }
            else
            {
                Label1.Text = "Not Bingo";
            }
        }

        private bool checkV(List<int> numbers)
        {
            string ans = "";
            int[] b = { 1, 2, 3, 4, 5 };
            int[] i = { 6, 7, 8, 9, 10 };
            int[] n = { 11, 12, 13, 14, 15 };
            int[] g = { 16, 17, 18, 19, 20 };
            int[] o = { 21, 22, 23, 24, 25 };

            foreach (int value in numbers)
            {

                if (Array.IndexOf(b, value) != -1)
                {
                    ans = ans + "B";
                }
                if (Array.IndexOf(i, value) != -1)
                {
                    ans = ans + "I";
                }
                if (Array.IndexOf(n, value) != -1)
                {
                    ans = ans + "N";
                }
                if (Array.IndexOf(g, value) != -1)
                {
                    ans = ans + "G";
                }
                if (Array.IndexOf(o, value) != -1)
                {
                    ans = ans + "O";
                }

            }

            if (ans == "BINGO")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private bool checkH(List<int> numbers)
        {
            string ans = "";
            int[] b = { 1, 6, 11, 16, 21 };
            int[] i = { 2, 7, 12, 17, 22 };
            int[] n = { 3, 8, 13, 18, 23 };
            int[] g = { 4, 9, 14, 19, 24 };
            int[] o = { 5, 10, 15, 20, 25 };

            foreach (int value in numbers)
            {
                
                if (Array.IndexOf(b, value) != -1)
                {
                    ans = ans + "B";  
                }
                if (Array.IndexOf(i, value) != -1)
                {
                    ans = ans + "I";
                }
                if (Array.IndexOf(n, value) != -1)
                {
                    ans = ans + "N";
                }
                if (Array.IndexOf(g, value) != -1)
                {
                    ans = ans + "G";
                }
                if (Array.IndexOf(o, value) != -1)
                {
                    ans = ans + "O";
                }

            }

            if (ans == "BINGO")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}