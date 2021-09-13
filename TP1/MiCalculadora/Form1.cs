using System.Windows.Forms;
using System.Text;
namespace Trabajo_Practico_1
{
    public partial  class  LaCalculadora : Form
    {


        public LaCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_click(object sender, System.EventArgs e)
        {
            this.lblResultado.Text = Calculadora.Operar(new Operando(this.txtNumero1.Text), 
                new Operando(this.txtNumero2.Text), 
                (string)this.cmbOperador.SelectedItem).ToString();
            CargarOperacionAListBox(OperacionAText() );

        }

        private void limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
            this.cmbOperador.SelectedIndex = 4;
            this.lstOperaciones.Items.Clear();
        }

        private void btnLimpiar_click(object sender, System.EventArgs e)
        {
            this.limpiar();
        }

        private void btnCerrar_click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_click(object sender, System.EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.lblResultado.Text.ToString());
            this.lblResultado.Text = Operando.DecimalBinario(this.lblResultado.Text);

            sb.AppendFormat(" ==> {0} " , this.lblResultado.Text.ToString());

            CargarOperacionAListBox(sb.ToString());
        }

        private void btnConvertirADecimal_Click(object sender, System.EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.lblResultado.Text.ToString());

            this.lblResultado.Text = Operando.BinarioDecimal(this.lblResultado.Text);

            sb.AppendFormat(" ==> {0} ", this.lblResultado.Text.ToString());

            CargarOperacionAListBox(sb.ToString());
        }

        private void LaCalculadora_Load(object sender, System.EventArgs e)
        {
            this.limpiar();
        }

        private void LaCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("Salir", "cerrar el form?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private string OperacionAText()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(" {0} {1} {2} = {3} ",
                txtNumero1.Text.ToString(),
                cmbOperador.SelectedItem.ToString(),
                txtNumero2.Text.ToString(),
                lblResultado.Text.ToString()
                );

            return sb.ToString();
        }



        private void CargarOperacionAListBox(string operacionActual)
        {
            lstOperaciones.Items.Add(operacionActual);
        }

        private void lstOperaciones_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {

        }
    }
}