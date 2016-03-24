using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FonctionsCheck
{
   public class Program
    {
        public static void Main(string[] args)
        {

            string mail = "nique";
            while (mail != "quit")
            {
                Console.WriteLine("entrez une adresse");
                mail = Console.ReadLine();
                string resultat = CheckMail(mail);
                Console.WriteLine(resultat);
                Console.ReadKey();
            }
        }
        static public string CheckMail(string mail)
        {
            
            string resultat = "";
            char separateur = '@';
            Regex local=new Regex("^[0-9a-zA-Z]+[0-9a-zA-Z]*[-._+]?[0-9a-zA-Z]+$");
            Regex domaine=new Regex("^[0-9a-zA-Z]+[-.]?[0-9a-zA-Z]+[.][a-z]{2,6}$");
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
    }
}
