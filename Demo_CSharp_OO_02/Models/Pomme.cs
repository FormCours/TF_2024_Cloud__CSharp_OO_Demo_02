using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_OO_02.Models
{
    internal class Pomme
    {
        public string Variete { get; set; }
        public double Poids { get; set; }


        public static bool operator ==(Pomme? left, Pomme? right)
        {
            if (left is null && right is null)
                return true;

            if (left is null || right is null)
                return false;

            return left.Variete == right.Variete
                && left.Poids == right.Poids;
        }

        public static bool operator !=(Pomme? left, Pomme? right)
        {
            return !(left == right);
        }
    }
}
