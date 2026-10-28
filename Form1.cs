namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        double numeroAnterior = 0;
        string operador = "";
        bool limpiarPantalla = false;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Establece que lo mostrado en el display de texto vuelva a 0
            txtNumeros.Text = "0";


            // Establece que se limpie en la memoria cualquier variable que haya quedado asignada
            numeroAnterior = 0;
            operador = "";
            limpiarPantalla = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Evaluamos la propiedad encadenada Length del texto
            if (txtNumeros.Text.Length > 1)
            {
                // Posición 0: inicio del texto.
                // Largo - 1: conserva todo excepto el último carácter.
                txtNumeros.Text = txtNumeros.Text.Substring(0, txtNumeros.Text.Length - 1);
            }
            else
            {
                // Si queda 1 solo carácter o está vacío, restablece la pantalla a cero
                txtNumeros.Text = "0";
            }
        }

        private void btnSumar_Click_1(object sender, EventArgs e)
        {
            // Asignamos el numero ingresado a la variable inicializada al principio
            numeroAnterior = double.Parse(txtNumeros.Text);

            // Asignamos el operador + correspondiente al evento de este metodo
            operador = "+";

            // reiniciamos el texto del textbox a 0
            txtNumeros.Text = "'0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Asignamos el segundo numero a una nueva variable
            double numeroActual = double.Parse(txtNumeros.Text);

            // Inicializamos una variable que sea el resultado
            double resultado = 0;

            if (operador == "+")
            {
                resultado = numeroAnterior + numeroActual;
            }

            lblResultado.Text = resultado.ToString();
        }
    }
}
