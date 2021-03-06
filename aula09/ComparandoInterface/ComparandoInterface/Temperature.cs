using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparandoInterface
{
    using System;
    using System.Collections;

    public class Temperature : IComparable
    {
        // The temperature value
        protected double temperatureF;

        public Temperature(double temperatureCelsius)
        {
            this.Celsius = temperatureCelsius;
        }

        public int CompareTo(object obj)
        {
            /* 1 se eu for maior
             * 0 se formos iguais
             * -1 se eu for menor
             */
            if (obj == null) return 1;

            Temperature otherTemperature = obj as Temperature;
            if (otherTemperature != null)
                return this.temperatureF.CompareTo(otherTemperature.temperatureF);
            else
                throw new ArgumentException("Object is not a Temperature");
        }

        public double Fahrenheit
        {
            get
            {
                return this.temperatureF;
            }
            set
            {
                this.temperatureF = value;
            }
        }

        public double Celsius
        {
            get
            {
                return (this.temperatureF - 32) * (5.0 / 9);
            }
            set
            {
                this.temperatureF = (value * 9.0 / 5) + 32;
            }
        }
    }
}
