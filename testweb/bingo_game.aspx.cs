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
            if (checkH(numbers) || checkV(numbers) || checkD(numbers))
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
            int ans = 0;
            int[] b = { 1, 2, 3, 4, 5 };
            int[] i = { 6, 7, 8, 9, 10 };
            int[] n = { 11, 12, 13, 14, 15 };
            int[] g = { 16, 17, 18, 19, 20 };
            int[] o = { 21, 22, 23, 24, 25 };

            for (int row = 0; row < 5; row++)
            {
                foreach (int value in numbers)
                {

                    if (b[row] == value)
                    {
                        ans = ans + 1;
                    }
                    if (i[row] == value)
                    {
                        ans = ans + 1;
                    }
                    if (n[row] == value)
                    {
                        ans = ans + 1;
                    }
                    if (g[row] == value)
                    {
                        ans = ans + 1;
                    }
                    if (o[row] == value)
                    {
                        ans = ans + 1;
                    }

                }
                if (ans == 5)
                {
                    return true;
                }
                else
                {
                    ans = 0;
                }
            }

            return false;


        }
        private bool checkH(List<int> numbers)
        {
            int ans = 0;
            int[] b = { 1, 6, 11, 16, 21 };
            int[] i = { 2, 7, 12, 17, 22 };
            int[] n = { 3, 8, 13, 18, 23 };
            int[] g = { 4, 9, 14, 19, 24 };
            int[] o = { 5, 10, 15, 20, 25 };

            for (int row = 0; row < 5; row++)
            {
                foreach (int value in numbers)
                {

                    if (b[row] == value)
                    {
                        ans = ans + 1;
                    }
                    if (i[row] == value)
                    {
                        ans = ans + 1;
                    }
                    if (n[row] == value)
                    {
                        ans = ans + 1;
                    }
                    if (g[row] == value)
                    {
                        ans = ans + 1;
                    }
                    if (o[row] == value)
                    {
                        ans = ans + 1;
                    }

                }
                if (ans == 5)
                {
                    return true;
                }
                else
                {
                    ans = 0;
                }
            }

            return false;

        }
        private bool checkD(List<int> numbers)
        {
            int ans = 0;
            int[] b = { 1, 21 };
            int[] i = { 7, 17 };
            int[] n = { 13, 13 };
            int[] g = { 9, 19 };
            int[] o = { 5, 25 };

            for (int row = 0; row < 2; row++)
            {
                foreach (int value in numbers)
                {

                    if (b[row] == value)
                    {
                        ans = ans + 1;
                    }
                    if (i[row] == value)
                    {
                        ans = ans + 1;
                    }
                    if (n[row] == value)
                    {
                        ans = ans + 1;
                    }
                    if (g[row] == value)
                    {
                        ans = ans + 1;
                    }
                    if (o[row] == value)
                    {
                        ans = ans + 1;
                    }

                }
                if (ans == 5)
                {
                    return true;
                }
                else
                {
                    ans = 0;
                }
            }

            return false;


        }

    }

}