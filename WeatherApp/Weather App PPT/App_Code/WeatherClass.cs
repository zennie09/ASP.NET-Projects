//This is A Weather Application that can used to send employee emails
//on the current weather on that day and indicate to them if they
//should work or not.
//Created By:Zennie09
//Dated:Feburary 10,2018
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Weather_App_PPT
{
    public class WeatherClass
    {
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }

        }// end of coord class


        public class weather
        {

            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }

        }// end of weather class


        public class main
        {

            public double temp { get; set; }
            public int pressure { get; set; }
            public int humidity { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }

        }// end of main class


        public class wind
        {

            public double speed { get; set; }
            public double deg { get; set; }


        }// end of wind class



        public class sys
        {
            public int type { get; set; }
            public int id { get; set; }
            public string message { get; set; }
            public string country { get; set; }
            public int sunrise { get; set; }
            public int sunset { get; set; }
        


        }// end of sys class



        public class root
        {

            public coord coord { get; set; }
            public List<weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public sys sys { get; set; }
            public string name { get; set; }
            
              
           
        }// end of sys class
    
    }
}