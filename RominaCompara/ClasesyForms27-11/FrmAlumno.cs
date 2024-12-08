using Entidades27_11;
namespace ClasesyForms27_11
{
    public partial class FrmAlumno : Form
    {
        public FrmAlumno()
        {
            InitializeComponent();
        }
        //Manejador del evento click del boton mostrar(btnMostrar_Click): Voy a traer 
        //todos los datos q estan en el formulario adentro de este metodo los voy a recuperar
        //Voy a crear a partir de esos datos un objeto
        //private void btnMostrar_Click(object sender, EventArgs e)
        //{//-Creo variables-> variables descartables q me sirven para guardar temporalmente los datos 
        ////q estoy trayendo desde la interfaz grafica-> a partir de esos datos->genero mi objeto
        //    string nombre = txtNombre.Text;
        //    int edad = int.Parse(txtEdad.Text);
        //    string carrera = cmbCarrera.SelectedText;
        //    string genero = "otro";//si no es masculino ni femenino->valor por defecto
        //    bool pagoMatricula = false;//por default

        //    if (rdoMasculino.Checked)//indica q de todos los radiobuttons q tengo
        //    {//dentro del formulario, el masculino esta tildado,esta chequeado-> el genero es Masculino
        //        genero = "Masculino"; //genero es masculino
        //    }
        //    else 
        //    {
        //        if (rdoFemenino.Checked)
        //        {
        //            genero = "Femenino";
        //        }
        //    }//si se cumple uno de los dos los seteo a masculino o femenino si no por defecto es false
        //    //Matricula:
        //    if (rdoSi.Checked)
        //    {
        //        pagoMatricula = true;
        //    }
        //    //-Con todos lo datos cargados ->voy a crear un objeto 
        //    Alumno miAlumno = new Alumno(nombre, edad, carrera, genero, pagoMatricula);
        //    //-Para mostrar el objeto: con el Metodo toString()-> me devuelve una cadena con todos los datos
        //    //como los sobrescribi en la clase Alumno
        //    //*Funciona como cuando usabamos el Console.WriteLine para mostrar info
        //    txtDato.Text = miAlumno.ToString(); 

        //}
        //otra forma dinamica de mostrar lo RadioButtons: ej por si tenemos varias opciones para pagar matricula
        //o varias opciones de genero
        private void btnMostrar_Click(object sender, EventArgs e)
        {//-Creo variables-> variables descartables q me sirven para guardar temporalmente los datos 
         //q estoy trayendo desde la interfaz grafica-> a partir de esos datos->genero mi objeto
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            string carrera = cmbCarrera.SelectedText;
            string genero = "otro";//si no es masculino ni femenino->valor por defecto
            bool pagoMatricula = false;//por default

            foreach (RadioButton rb in grpGenero.Controls)//Recorre cada radioButton y pregunta cual esta chequeado
            {
                if (rb.Checked)//si esta chequeado me va a devolver un texto asociado a "femenino,masculino o otro" 
                {//y lo guarda en la bariable genero
                    genero = rb.Text;
                    break;
                }
            }

            //Matricula:
            if (rdoSi.Checked)
            {
                pagoMatricula = true;
            }
            //-Con todos lo datos cargados ->voy a crear un objeto 
            Alumno miAlumno = new Alumno(nombre, edad, carrera, genero, pagoMatricula);
            
            //Para completar el objeto con la lista
            foreach (CheckBox chek in grpMaterias.Controls)
            {
                miAlumno.Materias.Add(chek.Text);
            }
            
            txtDato.Text = miAlumno.ToString();

        }
    }
}
//PATRON DE DISEÑO EN CAPAS:
//CAPAS:
//-INTERFAZ DE USUARIO
//-DE NEGOCIO
//-VISTA DE CONEXION DE DATOS