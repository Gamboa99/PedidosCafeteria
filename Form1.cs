using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class Form1 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Producto> ListaProductos { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Pedido> ListaPedidos { get; set; }

        public Form1()
        {
            InitializeComponent();
            ConfigurarPropiedadesObligatorias();
            InicializarDatos();
        }

        public void ConfigurarPropiedadesObligatorias()
        {
            this.Text = "Pedidos Cafetería";
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPrecio.ReadOnly = true;
            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 10;
            dgvPedidos.ReadOnly = true;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.AllowUserToAddRows = false;
        }

        public void InicializarDatos()
        {
            ListaProductos = new BindingList<Producto>
            {
                new Producto { Nombre = "Café", Precio = 30.00m },
                new Producto { Nombre = "Té", Precio = 25.00m },
                new Producto { Nombre = "Sándwich", Precio = 55.00m },
                new Producto { Nombre = "Galletas", Precio = 20.00m }
            };

            cmbProductos.DataSource = ListaProductos;

            ListaPedidos = new BindingList<Pedido>();
            dgvPedidos.DataSource = ListaPedidos;

            ActualizarTotal();
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem is Producto prod)
            {
                txtPrecio.Text = prod.Precio.ToString("C");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar un producto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto productoSeleccionado = (Producto)cmbProductos.SelectedItem;
            int cantidad = (int)nudCantidad.Value;
            bool paraLlevar = chkParaLlevar.Checked;

            decimal subtotal = (productoSeleccionado.Precio * cantidad) + (paraLlevar ? 5m : 0m);

            Pedido nuevoPedido = new Pedido
            {
                Producto = productoSeleccionado,
                Cantidad = cantidad,
                ParaLlevar = paraLlevar,
                Subtotal = subtotal
            };

            ListaPedidos.Add(nuevoPedido);
            ActualizarTotal();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count > 0)
            {
                Pedido seleccionado = dgvPedidos.SelectedRows[0].DataBoundItem as Pedido;
                if (seleccionado != null)
                {
                    ListaPedidos.Remove(seleccionado);
                    ActualizarTotal();
                }
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            if (ListaPedidos.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas vaciar todos los pedidos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    ListaPedidos.Clear();
                    ActualizarTotal();
                }
            }
        }

        private void ActualizarTotal()
        {
            decimal total = ListaPedidos.Sum(p => p.Subtotal);
            lblTotal.Text = $"TOTAL: {total:C2}";
        }
    }
}