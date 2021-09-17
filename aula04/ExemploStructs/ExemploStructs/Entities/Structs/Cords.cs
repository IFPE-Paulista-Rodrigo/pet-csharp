using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploStructs.Entities.Structs
{
    public struct Coords
    {
        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; init; }
        public double Y { get; init; }

        public override string ToString() => $"({X}, {Y})";
    }
}
