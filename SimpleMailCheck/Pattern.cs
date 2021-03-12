using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleMailCheck
{
    class Pattern
    {
        //string Regex_Pincode = "^[a-zA-Z0-9]{1,}@[A-Za-z]+[.][A-Za-z]{2,4}$";
        string Regex_Pincode = "^[a-z0-9A-Z]+([.#_+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";

        public bool validatePinCode(string pincode) 
        {
            return Regex.IsMatch(pincode, Regex_Pincode);
        }
    }
}
