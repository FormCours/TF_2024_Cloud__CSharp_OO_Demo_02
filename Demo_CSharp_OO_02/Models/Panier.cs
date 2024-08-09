using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_OO_02.Models
{
    internal class Panier
    {
        private List<Pomme> _Pommes = new List<Pomme>();

        public IEnumerable<Pomme> Pommes
        {
            get { return _Pommes.AsReadOnly(); }
        }


        public static Panier operator +(Panier left, Pomme right)
        {
            left._Pommes.Add(right);
            return left;
        }

        public static Panier operator +(Pomme left, Panier right)
        {
            return right + left;
        }
    }
}
