using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FonctionsCheck;
namespace TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() //bon
        {
            string mail = "alex@wild.com";
            string resultat = Program.CheckMail(mail);
            Assert.AreEqual(resultat,"bon");
        }
        [TestMethod]
        public void TestMethod2()//local faux
        {
            string mail = "a@wild.com";
            string resultat = Program.CheckMail(mail);
            Assert.AreNotEqual(resultat, "bon");
        }
        [TestMethod]
        public void TestMethod3()//domaine faux
        {
            string mail = "alex@w.com";
            string resultat = Program.CheckMail(mail);
            Assert.AreNotEqual(resultat, "bon");
        }
        [TestMethod]
        public void TestMethod4()//extension fausse
        {
            string mail = "alex@wild.c";
            string resultat = Program.CheckMail(mail);
            Assert.AreNotEqual(resultat, "bon");
        }
        [TestMethod]
        public void TestMethod5()//no @
        {
            string mail = "alexwild.com";
            string resultat = Program.CheckMail(mail);
            Assert.AreNotEqual(resultat, "bon");
        }
        [TestMethod]
        public void TestMethod6()//no .
        {
            string mail = "alex@wildcom";
            string resultat = Program.CheckMail(mail);
            Assert.AreNotEqual(resultat, "bon");
        }
        [TestMethod]
        public void TestMethod7()//extension trop longue
        {
            string mail = "alex@wild.commmm";
            string resultat = Program.CheckMail(mail);
            Assert.AreEqual(resultat, "bon");
        }
        [TestMethod]
        public void TestMethod8()//special détecté
        {
            string mail = "al/ex@wild.com";
            string resultat = Program.CheckMail(mail);
            Assert.AreNotEqual(resultat, "bon");
        }
        [TestMethod]
        public void TestMethod9()//deux '.' à la suite
        {
            string mail = "al..ex@wild.com";
            string resultat = Program.CheckMail(mail);
            Assert.AreNotEqual(resultat, "bon");
        }
        [TestMethod]
        public void TestMethod10()//'.' pas dans le local
        {
            string mail = "alex.@wild.com";
            string resultat = Program.CheckMail(mail);
            Assert.AreNotEqual(resultat, "bon");
        }
        [TestMethod]
        public void TestMethod11()//'.' pas dans le local
        {
            string mail = ".alex@wild.com";
            string resultat = Program.CheckMail(mail);
            Assert.AreNotEqual(resultat, "bon");
        }
        [TestMethod]
        public void TestMethod12()//'.' pas dans le domaine
        {
            string mail = "alex@.wild.com";
            string resultat = Program.CheckMail(mail);
            Assert.AreNotEqual(resultat, "bon");
        }
    }
}
