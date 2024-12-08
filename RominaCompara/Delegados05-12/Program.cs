namespace Delegados05_12
{
    internal class Program
    {
        //DECLARACION DEL TIPO DE DELEGADO
        public delegate void DelegadoWhatsapp(string mensaje);//Todos los metodos a los q 
        //apunte ese delegado tienen q cumplir con esa firma
        static void Notificar(string nombre) 
        {
            Console.WriteLine($"Notificacion para: {nombre}");
        }
        static void MostrarMensaje(string mensaje) 
        {
            Console.WriteLine($"{mensaje}");
        }
        static void AnunciarPublicidad(string publicidad) 
        {
            Console.WriteLine("Rappi informa: " + publicidad);
        }
        //-Funcion Generica: puede recibir cualquier otra funcion o metodo q cumpla con la misma firma
        //maneja cualquier tipo de mensaje
        public static void ManejarMensaje(string mensaje, DelegadoWhatsapp delegado) 
        {
            Console.WriteLine(DateTime.Now);    
            delegado(mensaje);
        }
        static void Main(string[] args)
        {
            //Notificar("Juan");
            //MostrarMensaje("Che loco nos encontramos a la vuelta del club");
            //--------------------------------------------------------------
            //DelegadoWhatsapp miDelegado;//creo una variable para poder guardar una funcion
            //miDelegado = Notificar;
            //miDelegado("Juan");

            //miDelegado = MostrarMensaje;//ahora el delegado apunta a otro metodo
            //miDelegado("Che loco nos encontramos a la vuelta del club");
            //-------------------------------------------------------------
            ManejarMensaje("Juan", Notificar);//cumplo con q a una funcion puedo pasarle como parametro otra funcion.
            Thread.Sleep(2000);
            ManejarMensaje("Che loco nos encontramos a la vuelta del club",MostrarMensaje);
            Thread.Sleep(2000);
            ManejarMensaje("Tenes 2000 rapicheks para la compra de alcohol", MostrarMensaje);
        }
    }
    //Ciudadano de primera clase:un objeto,las funciones,cualquier instancia,funciones o metodos
    //-parametrizar: pasar un metodo como parametro de una funcion
    //
    //-asignar a una variable:
    //-retornar una funcion/metodo
    //funciones/metodos
    //----------------------------
    //Las funciones son como variables q guardan direcciones de memoria
    //**********************************
    //DELEGADOS:
}
