using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class FrmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void ribbonControlAdv1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        FrmPedido frmPedido= null;
        private void PeddidoToolStripButton_Click(object sender, EventArgs e)
        {
            if (frmPedido == null)
            {
                frmPedido = new FrmPedido();
                frmPedido.MdiParent = this;
                frmPedido.Show();
            }
            else
            {
                frmPedido.Activate();
            }
        }

        FrmProducto frmProducto = null;
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (frmProducto == null)
            {
                frmProducto = new FrmProducto();
                frmProducto.MdiParent = this;
                frmProducto.Show();
            }
            else
            {
                frmProducto.Activate();
            }
            
        }
    }
}
