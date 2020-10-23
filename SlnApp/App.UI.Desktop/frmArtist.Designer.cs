namespace App.UI.Desktop
{
    partial class frmArtist
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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.txtFiltroCus = new System.Windows.Forms.TextBox();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.lblCountCus = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnNuevoCus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(25, 43);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(406, 207);
            this.dgvListado.TabIndex = 0;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            this.dgvListado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentDoubleClick);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(203, 10);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(284, 9);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(66, 23);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "label1";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(25, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(172, 20);
            this.txtFiltro.TabIndex = 3;
            // 
            // txtFiltroCus
            // 
            this.txtFiltroCus.Location = new System.Drawing.Point(472, 12);
            this.txtFiltroCus.Name = "txtFiltroCus";
            this.txtFiltroCus.Size = new System.Drawing.Size(205, 20);
            this.txtFiltroCus.TabIndex = 4;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(683, 12);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "Search";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // lblCountCus
            // 
            this.lblCountCus.Location = new System.Drawing.Point(764, 14);
            this.lblCountCus.Name = "lblCountCus";
            this.lblCountCus.Size = new System.Drawing.Size(66, 23);
            this.lblCountCus.TabIndex = 6;
            this.lblCountCus.Text = "label1";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(472, 43);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(406, 207);
            this.dgvCustomers.TabIndex = 7;
            this.dgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(356, 9);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnNuevoCus
            // 
            this.btnNuevoCus.Location = new System.Drawing.Point(803, 12);
            this.btnNuevoCus.Name = "btnNuevoCus";
            this.btnNuevoCus.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoCus.TabIndex = 9;
            this.btnNuevoCus.Text = "Nuevo";
            this.btnNuevoCus.UseVisualStyleBackColor = true;
            this.btnNuevoCus.Click += new System.EventHandler(this.btnNuevoCus_Click);
            // 
            // frmArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 284);
            this.Controls.Add(this.btnNuevoCus);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.lblCountCus);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.txtFiltroCus);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvListado);
            this.Name = "frmArtist";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.TextBox txtFiltroCus;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Label lblCountCus;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnNuevoCus;
    }
}

