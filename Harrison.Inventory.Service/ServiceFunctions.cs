using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harrison.Inventory.Service
{
    public class ServiceFunctions
    {
        public string GenerateID(string stringpart, int number, int noofdigits)
        {
            string id = "", numberpart = "";
            numberpart = number.ToString();
            while (numberpart.Length < noofdigits)
            {
                numberpart = "0" + numberpart;
            }
            id = stringpart + numberpart;
            return id;
        }
        public string GenerateID(string stringpart, int number)
        {
            return stringpart + number.ToString();

        }
        public int GetIDint(string id)
        {
            int i;
            for (i = id.Length - 1; i >= 0; i--)
            {
                if (char.IsLetter(id[i]))
                    break;
            }
            return int.Parse(id.Substring(i + 1));
        }

        public int GetIDint(string id, int noofdigits)
        {
            return int.Parse(id.Substring(id.Length - noofdigits));
        }
    }
}
