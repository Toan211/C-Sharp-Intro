using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "+";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "*";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "/";
        }

        static private bool IsDelimeter(char c)
        {
            if ((" =".IndexOf(c) != -1))
                return true;
            return false;
        }

        static private bool IsOperator(char с)
        {
            if (("+-/*^()PC!%".IndexOf(с) != -1))
                return true;
            return false;
        }
        static private bool IsFunction(String s)
        {
            String[] func = { "sin", "cos", "tg", "asin", "acos", "atg", "sqrt", "ln", "lg" };
            if (Array.Exists(func, e => e == s))
                return true;
            return false;
        }
        static private String doFunc(String fun, double param)
        {
            switch (fun)
            {
                case "cos": return Math.Cos(param).ToString();
                case "sin": return Math.Sin(param).ToString();
                case "tg": if (Math.Abs(param % (2 * Math.PI)) == (Math.PI / 2)) throw new TgException(param); else return Math.Tan(param).ToString();
                case "asin": if (param < -1 || param > 1) throw new ArcSinCosException(param); else return Math.Asin(param).ToString();
                case "acos": if (param < -1 || param > 1) throw new ArcSinCosException(param); else return Math.Acos(param).ToString();
                case "atg": return Math.Atan(param).ToString();
                case "sqrt": if (param < 0) throw new SqrtException(param); else return Math.Sqrt(param).ToString();
                case "ln": if (param <= 0) throw new LogException(param); else return Math.Log(param).ToString();
                case "lg": if (param <= 0) throw new LogException(param); else return Math.Log10(param).ToString();
                default: return "";
            }
        }
        static private byte GetPriority(char s)
        {
            switch (s)
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
        private static int factorial(int x)
        {
            int i = 1;
            for (int s = 1; s <= x; s++)
                i = i * s;
            if (x < 0) throw new NegativeFactorialException(x);
            return i;
        }

        static private double Counting(string input)
        {
            double result = 0;
            double b = 0;
            Stack<double> temp = new Stack<double>();
            try { return double.Parse(input); }
            catch (Exception)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    //if input is Digit (decimal number)
                    if (Char.IsDigit(input[i]))
                    {
                        string a = string.Empty;
                        // if input is not delimeter $$ not operator, then put input into string a
                        while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                        {
                            a += input[i]; //input [i] is string
                            i++;

                            if (i == input.Length) break;
                        }
                        //push number a into stack
                        temp.Push(double.Parse(a));
                        i--; //(in the while, we i++, now we i--
                    }
                    else if (IsOperator(input[i]))
                    {
                        double a = temp.Pop(); // pop the number in the stack out, then calculate (a b)

                        switch (input[i])
                        {
                            case '!': result = factorial((int)a); break;
                            case 'P': result = factorial((int)b) / factorial((int)(b - a)); break;
                            case 'C': result = factorial((int)b) / (factorial((int)a) * factorial((int)(b - a))); break;
                            case '^': result = Math.Pow(b, a); break;
                            case '%': result = b % a; break;
                            case '+': result = b + a; break;
                            case '-': result = b - a; break;
                            case '*': result = b * a; break;
                            case '/': if (a == 0) throw new DividedByZeroException(); else result = b / a; break;
                        }
                        temp.Push(result); //push the result of caculate into the stack again
                    }

                }

                try { return temp.Peek(); }//return object of the top of the stack 
                catch (Exception) { throw new SyntaxException(); }
                
            }
        }

        static private string GetExpression(string input)
        {
            string output = string.Empty;
            string fun = string.Empty;

            //create a stack LIFO 
            Stack<char> openStack = new Stack<char>();

            char k = ' '; string p = "";
            //loop through the input
            for (int i = 0; i< input.Length;i++)
            { 
                //if input is operator or digit (decimal number)
                if (IsOperator(input[i]) || Char.IsDigit(input[i]))
                {
                    if (k == ' ')
                        k = input[i];
                    else
                        if (input[i] == '-' && !Char.IsDigit(k))
                        p += " 0 ";
                    k = input[i];
                }
                p += input[i]; 
            }
            input = p; // done the for loop, give p back to string input

            for (int i = 0; i < input.Length; i++)
            {
                if (IsDelimeter(input[i]))
                    continue;
                if (Char.IsDigit(input[i]))
                {
                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        output += input[i];
                        i++;
                        if (i == input.Length) break;
                    }
                    output += " ";
                    i--;
                }
                else
                    if (IsOperator(input[i]))
                {

                    if (input[i] == '(')
                        openStack.Push(input[i]);
                    else if (input[i] == ')')
                    {
                        char s = openStack.Pop();
                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = openStack.Pop();
                        }
                    }
                    else
                    {
                        if (openStack.Count > 0)
                            if (GetPriority(input[i]) <= GetPriority(openStack.Peek()))
                                output += openStack.Pop().ToString() + " ";

                        openStack.Push(char.Parse(input[i].ToString()));

                    }
                }
                else if (input[i] == '\u03C0')
                    output += " \u03C0 ";
                else if (input[i] == 'e')
                    output += " e ";
                else
                {
                    fun = String.Empty;
                    while (input[i] != '(')
                    {
                        fun += input[i];
                        i++;
                        if (i == input.Length) break;
                    }
                    i++;
                    if (IsFunction(fun))
                    {
                        String param = String.Empty;
                        while (input[i] != ')')
                        {
                            param += input[i];
                            i++;
                            if (i == input.Length) break;
                        }
                        double d;
                        try { d = double.Parse(param); }
                        catch (Exception) { d = Counting(GetExpression(param)); }
                        output += doFunc(fun, d);
                    }
                }
            }
            while (openStack.Count > 0)
                output += openStack.Pop() + " ";

            return output;
        }
        static public double Calculate(string input)
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

        private void button17_Click(object sender, EventArgs e)
        {

            try { richTextBox2.Text = Calculate(richTextBox1.Text).ToString(); }
            catch (MyException ex) { richTextBox2.Text = ex.type; }


        }
        public static string ans = String.Empty;
        private void Del__Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ans = String.Empty;
        }

        private void ADel__Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
                richTextBox1.Text = (richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1));
        }
    }
}
public class MyException : Exception
{
    public string type;
}
public class DividedByZeroException : MyException
{
    public DividedByZeroException()
    {
        this.type = "Math error";
        MessageBox.Show("Division by zero is impossible", type, MessageBoxButtons.OK);
    }
}
public class SyntaxException : MyException
{
    public SyntaxException()
    {
        this.type = "Syntax error";
        MessageBox.Show("You made a mistake", type, MessageBoxButtons.OK);
    }
}
public class NegativeFactorialException : MyException
{
    public NegativeFactorialException(int x)
    {
        this.type = "Math error";
        MessageBox.Show("Factorial(" + x + ") does not exsists", type, MessageBoxButtons.OK);
    }
}
public class ArcSinCosException : MyException
{
    public ArcSinCosException(double x)
    {
        this.type = "Math error";
        MessageBox.Show("Acos(or Asin) (" + x + ") does not exsists", type, MessageBoxButtons.OK);
    }
}
public class LogException : MyException
{
    public LogException(double x)
    {
        this.type = "Math error";
        MessageBox.Show("Log(" + x + ") does not exsists", type, MessageBoxButtons.OK);
    }
}
public class SqrtException : MyException
{
    public SqrtException(double x)
    {
        this.type = "Math error";
        MessageBox.Show("Sqrt(" + x + ") does not exsists", type, MessageBoxButtons.OK);
    }
}
public class TgException : MyException
{
    public TgException(double x)
    {
        this.type = "Math error";
        MessageBox.Show("Tg(" + x + ") does not exsists", type, MessageBoxButtons.OK);
    }
}