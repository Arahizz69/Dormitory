using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Dormitory.Class;
using System.Runtime.InteropServices;

namespace Dormitory.Forms
{
    public partial class ConnectionString : Form
    {


        public Label TitlLabel = null;

        public ConnectionString()
        {
            InitializeComponent();
            FormatWindows();
            string connectionString = ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString;
            string DataSource = connectionString.Replace("data source=", "").Replace("Data Source=", "");
            txtbxDataSource.Texts = DataSource.Substring(0,DataSource.IndexOf(";"));
            string InitialCatalog =  DataSource.Replace(txtbxDataSource.Texts, "").Replace(";initial catalog=", "").Replace(";Initial Catalog=", "");
            txtbxInitialCatalog.Texts = InitialCatalog.Substring(0, InitialCatalog.IndexOf(";"));
        }

        private void FormatWindows()
        {
            TitlLabel = lblTitle;
            Text = string.Empty;
            ControlBox = false;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximize.Image = Properties.Resources.RestoreWindow;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnMaximize.Image = Properties.Resources.MaximizeWindow;
            }
        }

        private void BntMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=" + txtbxDataSource.Texts + ";Initial Catalog=" + txtbxInitialCatalog.Texts + ";integrated security = True;";

            if (AppData.BDConnect(ConnectionString))
            {
                MessageBox.Show("Подключение успешно");
                button2.Enabled = true;
                button3.Enabled = false;
            }
            else
            {
                MessageBox.Show("Подключение не удалось!");
                button2.Enabled = false;
                button3.Enabled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"Data Source=" + txtbxDataSource.Texts + ";Initial Catalog=" + txtbxInitialCatalog.Texts + ";integrated security = True;";

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["DataContext"].ConnectionString = ConnectionString + "MultipleActiveResultSets=True;App=EntityFramework";
            connectionStringsSection.ConnectionStrings["Dormitory.Properties.Settings.DataContext"].ConnectionString = ConnectionString;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

            AppData.СonnectionСorrect = true;
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            bool er = false;

            if (txtbxDataSource.Texts.Length == 0)
            {
                errorProvider1.SetError(txtbxDataSource, "Не указан Data Source");
                er = true;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtbxInitialCatalog.Texts.Length == 0)
            {
                errorProvider2.SetError(txtbxInitialCatalog, "Не указан Initial Catalog");
                er = true;
            }
            else
            {
                errorProvider2.Clear();
            }

            if (er)
            {
                return;
            }

            string ConnectionString = @"Data Source=" + txtbxDataSource.Texts + ";Initial Catalog=" + txtbxInitialCatalog.Texts + ";integrated security = True;";

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["DataContext"].ConnectionString = ConnectionString + "MultipleActiveResultSets=True;App=EntityFramework";
            connectionStringsSection.ConnectionStrings["Dormitory.Properties.Settings.DataContext"].ConnectionString = ConnectionString;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

            try
            {
                NewStart.BaseCreation();
                MessageBox.Show("База данных была создана упешно");

            }
            catch (Exception)
            {
                MessageBox.Show("Произошла неизвестная ошибка. Обратитесь к поставщику приложения!");
            }
        }

        private void TxtbxDataSource__TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void TxtbxInitialCatalog__TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
    }
}

