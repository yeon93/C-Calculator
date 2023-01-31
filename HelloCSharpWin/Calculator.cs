using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public partial class Calculator : Form
    {
        public double Result = 0;
        public string TempNum = "";     //연산 버튼을 누를 때까지 입력받은 숫자와 소수점 저장 => double.Parse() 통해 숫자로 변환
        public string InputNum = "";
        public string calProcessing = "";

        public Calculator()
        {
            InitializeComponent();
        }

        //더하기
        public double Add(double number1, double number2)
        {
            double result = number1 + number2;
            return result;
        }
        //빼기
        public double Subtract(double number1, double number2)
        {
            double result = number1 - number2;
            return result;
        }
        //곱하기
        public double Multiplicate(double number1, double number2)
        {
            double result = number1 * number2;
            return result;
        }
        //나누기
        public double Divide(double number1, double number2)
        {
            double result = number1 / number2;
            return result;
        }


        //숫자버튼
        public void SetNum(string num)
        {
            if (InputNum == "")
            {
                ResultScreen.Text = num;
            }
            else if (ResultScreen.Text == "0")
            { ResultScreen.Text = num; }
            else
            { ResultScreen.Text = ResultScreen.Text + num; }
            InputNum = InputNum + num;
        }


        private void NumButton1_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
            InputNum = InputNum + numButton.Text;
            calProcessing = calProcessing + numButton.Text;
        }

        //사칙연산 버튼
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (InputNum == "") { }  //숫자 입력 없는데 사칙연산 버튼 누르면 pass
            else
            {
                calProcessing = calProcessing + " + ";
                TempNum = InputNum;
                ProcessScreen.Text = calProcessing;
                Result = double.Parse(InputNum);
                
            }
            InputNum = "";
        }


        private void Equal_Click(object sender, EventArgs e)
        {
            ResultScreen.Text = Result.ToString();
            ProcessScreen.Text = calProcessing + " =";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Result = 0;

            ResultScreen.Text = "0";
            ProcessScreen.Text = "";
            calProcessing = "";
        }


        private void DecimalPoint_Click(object sender, EventArgs e)  //소수점
        {
            //ResultScreen.Text 가 int일 때 => int + "."
            //이미 .이 있을 때 => pass
            //InputNum = InputNum + "."
        }
    }
}