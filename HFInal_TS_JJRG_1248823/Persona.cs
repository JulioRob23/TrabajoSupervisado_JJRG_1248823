using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFInal_TS_JJRG_1248823
{
    class Persona
    {
        private string nombre, apellido;
        private int edad;
        private double alturacm;

        public string NombreCompleto()
        {
            string nombrec = "" + nombre + " " + apellido;
            return nombrec;
        }
        public double Alturaenm()
        {
            double alturam = alturacm / 100;
            return alturam;
        }
        public void Imprimir()
        {
            Console.WriteLine("Persona: " + NombreCompleto());
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Altura: " + Alturaenm());
         
        }
        public Persona(string elnombre, string elapellido, int laedad, double laalturacm)
        {
            nombre = elnombre;
            apellido = elapellido;
            edad = laedad;
            alturacm = laalturacm;
        }

    }
}
