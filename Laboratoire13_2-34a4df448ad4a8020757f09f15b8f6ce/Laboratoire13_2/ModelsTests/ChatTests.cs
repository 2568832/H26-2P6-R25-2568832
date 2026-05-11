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
    public class ChatTests
    {
        
        Chat crééChatParDeffault ()
        {
            Chat chat = new Chat("A123", "Minou", 3);
            return chat;
        }

        [TestMethod()]
        public void Chat_Matricule_Null_Test()
        {
            

            Assert.ThrowsException<ArgumentNullException>( 
                () =>
                {
                    Chat chat = new Chat( null, "Minou", 3); 

                }
            );

        }

        [TestMethod()]
        public void Chat_Matricule_4Caracteres_Test()
        {


            Assert.ThrowsException<ArgumentException>(
                () =>
                {
                    Chat chat = new Chat("abc", "Minou", 3);

                }
            );

        }

        [TestMethod()]
        public void Chat_Nom_null_Test()
        {


            Assert.ThrowsException<ArgumentNullException>(
                () =>
                {
                    Chat chat = new Chat("abcd", "  ", 3);

                }
            );

        }
        [TestMethod()]
        public void Chat_Nom_Moin_3Caracteres_Test()
        {


            Assert.ThrowsException<ArgumentException>(
                () =>
                {
                    Chat chat = new Chat("abcd", "al", 3);

                }
            );

        }

        [TestMethod()]
        public void Chat_Age_egale_zero_Test()
        {


            Assert.ThrowsException<ArgumentException>(
                () =>
                {
                    Chat chat = new Chat("abcd", "allle", 0);

                }
            );

        }


        [TestMethod()]
        public void Chat_Age_Plus_Grand_zero_Test()
        {

            Chat chat = new Chat("abcd", "allle", 12);

            
            Assert.AreNotEqual( chat.Age, 0 );
            


        }
    }
}