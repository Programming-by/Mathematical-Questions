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
        float Answer = 0;
        float UserAnswer = 0;
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
            if (Counter <= 3)
            {
                lblTime.ForeColor = Color.Red;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter--;
            lblTime.Text = Counter + "S";

            ChangeLabelColor();

            if (Counter == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time Up", "Time Up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();   

            lblNumber1.Text = _Number1.ToString();
            lblNumber2.Text = _Number2.ToString();
            lblOperation.Text = _Operation.ToString();
        }
        private float RightAnswer()
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
                case "/":
                    Answer = _Number1 / _Number2;
                    break;
            }
            return Answer;
        }
        private void CheckAnswer()
        { 
            UserAnswer = Convert.ToSingle(txtAnswer.Text);

          if (RightAnswer() == UserAnswer)
            {
                MessageBox.Show("True", "True Answer", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong", "Wrong Answer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

          timer1.Stop();
          this.Close();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }
        private void txtAnswer_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnswer.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAnswer , "this field is required");
            } else
                errorProvider1.SetError(txtAnswer, "");
        }
        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
