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
    public partial class Rooms : Form
    {
        private bool isSelection;
        private bool isFiltre;

        private List<string> parFltr = new List<string>();
        private Dictionary<string, Type> FiltreOperation = new Dictionary<string, Type>();
        private TRooms selectRoomsCard;

        public TRooms SelectRoomsCard
        {
            get { return selectRoomsCard; }
        }

        public Rooms(bool IsSelection = false, List<string> ValueVacancies = null, object СallParent = null)
        {
            InitializeComponent();
            isFiltre = false;
            isSelection = IsSelection;

            FiltreOperation.Add("Id", typeof(int));
            FiltreOperation.Add("NumberRoom", typeof(int));
            FiltreOperation.Add("NumberFloor", typeof(int));
            FiltreOperation.Add("NumberSeats", typeof(int));

            parFltr = new List<string>();
            for (int i = 0; i < tRoomsDataGridView.Columns.Count; i++)
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

            dtgrdNum.DefaultCellStyle = dataGridViewCellStyle2;
            dtgrdNumberFloor.DefaultCellStyle = dataGridViewCellStyle2;
            dtgrdNumberRoom.DefaultCellStyle = dataGridViewCellStyle2;
            dtgrdNumberSeats.DefaultCellStyle = dataGridViewCellStyle2;
            dtgrdId.DefaultCellStyle = dataGridViewCellStyle2;

            panel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.7);
            panel2.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.7);
            flowLayoutPanel1.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.7);
            tRoomsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            tRoomsDataGridView.BackgroundColor = ThemeColor.ChangeColorBrightness(ThemeColor.PrimaryColor, 0.3);

            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tRoomsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            tRoomsTableAdapter.Fill(dataContext.TRooms);
            LoadTheme();
        }

        private void TRoomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            tRoomsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataContext);

        }

        private void TRoomsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            Validate();
            tRoomsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.dataContext);
        }

        private void TRoomsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strId = "";
            if (e.RowIndex != -1)
                strId = tRoomsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            else
                return;

            if (Int32.TryParse(strId, out int id))
            {
                TRooms Rooms = AppData.modelBD.TRooms.FirstOrDefault(y => y.Id == id);
                if (isSelection)
                {
                    selectRoomsCard = Rooms;
                    this.Owner.Close();
                    return;
                }
                else
                {
                    Cards RoomsCard = new Cards(new RoomCard(), Rooms);
                    RoomsCard.ShowDialog(this);
                }
            }
            else
            {
                MessageBox.Show("Не удалось открыть карту комнаты!");
            }
            
            tRoomsTableAdapter.Fill(dataContext.TRooms);
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Cards RoomsCard = new Cards(new RoomCard());
            RoomsCard.ShowDialog();
            tRoomsTableAdapter.Fill(dataContext.TRooms);
        }

        private void TxtbxFiltre_Leave(object sender, EventArgs e)
        {
            tRoomsBindingSource.Filter = AppData.Filtre(parFltr, FiltreOperation, flowLayoutPanel1.Controls);
        }

        private void TxtbxFiltre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                ActiveControl = null;
        }

        private void UpDown_Click(object sender, EventArgs e)
        {
            AppData.UpDownFiltre(ref UpDown, ref isFiltre, ref flowLayoutPanel1, tRoomsDataGridView,
                parFltr, new EventHandler(TxtbxFiltre_Leave),
                new KeyPressEventHandler(TxtbxFiltre_KeyPress),
                null,
                panel1, 
                FiltreOperation); 
        }

        private void TRoomsDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < tRoomsDataGridView.RowCount; i++)
            {
                if (Int32.TryParse(tRoomsDataGridView["dtgrdNumberSeats", i].Value.ToString(), out int num))
                {
                    int Id = Int32.Parse(tRoomsDataGridView["dtgrdId", i].Value.ToString());
                    TRooms Room = AppData.modelBD.TRooms.FirstOrDefault(y => y.Id == Id);
                    int NumVacancies = num - Room.TStudentsRooms.Count;
                    tRoomsDataGridView["dtgrdNum", i].Value = NumVacancies;
                    if (NumVacancies == 0)
                        tRoomsDataGridView.Rows[i].DefaultCellStyle.BackColor = ThemeColor.ChangeColorBrightness(Color.Red, 0.6);
                }
            }
        }
    }
}
