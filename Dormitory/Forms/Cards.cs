using Dormitory.Class;
using Dormitory.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dormitory.Forms
{
    public partial class Cards : Form
    {
        private Form activeForm;

        public Label TitlLabel = null;

        public Cards()
        {
            InitializeComponent();
            FormatWindows();
            lblTitle.Text = "Пустая карта";
        }

        public Cards(Form OpenForm)
        {
            InitializeComponent();
            FormatWindows();
            AppData.TitlLable = lblTitle;
            OpenChildForm(OpenForm);
            lblTitle.Text = OpenForm.Text;
        }

        public Cards(Form OpenForm, TStudents ActivStudent)
        {
            InitializeComponent();
            FormatWindows();
            AppData.TitlLable = lblTitle;
            StudentsCard studentsCard = new StudentsCard(ActivStudent);
            OpenChildForm(studentsCard);
            lblTitle.Text = ActivStudent.FCs;
        }
        public Cards(Form OpenForm, TRooms ActivRoom)
        {
            InitializeComponent();
            FormatWindows();
            AppData.TitlLable = lblTitle;
            RoomCard studentsCard = new RoomCard(ActivRoom);
            OpenChildForm(studentsCard);
            lblTitle.Text = "Этаж: " + ActivRoom.NumberFloor + ", комната: " + ActivRoom.NumberRoom;
        }

        public Cards(Form OpenForm, TParents ActivParents)
        {
            InitializeComponent();
            FormatWindows();
            AppData.TitlLable = lblTitle;
            ParentsCard parentsCard = new ParentsCard(ActivParents);
            OpenChildForm(parentsCard);
            lblTitle.Text = ActivParents.FCs;
        }

        private void FormatWindows()
        {
            TitlLabel = lblTitle;
            panelTitleBar.BackColor = ThemeColor.PrimaryColor;
            Text = string.Empty;
            ControlBox = false;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void OpenChildForm(Form childForm)
        {
            childForm.Owner = this;
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

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
    }
}
