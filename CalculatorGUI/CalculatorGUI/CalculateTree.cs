using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGUI
{
    public class CalculateTree
    {
        string op;
        CalculateTree RightSide;
        CalculateTree LeftSide;
 
        string answer;
        public string Answer
        {
            get
            {
                return answer;
            }
            set
            {
                answer = value;
            }
        }

        public CalculateTree(string value)
        {
            op = "";
            CalculateTreeCheck(value);
        }

     
        public void CalculateTreeCheck(string value)
        {
            TreeSplit(value);
        }

        public void TreeSplit(string value)
        {
            if (value.Contains ('-'))
            {
                ResultTree('-', value);
            }
            else if (value.Contains ('+'))
            {
                ResultTree('+', value);
            }
           else if (value.Contains('*'))
            {
                ResultTree('*', value);
            }
           else if (value.Contains('/'))
            {
                ResultTree('/', value);
            }
            else
            {
                answer = value;
            }
        }

        public void ResultTree(char op, string value)
        {
            int index = value.IndexOf(op, 0);

            CalculateTree LeftSide = new CalculateTree(value.Substring(0, index));
            CalculateTree  RightSide = new CalculateTree(value.Substring(index+1));

            double leftVal = Convert.ToDouble(LeftSide.answer);
            double rightVal = Convert.ToDouble(RightSide.answer);
            
            switch (op)
            {
                case ('-'):
                    answer = (leftVal - rightVal).ToString();
                    break;
                case ('+'):
                    answer = (leftVal + rightVal).ToString();
                    break;
                case ('*'):
                    answer = (leftVal * rightVal).ToString();
                    break;
                case ('/'):
                    answer = (leftVal / rightVal).ToString();
                    break;
                    
                default:
                    break;
            }


        }


        
        
    }

}
