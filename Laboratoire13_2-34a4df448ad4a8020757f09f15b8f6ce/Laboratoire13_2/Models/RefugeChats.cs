using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Models;


namespace Models
{
    public class RefugeChats
    {

        //----------- variables membres ----------------------------------------------------------

        /// <summary>
        /// Obtenir la liste des chats de la refuge
        /// </summary>
        public List<Chat> ColChats { get; private set; }


        //=======================================================================================================
        public RefugeChats()
        {
           // TODO À compléter

        }
        public RefugeChats(List<Chat> pColChats)
        {
            // TODO À compléter

        }
        //-----------------------------------------------------------------------------------
        /// <summary>
        /// Vérifie si un chat avec ce matricule existe dans la collection
        /// </summary>
        /// <param name="pMatricule">Numéro de matricule du chat recherché</param>
        /// <returns>Retourne true si le matricule existe dans la collection, sinon retourne false</returns>
        public bool MatriculeExiste(string pMatricule)
        {
            // TODO À compléter

            return true;
        }


        /// <summary>
        /// Ajoute un chat à la fin de la liste des chats
        /// </summary>
        /// <param name="pChat"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public void Ajouter(Chat pChat)
        {
            // TODO À compléter

        }
        /// <summary>
        /// Supprimer un chat à une position donnée de la liste
        /// </summary>
        /// <param name="pIndex"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Supprimer(int pIndex)
        {

            // TODO À compléter


        }

        /// <summary>
        /// Obtenir la liste des chats dont l’âge est supérieur à l’âge spécifié.
        /// </summary>
        /// <param name="pAge"></param>
        /// <returns>Une liste contenant les chats ayant un âge supérieur à <paramref name="pAge"/>.</returns>
        public List<Chat> ChatsSelonAge(int pAge)
        {

            // TODO À compléter

            return null;

        }
    }
}
