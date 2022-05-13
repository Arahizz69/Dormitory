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
    public partial class StudentsCard : Form
    {
        private TStudents activStudent = null;
        private TRooms RoomStudent;

        public StudentsCard()
        {
            InitializeComponent();
            StyleForm();
            tParentsStudentsBindingNavigator.Enabled = true;
        }

        public StudentsCard(TStudents student)
        {
            InitializeComponent();
            StyleForm();
            activStudent = student;
        }

        private void StyleForm()
        {
            txtbxId.BorderColor = ThemeColor.AdditionalColor;
            txtbxFCs.BorderColor = ThemeColor.AdditionalColor;
            txtbxNumberPhone.BorderColor = ThemeColor.AdditionalColor;
            txtbxNumEr.BorderColor = ThemeColor.AdditionalColor;
            userRoom.BorderColor = ThemeColor.AdditionalColor;
            
            userRoom.BorderFocusColor = ThemeColor.SecondaryLightColor;
            txtbxFCs.BorderFocusColor = ThemeColor.SecondaryLightColor;
            txtbxNumberPhone.BorderFocusColor = ThemeColor.SecondaryLightColor;
            txtbxNumEr.BorderFocusColor = ThemeColor.SecondaryLightColor;

            cmbbxGender.BorderColor = ThemeColor.AdditionalColor;
            cmbbxGender.IconColor = ThemeColor.AdditionalColor;
            cmbbxGender.ListBackColor = ThemeColor.SecondaryLightColor;

            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle
            {
                SelectionBackColor = ThemeColor.AdditionalColor
            };

            Num.DefaultCellStyle = dataGridViewCellStyle2;
            FCs.DefaultCellStyle = dataGridViewCellStyle2;
            NumberPhone.DefaultCellStyle = dataGridViewCellStyle2;

            tParentsStudentsDataGridView.BackgroundColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.3);
            tParentsStudentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void TParentsStudentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            tParentsStudentsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataContext);
        }

        private void StudentsCard_Load(object sender, EventArgs e)
        {
            tParentsStudentsTableAdapter.Fill(dataContext.TParentsStudents);

            if (activStudent == null)
            {
                activStudent = new TStudents();
                tParentsStudentsBindingNavigator.Enabled = false;
                RoomStudent = null;
                userRoom.Texts = "Студент никуда не засёлен";
                userRoom.Enabled = false;
                button2.Enabled = false;
                tParentsStudentsBindingSource.Filter = "IdStudents = '0'";
            }
            else
            {
                txtbxId.Texts = activStudent.Id.ToString();
                txtbxFCs.Texts = activStudent.FCs;
                txtbxNumberPhone.Texts = activStudent.NumberPhone;
                cmbbxGender.SelectedIndex = Convert.ToInt32(activStudent.Men);
                txtbxNumEr.Texts = activStudent.NumberViolations.ToString();
                tParentsStudentsBindingSource.Filter = string.Format("IdStudents = '{0}'", activStudent.Id);

                TStudentsRooms StudentsRooms = activStudent.TStudentsRooms.FirstOrDefault(y => y.IdStudents == activStudent.Id);
                if (StudentsRooms == null)
                {
                    userRoom.Texts = "Студент никуда не засёлен";
                    userRoom.Enabled = false;
                    button2.Enabled = false;
                }    
                else
                {
                    RoomStudent = StudentsRooms.TRooms;
                    userRoom.Texts = "Этаж: " + RoomStudent.NumberFloor + ", комната: " + RoomStudent.NumberRoom;
                }
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
            if (txtbxNumberPhone.Texts.Length == 0)
            {
                er = true;
                errorProvider1.SetError(txtbxNumberPhone, "Не указан номер телефона!");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (cmbbxGender.Texts.Length == 0)
            {
                er = true;
                errorProvider2.SetError(cmbbxGender, "Не указан пол!");
            }
            else
            {
                errorProvider2.Clear();
            }

            if (txtbxFCs.Texts.Length == 0)
            {
                er = true;
                errorProvider3.SetError(txtbxFCs, "Не указано имя!");
            }
            else
            {
                errorProvider3.Clear();
            }

            if (!er)
            {
                int numEr = 0;
                if (Int32.TryParse(txtbxNumEr.Texts, out numEr)) { }
 
                activStudent.FCs = txtbxFCs.Texts;
                activStudent.Men = Convert.ToBoolean(cmbbxGender.SelectedIndex);
                activStudent.NumberViolations = numEr == 0 ? 0 : numEr;
                activStudent.NumberPhone = txtbxNumberPhone.Texts;
                if(txtbxId.Texts.Length == 0)
                {
                    tParentsStudentsBindingNavigator.Enabled = true;
                    AppData.modelBD.TStudents.Add(activStudent);
                    AppData.modelBD.SaveChanges();
                    AppData.TitlLable.Text = txtbxFCs.Texts;
                    txtbxId.Texts = activStudent.Id.ToString();
                    tParentsStudentsBindingNavigator.Enabled = true;
                }
                else
                {
                    AppData.TitlLable.Text = txtbxFCs.Texts;
                    AppData.modelBD.SaveChanges();
                }
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            List<string> ValueVacancies = new List<string>();
            for (int i = 0; i < tParentsStudentsDataGridView.RowCount; i++)
                ValueVacancies.Add(tParentsStudentsDataGridView["Num", i].Value.ToString());

            Parents parents = new Parents(true, ValueVacancies);
            Cards parentsCard = new Cards(parents);
            parentsCard.ShowDialog();

            TParents addParents = parents.SelectParentsCard;
            if (addParents != null)
            {
                if (addParents.TParentsStudents.FirstOrDefault(y=>y.IdStudents != activStudent.Id) == null)
                {
                    AppData.modelBD.TParentsStudents.Add(new TParentsStudents { IdParents = addParents.Id, IdStudents = activStudent.Id });
                    AppData.modelBD.SaveChanges();
                }
            }
            this.tParentsStudentsTableAdapter.Fill(this.dataContext.TParentsStudents);
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            string strId = "";
            if (tParentsStudentsDataGridView.SelectedRows.Count != 0)
                strId = tParentsStudentsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            else
                return;

            if (Int32.TryParse(strId, out int idP) && Int32.TryParse(txtbxId.Texts, out int idS))
            {
                TParentsStudents parentsStudents = AppData.modelBD.TParentsStudents.FirstOrDefault(y => y.IdParents == idP && y.IdStudents == idS);
                if (parentsStudents != null)
                {
                    AppData.modelBD.TParentsStudents.Remove(parentsStudents);
                    AppData.modelBD.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить карту родсвенника!");
                }
            }
            else
            {
                MessageBox.Show("Не удалось удалить карту родсвенника!");
            }
            this.tParentsStudentsTableAdapter.Fill(dataContext.TParentsStudents);
        }

        private void TParentsStudentsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string strId = "";
            if (e.RowIndex != -1)
                strId = tParentsStudentsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            else
                return;

            if (Int32.TryParse(strId, out int id))
            {
                TParents parents = AppData.modelBD.TParents.FirstOrDefault(y => y.Id == id);

                Cards studentsCard = new Cards(new ParentsCard(), parents);
                studentsCard.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Не удалось открыть карту родсвенника!");
            }
            this.tParentsStudentsTableAdapter.Fill(dataContext.TParentsStudents);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Cards RoomsCard = new Cards(new RoomCard(), RoomStudent);
            RoomsCard.ShowDialog(this);

            RoomStudent = activStudent.TStudentsRooms.FirstOrDefault(y => y.IdStudents == activStudent.Id).TRooms;
            if (RoomStudent == null)
            {
                userRoom.Texts = "Студент никуда не засёлен";
                userRoom.Enabled = false;
                button2.Enabled = false;
            }
            else
                userRoom.Texts = "Этаж: " + RoomStudent.NumberFloor + ", комната: " + RoomStudent.NumberRoom;
        }
    }
}
