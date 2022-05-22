namespace appFactura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxProductos.Items.Add("Pantalon");
            cbxProductos.Items.Add("Camisa");
            cbxProductos.Items.Add("Gorra");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            listProductos.Items.Add(cbxProductos.SelectedItem);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /**
             * Pantaolon 30 soles
             * camisa 10 soles 
             * gorra 5 soles
             */

            double resultado = 0;
            
            int cantidadProductos = listProductos.Items.Count;

            for (int i = 0; i < cantidadProductos; i++)
            {
                string productoSeleccionado = listProductos.Items[i].ToString();

                if(productoSeleccionado == "Pantalon")
                {
                    resultado += 30;

                }else if (productoSeleccionado == "Camisa")
                {
                    resultado += 10;

                }
                else
                {
                    resultado += 5;

                }


            }

            if(txtPalabraClave.Text == "NAVIDAD")
            {
                resultado -= 10;
            }
            
            MessageBox.Show("El resultado es: " + resultado);

        }
    }
}