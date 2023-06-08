using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinformApplication.BL
{
    public class ValidationService
    {
        bool a;

        public bool ToValidateRegisterNumber(string no)
        {
            string pattern = "^[0-9]{4}$";
            Regex r = new Regex(pattern);
            if (r.IsMatch(no))
            {
                return a = true;
            }
            else
            {
                return a = false;
            }
        }
        public bool ToValidateFirstName(string firstname)
        {
            string pattern = "^[a-zA-Z ]{3,30}$";
            Regex r = new Regex(pattern);
            if (r.IsMatch(firstname))
            {
                return a = true;
            }
            else
            {
                return a = false;
            }
        }
        public bool ToValidateLastName(string lastname)
        {
            string pattern = "^[a-zA-Z .]{1,4}$";
            Regex r = new Regex(pattern);
            if (r.IsMatch(lastname))
            {
                return a = true;
            }
            else
            {
                return a = false;
            }
        }
        public bool ToValidateAddress(string address)
        {
            string pattern = "^[a-zA-Z .,/0-9]{6,100}$";
            Regex r = new Regex(pattern);
            if (r.IsMatch(address))
            {
                return a = true;
            }
            else
            {
                return a = false;
            }
        }
        public bool ToValidatePhoneNumber(string phonenumber)
        {
            string pattern = "^[1-9]{1}[0-9]{9}$";
            Regex r = new Regex(pattern);
            if (r.IsMatch(phonenumber))
            {
                return a = true;
            }
            else
            {
                return a = false;
            }
        }

       

        }
    }

