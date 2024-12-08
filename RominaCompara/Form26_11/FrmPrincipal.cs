namespace Form26_11
{
    public partial class FrmPrincipal : Form
    {
        FrmPrueba miForm;//atributo
        public FrmPrincipal()//Constructor
        {
            InitializeComponent();//Metodo q inicializa todos los componentes
            //Se encuentra en el FormPrincipalDesigner.cs donde instancia todos los componentes del formulario
        }

        #region Manejador de Eventos-metodo btnMostrar_Click-Distintas formas
        //
        //Metodo(manejador de eventos): accion q se va a ejecutar cuando el usario haga click en el boton "Mostrar" 
        //------------------------------------------------------------------------------------------------------
        //private void btnMostrar_Click(object sender, EventArgs e)//->MANEJADOR DEL EVENTO CLICK DEL BOTON-Atiende lo q va hacer el usuario cuando haga click en el boton
        //{
        //    //Implementacion del metodo:lo q va a pasar cuando haga click en el boton
        //    lblDato.Text = "CFP N°6";//Cuando se precione el boton el texto del laber va a cambiar
        //         //.propiedades,
        //         //.metodos,
        //         //.eventos
        //}
        //----------------------------------------------------------------------------------------------
        //-Si quiero escribir dentro del texbox y q al apretar el boton Mostrar q lblDato(miDato) cambie
        //Funcion btnMostrar_click manejada por el evento click del boton 
        //private void btnMostrar_Click(object sender, EventArgs e)//->MANEJADOR DEL EVENTO CLICK DEL BOTON-Atiende lo q va hacer el usuario cuando haga click en el boton
        //{
        //    //obtengo el nombre:
        //    string nombre;
        //    nombre = txtNombre.Text;
        //    //Muestro el nombre:
        //    lblDato.Text = nombre;
        //}
        //-----------------------------------------------
        //-Si quiero mostrar el nombre y la edad dentro del label(lblEdad)
        //private void btnMostrar_Click(object sender, EventArgs e)//->MANEJADOR DEL EVENTO CLICK DEL BOTON-Atiende lo q va hacer el usuario cuando haga click en el boton
        //{
        //    string nombre;
        //    int edad;
        //    nombre = txtNombre.Text;
        //    edad = int.Parse(txtEdad.Text);
        //    lblDato.Text = nombre + " - " + edad;
        //}
        //---------------------------------------------
        //Usando excepciones: en el caso de que en txtEdad pase algo de tipo string tira una excepcion. 
        //Utilizo try-catch para controlar esa excepcion.
        //Si no puede parcear lanza una excepcion- la captura el catch y en vez de mostrar el dato muestra error
        //private void btnMostrar_Click(object sender, EventArgs e)//->MANEJADOR DEL EVENTO CLICK DEL BOTON-Atiende lo q va hacer el usuario cuando haga click en el boton
        //{
        //    string nombre;
        //    int edad;
        //    try
        //    {
        //        nombre = txtNombre.Text;
        //        edad = int.Parse(txtEdad.Text);
        //        lblDato.Text = nombre + " - " + edad;

        //    }
        //    catch (Exception ex)
        //    {

        //        lblDato.Text = "¡¡¡Error!!!";
        //    }
        //}
        #endregion
        //----------------------------------------------------------------------------------
        //MESSAGEBOX:
        //Es otra forma de interactuar con el usuario es atravez del MessageBox
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre;
            int edad;
            try
            {
                nombre = txtNombre.Text;
                edad = int.Parse(txtEdad.Text);

                MessageBox.Show(nombre + " - " + edad, "Datos");
                //Propiedad Enabled: podemos habilitar o desabilitar un control
                //Puedo hacer q luego de mostrar los datos:
                txtEdad.Enabled = false;//desabilite el control txtEdad

            }
            catch (Exception ex)
            {

                lblDato.Text = "¡¡¡Error!!!";
            }
        }
        //--------------------------------------------------------------------------
        //EVENTO FORMCLOSING CON MESSAGEBOX
        //-Si quiero evitar q se cancele el cierre de un formulario-
        //Desde propiedades -EVENTO- doble click en el evento FORMCLOSING y me tira o abre
        //un manejador para ese evento:
        //private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        //{//Mientras se este cerrando algo va a pasar
        //    MessageBox.Show("lalala");//se comporta como un alert
        //    //FormClosing se deja de ejecutar y se lo manda al FormClosed(q lo cierra)
        //}
        //--------------------------------------------------------------------------------

        //-Puedo hacer q el messaggeBox se comporte como un Confirm:
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {//sender:el bojeto(formulario) q causo el evento formClosing
         //e: es el evento q trae informacion del evento. Lo podemos manipular

            DialogResult dialogo = MessageBox.Show("Seguro que quiere salir", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //clase estatica.----("mensaje de tipo string", "  "   ,enumerado-------------- ,icono enumerado con distintas alternativas);               
            //Show: devuelve algo del tipo DialogResult

            if (dialogo == DialogResult.No)
            {
                e.Cancel = true; //Cancelo el evento, lo dejo sin efecto
            }
        }//Mostre un formulario(MessageBox) q es un dialogResul con ciertas caracteristicas y 
        //eso me devolvio un DialogResult y si el usuario puso q "NO" cancelo el evento

        //Metodo Close: Va a disparar la seguidilla de eventos q me permite cerrar el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();//Close() dispara el evento FrmClosing
        }
        //Metodo:
        //private void btnCrear_Click(object sender, EventArgs e)
        //{
        //    FrmPrueba miForm = new FrmPrueba();//creo una instancia del FrmPrueba(formulario prueba)
        //    miForm.Show();
        //}
        //Show:sirve para mostrar el fomulario

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.miForm = new FrmPrueba();//instancio atributo
            this.miForm.Show();
        }
        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.miForm.Hide();

        }

        private void btnDesocultar_Click(object sender, EventArgs e)
        {
            this.miForm.Show();
        }

        private void btnCerrarSec_Click(object sender, EventArgs e)
        {
            this.miForm.Close();
        }
    }
}
//*Texbox: caja de texto ej: la caja de texto de un navegador o la barra de direcciones de un navegador
//Tienen propiedades
//Por default poner txt adelante q cuando tenga distintos texbox puedo utilizar el nombre de la variable a mi favor

//Text: La mayoria de los controles heredan de la clase Control y la clase control define la propiedad Text
//Tanto los texbox como los label tiene la propiedad text que es de lectura o de escritura o de solo 
//lectura y escritura.Tiene get y set

//this: instancia- llamamos a la instancia del formulario
