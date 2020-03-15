using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLW {
    public partial class PageDialog : Form {
        public PageDialog(String title) {
            this.Text = title;
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;

        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
