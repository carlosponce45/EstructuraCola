namespace Estructura_Cola
{
    public partial class Form1 : Form
    {
        Cola cola = new Cola();
        int orden = 1;
        public Form1()
        {
            InitializeComponent();
            txtOrden.Text = orden.ToString();
            cola.listar(lstCola);
        }

        private void cmdInsertar_Click(object sender, EventArgs e)
        {
            cola.insertar(orden);
            orden++;
            txtOrden.Text = orden.ToString();
            cola.listar(lstCola);
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cola.eliminar());
            cola.listar(lstCola);
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cola.buscarPosicion(int.Parse(txtFiltro.Text)));

        }
    }
}