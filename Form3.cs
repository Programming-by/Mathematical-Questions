using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathematical_Questions
{
    public partial class Form3 : Form
    {
        int _Number1 = 0;
        int _Number2 = 0;
        string _Operation = "+";
        int Answer = 0;
        int UserAnswer = 0;
        public Form3(int Number1 ,int Number2,string Operation)
        {
            InitializeComponent();

            _Number1 = Number1;
            _Number2 = Number2;
            _Operation = Operation;

        }

        private int Counter = 10;
        private void ChangeLabelColor()
        {
            if (Counter == 3 || Counter == 2 || Counter == 1)
            {
                lblTime.ForeColor = Color.Red;
            }
        }

        private void CounterReachToZero()
        {
            if (Counter == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Time Up", "Time Up", MessageBoxButtons.OK);                
                return;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter--;
            lblTime.Text = Counter + "S";

            ChangeLabelColor();

            CounterReachToZero();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;   

            lblNumber1.Text = _Number1.ToString();
            lblNumber2.Text = _Number2.ToString();
            lblOperation.Text = _Operation.ToString();
        }

        private int RightAnswer()
        {
            switch (_Operation)
            {
                case "+":
                 Answer =  _Number1 + _Number2;
                    break;
                case "-":
                    Answer = _Number1 - _Number2;
                    break;
                    case "*":
                    Answer = _Number1 * _Number2;
                    break;
            }
            return Answer;
        }
   
        private void CheckAnswer()
        { 
            UserAnswer = Convert.ToInt32(txtBox1.Text);

          if (RightAnswer() == UserAnswer)
            {
                MessageBox.Show("True", "True Answer", MessageBoxButtons.OK);
            } else
            {
                MessageBox.Show("Wrong", "Wrong Answer", MessageBoxButtons.OK);

            }

          this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }
    }
}
