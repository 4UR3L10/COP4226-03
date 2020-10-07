using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// ORGANIZEEEEEEEEEEEEEEEEEEEEEEE BU CALC AND OTHER 
// CHANGE NAMES OF 
namespace NeatOffice
{
    class RPN
    {
        /*
            Get expression and validates for an error. 
        */
        static public double Calculate(string input)
        {
            if (input == "")
            {
                return 0.00;
            }
            else
            {
                try
                {
                    return double.Parse(GetExpression(input));
                }
                catch (Exception)
                {
                    return Counting(GetExpression(input));
                }
            }
        }

        /*
            Formats the expression using stack and classifies digits, operators and functions.
        */
        static private string GetExpression(string input)
        {
            // Initialization.
            string output = string.Empty;
            string function = string.Empty;
            Stack<char> operationStack = new Stack<char>();
            char spaceChar = ' ';
            string temporalString = "";

            // Iterate until the last of the expression.
            for (int i = 0; i < input.Length; i++)
            {
                // Classify between operator and digit.
                if (IsOperator(input[i]) || Char.IsDigit(input[i]))
                {
                    if (spaceChar == ' ')
                    {
                        spaceChar = input[i];
                    }
                    else
                    {
                        if (input[i] == '-' && !Char.IsDigit(spaceChar))
                        {
                            temporalString += " 0 ";
                        }
                    }

                    spaceChar = input[i];
                }

                // Build formated expression.
                temporalString += input[i];
            }

            // Set the expression.
            input = temporalString;

            // Organize the expression to get priorities using stack data structure.            
            for (int i = 0; i < input.Length; i++)
            {
                if (IsDelimeter(input[i]))
                {
                    continue;
                }

                if (Char.IsDigit(input[i]))
                {
                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        output += input[i];
                        i++;

                        if (i == input.Length)
                        {
                            break;
                        }
                    }

                    output += " ";
                    i--;
                }
                else
                {
                    if (IsOperator(input[i]))
                    {
                        if (input[i] == '(')
                        {
                            operationStack.Push(input[i]);
                        }
                        else if (input[i] == ')')
                        {
                            char temporalChar = operationStack.Pop();

                            while (temporalChar != '(')
                            {
                                output += temporalChar.ToString() + ' ';
                                temporalChar = operationStack.Pop();
                            }
                        }
                        else
                        {
                            if (operationStack.Count > 0)
                            {
                                if (GetPriority(input[i]) <= GetPriority(operationStack.Peek()))
                                {
                                    output += operationStack.Pop().ToString() + " ";
                                }
                            }
                            operationStack.Push(char.Parse(input[i].ToString()));
                        }
                    }
                    else
                    {
                        function = String.Empty;

                        while (input[i] != '(')
                        {
                            function += input[i];
                            i++;

                            if (i == input.Length)
                            {
                                break;
                            }
                        }

                        i++;

                        if (IsFunction(function))
                        {
                            String parameter = String.Empty;

                            while (input[i] != ')')
                            {
                                parameter += input[i];
                                i++;
                                if (i == input.Length)
                                {
                                    break;
                                }
                            }

                            double temporalDouble;

                            try
                            {
                                temporalDouble = double.Parse(parameter);
                            }
                            catch (Exception)
                            {
                                temporalDouble = Counting(GetExpression(parameter));
                            }

                            output += doFunc(function, temporalDouble);
                        }
                    }
                }
            }
            while (operationStack.Count > 0)
            {
                output += operationStack.Pop() + " ";
            }

            return output;
        }

        /*
            Check if the chars of the expression is an operator.
        */
        static private bool IsOperator(char charParmeter)
        {
            if (("+-/*^()".IndexOf(charParmeter) != -1))
            {
                return true;
            }

            return false;
        }

        /*
            Check if the chars of the expression is delimeter.
        */
        static private bool IsDelimeter(char charParmeter)
        {
            if ((" =".IndexOf(charParmeter) != -1))
            {
                return true;
            }
            return false;
        }

        /*
            Classifies the priority.
        */
        static private byte GetPriority(char charParmeter)
        {
            switch (charParmeter)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '!': return 4;
                case '%': return 4;
                case '*': return 4;
                case '/': return 4;
                case '^': return 5;
                default: return 4;
            }
        }

        /*
            Check if the chars of the expression is a function.
        */
        static private bool IsFunction(String s)
        {
            String[] func = { "sin", "cos", "tan", "sqrt", "log", "%" };

            if (Array.Exists(func, e => e == s))
            {
                return true;
            }

            return false;
        }

        /*
            Calculates operations using a temporal stack.
        */
        static private double Counting(string input)
        {
            // Initializing.
            double result = 0;
            double temporalDouble = 0;
            Stack<double> temporalStack = new Stack<double>();

            try
            {
                return double.Parse(input);
            }
            catch (Exception)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (Char.IsDigit(input[i]))
                    {
                        string temporalString = string.Empty;

                        while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                        {
                            temporalString += input[i];
                            i++;

                            if (i == input.Length)
                            {
                                break;
                            }
                        }
                        temporalStack.Push(double.Parse(temporalString));
                        i--;
                    }
                    else if (IsOperator(input[i]))
                    {
                        double tempDouble = temporalStack.Pop();

                        try
                        {
                            temporalDouble = temporalStack.Pop();
                        }
                        catch (Exception)
                        {
                            temporalDouble = 0;
                        }

                        switch (input[i])
                        {
                            case '^': result = Math.Pow(temporalDouble, tempDouble); break;
                            //case '%': result = temporalDouble / tempDouble; break; // CHECKKKKKKKKKKKKKKKKKKKK
                            case '+': result = temporalDouble + tempDouble; break;
                            case '-': result = temporalDouble - tempDouble; break;
                            case '*': result = temporalDouble * tempDouble; break;
                            case '/': if (tempDouble == 0) throw new DividedByZeroException(); else result = temporalDouble / tempDouble; break;
                        }

                        temporalStack.Push(result);
                    }
                }
                try
                {
                    return temporalStack.Peek();
                }
                catch (Exception)
                {
                    throw new SyntaxException();
                }
            }
        }

        /*
            Calculates functions.
        */
        static private String doFunc(String fun, double param)
        {
            switch (fun)
            {
                case "%": return (param / 100).ToString();
                case "cos": return Math.Cos(param).ToString();
                case "sin": return Math.Sin(param).ToString();
                case "tan": if (Math.Abs(param % (2 * Math.PI)) == (Math.PI / 2)) throw new TgException(param); else return Math.Tan(param).ToString();
                case "sqrt": if (param < 0) throw new SqrtException(param); else return Math.Sqrt(param).ToString();
                case "log": if (param <= 0) throw new LogException(param); else return Math.Log10(param).ToString();
                default: return "";
            }
        }
    }

    /**********************************/
    /* Exceptions                     */
    /**********************************/
    public class MyException : Exception
    {
        public string type;
    }

    // Tangent Exception.
    public class TgException : MyException
    {
        public TgException(double x)
        {
            this.type = "Math error";
            MessageBox.Show("Tan(" + x + ") does not exists", type, MessageBoxButtons.OK);
        }
    }

    // Zero Division.
    public class DividedByZeroException : MyException
    {
        public DividedByZeroException()
        {
            this.type = "Math error";
            MessageBox.Show("Division by zero is impossible", type, MessageBoxButtons.OK);

        }
    }

    // Square Root Exception.
    public class SqrtException : MyException
    {
        public SqrtException(double x)
        {
            this.type = "Math error";
            MessageBox.Show("Sqrt(" + x + ") does not exsists", type, MessageBoxButtons.OK);
        }
    }

    // Logarithm Exception.
    public class LogException : MyException
    {
        public LogException(double x)
        {
            this.type = "Math error";
            MessageBox.Show("Log(" + x + ") does not exists", type, MessageBoxButtons.OK);
        }
    }

    // Syntax Exception.
    public class SyntaxException : MyException
    {
        public SyntaxException()
        {
            this.type = "Syntax error";
            MessageBox.Show("You made a mistake", type, MessageBoxButtons.OK);
        }
    }
}