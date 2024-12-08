using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosComparador05_12
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public override string ToString()
        {
            return $"{Nombre}, {Edad} años";
        }
        //METODOS:para enseñarle al sort a ordennar por edad. Sort precisa recibir 1,-1 y 0
        public static int CompararPorEdad(Persona unaPersona,Persona otraPersona) 
        {
            int retorno = 0;
            if (unaPersona.Edad > otraPersona.Edad)
            {
                retorno = 1;
            }
            else 
            {
                if (unaPersona.Edad<otraPersona.Edad)
                {
                    retorno = -1;
                }
            }
            return retorno;
        }
        //METODO:para enseñarle al sort a ordenar por nombre
        public static int CompararPorNombre(Persona unaPersona, Persona otraPersona)
        {
            return string.Compare(unaPersona.Nombre, otraPersona.Nombre);
        }
        public static void
    }
}
