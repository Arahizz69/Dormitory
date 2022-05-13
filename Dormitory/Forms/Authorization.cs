using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Dormitory.Class;
using Dormitory.Data;

namespace Dormitory.Forms
{
    public partial class Authorization : Form
    {

        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            if (!AppData.BDConnect())
            {
                new ConnectionString().ShowDialog();
            }
        }

        private void TxtbxLogIn_Enter(object sender, EventArgs e)
        {
            if (txtbxLogIn.Texts.Length == 0)
                label1.Visible = !label1.Visible;
        }

        private void TxtbxLogIn_Leave(object sender, EventArgs e)
        {
            if (txtbxLogIn.Texts.Length == 0)
                label1.Visible = !label1.Visible;
        }

        private void TxtbxPassword_Enter(object sender, EventArgs e)
        {
            if (txtbxPassword.Texts.Length == 0)
                label2.Visible = !label2.Visible;
        }

        private void TxtbxPassword_Leave(object sender, EventArgs e)
        {
            if (txtbxPassword.Texts.Length == 0)
                label2.Visible = !label2.Visible;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bool er = false;
            TUsers user = null;
            if (txtbxLogIn.Texts.Length == 0)
            {
                er = true;
                errorProvider1.SetError(txtbxLogIn, "Логин не может быть пустым!");
            }
            else
            {
                user = AppData.modelBD.TUsers.FirstOrDefault(y => y.Name == txtbxLogIn.Texts);
                errorProvider1.Clear();
            }

            if (txtbxPassword.Texts.Length == 0)
            {
                er = true;
                errorProvider2.SetError(txtbxPassword, "Не верный пароль!");
            }
            else if (user == null)
            {
                er = true;
                errorProvider2.SetError(txtbxPassword, "Не верный пароль!");
            }
            else if (user != null)
            {
                if (user.Password != txtbxPassword.Texts)
                {
                    er = true;
                    errorProvider2.SetError(txtbxPassword, "Не верный пароль!");
                }
            }
            else errorProvider2.Clear();

            if (!er)
            {
                AppData.activUsers = user;
                AppData.admin = user.Admin;
                AppData.IsAuthoriz = true;
                Close();
            }
        }
    }
}
