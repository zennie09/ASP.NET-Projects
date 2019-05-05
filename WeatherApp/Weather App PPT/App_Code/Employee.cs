//This is A Weather Application that can used to send employee emails
//on the current weather on that day and indicate to them if they
//should work or not.
//Created By:Zennie09
//Dated:Feburary 10,2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weather_App_PPT.App_Code
{

    public class Employee
    {
        public string Email { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string p_number { get; set; }
        public string role { get; set; }
    }
}