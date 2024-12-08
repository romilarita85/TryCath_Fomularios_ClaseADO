
namespace ClaseComEntreForm27_11
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void btn_multiplicacion_Click(object sender, EventArgs e)
        {
            double operandoUno;
            double operandoDos;
            double resultado;
            operandoUno = double.Parse(txt_numero1.Text);
            operandoDos = double.Parse(txt_numero2.Text);

            resultado = operandoUno * operandoDos;
           //MessageBox.Show($"El resultado de la multiplicacion entre {operandoUno} y {operandoDos} es: {resultado}");
            MessageBox.Show($"El resultado de la multiplicacion entre {operandoUno} y {operandoDos} es: {resultado}");

        }
        private void btn_suma_Click(object sender, EventArgs e)
        {
            double operandoUno;
            double operandoDos;
            double resultado;
            operandoUno = double.Parse(txt_numero1.Text);
            operandoDos = double.Parse(txt_numero2.Text);

            resultado = operandoUno + operandoDos;
            //MessageBox.Show($"El resultado de la multiplicacion entre {operandoUno} y {operandoDos} es: {resultado}");
            MessageBox.Show($"El resultado de la suma entre {operandoUno} y {operandoDos} es: {resultado}");
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            double operandoUno;
            double operandoDos;
            double resultado;
            operandoUno = double.Parse(txt_numero1.Text);
            operandoDos = double.Parse(txt_numero2.Text);

            resultado = operandoUno - operandoDos;
            //MessageBox.Show($"El resultado de la multiplicacion entre {operandoUno} y {operandoDos} es: {resultado}");
            MessageBox.Show($"El resultado de la resta entre {operandoUno} y {operandoDos} es: {resultado}");
        }

        

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            double operandoUno;
            double operandoDos;
            double resultado;
            operandoUno = double.Parse(txt_numero1.Text);
            operandoDos = double.Parse(txt_numero2.Text);

            if (operandoDos != 0)
            {
                resultado = operandoUno / operandoDos;
                MessageBox.Show($"El resultado de la divicion entre {operandoUno} y {operandoDos} es: {resultado}");
            }
            else 
            {
                MessageBox.Show($"Imposible dividir por cero", "Error!!");
            }
        }
    }
}
//Los formularios estan compuestos por 3 clases parciales.Las tres partial class forman una unica clase
//1-La parte grafica-visual (FormPrincipal[Diseño])
//2-La parte logica del comportamiento(FormPrincipalDesigner.cs)
//3-La parte donde damos funcionalidad a esos componentes(FormPrincipal.cs)
//
//EVENTOS DENTRO DEL FORMULARIO: CUANDO ROMPE LA PARTE GRAFICA
//por q por ejemplo elimine un evento
//Ver codigo -> Borrar solo la linea de error dentro del FormPrincipalDesignel.cs
//