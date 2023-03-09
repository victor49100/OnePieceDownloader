using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaDowloader2
{
    public class methods
    {
        public static string ConvertUrlToTomeOp(int tome)
        {
            string l1 = "10";
            string l2 = "00";
            string l3 = "00";

            if (tome < 10)
            {
                l3 = tome.ToString() + "0";
                string t = l1 + l2 + l3 + "00";
                return t;
            }
            if (tome > 9 && tome < 100)
            {
                int d = int.Parse(tome.ToString().Substring(0, 1));
                l2 = "0" + d.ToString();
                l3 = (tome % 10).ToString() + "0";
                Console.WriteLine(l1 + " " + l2 + " " + l3);
                string t = l1 + l2 + l3 + "00";
                return t;
            }
            if (tome > 99 && tome < 1000)
            {
                l2 = tome.ToString().Substring(0, 2);
                l3 = (tome % 10).ToString() + "0";
                string t = l1 + l2 + l3 + "00";
                return t;
            }
            if (tome > 999)
            {
                l1 = "11";
                l2 = tome.ToString().Substring(1, 2);
                l3 = (tome % 10).ToString() + "0";
                string t = l1 + l2 + l3 + "00";
                return t;
            }

            // Retour par défaut
            return null;
        }



    }

}
