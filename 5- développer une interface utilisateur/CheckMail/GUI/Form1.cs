using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using FonctionsCheck;
namespace GUI
{
    public partial class Form1 : Form
    {
        static public string CheckMail(string mail)
        {

            string resultat = "";
            char separateur = '@';
            Regex local = new Regex("^[0-9a-zA-Z]+[0-9a-zA-Z]*[-._+]?[0-9a-zA-Z]+$");
            Regex domaine = new Regex("^[0-9a-zA-Z]+[-.]?[0-9a-zA-Z]+[.][a-z]{2,6}$");
            if (mail.IndexOf(separateur) == -1)
            {
                resultat = "'@' manquante\n";
            }
            else
            {
                string[] substring = mail.Split(separateur);
                Console.WriteLine(substring[0]);
                Console.WriteLine(substring[1]);
                if (local.IsMatch(substring[0]) && domaine.IsMatch(substring[1]))
                {
                    resultat = "bon";
                }
                else
                {
                    if (!local.IsMatch(substring[0]))
                    {
                        resultat += "local incorrect\n";
                    }
                    if (!domaine.IsMatch(substring[1]))
                    {
                        resultat += "domaine incorrect\n";
                    }
                }
            }

            return resultat;

        }
        public Form1()
        {
            InitializeComponent();
        }        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mail = textBox1.Text;
            string resultat = CheckMail(mail);
            MessageBox.Show(resultat);
            //Regex reglocal = new Regex("^[0-9a-zA-Z]+[-._+]?[0-9a-zA-Z]+$");
            //Regex regdomaine = new Regex("^[0-9a-zA-Z]+[-.]?[0-9a-zA-Z]+[.][a-z]{2,6}$");
            //Regex reglocal = new Regex("^[0-9a-zA-Z]+([0-9a-zA-Z]*[-._+])*[0-9a-zA-Z]+$");
            //Regex regdomaine = new Regex("^[0-9a-zA-Z]+[-.]*[0-9a-zA-Z]+[.][a-z]{2,6}$");
            //Regex regdomaine = new Regex("^[0-9a-zA-Z]+([-.][0-9a-zA-Z]+)*([0-9a-zA-Z]*[.])[a-zA-Z]{2,6}$");
            //char separateur = '@';
            //string[] subarrays = mail.Split(separateur);           
        }
    }
}
