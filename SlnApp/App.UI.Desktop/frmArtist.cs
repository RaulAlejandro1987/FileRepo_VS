using App.Data;
using App.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI.Desktop
{
    public partial class frmArtist : Form
    {
        public frmArtist()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var da = new ArtistDA();
          
            lblCount.Text = da.Count().ToString();
            dgvListado.DataSource = da.Gets(txtFiltro.Text.Trim());
            dgvListado.Refresh();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            var da = new ArtistDA();

            lblCountCus.Text = da.CountCustomers().ToString();
            dgvCustomers.DataSource = da.GetsCustomer(txtFiltroCus.Text.Trim());
            dgvCustomers.Refresh();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var from = new frmArtistEdicion();
            from.ShowDialog();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var artist = (Artist)dgvListado.Rows[e.RowIndex].DataBoundItem;
            var frm = new frmArtistEdicion();
            frm.Artist = artist;
            frm.ShowDialog();
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var customer = (Customer)dgvCustomers.Rows[e.RowIndex].DataBoundItem;
            var frm = new frmCustomerEdicion();
            frm.Customer = customer;
            frm.ShowDialog();
        }

        private void btnNuevoCus_Click(object sender, EventArgs e)
        {
            var from = new frmCustomerEdicion();
            from.ShowDialog();
        }
    }
}
