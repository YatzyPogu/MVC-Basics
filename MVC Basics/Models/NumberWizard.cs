using Microsoft.AspNetCore.Http;
using MVC_Basics.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics.Models
{
    public class NumberWizard
    {

        static Random random = new Random();
        public static int Magic() 
        {
            int theNum = random.Next(1, 101);
            return theNum;
        }


        public static string Guessing(int theNum, int guess) 
        {
            
            
                if (guess < theNum)
                {
                    return "Higher";
                }
                else if (guess > theNum)
                {
                    return "Lower";
                }
                else
                {

                    NumberWizard.Magic();
                    return "Congratulation!";


            }
            
           
        }

        
    }
}
