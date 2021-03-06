﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics.Models
{
    public class PeopleModel
    {
        public string search = "";

        static int idCounter = 0;
        public static List<PeopleModel> peopleList = new List<PeopleModel>();
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }

        public PeopleModel()
        {
            Id = ++idCounter;
        }
    }
}
