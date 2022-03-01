﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IVehicle
    {
        public int Wheels { get; set; }
        public string? Colour { get; set; }
        public string Horn();
    }

    internal class Car : IVehicle
    {
        public int Wheels { get; set; }
        public string? Colour { get; set; }
        public string Horn()
        {
            return "Beep";
        }
    }

    internal class Car : IVehicle
    {
        public int Wheels { get; set; }
        public string? Colour { get; set; }
        public string Horn()
        {
            return "Beep";
        }
    }
}