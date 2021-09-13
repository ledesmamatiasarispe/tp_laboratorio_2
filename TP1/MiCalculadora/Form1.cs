using System.Windows.Forms;

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
            this.lblResultado.Text = Calculadora.Operar(new Operando(this.txtNumero1.Text), new Operando(this.txtNumero2.Text), (string
                )this.cmbOperador.SelectedItem).ToString();
        }

        private void limpiar()
        {
            this.txtNumero1.Text = null;
            this.txtNumero2.Text = null;
            this.lblResultado.Text = null;
            this.cmbOperador.SelectedItem = null;
            this.cmbOperador.SelectedItem = null;
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
            this.lblResultado.Text = Operando.DecimalBinario(this.lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, System.EventArgs e)
        {
            this.lblResultado.Text = Operando.BinarioDecimal(this.lblResultado.Text);
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
    }
}