//UI-INTERFAZ DE USUARIO-FORMULARIOS
using BibliotecaDeAlumnos_Ado03_12;

namespace FormsClaseAdo03_12
{
    public partial class FrmAlumno : Form
    {
        private Alumno miAlumno;//Atributo
        //Para obtener el dato del form de carga:Usamos una propertie para obtener el objeto
        // q estaba encapsulado dentro del formulario
        public Alumno MiAlumno //Propertie
        {
            get
            {
                return this.miAlumno;
            }
        }
        //Para poder comunicar una formulario con otro(o un objeto con otro)
        //Lo podemos hacer: 
        //-Atravez de metodos
        //-Atravez de Get y Set
        //-Con sobrecarga de constructores: una sobrecarga q recibe un objeto.Frm principal
        //le podria enviar a frmAlumno atravez del constructor el objeto.
        public FrmAlumno()
        {
            InitializeComponent();
        }
        public FrmAlumno(Alumno unAlumno)
        {
            InitializeComponent();
            miAlumno = unAlumno;
        }
        //En el load obtener c/propiedad de miAlumno(objeto) para ponerlo en mi formulario
        //Estoy haciendo el paso inverso-> estoy obteniendo de la lista el objeto grafico visual de un control
        //se lo paso al formulario-> el formulario lo desarma y lo vuelve a mostrar en sus controles
        //Del objeto hay q sacar informacion para cargarla en el formulario
        private void FrmAlumno_Load(object sender, EventArgs e)
        {
            if (miAlumno != null)
            {
                //Construir el objeto:(puedo usar propertie(es para afuera) o atributo-desde adentro del objeto lo podemos usar)
                numId.Value = miAlumno.Id;
                txtNombre.Text = miAlumno.Nombre;
                txtEdad.Text = miAlumno.Edad.ToString();
                cmbCarrera.Text = miAlumno.Carrera;

                foreach (RadioButton r in grpGenero.Controls)
                {
                    if (r.Text == miAlumno.Genero)
                    {
                        r.Checked = true;
                        break;
                    }
                }
                //Vamos a usar foreach anidado: por q tngo muchos elementos en una lista y 
                //muchos elementos en otra.
                foreach (string materia in miAlumno.Materias)//1°Foreach: va a recorrer la lista de materias
                {
                    foreach (CheckBox chk in grpMaterias.Controls)//2°Forech:va a recorrer la lista de controles del groupBox y en cada iteracion va a buscar si un objeto machea con otro objeto
                    {//si machea significa q el alumno curso la materia
                        if (chk.Text == materia)
                        {
                            chk.Checked = true;
                            break;
                        }
                    }
                }
                rdoNo.Checked = true;
                if (miAlumno.PagoMatricula)
                {
                    rdoSi.Checked = true;
                }
            }
        }

        //----------------------------------------------------
        private void btnAceptar_Click(object sender, EventArgs e)
        { //Crea la instancia del alumno:
            Alumno alumno = CrearAlumno();
            this.miAlumno = alumno;
            this.DialogResult = DialogResult.OK;//si salio todo bien

        }
        //----------------------------------------------
        //FORMAS DE RECORRER GROUPBOX CON FUNCIONES
        //1-Funcion sin parametro:Si recorriamos el groupbox para obtener el genero podemos trabajar directamente
        //sin recibirlo por parametro ni nada por q el groupbox de genero es propio del formulario->es un atributo del formulario
        //directamente lo recorro y obtenia q texto tengo seleccionado como true
        //no necesitaba recibirlo por parametro
        private string ObtenerGenero()
        {
            string genero = string.Empty;
            foreach (RadioButton rb in this.grpGenero.Controls)//Recorre cada radioButton y pregunta cual esta chequeado
            {
                if (rb.Checked)
                {
                    genero = rb.Text;
                    break;
                }
            }
            return genero;
        }
        //2-Funcion generica: q recibe un groupbox-> ese groupbox va tener adentro radiobutton
        //puedo agarrar y recorrerlo.Recorro la lista del groupbox y me saco el texto q tenga 
        //ese radiobutton, sin importarme si es de genero o pago matricula o de cualquier cosa

        private static string ObtenerTextGrp(GroupBox grp)//Funcion generica
        {
            string texto = string.Empty;
            foreach (RadioButton rb in grp.Controls)//Recorre cada radioButton y pregunta cual esta chequeado
            {
                if (rb.Checked)
                {
                    texto = rb.Text;
                    break;
                }
            }
            return texto;
        }
        //-------------------------------------------------------------------------
        //FORMAS DE RECORRER LOS CHEKBOX CON FUNCIONES:
        //1-Funcion para obtener las materias pasandole el alumno-CheckBox
        private void ObtenerMaterias(Alumno miAlumno)
        {
            foreach (CheckBox chek in grpMaterias.Controls)
            {
                if (chek.Checked)
                {
                    miAlumno.Materias.Add(chek.Text);
                }

            }
        }
        //2-Funcion generica: para recorrer los checkBox
        //q reciba la lista de controles de tipo checkbox
        private List<string> ObtenerMaterias(GroupBox grp)
        {
            List<string> list = new List<string>();//crear lista de tipo string
            foreach (CheckBox check in grp.Controls)
            {
                if (check.Checked)
                {
                    list.Add(check.Text);
                }
            }
            return list;

        }
        //-------------------------------------------------------------------
        //Crear un metodo q se encarge de instanciar un alumno
        private Alumno CrearAlumno()
        {
            //obtengo cada uno de los controles para llevarlos a una variable
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            string carrera = cmbCarrera.SelectedItem.ToString();
            string genero = "otro";//si no es masculino ni femenino->valor por defecto
            bool pagoMatricula = false;//por default
            int id = (int)numId.Value;

            genero = FrmAlumno.ObtenerTextGrp(grpGenero);

            if (rdoSi.Checked)
            {
                pagoMatricula = true;
            }

            Alumno miAlumno = new Alumno(nombre, edad, carrera, genero, pagoMatricula, id);//Convertir en un objeto
            //-Agregar ese objeto a la lista:
            //ObtenerMaterias(miAlumno);
            //-Agregar objeto a la lista usando funcion ObtenerMaterias:
            miAlumno.Materias = ObtenerMaterias(grpMaterias);

            return miAlumno;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
