using BilgeAdam.OOP.App.Enums;
using BilgeAdam.OOP.App.Helpers;
using BilgeAdam.OOP.App.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BilgeAdam.OOP.App
{
    public partial class frmNew : Form
    {
        private readonly ModelManager manager;

        public frmNew(ModelManager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var model = new Model(txtFullName.Text, dtpBirhtDate.Value)
            {
                Language = (Language)cmbLanguage.SelectedValue,
                Measure = new Measure((byte)nudHeight.Value, (float)nudWeight.Value),
                Size = new Size((byte)nudBreast.Value, (byte)nudWaist.Value, (byte)nudHips.Value),
                Price = (double)nudPrice.Value
            };
            manager.Models.Add(model);
            this.Close();
        }

        private void frmNew_Load(object sender, EventArgs e)
        {
            dtpBirhtDate.MaxDate = DateTime.Now.AddYears(-17);
            dtpBirhtDate.MinDate = DateTime.Now.AddYears(-40);
            dtpBirhtDate.Value = DateTime.Now.AddYears(-20);

            var translator = new LanguageTranslator();
            cmbLanguage.DataSource = translator.GetLanguages().ToList();
            //cmbLanguage.ValueMember = "Text"; //KekoYöntem
            cmbLanguage.ValueMember = nameof(LanguageTranslator.LanguageMap.Key);
            cmbLanguage.DisplayMember = nameof(LanguageTranslator.LanguageMap.Text);
        }
    }
}