using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Metodos
    {
        private String Nm;
        private double NT1, NT2, NT3, NT4;

        public Metodos()
        {
        }

        public Metodos(string nm, double nT1, double nT2, double nT3, double nT4)
        {
            Nm = nm;
            NT1 = nT1;
            NT2 = nT2;
            NT3 = nT3;
            NT4 = nT4;
        }

        public string Nm1 { get => Nm; set => Nm = value; }
        public double NT1s { get => NT1; set => NT1 = value; }
        public double NT2s { get => NT2; set => NT2 = value; }
        public double NT3s { get => NT3; set => NT3 = value; }
        public double NT4s { get => NT4; set => NT4 = value; }

        public double Prom(double nT1, double nT2, double nT3, double nT4)
        {
            double z=nT1+nT2+ nT3+nT4;
            return (z / 4);
        }
        public double NtMayor(double nT1, double nT2, double nT3, double nT4)
        {
            double z=0;
            if((nT1 > nT2) && (nT1 > nT3) && (nT1 > nT4))
            {
                z = nT1;
            }else if((nT2 > nT1) && (nT2 > nT3) && (nT2 > nT4))
            {
                z= nT2;   
            }else if((nT3 > nT1) && (nT3 > nT2) && (nT3 > nT4))
            {
                z= nT3; 
            }else if((nT4 > nT1) && (nT4 > nT2) && (nT4 > nT3))
            {
                z= nT4; 
            }
            return z;
        }
        public double NtMenor(double nT1, double nT2, double nT3, double nT4)
        {
            double z = 0;
            if ((nT1 < nT2) && (nT1 < nT3) && (nT1 < nT4))
            {
                z = nT1;
            }
            else if ((nT2 < nT1) && (nT2 < nT3) && (nT2 < nT4))
            {
                z = nT2;
            }
            else if ((nT3 < nT1) && (nT3 < nT2) && (nT3 < nT4))
            {
                z = nT3;
            }
            else if ((nT4 < nT1) && (nT4 < nT2) && (nT4 < nT3))
            {
                z = nT4;
            }
            return z;
        }
    }
}
