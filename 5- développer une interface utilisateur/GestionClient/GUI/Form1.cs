using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            ClientDAO data = new ClientDAO();

            listBox1.DisplayMember = "clinom";
            listBox1.ValueMember = "cliref";
            listBox1.DataSource = data.list();
        }

        private void button1_Click(object sender, EventArgs e) //modif
        {
            if (textBox1.BackColor == SystemColors.Window && textBox2.BackColor == SystemColors.Window && textBox3.BackColor == SystemColors.Window)
            {
                ClientDAO cli = new ClientDAO();
                Client c = new Client();
                c.cliref = Convert.ToInt32(textBox1.Text);
                c.clinom = textBox2.Text;
                c.clipre = textBox3.Text;
                c.clistat = Convert.ToBoolean(checkBox1.Checked);

                cli.update(c);
            }



        }

        private void button2_Click(object sender, EventArgs e) //ajout
        {
            if (textBox1.BackColor == SystemColors.Window && textBox2.BackColor == SystemColors.Window && textBox3.BackColor == SystemColors.Window)
            { 
            ClientDAO cli = new ClientDAO();
            Client c = new Client();
            c.clinom = textBox2.Text;
            c.clipre = textBox3.Text;
            c.clistat = checkBox1.Checked;

            cli.insert(c);
            }
        }

        private void button3_Click(object sender, EventArgs e) //supr
        {
            ClientDAO cli = new ClientDAO();
            Client c = new Client();

            c.cliref = Convert.ToInt32(listBox1.SelectedValue);

            cli.delete(c);
        }

        private void button4_Click(object sender, EventArgs e)//select
        {
           
            
                Client c = new Client(); //déclaration de la variable c
                c = (Client)listBox1.SelectedItem; //assignation de la variable c

                textBox1.Text = Convert.ToString(listBox1.SelectedValue);
                textBox2.Text = c.clinom;
                textBox3.Text = c.clipre;
                checkBox1.Checked = c.clistat;
            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Regex reference = new Regex("^([0-9])*$");
            if (!reference.IsMatch(textBox1.Text))
            {
                textBox1.BackColor = Color.Red;
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
                textBox1.BackColor = SystemColors.Window;
            }           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
   
            Regex str = new Regex("^[a-zA-Z]*$");
            if (!str.IsMatch(textBox2.Text))
            {
                textBox2.BackColor = Color.Red;
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;
                textBox2.BackColor = SystemColors.Window;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
         
            Regex str = new Regex("^[a-zA-Z]*$");
            if (!str.IsMatch(textBox3.Text))
            {
                textBox3.BackColor = Color.Red;
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
                textBox3.BackColor = SystemColors.Window;
            }
        }
    }
}
