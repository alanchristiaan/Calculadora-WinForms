// agregamos la libreria de Math
using static System.Math;
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


        // Este metodo es para no estar repitiendo las asignaciones dentro de los eventos
        private void PrepararOperacion(string simboloOperador)
        {
            numeroAnterior = double.Parse(txtNumeros.Text);
            operador = simboloOperador;
            txtNumeros.Text = "";
            txtNumeros.Focus();
        }

        //private void btnSumar_Click(object sender, EventArgs e)
        //{

        //}

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
            #region Operacion suma vieja
            //// Asignamos el numero ingresado a la variable inicializada al principio
            //numeroAnterior = double.Parse(txtNumeros.Text);

            //// Asignamos el operador + correspondiente al evento de este metodo
            //operador = "+";

            //// reiniciamos el texto del textbox a 0
            //txtNumeros.Text = "0";
            #endregion

            PrepararOperacion("+");
        }


        private void btnRestar_Click(object sender, EventArgs e)
        {
            PrepararOperacion("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            PrepararOperacion("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            PrepararOperacion("/");
        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
            PrepararOperacion("sqr");
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            PrepararOperacion("pow");
        }

        private void btnLogaritmo_Click(object sender, EventArgs e)
        {
            PrepararOperacion("log");
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            #region Operacion igual vieja

            // Asignamos el segundo numero a una nueva variable
            // double numeroActual = double.Parse(txtNumeros.Text);

            // Inicializamos una variable que sea el resultado
            //double resultado = 0;

            //if (operador == "+")
            //{
            //    resultado = numeroAnterior + numeroActual;
            //}

            //lblResultado.Text = resultado.ToString();
            #endregion


            double? resultado = null;
            if (operador == "sqr")
            {
                if (numeroAnterior >= 0)
                {

                    /* Si lo asigno en el switch la calculadora espera una operacion de numeroAnterior y numero actual
                     * poniendolo aca solo van las operaciones donde el hay un solo numero
                     * de todas formas hay que ponerle un return al final del codigo para que no siga recorriendo el evento porque sino va a saltar otro error
                     * */
                    resultado = Sqrt(numeroAnterior);
                    lblResultado.Text = resultado?.ToString() ?? "";
                    return;
                }
                else
                {
                    MessageBox.Show("Es una raiz compleja, no es posible realizar la operacion en el conjunto de los NUMEROS REALES", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                double numeroActual = double.Parse(txtNumeros.Text);
                switch (operador)
                {
                    case "+":
                        resultado = numeroAnterior + numeroActual;
                        break;

                    case "-":
                        resultado = numeroAnterior - numeroActual;
                        break;

                    case "*":
                        resultado = numeroAnterior * numeroActual;
                        break;

                    case "/":
                        if (numeroActual != 0)
                        {
                            resultado = numeroAnterior / numeroActual;
                        }
                        else
                        {
                            MessageBox.Show("No se puede dividir por 0", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        break;

                    case "pow":
                        resultado = Pow(numeroAnterior, numeroActual);
                        break;

                    case "log":
                        resultado = Log(numeroAnterior, numeroActual);
                        break;
                }


                lblResultado.Text = resultado?.ToString() ?? "";
            }
        }
    }
}
