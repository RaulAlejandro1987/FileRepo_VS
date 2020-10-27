﻿using App.Data;
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
    public partial class frmTrack : Form
    {
        public frmTrack()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var da = new TrackDA();

            dgvConsultar.DataSource = da.GetTrackByName(txtConsultar.Text.Trim());
            dgvConsultar.Refresh();
        }
    }
}
