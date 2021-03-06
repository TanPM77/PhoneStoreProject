﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagePhone {
    public partial class frmViewCustomer : Form {
        public frmViewCustomer() {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void btnCancelCustomer_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e) {
            frmUpdateCustomer updateCustomer = new frmUpdateCustomer();
            this.Hide();
            updateCustomer.ShowDialog();
            this.Show();
        }
    }
}
