﻿using System;

namespace FetchConsole.Data
{
    public class Weather
    {
        public int id { get; set; }
        public Nullable<System.DateTime> timestamp { get; set; }
        public int tp { get; set; }
        public int pr { get; set; }
        public int hu { get; set; }
        public int ws { get; set; }
        public int wd { get; set; }
        public string ic { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string state { get; set; }
    }
}