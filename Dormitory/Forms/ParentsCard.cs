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
    public partial class ParentsCard : Form
    {
        private TParents activParent = null;

        public ParentsCard()
        {
            InitializeComponent();
            StyleForm();
            tParentsParentsBindingNavigator.Enabled = false;
        }

        public ParentsCard(TParents Parent)
        {
            InitializeComponent();
            StyleForm();
            activParent = Parent;
        }

        private void StyleForm()
        {
            txtbxId.BorderColor = ThemeColor.AdditionalColor;
            txtbxFCs.BorderColor = ThemeColor.AdditionalColor;
            txtbxNumberPhone.BorderColor = ThemeColor.AdditionalColor;
            txtbxFCs.BorderFocusColor = ThemeColor.SecondaryLightColor;
            txtbxNumberPhone.BorderFocusColor = ThemeColor.SecondaryLightColor;

            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewCellStyle2.SelectionBackColor = ThemeColor.AdditionalColor;

            Num.DefaultCellStyle = dataGridViewCellStyle2;
            FCs.DefaultCellStyle = dataGridViewCellStyle2;
            NumberPhone.DefaultCellStyle = dataGridViewCellStyle2;

            tParentsParentsDataGridView.BackgroundColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.3);
        }

        private void TParentsParentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            tParentsParentsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataContext);
        }

        private void ParentsCard_Load(object sender, EventArgs e)
        {
            tParentsStudentsTableAdapter.Fill(dataContext.TParentsStudents);

            if (activParent != null)
            {
                txtbxId.Texts = activParent.Id.ToString();
                txtbxFCs.Texts = activParent.FCs;
                txtbxNumberPhone.Texts = activParent.NumberPhone;
                tParentsParentsBindingSource.Filter = string.Format("IdParents = '{0}'", activParent.Id);
            }
            else
            {
                activParent = new TParents();
                tParentsParentsBindingSource.Filter = "IdParents = '0'";
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

            if (txtbxFCs.Texts.Length == 0)
            {
                er = true;
                errorProvider2.SetError(txtbxFCs, "Не указано имя!");
            }
            else
            {
                errorProvider2.Clear();
            }

            if (!er)
            {
                activParent.FCs = txtbxFCs.Texts;
                activParent.NumberPhone = txtbxNumberPhone.Texts;
                if (txtbxId.Texts.Length == 0)
                {
                    AppData.modelBD.TParents.Add(activParent);
                    AppData.modelBD.SaveChanges();
                    AppData.TitlLable.Text = txtbxFCs.Texts;
                    txtbxId.Texts = activParent.Id.ToString();
                    tParentsParentsBindingNavigator.Enabled = true;
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
            for (int i = 0; i < tParentsParentsDataGridView.RowCount; i++)
                ValueVacancies.Add(tParentsParentsDataGridView["Num", i].Value.ToString());

            Students students = new Students(true, ValueVacancies);
            Cards parentsCard = new Cards(students);
            parentsCard.ShowDialog();

            TStudents addStudents = students.SelectStudentsCard;
            if (addStudents != null)
            {
                if (addStudents.TParentsStudents.FirstOrDefault(y => y.IdParents != activParent.Id) == null)
                {
                    AppData.modelBD.TParentsStudents.Add(new TParentsStudents { IdParents = addStudents.Id, IdStudents = activParent.Id });
                    AppData.modelBD.SaveChanges();
                }
            }
            this.tParentsStudentsTableAdapter.Fill(dataContext.TParentsStudents);
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            string strId = "";
            if (tParentsParentsDataGridView.SelectedRows.Count != 0)
                strId = tParentsParentsDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            else
                return;

            if (Int32.TryParse(strId, out int idS) && Int32.TryParse(txtbxId.Texts, out int idP))
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
                MessageBox.Show("Не удалось удалить карту студента!");
            }
            this.tParentsStudentsTableAdapter.Fill(dataContext.TParentsStudents);
        }

        private void TParentsParentsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string strId = "";
            if (e.RowIndex != -1)
                strId = tParentsParentsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
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
            tParentsStudentsTableAdapter.Fill(dataContext.TParentsStudents);
        }
    }
}
