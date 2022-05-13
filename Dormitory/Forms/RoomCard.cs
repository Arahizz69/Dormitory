using Dormitory.Class;
using Dormitory.Data;
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
    public partial class RoomCard : Form
    {
        private TRooms activRoom = null;

        public RoomCard()
        {
            InitializeComponent();
            StyleForm();
            tRoomsRoomsBindingNavigator.Enabled = false;
        }

        public RoomCard(TRooms Room)
        {
            InitializeComponent();
            StyleForm();
            activRoom = Room;
        }

        private void StyleForm()
        {
            txtbxId.BorderColor = ThemeColor.AdditionalColor;
            txtbxNumFloor.BorderColor = ThemeColor.AdditionalColor;
            txtbxNumRoom.BorderColor = ThemeColor.AdditionalColor;
            txtbxNumSeats.BorderColor = ThemeColor.AdditionalColor;
            txtbxNumFloor.BorderFocusColor = ThemeColor.SecondaryLightColor;
            txtbxNumRoom.BorderFocusColor = ThemeColor.SecondaryLightColor;
            txtbxNumSeats.BorderFocusColor = ThemeColor.SecondaryLightColor;

            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle
            {
                SelectionBackColor = ThemeColor.AdditionalColor
            };

            idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            fCsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            numberPhoneDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            numberViolationsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            menDataGridViewCheckBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;

            tRoomsRoomsDataGridView.BackgroundColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.3);
        }

        private void TRoomsRoomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            tRoomsRoomsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataContext);
        }

        private void RoomsCard_Load(object sender, EventArgs e)
        {
            tRoomsStudentsTableAdapter.Fill(dataContext.TStudentsRooms);

            if (activRoom != null)
            {
                txtbxId.Texts = activRoom.Id.ToString();
                txtbxNumFloor.Texts = activRoom.NumberFloor.ToString();
                txtbxNumRoom.Texts = activRoom.NumberRoom.ToString();
                txtbxNumSeats.Texts = activRoom.NumberSeats.ToString();
                lblNum.Text = "Свободных мест: " + (activRoom.NumberSeats - activRoom.TStudentsRooms.Count).ToString();
                tRoomsRoomsBindingSource.Filter = string.Format("IdRooms = '{0}'", activRoom.Id);
            }
            else
            {
                activRoom = new TRooms();
                tRoomsRoomsBindingSource.Filter = "IdRooms = '0'";
                lblNum.Text = "Свободных мест: ∞";
            }

        }

        private void UserTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool er = false;
            if (txtbxNumRoom.Texts.Length == 0)
            {
                er = true;
                errorProvider1.SetError(txtbxNumRoom, "Не указан номер комнаты!");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtbxNumFloor.Texts.Length == 0)
            {
                er = true;
                errorProvider2.SetError(txtbxNumFloor, "Не указан номер этажа!");
            }
            else
            {
                errorProvider2.Clear();
            }

            if (txtbxNumSeats.Texts.Length == 0)
            {
                er = true;
                errorProvider3.SetError(txtbxNumSeats, "Не указано количество мест");
            }
            else
            {
                errorProvider3.Clear();
            }

            if (!er)
            {
                activRoom.NumberFloor = Convert.ToInt32(txtbxNumFloor.Texts);
                activRoom.NumberRoom = Convert.ToInt32(txtbxNumRoom.Texts);
                activRoom.NumberSeats = Convert.ToInt32(txtbxNumSeats.Texts);

                if (txtbxId.Texts.Length == 0)
                {
                    AppData.modelBD.TRooms.Add(activRoom);
                    AppData.modelBD.SaveChanges();
                    AppData.TitlLable.Text = "Этаж: " + activRoom.NumberFloor + ", комната: " + activRoom.NumberRoom;
                    txtbxId.Texts = activRoom.Id.ToString();
                    tRoomsRoomsBindingNavigator.Enabled = true;
                }
                else
                {
                    AppData.TitlLable.Text = "Этаж: " + activRoom.NumberFloor + ", комната: " + activRoom.NumberRoom;
                    AppData.modelBD.SaveChanges();
                }
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (activRoom.NumberSeats - activRoom.TStudentsRooms.Count == 0)
            {
                MessageBox.Show("Комната уже заполнена");
                return;
            }

            Students students = new Students(true, null, typeof(TRooms));
            Cards RoomsCard = new Cards(students);
            RoomsCard.ShowDialog();

            TStudents addStudents = students.SelectStudentsCard;
            if (addStudents != null)
            {
                if (addStudents.TStudentsRooms.FirstOrDefault(y => y.IdRooms != activRoom.Id) == null)
                {
                    AppData.modelBD.TStudentsRooms.Add(new TStudentsRooms { IdRooms = activRoom.Id, IdStudents = addStudents.Id, EvictionDate = DateTime.Today});
                    AppData.modelBD.SaveChanges();
                }
            }
            lblNum.Text = "Свободных мест: " + (activRoom.NumberSeats - activRoom.TStudentsRooms.Count).ToString();

            this.tRoomsStudentsTableAdapter.Fill(this.dataContext.TStudentsRooms);
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            string strId = "";
            if (tRoomsRoomsDataGridView.SelectedRows.Count != 0)
                strId = tRoomsRoomsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            else return;

            if (Int32.TryParse(strId, out int idS) && Int32.TryParse(txtbxId.Texts, out int idP))
            {
                TStudentsRooms RoomsStudents = AppData.modelBD.TStudentsRooms.FirstOrDefault(y => y.IdRooms == idP && y.IdStudents == idS);
                if (RoomsStudents != null)
                {
                    AppData.modelBD.TStudentsRooms.Remove(RoomsStudents);
                    AppData.modelBD.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Не удалось выселить студента!");
                }
            }
            else
            {
                MessageBox.Show("Не удалось выселить студента!");
            }
            this.tRoomsStudentsTableAdapter.Fill(this.dataContext.TStudentsRooms);
        }

        private void TRoomsRoomsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string strId = "";
            if (e.RowIndex != -1)
                strId = tRoomsRoomsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            else
                return;

            if (Int32.TryParse(strId, out int id))
            {
                TStudents students = AppData.modelBD.TStudents.FirstOrDefault(y => y.Id == id);

                Cards studentsCard = new Cards(new StudentsCard(), students);
                studentsCard.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Не удалось открыть карту студента!");
            }
            this.tRoomsStudentsTableAdapter.Fill(this.dataContext.TStudentsRooms);
        }

        private void TxtbxNumSeats_Leave(object sender, EventArgs e)
        {
            if (txtbxNumSeats.Texts.Length != 0)
            {
                if (Convert.ToInt32(txtbxNumSeats.Texts) - activRoom.TStudentsRooms.Count < 0)
                {
                    MessageBox.Show("Нельзя установить количество мест меньше количесмтва заселённых студентов!");
                    txtbxNumSeats.Texts = activRoom.TStudentsRooms.Count.ToString();
                }

                lblNum.Text = "Свободных мест: " + (Convert.ToInt32(txtbxNumSeats.Texts) - activRoom.TStudentsRooms.Count).ToString();
            }
            else lblNum.Text = "Свободных мест: ∞";
        }
    }
}
