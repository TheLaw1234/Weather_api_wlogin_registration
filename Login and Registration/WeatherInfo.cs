﻿using System;
using System.Collections.Generic;



namespace Login_and_Registration
{
    internal class WeatherInfo
    {
        public class coordinates
        {
            public double longitude { get; set; }
            public double latitude { get; set; }
        }

        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class main
        {
            public double temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
        }

        public class wind
        {
            public double speed { get; set; }
        }

        public class sys
        {
            public long sunrise { get; set; }
            public long sunset { get; set; }
        }

        public class sum
        {
            public coordinates coordinates { get; set; }
            public List<weather> weather { get; set;}

            public main main { get; set; }
            public wind wind { get; set; }
            public sys sys { get; set; }
            
        }
       
    }
}

