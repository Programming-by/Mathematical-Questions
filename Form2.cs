using System;
using System.Windows.Forms;

namespace Mathematical_Questions
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int Number1 = 0;
        int Number2 = 0;
        string Operation = "+";

        private void RandomNumber(int Num1 , int Num2)
        {
            Random rnd  = new Random();

           Number1 =  rnd.Next(Num1, Num2);
           Number2 =  rnd.Next(Num1, Num2);
        }

        private void GameLevel()
        {
            if (rbEasy.Checked)
            {
                RandomNumber(1,20);

            } else if (rbMedium.Checked)
            {
                RandomNumber(20, 99);
            }
            else
            {
                RandomNumber(100, 1000);
            }
        }      
      
        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            Operation = "+";

        }
        private void rbSubtract_CheckedChanged(object sender, EventArgs e)
        {
            Operation = "-";

        }
        private void rbMultiply_CheckedChanged(object sender, EventArgs e)
        {
            Operation = "*";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            GameLevel();
            Form3 frm = new Form3(Number1,Number2,Operation);    
            frm.ShowDialog();


        }
    }
}
