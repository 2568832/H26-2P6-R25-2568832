using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Tests
{

    [TestClass()]
    public class MontreTests
    {
        public const int Temp_compris_MIN = 0;
        public const int Heur_Compris_MAX = 23;
        public const int MIN_Compris_MAX = 59;
        public const int SECONDE_Compris_MAX = 59;



        [TestMethod()]
        public void MontreTest()
        {
            Montre m = new Montre(11,33,33);
            Assert.AreEqual("11:33:33",m.ObtenirTempsCourant()); 
        }

        [TestMethod()]
        public void Montre_Aucune_Donnees_Test()
        {
            Montre m = new Montre();
            Assert.AreEqual("00:00:00", m.ObtenirTempsCourant());
        }


        [TestMethod()]
        public void AvancerUneSecondeTest()
        {
            Montre m = new Montre(11, 33, 33);
            m.AvancerUneSeconde();
            Assert.AreEqual("11:33:34", m.ObtenirTempsCourant());
            
        }

        [TestMethod()]
        public void ObtenirTempsCourantTest()
        {
            Montre m = new Montre(11, 33, 33);
            

            Assert.AreEqual("11:33:33", m.ObtenirTempsCourant());
        }
    }
}