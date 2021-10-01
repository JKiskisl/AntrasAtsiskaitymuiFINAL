using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntrasPraktzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region "CheckforNULL & CheckforvalidAGE"
        private bool CheckForNull()
        {

            if (textBox1.Text == ""
                || textBox2.Text == ""
                || comboBox1.Text == ""
                || comboBox2.Text == ""
                || comboBox3.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckForAge()
        {
            DateTime now = DateTime.Now;
            try
            {
                DateTime dateTime = new DateTime(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text), int.Parse(comboBox3.Text));
                if (dateTime > now)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        #endregion

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (CheckForNull() && CheckForAge())
            {
                Person person = new Person(textBox1.Text, textBox2.Text, int.Parse(comboBox1.Text), int.Parse(comboBox2.Text), int.Parse(comboBox3.Text));
                MessageBox.Show(person.Info());
            }
            else
            {
                MessageBox.Show("Invalid data");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
