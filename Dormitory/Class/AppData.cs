using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using Dormitory.Data;
using System.Windows.Forms;
using Dormitory.Class.Control;
using static System.Windows.Forms.Control;
using System.Drawing;

namespace Dormitory.Class
{
    static public class AppData
    {
        private static Dictionary<Type, string> СomparisonOperator = new Dictionary<Type, string>() {
            { typeof(string), " LIKE '%{0}%'" },
            { typeof(int), " = '{0}'" },
        };

        static public ModelBD modelBD;

        static public Label TitlLable;

        static public TUsers activUsers;

        static public bool admin;

        static public bool СonnectionСorrect;

        static public bool IsAuthoriz {
            get { return isAuthoriz; }
            set { 
                pmenu.Enabled = value; 
                bsetings.Visible = admin; 
                isAuthoriz = value; 
            }
        }

        static private Panel pmenu;
        static private bool isAuthoriz;
        static private Button bsetings;

        static public Panel PMenu { set { pmenu = value; } }

        static public Button BSetings { set { bsetings = value; } }

        static private void KeyPressOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        static public void UpDownFiltre(ref Button sender,
            ref bool isFiltre,
            ref FlowLayoutPanel ParentFlowLayoutPanel,
            DataGridView DataGridViewFiltre,
            List<string> parFltr,
            EventHandler Leave,
            KeyPressEventHandler KeyPress,
            EventHandler OnSelectedIndexChanged,
            Panel SlidingPanel,
            Dictionary<string, Type> FiltreOperation)
        {
            if (!isFiltre)
            {
                ParentFlowLayoutPanel.Height += (DataGridViewFiltre.ColumnCount * 35);
                SlidingPanel.Height -= (DataGridViewFiltre.ColumnCount * 35);
                SlidingPanel.Location = new Point(SlidingPanel.Location.X,
                    SlidingPanel.Location.Y + (DataGridViewFiltre.ColumnCount * 35));
                sender.Image = Properties.Resources.BlackUp;
                isFiltre = true;

                int i = 0;
                foreach (DataGridViewColumn item in DataGridViewFiltre.Columns)
                {
                    if (item.DataPropertyName.Length == 0)
                        continue;

                    if (item.DataPropertyName == "Men")
                    {
                        UserComboBox cmbbxGender = new UserComboBox
                        {
                            BackColor = Color.WhiteSmoke,
                            BorderSize = 1,
                            DropDownStyle = ComboBoxStyle.DropDownList,
                            Font = new Font("Microsoft Sans Serif", 10F),
                            ForeColor = Color.DimGray,
                            ListTextColor = Color.Black,
                            BorderColor = ThemeColor.AdditionalColor,
                            IconColor = ThemeColor.AdditionalColor,
                            ListBackColor = ThemeColor.SecondaryLightColor,
                            Name = "uscmbbx" + item.DataPropertyName,
                            Size = new Size(250, 31),
                            TabIndex = i,
                            Texts = ""
                        };
                        cmbbxGender.Items.AddRange(new object[] { "Жен.", "Муж." });
                        if (Int32.TryParse(parFltr[i], out int tmpNum))
                        {
                            cmbbxGender.SelectedIndex = tmpNum;
                        }

                        cmbbxGender.Leave += Leave;
                        cmbbxGender.OnSelectedIndexChanged += OnSelectedIndexChanged;

                        ParentFlowLayoutPanel.Controls.Add(cmbbxGender);
                        i++;
                        continue;
                    }

                    UserTextBox userTextBox = new UserTextBox
                    {
                        BackColor = SystemColors.Window,
                        BorderRadius = 15,
                        BorderSize = 1,
                        Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                        BorderFocusColor = ThemeColor.SecondaryLightColor,
                        BorderColor = ThemeColor.AdditionalColor,
                        ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
                        Multiline = false,
                        Names = "ustxtbx" + item.DataPropertyName,
                        Name = "ustxtbx" + item.DataPropertyName,
                        PasswordChar = false,
                        PlaceholderColor = Color.DarkGray,
                        PlaceholderText = item.HeaderText,
                        Size = new Size(250, 31),
                        TabIndex = i,
                        SignatureOnTop = true,
                        Texts = parFltr[i],
                        UnderlinedStyle = false,
                    };

                    userTextBox.Leave += Leave;
                    if (FiltreOperation[item.DataPropertyName] == typeof(int))
                    {
                        userTextBox.KeyPress += KeyPressOnlyNumbers;
                    }
                    userTextBox.KeyPress += KeyPress;

                    ParentFlowLayoutPanel.Controls.Add(userTextBox);
                    i++;
                }
            }
            else
            {
                foreach (UserTextBox item in ParentFlowLayoutPanel.Controls)
                    parFltr[item.TabIndex] = item.Texts;

                ParentFlowLayoutPanel.Height -= (DataGridViewFiltre.ColumnCount * 35);
                SlidingPanel.Height += (DataGridViewFiltre.ColumnCount * 35);
                SlidingPanel.Location = new Point(SlidingPanel.Location.X,
                    SlidingPanel.Location.Y - (DataGridViewFiltre.ColumnCount * 35));
                sender.Image = Properties.Resources.BlackDown;
                ParentFlowLayoutPanel.Controls.Clear();
                isFiltre = false;
            }
        
        }

        static public string Filtre(List<string> parFltr, Dictionary<string, Type> FiltreOperation, ControlCollection Controls)
        {
            string FilterString = "";
            foreach (object item in Controls)
            {
                if (item.GetType() == new UserComboBox().GetType())
                {
                    UserComboBox userComboBox = item as UserComboBox;
                    if (userComboBox.Texts.Length != 0)
                    {
                        string nameColumn = userComboBox.Name.Replace("uscmbbx", "");
                        int Value = userComboBox.SelectedIndex;
                        parFltr[userComboBox.TabIndex] = Value.ToString();

                        FilterString += string.Format(string.Format("{0}{1} AND ", nameColumn, СomparisonOperator[FiltreOperation[nameColumn]]), Convert.ToBoolean(Value));
                    }
                }

                else if (item.GetType() == new UserTextBox().GetType())
                {
                    UserTextBox userTextBox = item as UserTextBox;
                    if (userTextBox.Texts.Length != 0)
                    {
                        string nameColumn = userTextBox.Name.Replace("ustxtbx", "");
                        string Value = userTextBox.Texts;
                        if (FiltreOperation[nameColumn] == typeof(int))
                            if (!Int32.TryParse(Value, out int num))
                                continue;

                        parFltr[userTextBox.TabIndex] = Value;
                        FilterString += string.Format(string.Format("{0}{1} AND ", nameColumn, СomparisonOperator[FiltreOperation[nameColumn]]), Value);
                    }
                }

            }

            if (FilterString.Length != 0)
            {
                try
                {
                    return FilterString.Substring(0, FilterString.Length - 5);

                }
                catch (Exception)
                {
                    return "Id = 0";
                }
            }
            else
            {
                return null;
            }
        }

        static public bool BDConnect()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DataContext"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        static public bool BDConnect(string ConnectionString)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
