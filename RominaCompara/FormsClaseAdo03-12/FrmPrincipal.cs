//UI-INTERFAZ DE USUARIO
using Biblioteca_Datos03_12;
using BibliotecaDeAlumnos_Ado03_12;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsClaseAdo03_12
{
    public partial class FrmPrincipal : Form
    {
        private List<Alumno> alumnos;//Creamos la lista
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarContenedores();
        }

        private void btnCrear_Click(object sender, EventArgs e)//CREAMOS UN ALUMNO
        {//-CREAMOS UN FORMULARIO->Crear una instancia de la clase FrmAlumno
            FrmAlumno frmAlumno = new FrmAlumno();//->nueva instancia de formulario            
            DialogResult res;
            res = frmAlumno.ShowDialog();//SI TO ESTA OK AGREGAMOS ESE ALUMNO A LA LISTA

            if (res == DialogResult.OK)//si dialog result esta en ok
            {
                //****NECESITAMOS INCERTAR ESE ALUMNO A LA BASE DE DATOS***
                //Ademas de agregar el elemento a la lista queremos agregar el objeto a la base de datos
                AlumnoADO.IncertarAlumno(frmAlumno.MiAlumno);//incerto el alumno en la base de datos
                MessageBox.Show("El alumno fue creado con exito");
            }
            else
            {
                MessageBox.Show("La creacion fue cancelada");
            }
            CargarContenedores();//CARGO LOS CONTENEDORES(RECORRO)
        }

        //Para agregar y mostrar:Cargar listas o contenedores
        private void CargarContenedores() //RECORRO LOS CONTENEDORES
        {

            lstAlumnos.Items.Clear();
            dgwAlumnos.DataSource = null;
            alumnos = AlumnoADO.SeleccionarAlumnos();
            //Por estas dos sentencias puedo ver en el FrmPrincipal los datos en el listBox y en el DataGrid
            lstAlumnos.Items.AddRange(alumnos.ToArray());//Convierto la lista en un array y lo agrego al listBox
            dgwAlumnos.DataSource = alumnos;//le enseño al dataGrid la forma q tiene el objeto q va a mostrar
                                            //*le enseñamos al dataGrid como mostrar el objeto

        }

        //------------------------------------------------
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Alumno alumnoSeleccionado = dgwAlumnos.CurrentRow.DataBoundItem as Alumno;//->OBJETO
            FrmAlumno formModificar = new FrmAlumno(alumnoSeleccionado);

            if (formModificar.ShowDialog() == DialogResult.OK)//si el resultado fue ok-> si el usuario dijo q si quiere modificar
            {
                AlumnoADO.ModificarAlumno(formModificar.MiAlumno);
            }
            CargarContenedores();//Refresco la lista-se actualizan los datos en la base de datos y el programa
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //obtengo el objeto de la fila seleccionada
            Alumno alumnoSeleccionado = dgwAlumnos.CurrentRow.DataBoundItem as Alumno;//->OBJETO
            int index = -1;
            FrmAlumno formEliminar = new FrmAlumno(alumnoSeleccionado);

            foreach (Control c in formEliminar.Controls)//ideal ponerlo en un metodo ej:bloquear componentes
            {
                if (c.GetType() != typeof(Button))
                {
                    c.Enabled = false;
                }
            }

            if (formEliminar.ShowDialog() == DialogResult.OK)
            {
                AlumnoADO.EliminarAlumno(formEliminar.MiAlumno.Id);
            }
            CargarContenedores();//Refresco la lista
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            int contadorMasculino = 0;
            foreach (Alumno al in alumnos)
            {
                if (al.Genero == "Masculino")
                {
                    contadorMasculino++;
                }
            }
            MessageBox.Show(contadorMasculino.ToString());
        }
    }
}
