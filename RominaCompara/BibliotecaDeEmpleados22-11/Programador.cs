using LibreriaDeExcepciones22_11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeEmpleados22_11
{
    public class Programador:Empleado
    {
        private double salarioBase;
        private int lineasPorHora;// cantidad de lineas q desarrolla por hora

        public Programador(int id, string nombre, string apellido, int edad, string departamento, double salarioBase, int lineasPorHora)
            : base(id, nombre, apellido, edad, departamento)
        {
            this.salarioBase = salarioBase;
            this.lineasPorHora = lineasPorHora;

        }

        public double SalarioBase { get => salarioBase; set => salarioBase = value; }
        public int LineasPorHora { get => lineasPorHora; set => lineasPorHora = value; }

        //Sobreescribir metodo:Redefinimos el comportamiento del metodo MostrarInformacion()

        public override string MostrarInformacion()//puede no existir este metodo
        {
            //string mensaje = $"{base.MostrarInformacion()} - SALARIO: USD{this.salarioBase} - CANT.LINEAS: {this.lineasPorHora}";
            //return mensaje;
            return $"Es un programador se llama {this.nombre}";//-> Como el atributo nombre es protected en clase Empleado(base) las clases derivadas lo pueden ver y usar)
        }
        //Creacion de nuestras propias excepciones en el metodo propio de la clase programador:
        //Usando Excepcion generico:
        //public void Codear(int cantidad)
        //{//para avisarle q esta fuera de rango:
        //    if (cantidad >= 0 && cantidad <= 500)//si la cantidad q reciba por parametro 
        //    {//esta fuera d los rangos q yo acepto puedo producir una excepcion
        //        for (int i = 0; i < cantidad; i++)
        //        {
        //            Console.WriteLine($"LINEA {i + 1}");
        //            this.lineasPorHora++;//voy a incrementar lineas por hora
        //        }
        //    }
        //    else 
        //    {
        //        throw new Exception("La cantidad esta fuera de rango, valor aceptado >= 0 o =< 500");
        //    }
        //}
        //....................................................................
        //Usando el nombre de la clase "CantidadErronea" creada en LibreriaDeExcepciones
        /// <summary>
        /// Recibe una cantidad de lineas a codear
        /// </summary>
        /// <param name="cantidad">cantidad de lineas</param>
        /// <exception cref="CantidadErroneaException">
        /// Si cantidad esta por debajo de 0 o es mayor a 500
        /// </exception>
        public void Codear(int cantidad)
        {//para avisarle q esta fuera de rango:
            if (cantidad >= 0 && cantidad <= 500)//si la cantidad q reciba por parametro 
            {//esta fuera d los rangos q yo acepto puedo producir una excepcion
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine($"LINEA {i + 1}");
                    this.lineasPorHora++;//voy a incrementar lineas por hora
                }
            }
            else
            {
                throw new CantidadErroneaException("La cantidad esta fuera de rango, valor aceptado >= 0 o =< 500");
                //tengo q agregar la referencia de la libreria de excepciones
            }
        }

        public override string MostrarEdad(int fechaNacimiento)
        {
            return "No quiero mostrar edad ni ninguna otra cosa";
        }

    }
}
