using BilgeAdam.OOP.App.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.OOP.App
{
    public partial class frmMain : Form
    {
        private ModelManager manager;
        public frmMain()
        {
            InitializeComponent();
            manager = new ModelManager();
        }

        private void mtsNew_Click(object sender, EventArgs e)
        {
            var @new = new frmNew(manager);
            @new.ShowDialog();
        }

        private void mtsExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Can Manken Ajansı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            manager.Initialize();
            dgvModels.DataSource = manager.Models;
        }
    }
}
