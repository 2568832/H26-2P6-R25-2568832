using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    /// -----------------------------------------------------------------------------------------------------
    /// <summary>
    ///	 Représente un chat : son nom et son age
    /// </summary>
    /// -----------------------------------------------------------------------------------------------------
    public class Chat
    {
        //------------------------------------------------------
        private string m_matricule;

        /// ----------------------------------------------------
        /// <summary>
        /// Obtient et définit le matricule du chat
        /// </summary>
        /// ----------------------------------------------------
        public string Matricule
        {
            get { return m_matricule; }
            set
            {
                if (value == null )
                {
                    throw new ArgumentNullException();

                }
                if (value.Length != 4)
                {
                    throw new ArgumentException();

                }
                // TODO À compléter
                m_matricule = value;
            }
        }
        //------------------------------------------------------
        private string m_nom;

        /// ----------------------------------------------------
        /// <summary>
        /// Obtient et définit le nom du chat
        /// </summary>
        /// ----------------------------------------------------
        public string Nom
        {
            get { return m_nom; }
            set
            {
                // TODO À compléter
                if (value == null || value.Trim() == "")
                {
                    throw new ArgumentNullException();
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException();
                }
                m_nom = value;
            }
        }

        //------------------------------------------------------
        private int m_age;

        /// ----------------------------------------------------
        /// <summary>
        /// Obtient et définit l'age du chat (en nombre d'années)
        /// </summary>
        /// ----------------------------------------------------
        public int Age
        {
            get { return m_age; }
            set
            {
                // TODO À compléter
                if (value == 0)
                {
                    throw new ArgumentException();
                }
                m_age = value;
            }
        }

        //---------------------------------------------------------------
        /// <summary>
        /// Instancie un chat avec les données passées en paramètre.
        /// </summary>
        /// <param name="pMatricule">matricule du chat à créer</param>
        /// <param name="pNom">nom du chat à créer</param>
        /// <param name="pAge">age du chat à créer</param>
        /// -------------------------------------------------------------
        public Chat(string pMatricule, string pNom, int pAge)
        {
            // À compléter
            Matricule = pMatricule;
            Nom = pNom;
            Age = pAge;

        }
    }
}

