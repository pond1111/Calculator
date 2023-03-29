namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false; 

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            double num1 = Double.Parse(fstNum.Replace(",", ""));
            double num2 = Double.Parse(secNum.Replace(",", ""));
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    break;
            }
            label2.Text = result.ToString("#,##0");
            enterValue = false;
            fstNum = result.ToString("#,##0");
        }

        private void buttonPlu_Click(object sender, EventArgs e)
        {
            operation = "+";
            label1.Text = fstNum + " " + operation + " ";
            enterValue = true;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            operation = "-";
            label1.Text = fstNum + " " + operation + " ";
            enterValue = true;
        }

        private void buttonMli_Click(object sender, EventArgs e)
        {
            operation = "*";
            label1.Text = fstNum + " " + operation + " ";
            enterValue = true;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            label1.Text = fstNum + " " + operation + " ";
            enterValue = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            result = 0;
            operation = string.Empty;
            fstNum = string.Empty;
            secNum = string.Empty;
            enterValue = false;
            label1.Text = "";
            label2.Text = "";
        }

        private void btnNum(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (enterValue)
            {
                secNum += button.Text;
                label1.Text = fstNum + " " + operation + " " + secNum;
            }
            else
            {
                fstNum += button.Text;
                label1.Text = fstNum + " " + operation;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}