using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Result issue1 = new Result(new Monthly_deposit());
            Result issue2 = new Result(new Quarterly_deposit());
            Result issue3 = new Result(new Deposit_for_a_year());
            string everyDay = textBox4.Text;
            if (comboBox1.SelectedIndex == 0)
            {
                Deposit issue4 = new Universal_Bank();
                MessageBox.Show(issue4.Name);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Deposit issue4 = new Industrialbank();
                MessageBox.Show(issue4.Name);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                Deposit issue4 = new Accordbank();
                MessageBox.Show(issue4.Name);
            }
            if ( textBox4.Text == "" )
            {
                MessageBox.Show("Заполните все поля");
            }
            textBox3.Text = issue1.Monthly_deposit(Convert.ToDouble(everyDay)).ToString();
            textBox2.Text = issue2.Quarterly_deposit(Convert.ToDouble(everyDay)).ToString();
            textBox1.Text = issue3.Deposit_for_a_year(Convert.ToDouble(everyDay)).ToString();
        }
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
