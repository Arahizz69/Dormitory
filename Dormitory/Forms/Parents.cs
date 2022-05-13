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
    public partial class Parents : Form
    {
        private bool isSelection;
        private bool isFiltre;
        private string SelectionFiltreString = "";

        private List<string> parFltr = new List<string>();
        private Dictionary<string, Type> FiltreOperation = new Dictionary<string, Type>();
        private TParents selectParentsCard;

        public TParents SelectParentsCard
        {
            get { return selectParentsCard; }
        }

        public Parents(bool IsSelection = false, List<string> ValueVacancies = null, Type СallParent = null)
        {
            InitializeComponent();
            isFiltre = false;
            isSelection = IsSelection;
            if (IsSelection)
            {
                if (ValueVacancies.Count != 0)
                {
                    SelectionFiltreString = " AND Id NOT IN (";
                    foreach (string item in ValueVacancies)
                    {
                        SelectionFiltreString += item + ", ";
                    }
                    SelectionFiltreString = SelectionFiltreString.Remove(SelectionFiltreString.Length - 2, 2) + ")";
                }
            }
           

            FiltreOperation.Add("Id", typeof(int));
            FiltreOperation.Add("FCs", typeof(string));
            FiltreOperation.Add("NumberPhone", typeof(string));

            parFltr = new List<string>();
            for (int i = 0; i < tparentsDataGridView.Columns.Count; i++)
                parFltr.Add("");

            if (isSelection)
                Text = "Выбор родителя";
        }

        private void LoadTheme()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle
            {
                SelectionBackColor = ThemeColor.AdditionalColor
            };
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;

            tparentsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            tparentsDataGridView.BackgroundColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.3);
            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.7);
            panel2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.7);
            flowLayoutPanel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.7);
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tparentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Parents_Load(object sender, EventArgs e)
        {
            if (isSelection)
                if (SelectionFiltreString.Length != 0)
                    tparentsBindingSource.Filter = SelectionFiltreString.Remove(0, 4);
            tParentsTableAdapter.Fill(dataContext.TParents);
            LoadTheme();
        }

        private void TparentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            tparentsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataContext);

        }

        private void TparentsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            Validate();
            tparentsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataContext);
        }

        private void TparentsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strId = "";
            if (e.RowIndex != -1)
                strId = tparentsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            else
                return;

            if (Int32.TryParse(strId, out int id))
            {
                TParents parents = AppData.modelBD.TParents.FirstOrDefault(y => y.Id == id);
                if (isSelection)
                {
                    selectParentsCard = parents;
                    this.Owner.Close();
                    return;
                }
                else
                {
                    Cards parentsCard = new Cards(new ParentsCard(), parents);
                    parentsCard.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show("Не удалось открыть карту родителя!");
            }
            tParentsTableAdapter.Fill(dataContext.TParents);
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Cards parentsCard = new Cards(new ParentsCard());
            parentsCard.ShowDialog();
            tParentsTableAdapter.Fill(dataContext.TParents);
        }

        private void TxtbxFiltre_Leave(object sender, EventArgs e)
        {
            string strFiltre = AppData.Filtre(parFltr, FiltreOperation, flowLayoutPanel1.Controls);
            if (isSelection)
                if (strFiltre != null)
                    strFiltre += SelectionFiltreString;
                else if (SelectionFiltreString.Length != 0)
                    strFiltre = SelectionFiltreString.Remove(0, 4);
            tparentsBindingSource.Filter = strFiltre;
        }

        private void TxtbxFiltre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                ActiveControl = null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AppData.UpDownFiltre(ref UpDown, ref isFiltre, ref flowLayoutPanel1, tparentsDataGridView,
                parFltr, new EventHandler(TxtbxFiltre_Leave),
                new KeyPressEventHandler(TxtbxFiltre_KeyPress),
                null,
                panel1,
                FiltreOperation);
        }
    }
}
