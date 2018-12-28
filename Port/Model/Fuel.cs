﻿using Port.Interfaces;

namespace Port.Model
{
    public class Fuel : IFuel
    {
        public double Cost { get; set; }

        public Fuel(double cost)
        {
            Cost = cost;
        }
    }
}
