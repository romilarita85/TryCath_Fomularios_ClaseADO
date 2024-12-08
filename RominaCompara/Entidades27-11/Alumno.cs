using System.Text;

namespace Entidades27_11
{
    public class Alumno
    {
        string nombre;
        int edad;
        string carrera;
        List<string> materias;
        string genero;
        bool pagoMatricula;

        public Alumno(string nombre, int edad, string carrera, string genero, bool pagoMatricula)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.carrera = carrera;
            //this.materias = materias;//no vamos a pasar la lista por el constructor
            materias = new List<string>();//Instanciamos la lista
            this.genero = genero;
            this.pagoMatricula = pagoMatricula;
        }
        //Vamos a cargar la lista directamente.
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public List<string> Materias { get => materias; set => materias = value; }
        public string Genero { get => genero; set => genero = value; }
        public bool PagoMatricula { get => pagoMatricula; set => pagoMatricula = value; }

        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
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
                datos.AppendLine("Matricula paga");
            }
            else 
            {
                datos.AppendLine("Matricula impaga");
            }
            return datos.ToString();
        }
    }
}
