namespace Cafeteria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbProductos = new ComboBox();
            txtPrecio = new TextBox();
            nudCantidad = new NumericUpDown();
            chkParaLlevar = new CheckBox();
            dgvPedidos = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnVaciar = new Button();
            lblTotal = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(179, 32);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(121, 23);
            cmbProductos.TabIndex = 0;
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(179, 61);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 1;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(179, 102);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 2;
            // 
            // chkParaLlevar
            // 
            chkParaLlevar.AutoSize = true;
            chkParaLlevar.Location = new Point(133, 146);
            chkParaLlevar.Name = "chkParaLlevar";
            chkParaLlevar.Size = new Size(166, 19);
            chkParaLlevar.TabIndex = 3;
            chkParaLlevar.Text = "Para llevar (+5 por pedido)";
            chkParaLlevar.UseVisualStyleBackColor = true;
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(362, 32);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.Size = new Size(338, 133);
            dgvPedidos.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(60, 188);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(152, 188);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVaciar
            // 
            btnVaciar.Location = new Point(249, 188);
            btnVaciar.Name = "btnVaciar";
            btnVaciar.Size = new Size(75, 23);
            btnVaciar.TabIndex = 7;
            btnVaciar.Text = "Vaciar";
            btnVaciar.UseVisualStyleBackColor = true;
            btnVaciar.Click += btnVaciar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(598, 188);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            textBox1.Text = "Producto";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(73, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            textBox2.Text = "Precio Unitario";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(73, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            textBox3.Text = "Cantidad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 245);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblTotal);
            Controls.Add(btnVaciar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvPedidos);
            Controls.Add(chkParaLlevar);
            Controls.Add(nudCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(cmbProductos);
            Name = "Form1";
            Text = "PedidosCafeteria";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProductos;
        private TextBox txtPrecio;
        private NumericUpDown nudCantidad;
        private CheckBox chkParaLlevar;
        private DataGridView dgvPedidos;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnVaciar;
        private Label lblTotal;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
