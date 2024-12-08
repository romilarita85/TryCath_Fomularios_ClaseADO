////namespace DelegadosComparador05_12
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //DECLARACION DEL DELEGADO COMPARISON:
//            Comparison<Persona> comparadorEdad = Persona.CompararPorEdad;//
//            Comparison<Persona> comparadorNombre = Persona.CompararPorNombre;
//            List<Persona> list = new List<Persona>()
//            {
//               new Persona("Juan",32),
//               new Persona("Ana",38),
//               new Persona("Luis",22)
//            };
//            Console.WriteLine("Por edad");
//            list.Sort(comparadorEdad);
//            foreach (Persona persona in list)
//            {
//                Console.WriteLine(persona);
//            }
//            Console.WriteLine("Por nombre");
//            list.Sort(comparadorNombre);
//            foreach (Persona persona in list)
//            {
//                Console.WriteLine(persona);
//            }
//        }
//    }
//}
//----------------------------------------------------------------

//USANDO FUNCIONES ORDENAR:
//namespace DelegadosComparador05_12
//{
//    internal class Program
//    {

//        static void OrdenarListaPorNombre(List<Persona> lista)
//        {
//            Persona aux;
//            for (int i = 0; i < lista.Count; i++)
//            {
//                for (int j = i + 1; j < lista.Count; j++)
//                {
//                    if (lista[i].Nombre.CompareTo(lista[j].Nombre) > 0)
//                    {
//                        aux = lista[i];
//                        lista[i] = lista[j];
//                        lista[j] = aux;
//                    }
//                }
//            }
//        }
//        static void OrdenarListaPorEdad(List<Persona> lista)
//        {
//            Persona aux;
//            for (int i = 0; i < lista.Count; i++)
//            {
//                for (int j = i + 1; j < lista.Count; j++)
//                {
//                    if (lista[i].Edad.CompareTo(lista[j].Edad) > 0)
//                    {
//                        aux = lista[i];
//                        lista[i] = lista[j];
//                        lista[j] = aux;
//                    }
//                }
//            }
//        }
//        static void Main(string[] args)
//        {

//            List<Persona> list = new List<Persona>()
//            {
//               new Persona("Juan",32),
//               new Persona("Ana",38),
//               new Persona("Luis",22)
//            };
//            Console.WriteLine("Por nombre");
//            OrdenarListaPorNombre(list);
//            foreach (Persona persona in list)
//            {
//                Console.WriteLine(persona);
//            }
//            Console.WriteLine("Por edad");
//            OrdenarListaPorEdad(list);
//            foreach (Persona persona in list)
//            {
//                Console.WriteLine(persona);
//            }
//        }
//    }
//}
//---------------------------------

namespace DelegadosComparador05_12
{
    //USANDO FUCION GENERICA:
    internal class Program
    {
        public delegate int DelegadoComparador(Persona unaPersona,Persona otraPersona);
        //Funcion generica:para la accion de ordenar. Ordena cualquier cosa.
        //Podriamos hacer el mismo sort para cualquier tipo de lista
        static void MySort(List<Persona> lista,DelegadoComparador delegadito)
        {
            Persona aux;
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (delegadito(lista[i], lista[j]) > 0)//accion q viene dada por el delegado
                    {
                        aux = lista[i];
                        lista[i] = lista[j];
                        lista[j] = aux;
                    }
                }
            }
        }
        static void Main(string[] args)
        {  
            List<Persona>list = new List<Persona>() 
            {
               new Persona("Juan",32),
               new Persona("Ana",38),
               new Persona("Luis",22)
            };
            Console.WriteLine("Por nombre");
            MySort(list,Persona.CompararPorNombre);
            foreach (Persona persona in list)
            {
                Console.WriteLine(persona);
            }
            Console.WriteLine("Por edad");
            MySort(list,Persona.CompararPorEdad);
            foreach (Persona persona in list)
            {
                Console.WriteLine(persona);
            }
        }
    }
}
