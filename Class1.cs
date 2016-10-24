using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions; 

namespace bloodbanksystem
{
    public class Class1
    {
        public static bool chechforemail(string email)
        {
            bool isvalid = false;
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (r.IsMatch(email))
                isvalid = true;
            return isvalid;

        }

    }
}
