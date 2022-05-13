using Dormitory.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory.Forms
{
    public partial class Settings : Form
    {
        private bool isFiltre;
        private List<string> parFltr = new List<string>();
        private Dictionary<string, Type> FiltreOperation = new Dictionary<string, Type>();

        public Settings()
        {
            InitializeComponent();

            isFiltre = false;

            FiltreOperation.Add("Id", typeof(int));
            FiltreOperation.Add("Admin", typeof(int));
            FiltreOperation.Add("Name", typeof(string));
            FiltreOperation.Add("Password", typeof(string));

            parFltr = new List<string>();
            for (int i = 0; i < tUsersDataGridView.Columns.Count; i++)
                parFltr.Add("");
        }

        private void tUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            tUsersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataContext);

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            tUsersTableAdapter.Fill(dataContext.TUsers);
            LoadTheme();
        }

        private void LoadTheme()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle
            {
                SelectionBackColor = ThemeColor.AdditionalColor
            };

            dtgrdAdmin.DefaultCellStyle = dataGridViewCellStyle2;
            dtgrdId.DefaultCellStyle = dataGridViewCellStyle2;
            dtgrdName.DefaultCellStyle = dataGridViewCellStyle2;
            dtgrdPassword.DefaultCellStyle = dataGridViewCellStyle2;

            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.7);
            panel2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.7);
            flowLayoutPanel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.7);
            tUsersDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            tUsersDataGridView.BackgroundColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.3);

            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tUsersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void TxtbxFiltre_Leave(object sender, EventArgs e)
        {
            tUsersBindingSource.Filter = AppData.Filtre(parFltr, FiltreOperation, flowLayoutPanel1.Controls);
        }

        private void TxtbxFiltre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                ActiveControl = null;
        }

        private void CmbbxGender_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            tUsersBindingSource.Filter = AppData.Filtre(parFltr, FiltreOperation, flowLayoutPanel1.Controls);
        }

        private void UpDown_Click(object sender, EventArgs e)
        {
            AppData.UpDownFiltre(ref UpDown, ref isFiltre, ref flowLayoutPanel1, tUsersDataGridView,
                parFltr, new EventHandler(TxtbxFiltre_Leave),
                new KeyPressEventHandler(TxtbxFiltre_KeyPress),
                new EventHandler(CmbbxGender_OnSelectedIndexChanged),
                panel1,
                FiltreOperation);
        }
    }
}
