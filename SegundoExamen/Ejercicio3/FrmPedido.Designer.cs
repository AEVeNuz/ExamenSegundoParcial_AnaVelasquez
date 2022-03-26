namespace Ejercicio3
{
    partial class FrmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PedidoDataGridView = new System.Windows.Forms.DataGridView();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.CantidadProductoTextBox = new System.Windows.Forms.TextBox();
            this.IdProductoTextBox = new System.Windows.Forms.TextBox();
            this.NombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PedidoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PedidoDataGridView
            // 
            this.PedidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PedidoDataGridView.Location = new System.Drawing.Point(7, 307);
            this.PedidoDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.PedidoDataGridView.Name = "PedidoDataGridView";
            this.PedidoDataGridView.RowHeadersWidth = 51;
            this.PedidoDataGridView.Size = new System.Drawing.Size(760, 255);
            this.PedidoDataGridView.TabIndex = 23;
            // 
            // CancelarButton
            // 
            this.CancelarButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.CancelarButton.FlatAppearance.BorderSize = 3;
            this.CancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarButton.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Location = new System.Drawing.Point(577, 227);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(6);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(138, 56);
            this.CancelarButton.TabIndex = 22;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.GuardarButton.FlatAppearance.BorderSize = 3;
            this.GuardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarButton.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(425, 227);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(6);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(138, 56);
            this.GuardarButton.TabIndex = 20;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click_1);
            // 
            // NuevoButton
            // 
            this.NuevoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.NuevoButton.FlatAppearance.BorderSize = 3;
            this.NuevoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoButton.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Location = new System.Drawing.Point(275, 227);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(6);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(138, 56);
            this.NuevoButton.TabIndex = 18;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // CantidadProductoTextBox
            // 
            this.CantidadProductoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadProductoTextBox.Enabled = false;
            this.CantidadProductoTextBox.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadProductoTextBox.Location = new System.Drawing.Point(275, 146);
            this.CantidadProductoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CantidadProductoTextBox.Name = "CantidadProductoTextBox";
            this.CantidadProductoTextBox.Size = new System.Drawing.Size(440, 27);
            this.CantidadProductoTextBox.TabIndex = 31;
            // 
            // IdProductoTextBox
            // 
            this.IdProductoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdProductoTextBox.Enabled = false;
            this.IdProductoTextBox.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProductoTextBox.Location = new System.Drawing.Point(275, 106);
            this.IdProductoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IdProductoTextBox.Name = "IdProductoTextBox";
            this.IdProductoTextBox.Size = new System.Drawing.Size(440, 27);
            this.IdProductoTextBox.TabIndex = 30;
            // 
            // NombreClienteTextBox
            // 
            this.NombreClienteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreClienteTextBox.Enabled = false;
            this.NombreClienteTextBox.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreClienteTextBox.Location = new System.Drawing.Point(275, 61);
            this.NombreClienteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombreClienteTextBox.Name = "NombreClienteTextBox";
            this.NombreClienteTextBox.Size = new System.Drawing.Size(440, 27);
            this.NombreClienteTextBox.TabIndex = 29;
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodigoTextBox.Enabled = false;
            this.CodigoTextBox.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoTextBox.Location = new System.Drawing.Point(275, 13);
            this.CodigoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(440, 27);
            this.CodigoTextBox.TabIndex = 28;
            this.CodigoTextBox.TextChanged += new System.EventHandler(this.CodigoTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cantidad del producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Id del Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre del cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Código del pedido:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotaltextBox.Font = new System.Drawing.Font("Elephant", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotaltextBox.Location = new System.Drawing.Point(275, 190);
            this.TotaltextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(440, 27);
            this.TotaltextBox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Total:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 576);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CantidadProductoTextBox);
            this.Controls.Add(this.IdProductoTextBox);
            this.Controls.Add(this.NombreClienteTextBox);
            this.Controls.Add(this.CodigoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PedidoDataGridView);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PedidoDataGridView;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox CantidadProductoTextBox;
        private System.Windows.Forms.TextBox IdProductoTextBox;
        private System.Windows.Forms.TextBox NombreClienteTextBox;
        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}