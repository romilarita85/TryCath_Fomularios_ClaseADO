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

namespace ClasesyForms03_12
{
    public partial class FrmPrincipal : Form
    {
        private List<Alumno> alumnos;//Creamos la lista
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {//instanciamos la lista
            alumnos = new List<Alumno>();
        }

        private void btnCrear_Click(object sender, EventArgs e)//CREAMOS UN ALUMNO
        {//-CREAMOS UN FORMULARIO->Crear una instancia de la clase FrmAlumno
            FrmAlumno frmAlumno = new FrmAlumno();//->nueva instancia de formulario
                                                  //-ESTABLECEMOS UN DIALOGRESULT:
            DialogResult res;//Creo una variable del tipo DialogResult
            res = frmAlumno.ShowDialog();//leo esa res(respuesta) de mi formulario alumno
                                         //-EVALUAR SI ESTA TODO OK.->
            if (res == DialogResult.OK)//si dialog result esta en ok
            {
                //AGREGO EL ALUMNO Q SE ESTA CREANDO EN EL OTRO FORMULARIO(FORMALUMNO) A LA LISTA
                alumnos.Add(frmAlumno.MiAlumno);

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
            dgwAlumnos.DataSource = null;
            lstAlumnos.Items.Clear();
            //Por estas dos sentencias puedo ver en el FrmPrincipal los datos en el listBox y en el DataGrid
            lstAlumnos.Items.AddRange(alumnos.ToArray());//Convierto la lista en un array y lo agrego al listBox
            dgwAlumnos.DataSource = alumnos;//le enseño al dataGrid la forma q tiene el objeto q va a mostrar
            //*le enseñamos al dataGrid como mostrar el objeto
        }
        //------------------------------------------------------------------------------
        //Para el btnModificar vamos a trabajar con el DataGrid:
        ////private void btnModificar_Click(object sender, EventArgs e)
        ////{//Tengo encapsulado dentro del objeto un alumno:
        ////    //1-Desencapsular usando el "as"(alias):
        ////    Alumno alumnoSeleccionado = dgwAlumnos.CurrentRow.DataBoundItem as Alumno;//OBJETO
        ////    //2-Desencapsular usando conversion explicita a Alumno (casteo explicito):
        ////    //Alumno alumnoSeleccionado1 = (Alumno)dgwAlumnos.CurrentRow.DataBoundItem;
        ////    MessageBox.Show(alumnoSeleccionado.ToString());
        ////}
        //////DataGrid:Objeto para poder visualizar listas
        //////CurrentCell: me devuelve la celda seleccionada
        //////CurrentRow: me devuelve toda la fila donde yo este parado
        //------------------------------------------------
        private void btnModificar_Click(object sender, EventArgs e)
        {//Tengo encapsulado dentro del objeto un alumno:
            //-Desencapsular usando el "as"(alias):
            Alumno alumnoSeleccionado = dgwAlumnos.CurrentRow.DataBoundItem as Alumno;//->OBJETO

            //Al momento de crear el formulario alumno voy a cargar los datos del alumno q selecciones -los voy a modificar
            FrmAlumno formModificar = new FrmAlumno(alumnoSeleccionado);//le paso el alumno al formulario(uso la sobrecarga)
                                                                        //Para pasarle el objeto al formulario

            if (formModificar.ShowDialog() == DialogResult.OK)//si el resultado fue ok-> busco el alumno y lo reemplazo
            {
                for (int i = 0; i < alumnos.Count; i++)
                {//si de la lista de alumnos el alumno q esta en la posicion [i] (alumno actual)su id coincide con el id del alumno q modifique 
                    if (alumnos[i].Id == formModificar.MiAlumno.Id)// el alumno de la list con la instancia del formulario
                    {
                        alumnos[i] = formModificar.MiAlumno;
                        break;
                    }
                }
            }
            CargarContenedores();//Refresco la lista
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //obtengo el objeto de la fila seleccionada
            Alumno alumnoSeleccionado = dgwAlumnos.CurrentRow.DataBoundItem as Alumno;//->OBJETO
            int index = -1; // no lo encontro
           //creo una instancia del formulario
            FrmAlumno formModificar = new FrmAlumno(alumnoSeleccionado);
            //Bloqueo de los controles de formModificar: desabilito los controles para q no se puedan modificar
            //Y solo si es del tipo boton no los desabilita(boton aceptar y cancelar)
            foreach (Control c in formModificar.Controls)
            {
                if (c.GetType() != typeof(Button))
                {
                    c.Enabled = false;
                }
            }                                                         

            if (formModificar.ShowDialog() == DialogResult.OK)
            {//recorro la lista buscando el id
                for (int i = 0; i < alumnos.Count; i++)
                {
                    if (alumnos[i].Id == formModificar.MiAlumno.Id)
                    {//Guardo el index
                        index = i;//guardo i -> por q i es la instancia del objeto q va a eliminar
                        break;
                    }
                }
                if (index != -1)
                {
                    alumnos.RemoveAt(index);
                }
            }
            CargarContenedores();//Refresco la lista
        }
    }
}
