//ENTIDADES:
using System.Text;

namespace BibliotecaDeAlumnos_Ado03_12
{
    public class Alumno
    {
        int id;
        string nombre;
        int edad;
        string carrera;
        List<string> materias;
        string genero;
        bool pagoMatricula;
        public Alumno()
        {
            this.materias = new List<string>();//Ininializamos la lista en el constructo vacio por defecto
        }
        public Alumno(string nombre, int edad, string carrera, string genero, bool pagoMatricula, int id) : this()
        {
            this.nombre = nombre;
            this.edad = edad;
            this.carrera = carrera;
            this.genero = genero;
            this.pagoMatricula = pagoMatricula;
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        //Propiedad de la lista de materias:
        public List<string> Materias { get => materias; set => materias = value; }
        public string Genero { get => genero; set => genero = value; }
        public bool PagoMatricula { get => pagoMatricula; set => pagoMatricula = value; }
        //****************************************************
        //Propiedad que convierte la lista de materias en un string:Creo propertie para
        //q se muestren las materias en el DataGrew(se encarga de tomar las properties y mostrar los valores)
        //-Para separar elemenos donde haya espacio con Split:
        ////public string MisMaterias
        ////{

        ////    get
        ////    {
        ////        StringBuilder datos = new StringBuilder();
        ////        foreach (string materia in materias)//Recorremos cada materia en la lista
        ////        {//y cada vez q llamanmos a misMaterias concatena con un espacio la materia en un string
        ////            datos.AppendLine($"{materia} ");
        ////        }
        ////        return datos.ToString();//la propiedad retorna la lista(dato) convertida a un string
        ////    }
        ////    set 
        ////    {
        ////        this.Materias.AddRange(value.Split(" "));//Split: va a separar en pedasos
        ////    }
        ////}
        //////-------------------------------------------------------------
        ///-Delimitador para separar con guion bajo las materias: Usando Join
        public string MisMaterias
        {

            get
            {
                return string.Join(" - ", materias);
            }
            set
            {
                this.Materias.AddRange(value.Split(" - "));//Split: va a separar en pedasos
            }
        }
        public override string ToString()
        {
            string pago = "Matricula impaga";
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(this.id.ToString());
            datos.AppendLine(this.nombre);
            datos.AppendLine(this.edad.ToString());
            datos.AppendLine(this.carrera);
            datos.AppendLine(this.genero);
            datos.AppendLine("Materias: ");

            foreach (string materia in materias)
            {
                datos.AppendLine(materia.ToString());
            }
            if (pagoMatricula)
            {
                pago = "Matricula paga";
            }
            datos.AppendLine(pago);
            return datos.ToString();
        }

    }
}
