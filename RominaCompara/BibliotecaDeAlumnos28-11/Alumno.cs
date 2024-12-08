using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BibliotecaDeAlumnos28_11
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
        public Alumno(string nombre, int edad, string carrera, string genero, bool pagoMatricula,int id):this()
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
        public List<string> Materias { get => materias; set => materias = value; }
        public string Genero { get => genero; set => genero = value; }
        public bool PagoMatricula { get => pagoMatricula; set => pagoMatricula = value; }
     
        //Creo propertie para para q se muestren las materias en el DataGrew(se encarga de tomar las properties y mostrar los valores)
        
        public string MisMaterias 
        {

            get 
            {
                StringBuilder datos = new StringBuilder();
                foreach (string materia in materias)//Recorremos cada materia en la lista
                {//y cada vez q llamanmos a misMaterias concatena con un espacio la materia en un string
                    datos.AppendLine($"{materia} ");
                }
                return datos.ToString();//la propiedad retorna la lista(dato) convertida a un string
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
