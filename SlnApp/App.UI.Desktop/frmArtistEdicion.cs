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
    public partial class frmArtistEdicion : Form
    {
        public Artist Artist { get; set; }
        public frmArtistEdicion()
        {
            InitializeComponent();
        }

        public void MostrarDatos()
        {
            if (IsEdit())
            {
                txtNombre.Text = this.Artist.Name;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var artist = new Artist();
            artist.Name = txtNombre.Text.Trim();

            var artisDA = new ArtistDA();

            if (IsEdit())
            {
                artist.ArtistId = this.Artist.ArtistId;
                artisDA.Update(artist);
            }
            else
            {
                artisDA.Insert(artist);
            }

            this.Close();

        }

        public bool IsEdit()
        {
            return this.Artist != null;
        }
    }
}
