using Dormitory.Class;
using Dormitory.Class.Control;
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
    public partial class Students : Form
    {
        private bool isSelection;
        private bool isSelectionCallRoom;
        private bool isFiltre;
        private string SelectionFiltreString = "";

        private List<string> parFltr = new List<string>();
        private Dictionary<string, Type> FiltreOperation = new Dictionary<string, Type>();
        private TStudents selectStudentsCard;

        public TStudents SelectStudentsCard
        {
            get { return selectStudentsCard; }
        }

        public Students(bool IsSelection = false, List<string> ValueVacancies = null, Type СallParent = null)
        {
            InitializeComponent();
            isFiltre = false;
            isSelectionCallRoom = false;
            isSelection = IsSelection;
            if (IsSelection)
            {
                if (СallParent == typeof(TRooms))
                {
                    isSelectionCallRoom = true;
                }
                else
                {
                    if (ValueVacancies.Count != 0)
                    {
                        SelectionFiltreString = "AND Id NOT IN (";
                        foreach (string item in ValueVacancies)
                        {
                            SelectionFiltreString += item + ", ";
                        }
                        SelectionFiltreString = SelectionFiltreString.Remove(SelectionFiltreString.Length - 2, 2) + ")";
                    }
                }
            }
            

            FiltreOperation.Add("Id", typeof(int));
            FiltreOperation.Add("FCs", typeof(string));
            FiltreOperation.Add("NumberPhone", typeof(string));
            FiltreOperation.Add("NumberViolations", typeof(int));
            FiltreOperation.Add("Men", typeof(int));

            for (int i = 0; i < tStudentsDataGridView.Columns.Count; i++)
                parFltr.Add("");
            if (isSelection)
                Text = "Выбор студента";
        }

        private void LoadTheme()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle
            {
                SelectionBackColor = ThemeColor.AdditionalColor
            };

            dataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;

            tStudentsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            tStudentsDataGridView.BackgroundColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.3);
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.7);
            panel2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.7);
            flowLayoutPanel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.7);

            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tStudentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Students_Load(object sender, EventArgs e)
        {
            if (isSelectionCallRoom)
                tStudentsTableAdapter.FillBy(dataContext.TStudents);
            else if (isSelection)
            {
                if (SelectionFiltreString.Length != 0)
                    tStudentsBindingSource.Filter = SelectionFiltreString.Remove(0, 4);
                tStudentsTableAdapter.Fill(dataContext.TStudents);
            }
            else
                tStudentsTableAdapter.Fill(dataContext.TStudents);
            LoadTheme();
        }

        private void TStudentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            tStudentsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataContext);
        }

        private void TStudentsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            Validate();
            tStudentsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.dataContext);
        }

        private void TStudentsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strId = "";
            if (e.RowIndex != -1)
                strId = tStudentsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            else
                return;

            if (Int32.TryParse(strId, out int id))
            {
                TStudents students = AppData.modelBD.TStudents.FirstOrDefault(y => y.Id == id);
                if (isSelection)
                {
                    selectStudentsCard = students;
                    Cards parentForm = Owner as Cards;
                    parentForm.Close();
                    return;
                }
                else
                {
                    Cards studentsCard = new Cards(new StudentsCard(), students);
                    studentsCard.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show("Не удалось открыть карту студента!");
            }
            if (isSelectionCallRoom)
                tStudentsTableAdapter.FillBy(dataContext.TStudents);
            else
                tStudentsTableAdapter.Fill(dataContext.TStudents);
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Cards studentsCard = new Cards(new StudentsCard());
            studentsCard.ShowDialog(this);
            if (isSelectionCallRoom)
                tStudentsTableAdapter.FillBy(dataContext.TStudents);
            else
                tStudentsTableAdapter.Fill(dataContext.TStudents);
        }

        private void TxtbxFiltre_Leave(object sender, EventArgs e)
        {
            string strFiltre = AppData.Filtre(parFltr, FiltreOperation, flowLayoutPanel1.Controls);
            if (isSelection && !isSelectionCallRoom)
                if (strFiltre != null)
                    strFiltre += SelectionFiltreString;
                else if(SelectionFiltreString.Length != 0)
                    strFiltre = SelectionFiltreString.Remove(0, 4);
            tStudentsBindingSource.Filter = strFiltre;
        }

        private void TxtbxFiltre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                ActiveControl = null;
        }

        private void CmbbxGender_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string strFiltre = AppData.Filtre(parFltr, FiltreOperation, flowLayoutPanel1.Controls);
            if (isSelection && !isSelectionCallRoom)
                if (strFiltre != null)
                    strFiltre += SelectionFiltreString;
                else if (SelectionFiltreString.Length != 0)
                    strFiltre = SelectionFiltreString.Remove(0, 4);
            tStudentsBindingSource.Filter = strFiltre;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AppData.UpDownFiltre(ref UpDown, ref isFiltre, ref flowLayoutPanel1, tStudentsDataGridView,
                parFltr, new EventHandler(TxtbxFiltre_Leave),
                new KeyPressEventHandler(TxtbxFiltre_KeyPress),
                new EventHandler(CmbbxGender_OnSelectedIndexChanged),
                panel1,
                FiltreOperation);
        }
    }
}
