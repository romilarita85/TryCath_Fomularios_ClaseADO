using BibliotecaDeAlumnos28_11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasesyForms28_11
{
    public partial class FrmPrincipal : Form
    {
        private List<Alumno> alumnos;//Creamos la lista
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        //Creamos un evento para q el boton Crear haga algo:
        //Si quiero mostrar un mesaggeBox:
        //private void btnCrear_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show("Cualquiera");
        //    
        //}///Show:Metodo q hace q un mensaje se vea
        //Si quiero q se vea el formulario de crear alumnos:
        //private void btnCrear_Click(object sender, EventArgs e)
        //{//Crear una instancia de la clase FrmAlumno
        //    FrmAlumno frmAlumno = new FrmAlumno();//->nueva instancia de formulario
        //    //Mostrar un formulario:lograr q se ejecute y se muestre:
        //  //El formulario tiene un tipo de respuesta q siempre va a ser un DialogResult
        //    DialogResult res;//Creo una variable del tipo DialogResult
        //    res = frmAlumno.ShowDialog();//leo esa res(respuesta) de mi formulario alumno

        //}
        ////Metodos para mostrar formulario:
        //Show:
        //ShowDialog:Q cuando termine de trabajar con el FrmAlumno automaticamente me lleva el principal
        //----------------------------------
        //DIALOGRESULT:Cualquier tipo de interaccion q yo tenga con un formulario tiene un tipo de respuesta
        //llamado DialogResult(propertie para saber q tipo de interaccion tuvo)
        //------------------------------------
        //Podemos tener condicional en el formPrincipal:
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {//instanciamos la lista
            alumnos = new List<Alumno>();
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {//Crear una instancia de la clase FrmAlumno
            FrmAlumno frmAlumno = new FrmAlumno();//->nueva instancia de formulario

            DialogResult res;//Creo una variable del tipo DialogResult
            res = frmAlumno.ShowDialog();//leo esa res(respuesta) de mi formulario alumno
            if (res == DialogResult.OK)//si la respuesta q me acaba de dar el formulario es == a algo del tipo DialogResult.Ok-> el alumno fue creado correctamente 
            {
                //Leer propertie y sacar alumno q acabo de crear
                alumnos.Add(frmAlumno.MiAlumno);

                MessageBox.Show("El alumno fue creado con exito");
            }
            else
            {
                MessageBox.Show("La creacion fue cancelada");
            }
            CargarContenedores();//Lo llamamos cada vez q vamos a crear un alumno
        }
        //Para agregar y mostrar:
        private void CargarContenedores() //Cargar listas o contenedores
        {
            dgwAlumnos.DataSource = null;
            lstAlumnos.Items.Clear();
                                     //atributo
            lstAlumnos.Items.AddRange(alumnos.ToArray());                
            dgwAlumnos.DataSource = alumnos;
        }
    }
}
