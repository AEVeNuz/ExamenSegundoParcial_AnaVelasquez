using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        ProductoDA productoDA = new ProductoDA();
        string operacion = string.Empty;
        PedidoDA pedidoDA = new PedidoDA();
        Producto producto;
        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            CodigoTextBox.Enabled = true;
            NombreClienteTextBox.Enabled = true;
            CantidadProductoTextBox.Enabled = true;
            IdProductoTextBox.Enabled = true;
            NuevoButton.Enabled = false;
            GuardarButton.Enabled = true;
        }

        private void DesabilitarControles()
        {
            CodigoTextBox.Enabled = false;
            NombreClienteTextBox.Enabled = false;
            CantidadProductoTextBox.Enabled = false;
            IdProductoTextBox.Enabled = false;
            NuevoButton.Enabled = true;
            GuardarButton.Enabled = false;
        }

        private void LimpiarControles()
        {
            CodigoTextBox.Clear();
            TotaltextBox.Clear();
            CantidadProductoTextBox.Clear();
            NombreClienteTextBox.Clear();
            IdProductoTextBox.Clear();
        }

        
        private void FrmPedido_Load(object sender, EventArgs e)
        {
            ListarPedidos();
        }
        private void ListarPedidos()
        {
            PedidoDataGridView.DataSource = pedidoDA.ListarPedidos();
        }

        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CodigoTextBox.Text))
                {
                    errorProvider1.SetError(CodigoTextBox, "Ingrese el Id del Pedido");
                    CodigoTextBox.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(TotaltextBox.Text))
                {
                    errorProvider1.SetError(TotaltextBox, "Ingrese el total");
                    TotaltextBox.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(CantidadProductoTextBox.Text))
                {
                    errorProvider1.SetError(CantidadProductoTextBox, "Ingrese la cantidad");
                    CantidadProductoTextBox.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(NombreClienteTextBox.Text))
                {
                    errorProvider1.SetError(NombreClienteTextBox, "Ingrese el Nombre del Cliente");
                    NombreClienteTextBox.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(IdProductoTextBox.Text))
                {
                    errorProvider1.SetError(IdProductoTextBox, "Ingrese el codigo del producto");
                    IdProductoTextBox.Focus();
                    return;
                }

                Pedido pedido = new Pedido();
                pedido.Cliente = NombreClienteTextBox.Text;
                pedido.Total = Convert.ToDecimal(TotaltextBox.Text);
                pedido.Cantidad = Convert.ToInt32(CantidadProductoTextBox.Text);
                pedido.IdProducto = IdProductoTextBox.Text;
                pedido.Codigo = Convert.ToInt32(CodigoTextBox.Text);

                if (operacion == "Nuevo")
                {
                    bool inserto = pedidoDA.InsertarPedidos(pedido);

                    if (inserto)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        ListarPedidos();
                        MessageBox.Show("Pedido insertado");
                    }
                }

            }
            catch (Exception ex)
            {
            }
        }

        private void CodigoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                producto = new Producto();
                producto = productoDA.GetProductoPorCodigo(IdProductoTextBox.Text);
                /*DescripcionTextBox.Text = producto.Descripcion;
                PrecioTextBox.Text = Convert.ToString(producto.Precio);
                TotaltextBox.Text = Convert.ToString(Convert.ToDecimal(PrecioTextBox.Text) * Convert.ToDecimal(CantidadProductoTextBox.Text)); ;*/
            }
            else
            {

            }
        }

        private void CodigoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
