namespace DelegadoCalculadora05_12
{
    internal class Program
    {
        //Firma del delegado:
        public delegate float DelegadoCalculadora(int a, int b);
        static void Main(string[] args)
        {   //Ejemplo 1:
            //DelegadoCalculadora delegado;
            //delegado = Calculos.Sumar;
            //float resultado = delegado(5, 7);
            //Console.WriteLine(resultado);
            //---------------------------------------
            //Ejemplo 2:Con lista de invocacion para ejecutar todos los metodos
            float resultado;
            DelegadoCalculadora delegado;
            delegado = Calculos.Sumar;
            delegado += Calculos.Restar;
            delegado += Calculos.Multiplicar;
            delegado += Calculos.Dividir;
            delegado += Calculos.Restar;//si quiero agregar restar para q se ejecute
            delegado -= Calculos.Multiplicar;//si quiero sacar la multiplicacion 

            //***LISTA DE INVOCACION***
            foreach (DelegadoCalculadora del in delegado.GetInvocationList())
            {
                resultado = del(5,9);
                Console.WriteLine(resultado);
            }
           
        }
        //Puedo
    }
}
