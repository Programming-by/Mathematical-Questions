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
        static Random rnd = new Random();
        private int RandomNumber(int Min, int Max)
        {
           return rnd.Next(Min, Max);
        }
        private void GenerateNumbers(int Min, int Max)
        {
            Number1 = RandomNumber(Min, Max);
            Number2 = RandomNumber(Min, Max);
        }
        private void GameLevel()
        {
            if (rbEasy.Checked)
            {
                GenerateNumbers(1, 20);
            } else if (rbMedium.Checked)
            {
                GenerateNumbers(20, 99);
            }
            else
            {
                GenerateNumbers(100, 1000);
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
        private void rbDivide_CheckedChanged(object sender, EventArgs e)
        {
            Operation = "/";
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            GameLevel();
            Form3 frm = new Form3(Number1,Number2,Operation);    
            frm.ShowDialog();
        }
    }
}
