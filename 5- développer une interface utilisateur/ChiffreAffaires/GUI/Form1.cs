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
            ChiffreDAO chi = new ChiffreDAO();

            listBox1.DisplayMember= "reffou";           
            listBox1.DataSource = chi.list();
            listBox2.DisplayMember = "ca";
            listBox2.DataSource = chi.list();
        }
    }
}
