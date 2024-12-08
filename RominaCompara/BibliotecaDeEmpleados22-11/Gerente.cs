using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeEmpleados22_11
{
    public class Gerente:Empleado
    {
        //Atributos propios del Gerente:
        private double salarioBase;
        private int proyectosManejados;
        private List<string> titulos;
        //Properties:
        public double SalarioBase { get => salarioBase; set => salarioBase = value; }
        public int ProyectosManejados { get => proyectosManejados; set => proyectosManejados = value; }

       // Constructor:
        //ctor para la clase base q inicializa todo:
        public Gerente(int id, string nombre, string apellido, int edad, string departamento)
        : base(id, nombre, apellido, edad, departamento) //->indicamos q explicitamente estoy llamando al constructor de la clase base para 
        {//q empiece a construir la instancia.
            this.titulos = new List<string>();

        }
        //ctor propio de gerente: q se encarga de darle valores a los atributos
        public Gerente(int id, string nombre, string apellido, int edad, string departamento, double salario, int proyectosManejados)
        : this(id, nombre, apellido, edad, departamento) //->llamo al this
        {
            //Constructor gerente inicializa los atributos de la clase propia
            this.salarioBase = salario;
            this.proyectosManejados = proyectosManejados;
        }

        //Metodos propios de Gerente:algo especifico de un Gerente
        //Metodo para mostrar la cantidad de proyectos y aumentar
        public string AsignarProyecto()
        {
            string mensaje;
            this.proyectosManejados++;//voy a incrementar la cantidad de proyectos
            mensaje = $"{this.nombre} tiene un total de {this.proyectosManejados} proyectos";
            return mensaje;
        }

        public override string MostrarInformacion()
        {
            string mensaje = $"{base.MostrarInformacion()} - SALARIO: USD{this.salarioBase} - CANT.PROYECTOS: {this.proyectosManejados}";
            //implemetamos a la base -le agregamos mas informacion
            return mensaje;
        }
        public override string MostrarEdad(int fechaNaciemiento)
        {
            return $"Mi edad es de {this.edad} y naci en {fechaNaciemiento}";//sumo comportamiento
        }
        //public abstract bool EstaCasado(); // la clase Gerente es de instancia no puedo declarar metodos Abstractos


        //Sobrecarga de operador +
        //Cuando se encuentre con algo de la clase gerente y con algo del tipo string 
        //Va agarrar al gerente y va a cargar en su lista de titulos ese string q recibio 
        //y va a retornar el gerente nuevamente
        public static Gerente operator +(Gerente g, string titulo) 
        {
            g.titulos.Add(titulo);
            return g;
        }
        //MANEJO DE EXCEPCIONES:
        //*Si la lista no esta instanciada el metodo va a intentar acceder a la lista
        //y me va a tirar una falla->excepcion(error)
        //-Podemos usar una forma de fijarnos la nulidad de nuestro objeto usando el is not null)
    
        //public string MostrarTitulos() 
        //{
        //    StringBuilder sb = new StringBuilder();

        //    if (titulos is not null)
        //    {
        //        foreach (string item in titulos)
        //        {
        //            sb.AppendLine(item);
        //        }
        //    }
        //    return sb.ToString();
        //}
        //-Otra forma es usando Bloque de codigo Try-Catch
        //public string MostrarTitulos()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    try
        //    { 
        //        foreach (string item in titulos)
        //        {
        //            sb.AppendLine(item);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        sb.AppendLine("Imposible recorrer la lista");
        //    }

        //    return sb.ToString();
        //}
        //public string MostrarTitulos()
        //{
        //    StringBuilder sb = new StringBuilder();
            
        //    foreach (string item in titulos)
        //    {
        //        sb.AppendLine(item);
        //    }
  
        //    return sb.ToString();
        //}
        //-----------------------------------
        //Formas de usar el tryCatch con if-else
        //Revisando si es nulo con excepcion personalizada:
        //public string MostrarTitulos()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    if (titulos is not null)
        //    {
        //        foreach (string item in titulos)
        //        {
        //            sb.AppendLine(item);
        //        }
        //    }
        //    else 
        //    {
        //        throw new NullReferenceException("La lista es nula");
        //    }
            

        //    return sb.ToString();
        //}
        //------------------------------------------
        //Usando tryCatch de forma directa

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        public string MostrarTitulos()
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (string item in titulos)
                {
                    sb.AppendLine(item);
                }

            }
            catch (Exception ex)
            {

                throw new NullReferenceException("La lista es nula");
            }

            return sb.ToString();
        }
    }
}
