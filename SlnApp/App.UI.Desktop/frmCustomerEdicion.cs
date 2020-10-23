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
    public partial class frmCustomerEdicion : Form
    {
        public Customer Customer { get; set; }
        public frmCustomerEdicion()
        {
            InitializeComponent();
        }

        public void MostrarDatos()
        {
            if (IsEdit())
            {
                txtFisrtName.Text = this.Customer.FirstName;
                txtLastName.Text = this.Customer.LastName;
                txtCompany.Text = this.Customer.Company;
                txtCity.Text = this.Customer.City;
                txtState.Text = this.Customer.State;
                txtCountry.Text = this.Customer.Country;
                txtPostalCode.Text = this.Customer.PostalCode;
                txtPhone.Text = this.Customer.Phone;
                txtFax.Text = this.Customer.Fax;
                txtEmail.Text = this.Customer.Email;
                txtSupportRepId.Text = this.Customer.SupportRepId.ToString();
            }
        }

        private void btnInsertarCus_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            customer.FirstName = txtFisrtName.Text.Trim();
            customer.LastName = txtLastName.Text.Trim();
            customer.Company = txtCompany.Text.Trim();
            customer.Address = txtAddress.Text.Trim();
            customer.City = txtCity.Text.Trim();
            customer.State = txtState.Text.Trim();
            customer.Country = txtCountry.Text.Trim();
            customer.PostalCode = txtPostalCode.Text.Trim();
            customer.Phone = txtPhone.Text.Trim();
            customer.Fax = txtFax.Text.Trim();
            customer.Email = txtEmail.Text.Trim();
            customer.SupportRepId =Convert.ToInt32(txtSupportRepId.Text.Trim());

            var CustomerDA = new ArtistDA();

            if (IsEdit())
            {
                customer.CustomerId = this.Customer.CustomerId;
                CustomerDA.UpdateCustomer(customer);
            }
            else
            {
                CustomerDA.InsertCustomer(customer);
            }

            this.Close();
        }

        public bool IsEdit()
        {
            return this.Customer != null;
        }
    }
}
