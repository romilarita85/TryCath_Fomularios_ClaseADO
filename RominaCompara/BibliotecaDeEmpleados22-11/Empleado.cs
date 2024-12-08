namespace BibliotecaDeEmpleados22_11
{
    public abstract class Empleado
    {
        private int id;
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected string departamento;

        //Properties:
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Departamento { get => departamento; set => departamento = value; }

        //Constructores
        //Constructor de instancia: con sobrecargas
        //Regla: El q tiene mas llama al q tiene menos
        public Empleado(int id, string nombre, string apellido, int edad, string departamento) : this(id,nombre)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.departamento = departamento;
        }
        public Empleado(int id)
        {
            this.id = id;
        }

        protected Empleado(int id, string nombre) : this(id)
        {
            this.nombre = nombre;
        }

        public static string MetodoEstatico()
        {
            return "Soy un metodo estatico definido en la clase empleado";
        }
        public virtual string MostrarInformacion()
        {
            string mensaje;
            mensaje = $"Id: {this.id} - NOMBRE: {this.nombre},{this.apellido} -DPTO: {this.departamento} ";
            return mensaje;
        }
        public abstract string MostrarEdad(int fechaNacimiento);



       

    }
}
