using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class Statistiques
    {

        public List<int> ColNombres { get; private set; }

        /// <summary>
        /// Obtenir les nombres pairs de la collection ColNombres 
        /// </summary>
        public List<int> NombresPairs
        {                   
            get
            {
                // TODO : À Compléter    

                return null;
            }
        }
        /// <summary>
        /// Obtenir le total des nombres dans la collection
        /// </summary>
        public int Somme
        {           
            get
            {
                // TODO À compléter
                return 0;

            }
            
        }
        /// <summary>
        /// Obtenir la moyenne des nombres de la collection ou zéro si aucun élément.      
        /// </summary>
        /// <returns>décimal</returns>
        public double Moyenne
        {
            get
            {
                // TODO À compléter
                return 0;

            }
        }
        /// <summary>
        /// Instancier la classe avec une collection vide de nombres entiers
        /// </summary>
        public Statistiques()
        {
            // TODO À compléter
        }
        /// <summary>
        /// Instancier la classe avec collection d'entiers passée en paramètre
        /// </summary>
        /// <param name="pColNombres"> Collection d'entiers</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Statistiques(List<int> pColNombres)
        {
            // TODO À compléter
        }
        /// <summary>
        /// Ajouter un nom,bre entier à la fin de la collection
        /// </summary>
        /// <param name="pNombre">Nombre entier</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Ajouter(int pNombre)
        {
            // TODO À compléter

        }
        /// <summary>
        /// Compter le nombre d'occurences d'un entier dans la collection
        /// </summary>
        /// <param name="pNombre">nombre entier</param>
        /// <returns></returns>
        public int NbOccurences(int pNombre)
        {
            // TODO À compléter

            return 0;
        }



    }
}

