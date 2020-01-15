using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics.Models
{
    public class Doctor
    {
        public static string FeverCheck(int temp) 
        {
            if (temp > 38)
            {
               return "You've got fever - You can take an icecream babe!";
            }
            else if (temp < 35)
            {
                return "You've got hyperthermia - Move into the sauna!";
            }
            else
            {
                return "everything seems to be ok!";
            }
        }
    }
}
