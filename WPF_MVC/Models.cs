using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_MVC
{
    public static class Models
    {
        public static double one;
        public static double two;
        public static List<string> operationList = new List<string> { "+", "-", "*", "/" };

        public static TextBox tbOne;
        public static TextBox tbTwo;
        public static TextBlock tbOperation;
        public static GroupBox res;
        public static double ResultOne
        {
            get { return one; }
            set
            {
                one = value;
                tbOne.Text = one.ToString();
            }
        }
        public static double ResultTwo
        {
            get { return two; }
            set
            {
                two = value;
                tbTwo.Text = two.ToString();
            }
        }

        public static int Combo
        {
            set
            {
                tbOperation.Text = operationList[value];
            }
        }

        public static int Result 
        {
            set
            {
                switch (operationList)
                {
                    case 0:
                        break;
                }
            }
        }

    }
}
