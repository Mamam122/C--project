using System;
using System.Collections.Generic;
using System.Text;

namespace abstract
{
    class kalkulator
    {
        abstract kalkulator()
        {
            interface interface1
            {
                double add(double x,double y);
                double min(double x, double y);
                double cross(double x, double y);
                double devide(double x, double y);
            }
            class hitung : interface1
            {
                public double add(double x, double y)
                {
                    return x + y;
                }
                public double min(double x, double y)
                {
                    return x - y;
                }
                public double cross(double x, double y)
                {
                    return x * y;
                }
                public double devide(double x, double y)
                {
                    return x / y;
                }
            }
            
        }
    }
}
