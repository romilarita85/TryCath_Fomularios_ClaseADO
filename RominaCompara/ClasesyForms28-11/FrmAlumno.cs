#region Formalumno con texto multilinea/con ListBox-DataGriew
//using BibliotecaDeAlumnos28_11;

//namespace ClasesyForms28_11
//{
//    //Salvo los constructores, todos lo metodos y eventos estan encapsulados dentro del formulario
//    //Por fuera si quiero mostrar algo hare una propertie o algo particular para exponer la informacion
//    public partial class FrmAlumno : Form //partial class -> parte logica donde decidimos q hacer con cada evento
//    {
//        //Atributos de la clase frmalumno: podemos crear nuevos atributos q van a ser propios de la clase formulario
//        //mientras el formulario esta en ejecucion lo atributos van a tener los valores guardados y pueden ejecutarse distintos 
//        //metodos y se van a ir cargando estos atributos
//        List<Alumno> alumnos;

//        //Puedo tener mas de un constructor dentro de la clase
//        public FrmAlumno()//constructor del formulario
//        {
//            InitializeComponent();
//        }

//        //public FrmAlumno(List<Alumno>list):this()
//        //{
//        //    alumnos = list;
//        //}
//        //Pero generalmente en el formulario de alta no hacemos sobrecarga de constructores
//        //-Instanciamos la lista la lista dentro del evento Load:
//        private void FrmAlumno_Load(object sender, EventArgs e)
//        {
//            alumnos= new List<Alumno>();    
//        }
//        //-----------------------------------------------------------------------------------
//        //Metodo btn_mostrar sin funciones:
//        //private void btnMostrar_Click(object sender, EventArgs e)
//        //{
//        //    string nombre = txtNombre.Text;
//        //    int edad = int.Parse(txtEdad.Text);
//        //    string carrera = cmbCarrera.SelectedItems.ToString();
//        //    string genero = "otro";//si no es masculino ni femenino->valor por defecto
//        //    bool pagoMatricula = false;//por default
//        //    int id = (int)numId.Value;
//        //    //Genero
//        //    foreach (RadioButton rb in grpGenero.Controls)//Recorre cada radioButton y pregunta cual esta chequeado
//        //    {
//        //        if (rb.Checked)
//        //        {
//        //            genero = rb.Text;
//        //            break;
//        //        }
//        //    }

//        //    //Matricula:
//        //    if (rdoSi.Checked)
//        //    {
//        //        pagoMatricula = true;
//        //    }
//        //    //-Con todos lo datos cargados ->voy a crear un objeto ->alumno
//        //    Alumno miAlumno = new Alumno(nombre, edad, carrera, genero, pagoMatricula, id);

//        //    //Para completar el objeto con la lista de materias:
//        //    foreach (CheckBox chek in grpMaterias.Controls)
//        //    {
//        //        miAlumno.Materias.Add(chek.Text);
//        //    }

//        //    txtDato.Text = miAlumno.ToString();
//        //   //-La lista q ya instanciamos en el load le podemos dar valor del alumno q acabamos de crear
//        //    alumnos.Add(miAlumno);
//        //}
//        //----------------------------------------------------------------------------------------------
//        //Metodo btnMostrar con funciones:
//        //private void btnMostrar_Click(object sender, EventArgs e)
//        //{
//        //    string nombre = txtNombre.Text;
//        //    int edad = int.Parse(txtEdad.Text);
//        //    string carrera = cmbCarrera.SelectedItems.ToString();
//        //    string genero = "otro";//si no es masculino ni femenino->valor por defecto
//        //    bool pagoMatricula = false;//por default
//        //    int id = (int)numId.Value;
//        //    //Genero:
//        //    //genero = ObtenerGenero();
//        //    genero = FrmAlumno.ObtenerTextGrp(grpGenero);
//        //    //Matricula:
//        //    if (rdoSi.Checked)
//        //    {
//        //        pagoMatricula = true;
//        //    }
//        //    //-Con todos lo datos cargados ->voy a crear un objeto ->alumno
//        //    Alumno miAlumno = new Alumno(nombre, edad, carrera, genero, pagoMatricula, id);

//        //    //Para completar el objeto con la lista de materias:
//        //    ObtenerMaterias(miAlumno);//cargar materias

//        //    txtDato.Text = miAlumno.ToString();
//        //    //-La lista q ya instanciamos en el load le podemos dar valor del alumno q acabamos de crear
//        //    alumnos.Add(miAlumno);
//        //}
//        //---------------------------------------------------------------
//        //Otra fomra: Metodo btnMostrar con funciones: 
//        //private void btnMostrar_Click(object sender, EventArgs e)
//        //{
//        //    Alumno alumno = CrearAlumno();//instanciamos con un solo metodo
//        //    txtDato.Text = alumno.ToString();//lo mostramos
//        //}
//        //--------------------------
//        //COMPONENTE LIST BOX:
//        //Si quiero mostrar todo lo q tengo en mi lista:
//        //Usamos listBox-q utiliza la propertie items ya no Text como en 
//        //los otros componentes
//        //private void btnMostrar_Click(object sender, EventArgs e)//->Metodo q tira error por q uso propiedad Text
//        //{
//        //    Alumno alumno = CrearAlumno();//instanciamos con un solo metodo
//        //    alumnos.Add(alumno);

//        //    foreach (Alumno al in alumnos)
//        //    {
//        //        lstAlumnos.Text += al.ToString();
//        //    }
//        //}
//        //USANDO PROPERIE ITEMS:
//        //private void btnMostrar_Click(object sender, EventArgs e)//->Metodo q tira error por q uso propiedad Text
//        //{
//        //    Alumno alumno = CrearAlumno();//instanciamos con un solo metodo
//        //    lstAlumnos.Items.Add(alumno.ToString());//lista donde puedo guardar objetos dentro de la lista
//        //}
//        //-Dentro de la lista (listBox) puedo guardar cualquier tipo de objeto:
//        //Ejemplo:
//        //private void btnMostrar_Click(object sender, EventArgs e)//->Metodo q tira error por q uso propiedad Text
//        //{
//        //    Alumno alumno = CrearAlumno();//instanciamos con un solo metodo
//        //    CualquierCosa cc = new CualquierCosa();
//        //    lstAlumnos.Items.Add(alumno);//lista donde puedo guardar objetos dentro de la lista
//        //    lstAlumnos.Items.Add(cc);
//        //}
//        //Si quiero saber de q tipo son los objetos q agregue a la lista:
//        //private void btnMostrar_Click(object sender, EventArgs e)//->Metodo q tira error por q uso propiedad Text
//        //{
//        //    Alumno alumno = CrearAlumno();//instanciamos con un solo metodo
//        //    CualquierCosa cc = new CualquierCosa();
//        //    lstAlumnos.Items.Add(alumno);//lista donde puedo guardar objetos dentro de la lista
//        //    lstAlumnos.Items.Add(cc);
//        //    foreach (object obj in lstAlumnos.Items)
//        //    {
//        //        MessageBox.Show($"es del tipo {obj.GetType().Name}");
//        //    }
//        //}
//        //----------------------------------------------------------------------------------------------------------
//        //Usando metodo CargarListBox:
//        private void btnMostrar_Click(object sender, EventArgs e)//->Metodo q tira error por q uso propiedad Text
//        {
//            Alumno alumno = CrearAlumno();//instanciamos con un solo metodo

//            lstAlumnos.Items.Add(alumno);//lista donde puedo guardar objetos dentro de la lista
//            CargarListBox();
//        }
//        //----------------------------------------------
//        //Creamos funciones o metodos propios de formulario:

//        //private string ObtenerGenero(GroupBox gpr) //Metodo q recibe groupbox por parametro
//        //{
//        //    string genero = string.Empty;
//        //    foreach (RadioButton rb in grpGenero.Controls)//Recorre cada radioButton y pregunta cual esta chequeado
//        //    {
//        //        if (rb.Checked)
//        //        {
//        //            genero = rb.Text;
//        //            break;
//        //        }
//        //    }
//        //    return genero;
//        //}
//        //*Si esta dentro de la clase y lo q intentamos recorrer un atributo q corresponde a la clase
//        //no hace falta q no reciba por parametro
//        //Puedo trabajar directamente con el atributo q le corresponde al formulario

//        private string ObtenerGenero() //Metodo q recibe groupbox por parametro
//        {
//            string genero = string.Empty;
//            foreach (RadioButton rb in this.grpGenero.Controls)//Recorre cada radioButton y pregunta cual esta chequeado
//            {
//                if (rb.Checked)
//                {
//                    genero = rb.Text;
//                    break;
//                }
//            }
//            return genero;
//           //obtiene el valor del texto de un groupbox donde solo va a trabajar con los de generos 
//        }//si quiero recorrer otro grupo de radiobuton tengo q hacer otro metodo 

//        //Otra forma de hacer metodo Obtener Genero: Hacer un metodo reutilizable de tipo estatico
//        //donde no va a importar q groupBox yo le pase lo va a recorrer y me va a traer el valor
//        //de ese groupBox
//        private static string ObtenerTextGrp(GroupBox grp)
//        {
//            string genero = string.Empty;
//            foreach (RadioButton rb in grp.Controls)//Recorre cada radioButton y pregunta cual esta chequeado
//            {
//                if (rb.Checked)
//                {
//                    genero = rb.Text;
//                    break;
//                }
//            }
//            return genero;
//        }//En este metodo no importa lo q yo le pase me va a devolver el text de lo q yo estoy cargando
//        //Metodo Obtener Materias
//        //miAlumno no es propio del formulario y voy a necesitar recibir algo de tipo alumno
//        private void ObtenerMaterias(Alumno miAlumno) 
//        {
//            foreach (CheckBox chek in grpMaterias.Controls)
//            {
//                miAlumno.Materias.Add(chek.Text);
//            }

//        }
//        //Crear un metodo q se encarge de instanciar un alumno
//        private Alumno CrearAlumno() 
//        {
//            string nombre = txtNombre.Text;
//            int edad = int.Parse(txtEdad.Text);
//            string carrera = cmbCarrera.SelectedItem.ToString();
//            string genero = "otro";//si no es masculino ni femenino->valor por defecto
//            bool pagoMatricula = false;//por default
//            int id = (int)numId.Value;

//            genero = FrmAlumno.ObtenerTextGrp(grpGenero);

//            if (rdoSi.Checked)
//            {
//                pagoMatricula = true;
//            }
//            Alumno miAlumno = new Alumno(nombre, edad, carrera, genero, pagoMatricula, id);
//            ObtenerMaterias(miAlumno);
//            return miAlumno;
//        }
//        //-----------------------------------------------------
//        //Metodo q se encargue de guardar alumnos en el listbox:
//        //Usando listBox:
//        //private void CargarListBox() 
//        //{
//        //    lstAlumnos.Items.Clear();//Clear para q no se repitan los datos
//        //    lstAlumnos.Items.AddRange(alumnos.ToArray());
//        //    //el lisBox precisa un array-trabaja con colecciones de tipo array
//        //}
//        //--------------
//        //Usando DataGriew y listBox:
//        private void CargarListBox()
//        {
//            lstAlumnos.Items.Clear();//Clear para q no se repitan los datos
//            dgwAlumnos.DataSource = null;
//            lstAlumnos.Items.AddRange(alumnos.ToArray());
//            //el lisBox precisa un array-trabaja con colecciones de tipo array
//            dgwAlumnos.DataSource = alumnos;
//        }
//    }
//}
#endregion
//**************************************************************************
//COMUNICACION ENTRE FORMULARIOS:
//FrmAlumno sin DataGriew-listBox
using BibliotecaDeAlumnos28_11;
namespace ClasesyForms28_11
{
    public partial class FrmAlumno : Form //partial class -> parte logica donde decidimos q hacer con cada evento
    {
        private Alumno miAlumno;//Atributo

        public Alumno MiAlumno //Propertie
        {
            get
            {
                return this.miAlumno;
            }
        }

        public FrmAlumno()//constructor del formulario
        {
            InitializeComponent();
        }
        //-Instanciamos la lista la lista dentro del evento Load:
        private void FrmAlumno_Load(object sender, EventArgs e)
        {

        }
        //----------------------------------------------------
        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Crea la instancia del alumno:
            Alumno alumno = CrearAlumno();
            this.miAlumno = alumno;
            this.DialogResult = DialogResult.OK;//si salio todo bien
        }//this:hace referencia a este formulario
        //----------------------------------------------
        private string ObtenerGenero() //Metodo q recibe groupbox por parametro
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
        private static string ObtenerTextGrp(GroupBox grp)
        {
            string genero = string.Empty;
            foreach (RadioButton rb in grp.Controls)//Recorre cada radioButton y pregunta cual esta chequeado
            {
                if (rb.Checked)
                {
                    genero = rb.Text;
                    break;
                }
            }
            return genero;
        }
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
        //Crear un metodo q se encarge de instanciar un alumno
        private Alumno CrearAlumno()
        {
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
            Alumno miAlumno = new Alumno(nombre, edad, carrera, genero, pagoMatricula, id);
            ObtenerMaterias(miAlumno);
            return miAlumno;
        }
    }
}
