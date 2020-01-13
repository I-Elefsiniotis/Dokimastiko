using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Kouti Kouti1 = new Kouti();
            Kouti Kouti2 = new Kouti();

            //double ogos;
            Kouti1.setIpsos(5.4);
            Kouti1.setMikos(4.5);
            Kouti1.setPlatos(3.1);

            Kouti2.setIpsos(6.1);
            Kouti2.setPlatos(5.2);
            Kouti2.setMikos(4.1);

            double ogos;

            ogos = Kouti1.getOgos();
            //ogos = Kouti1.ipsos * Kouti1.mikos * Kouti1.platos;
            Console.WriteLine("Ogos koutiou 1: {0}", ogos);


            ogos = Kouti2.getOgos();
            //ogos = Kouti2.ipsos * Kouti2.mikos * Kouti2.platos;
            Console.WriteLine("Ogos koutiou 2: {0}", ogos);


            Grammi grammi = new Grammi(10.0, 12.0);
            //grammi.setMikos(5.0);
            //grammi.setPlatos(6.0);
            Console.WriteLine("To emvadon einai {0}", grammi.getEmvadon());
        }
    }

    class Kouti
    {
        private double ipsos;
        private double mikos;
        private double platos;

    

        public void setIpsos(double ips)
        {
            ipsos = ips;
        }
        public void setMikos(double mik)
        {
            mikos = mik;
        }
        public void setPlatos(double pla)
        {
            platos = pla;
        }

        public double getOgos()
        {
            return ipsos * mikos * platos;
        }

        
    }

    class Grammi
    {
        private double Mikos;
        private double Platos;

        public Grammi(double mik, double pla)
        {
            Console.WriteLine("To antikeimeno ftiaxnete"/*, mik, pla*/);
            Mikos = mik;
            Platos = pla;
        }

        public void setMikos(double mik)
        {
            Mikos = mik;
        }
        public void setPlatos(double pla)
        {
            Platos = pla;
        }


        public double getEmvadon()
        {
            return Mikos * Platos;
        }
        
    }
}
