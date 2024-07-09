using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaPOO.Modelo
{
   public class Persona
    {
        private int CalEdad;
        private int IMC;
        private int year;
        private int month;
        private int day;

        public Persona()
        {
        }

        public Persona(int calEdad, int iMC)
        {
            CalEdad = calEdad;
            IMC = iMC;
        }

        public int CalEdad1 { get => CalEdad; set => CalEdad = value; }
        public int IMC1 { get => IMC; set => IMC = value; }
        public int Year { get => year; set => year = value; }
        public int Month { get => month; set => month = value; }
        public int Day { get => day; set => day = value; }
    }


}
