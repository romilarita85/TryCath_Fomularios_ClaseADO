using static Clase22_11.Program;
using System.Data;
using System.Reflection.Emit;
using System.Reflection;
using System;
using BibliotecaDeEmpleados22_11;
using LibreriaDeExcepciones22_11;

namespace Clase22_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado g1 = new Gerente(5, "Juan", "Ruiz", 33, "Contable", 1500, 3);
            Programador p1 = new Programador(10, "Pedro", "Gomez", 25, "Sistemas", 500, 10);
            Gerente g2 = new Gerente(6, "Maria", "Gomez", 44, "Contable", 1500, 3);
            Programador p2 = new Programador(7, "Pedro Jose", "Gomez", 22, "Sistemas", 500, 10);
            Gerente g3 = new Gerente(8, "Ana", "Perez", 36, "Contable", 1500, 3);
            Programador p3 = new Programador(9, "Pedro", "Gomez", 25, "Sistemas", 500, 10);
            Gerente g4 = new Gerente(11, "Juan Arnaldo", "Rodriguez", 26, "Contable", 1500, 3);
            Empleado sg1 = new Subgerente(11, "Juan Arnaldo", "Rodriguez", 26, "Contable", 1500, 3);
            Gerente sg2 = new Subgerente(12, "Juan Arnaldo", "Rodriguez", 26, "Contable", 1500, 3);
            Subgerente sg3 = new Subgerente(13, "Juan Arnaldo", "Rodriguez", 26, "Contable", 1500, 3);
            //Gerente g5 = new Gerente(99, "Raul");


            //Creo una lista de empleados:
            List<Empleado> lista = new List<Empleado>() { g1, g2, g3, g4, p1, p2, p3, sg1, sg2, sg3 };

            //g2 = g2 + "Mejora continua";//El codigo rompe en dos partes distintas
            //                            //-Cuando intenta agregar un elemento a la lista -> metodo con el operador mas
            //                            //-Cuando intenta mostrar la lista- Metodo Mostrar titulos


            //MANEJO DE EXCEPCIONES:
            //Puedo utilizar el try catch en el main para poder controlar las excepciones o fallas

            //try
            //{
            //    g2 = g2 + "Mejora continua";
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error al intentar agregar un elemento a la lista");

            //}

            //Console.WriteLine(g2.MostrarTitulos()); // va a tirar fallas -> es conveniente meterlo tmbien en un try cath

            ////Rompe cuando intenta mostrarlo-por q cuando intento ejecutar una excepcion q no esta 
            ////controlada el programa rompe.

            //-------------------------------------------------
            //try
            //{
            //    g2 = g2 + "Mejora continua";
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error al intentar agregar un elemento a la lista");
            //}

            //Console.WriteLine("Saliendo del primer try catch");

            //try
            //{
            //    Console.WriteLine(g2.MostrarTitulos());
            //}
            //catch (Exception)//->parentesis para atrapar la excepcion
            //{
            //    Console.WriteLine("Error al intentar mostrar la lista");

            //}

            //Console.WriteLine("Sali del segundo Trycatch");//Sale del catch y se sigue
            //ejecutando con normalidad.

            //---------------------------------------------------
            ////Excepcion: es la clase. Podemos darle nombre a las excepciones q atrapemos
            //*Podemos mostrar un mensaje con propiedad Message:
            //try
            //{
            //    g2 = g2 + "Mejora continua";
            //}
            //catch (Exception fallo)
            //{
            //    Console.WriteLine("Error al intentar agregar un elemento a la lista");
            //    Console.WriteLine($"Tipo de error:{fallo.Message}");
            //}

            //Console.WriteLine("Saliendo del primer try catch");

            //try
            //{
            //    Console.WriteLine(g2.MostrarTitulos());
            //}
            //catch (Exception fallo)//->parentesis para atrapar la excepcion
            //{
            //    Console.WriteLine("Error al intentar mostrar la lista");
            //    Console.WriteLine($"Tipo de error:{fallo.Message}");
            //}

            //Console.WriteLine("Sali del segundo Trycatch");//Sale del catch y se sigue
            //ejecutando con normalidad.

            //Son distintas excepciones con el mismo nombre de fantasia pero con distinto scope
            //Al darle nombre a la excepcion yo puedo tener acceso a las propiedades
            //*Propiedad Message: me dice por q esta fallando. Podemos mostrar un mensaje con propiedad Message
            //Es el mensaje q tiene por defecto en esa excepcion.
            //----------------------------------------------
            //*Propiedad StackTrace:(informacion) me dice donde esta el error.
            //muestra la ubicacion del archivo y el numero de linea donde esta el error
            //Hace el seguimiento de donde esta fallando en q metodo y se ejecuto el metodo.
            ////Se puede guardar en un registro de errores
            //try
            //{
            //    g2 = g2 + "Mejora continua";
            //    g2 = g2 + "Mejora continua2";
            //    g2 = g2 + "Mejora continua3";
            //    g2 = g2 + "Mejora continua4";
            //}
            //catch (Exception fallo)
            //{
            //    Console.WriteLine("Error al intentar agregar un elemento a la lista");
            //    Console.WriteLine($"Tipo de error:{fallo.StackTrace}");
            //}

            //Console.WriteLine("Saliendo del primer try catch");

            //try
            //{
            //    Console.WriteLine(g2.MostrarTitulos());
            //}
            //catch (Exception fallo)//->parentesis para atrapar la excepcion
            //{
            //    Console.WriteLine("Error al intentar mostrar la lista");
            //    Console.WriteLine($"Tipo de error:{fallo.Message}");
            //}

            //Console.WriteLine("Sali del segundo Trycatch");
            //Todo lo q este dento del catch solo se ejecuta si se produjo un error,
            //si no se produce ningun error lo skipea y hace lo q tiene q hacer
            //------------------------------------------------------------
            ////*Dentro de los catch puedo hacer adentro de los catch q sea necesario en caso 
            ////de que haya un error. Me da la posibilidad de hacer una accion evitando
            ////q mi programa rompa
            ////*Puedo contar las fallas:
            //int contarFallas = 0;
            //try
            //{
            //    g2 = g2 + "Mejora continua";
            //    g2 = g2 + "Mejora continua2";
            //    g2 = g2 + "Mejora continua3";
            //    g2 = g2 + "Mejora continua4";
            //}
            //catch (Exception fallo)
            //{
            //    Console.WriteLine("Error al intentar agregar un elemento a la lista");
            //    Console.WriteLine($"Tipo de error:{fallo.StackTrace}");
            //    contarFallas++;
            //}

            //Console.WriteLine("Saliendo del primer try catch");

            //try
            //{
            //    Console.WriteLine(g2.MostrarTitulos());
            //}
            //catch (Exception fallo)//->parentesis para atrapar la excepcion
            //{
            //    Console.WriteLine("Error al intentar mostrar la lista");
            //    Console.WriteLine($"Tipo de error:{fallo.Message}");
            //    contarFallas++;
            //}

            //Console.WriteLine($"Sali del segundo Trycatch con cantidad de fallas {contarFallas} fallas");
            //------------------------------------------------------------------------
            ////*Puedo tener multiples catch para un solo try (pero es optativo hacer varios catch o uno)
            ////*Siempre tiene q haber try y catch
            ////*Dentro del tryCatch puedo tener solo un try
            ///ES OBLIGATORIO Q TENGA UN TRY Y POR LO MENOS UN CATCH(O MAS-la cantidad de catch es optativa)
            ///*El trycatch puede tener un finally(es optativo)

            //------------------------------------------
            //BLOQUE CATCH GENERICO:agarro y pongo q agarre la excepcion y no me importa de q tipo viene lo guarda

            ////BLOQUE FINALLY: q aparte de lo q esta pasando siempre se ejecuta independientemente de cual de los caminos 
            ////este pasando (no le importa si salio bien o mal)
            ////El finally no precisa argumentos por algo no tiene parentesis- no recibe nada            
            ////y siempre se ejecuta.Es opcional-> Cuando creo el bloque no es obligatorio utilizarlo

            ////Si estamos trabajando con la conexion a una base de datos y en el finally siempre nos 
            ////encargamos q la conexion haya quedado cerrada
            ////Podemos tener el registro de si hubo fallas o no guardarla en un archivo
            //int contarFallas = 0;
            //try
            //{
            //    g2 = g2 + "Mejora continua";
            //    g2 = g2 + "Mejora continua2";
            //    g2 = g2 + "Mejora continua3";
            //    g2 = g2 + "Mejora continua4";
            //}
            //catch (Exception fallo)
            //{
            //    Console.WriteLine("Error al intentar agregar un elemento a la lista");
            //    Console.WriteLine($"Tipo de error:{fallo.Message}");
            //    contarFallas++;
            //}
            //finally
            //{
            //    Console.WriteLine("Finally del primer trycatch");
            //}

            //Console.WriteLine("Saliendo del primer try catch");

            //try
            //{
            //    Console.WriteLine(g2.MostrarTitulos());
            //}
            //catch (Exception fallo)//->parentesis para atrapar la excepcion
            //{
            //    Console.WriteLine("Error al intentar mostrar la lista");
            //    Console.WriteLine($"Tipo de error:{fallo.Message}");
            //    contarFallas++;
            //}
            //finally 
            //{
            //    Console.WriteLine("Finally del segundo trycatch");
            //}

            //Console.WriteLine($"Sali del segundo Trycatch con cantidad de fallas {contarFallas} fallas");

            //-----------------------------------------------------------------

            //int[] numeros = new int[5];

            ////Usando bloque trycatch
            //try
            //{
            //    numeros[8] = 67;//-> falla excepcion
            //}
            //catch (IndexOutOfRangeException)
            //{

            //    Console.WriteLine("Se esta superando los limites del array");
            //}
            //catch (Exception) 
            //{
            //    Console.WriteLine("Error inesperado");
            //}
            //------------------------------------------------------------------
            ////Si quiero pasar un char q es distinto a un array:
            //int[] numeros = new int[5];

            ////Usando bloque trycatch
            //try
            //{
            //    numeros[2] = 'd';//->me toma el char como un valor numerico del codigo ascci
            //    //si es un solo caracter tiene un valor numerico
            //    //guarda el valor numerico q tenga ese caracter

            //}
            //catch (IndexOutOfRangeException)
            //{

            //    Console.WriteLine("Se esta superando los limites del array");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error inesperado");
            //}
            //Console.WriteLine(numeros[2]);
            //-------------------------------------------------------
            //Si cargamos distintos valores para nuestro array:
            //int[] numeros = {2,0,45,22,422 };
            //double resultado = 0;
            ////Usando bloque trycatch
            //try
            //{
            //    //resultado = (double)numeros[2] / numeros[3];
            //    resultado = numeros[2] / numeros[1];
            //}
            //catch (IndexOutOfRangeException)
            //{

            //    Console.WriteLine("Se esta superando los limites del array");
            //}
            //catch (Exception) //->bloque generico
            //{
            //    Console.WriteLine("Error inesperado");
            //}
            //Console.WriteLine(resultado);
            //-------------------------------------------------
            ////Si no tengo el bloque generico va a romper
            // int[] numeros = { 2, 0, 45, 22, 422 };
            // double resultado = 0;
            // //Usando bloque trycatch sin metodo generico:
            // try
            // {
            //     resultado = numeros[2] / numeros[1];
            // }
            // catch (IndexOutOfRangeException)
            // {

            //     Console.WriteLine("Se esta superando los limites del array");
            // }

            //------------------------------------------------
            ////*Siempre q tengamos multiples catch la excepcion generica tiene q estar al final
            ////si esta antes q las demas me va a tidar error por q las otras excepciones no la van a 
            ////atrapar
            //int[] numeros = { 2, 0, 45, 22, 422 };
            //double resultado = 0;
            ////Usando bloque trycatch
            //try
            //{

            //    resultado = numeros[2] / numeros[1];
            //    //resultado = numeros[2] / numeros[-5];

            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Se esta superando los limites del array");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Imposible dividir por CERO");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Error inesperado");
            //}
            //finally 
            //{
            //    Console.WriteLine("Fin del try catch");
            //}
            //-------------------------------------------------------------
            //POSIBILIDAD DE CREAR NUESTRAS PROPIAS EXCEPCIONES:
            //Ejemplo excepcion creada en la clase Programador-Metodo Codear

            ////Usamos un programador:
            ////p1.Codear(510);//error System.Exeption

            //try
            //{
            //    p1.Codear(510);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //.......................................
            ////Podemos tener una lista de errores:
            //List<string> listaDeErrores = new List<string>();
            //try
            //{
            //    p1.Codear(510);
            //}
            //catch (Exception ex)
            //{
            //    listaDeErrores.Add(ex.Message);
            //    Console.WriteLine("Error al intentar usar el metodo codear");
            //}
            ////el error queda guardado dentro de mi lista

            //**********************************++++
            //En la asociacion no tengo agregada la libreria de excepciones pero si lo tengo en Biblioteca de 
            //empleados.
            //Si estoy incluyendo BibliotecaDeEmpleados tambien me incluia la LibreriaDeExcepciones
            List<string> listaDeErrores = new List<string>();
            try
            {
                p1.Codear(510);
            }
            catch (CantidadErroneaException ex)
            {
                listaDeErrores.Add(ex.Message);
                Console.WriteLine("Error al intentar usar el metodo codear");
            }
        }
    }
}
