
namespace Dormitory.Forms
{
    partial class RoomCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panelRooms = new System.Windows.Forms.Panel();
            this.tRoomsRoomsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tRoomsRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataContext = new Dormitory.DataContext();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tRoomsRoomsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fCsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberViolationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxNumSeats = new Dormitory.Class.Control.UserTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxId = new Dormitory.Class.Control.UserTextBox();
            this.txtbxNumRoom = new Dormitory.Class.Control.UserTextBox();
            this.txtbxNumFloor = new Dormitory.Class.Control.UserTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tRoomsStudentsTableAdapter = new Dormitory.DataContextTableAdapters.TStudentsRoomsTableAdapter();
            this.tableAdapterManager = new Dormitory.DataContextTableAdapters.TableAdapterManager();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRoomsRoomsBindingNavigator)).BeginInit();
            this.tRoomsRoomsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRoomsRoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRoomsRoomsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // panelRooms
            // 
            this.panelRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRooms.Controls.Add(this.tRoomsRoomsBindingNavigator);
            this.panelRooms.Controls.Add(this.tRoomsRoomsDataGridView);
            this.panelRooms.Location = new System.Drawing.Point(0, 171);
            this.panelRooms.Margin = new System.Windows.Forms.Padding(0);
            this.panelRooms.Name = "panelRooms";
            this.panelRooms.Size = new System.Drawing.Size(863, 200);
            this.panelRooms.TabIndex = 3;
            // 
            // tRoomsRoomsBindingNavigator
            // 
            this.tRoomsRoomsBindingNavigator.AddNewItem = null;
            this.tRoomsRoomsBindingNavigator.BindingSource = this.tRoomsRoomsBindingSource;
            this.tRoomsRoomsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tRoomsRoomsBindingNavigator.DeleteItem = null;
            this.tRoomsRoomsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tRoomsRoomsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton2,
            this.toolStripButton1});
            this.tRoomsRoomsBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tRoomsRoomsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tRoomsRoomsBindingNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.tRoomsRoomsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tRoomsRoomsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tRoomsRoomsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tRoomsRoomsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tRoomsRoomsBindingNavigator.Name = "tRoomsRoomsBindingNavigator";
            this.tRoomsRoomsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tRoomsRoomsBindingNavigator.Size = new System.Drawing.Size(863, 23);
            this.tRoomsRoomsBindingNavigator.TabIndex = 4;
            this.tRoomsRoomsBindingNavigator.Text = "bindingNavigator1";
            // 
            // tRoomsRoomsBindingSource
            // 
            this.tRoomsRoomsBindingSource.DataMember = "TStudentsRooms";
            this.tRoomsRoomsBindingSource.DataSource = this.dataContext;
            // 
            // dataContext
            // 
            this.dataContext.DataSetName = "DataContext";
            this.dataContext.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::Dormitory.Properties.Resources.BackArrowDouble;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::Dormitory.Properties.Resources.BackArrow;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 23);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::Dormitory.Properties.Resources.ForwardArrow;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::Dormitory.Properties.Resources.ForwardArrowDouble;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Dormitory.Properties.Resources.Del;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton2.Text = "Выселить";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Dormitory.Properties.Resources.Add;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton1.Text = "Заселить";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // tRoomsRoomsDataGridView
            // 
            this.tRoomsRoomsDataGridView.AllowUserToAddRows = false;
            this.tRoomsRoomsDataGridView.AllowUserToDeleteRows = false;
            this.tRoomsRoomsDataGridView.AllowUserToResizeRows = false;
            this.tRoomsRoomsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tRoomsRoomsDataGridView.AutoGenerateColumns = false;
            this.tRoomsRoomsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tRoomsRoomsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tRoomsRoomsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tRoomsRoomsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tRoomsRoomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tRoomsRoomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fCsDataGridViewTextBoxColumn,
            this.numberPhoneDataGridViewTextBoxColumn,
            this.numberViolationsDataGridViewTextBoxColumn,
            this.menDataGridViewCheckBoxColumn});
            this.tRoomsRoomsDataGridView.DataSource = this.tRoomsRoomsBindingSource;
            this.tRoomsRoomsDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.tRoomsRoomsDataGridView.Location = new System.Drawing.Point(0, 24);
            this.tRoomsRoomsDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.tRoomsRoomsDataGridView.MultiSelect = false;
            this.tRoomsRoomsDataGridView.Name = "tRoomsRoomsDataGridView";
            this.tRoomsRoomsDataGridView.ReadOnly = true;
            this.tRoomsRoomsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tRoomsRoomsDataGridView.RowHeadersVisible = false;
            this.tRoomsRoomsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tRoomsRoomsDataGridView.RowTemplate.ReadOnly = true;
            this.tRoomsRoomsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tRoomsRoomsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tRoomsRoomsDataGridView.Size = new System.Drawing.Size(863, 176);
            this.tRoomsRoomsDataGridView.TabIndex = 1;
            this.tRoomsRoomsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TRoomsRoomsDataGridView_CellMouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Код";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fCsDataGridViewTextBoxColumn
            // 
            this.fCsDataGridViewTextBoxColumn.DataPropertyName = "FCs";
            this.fCsDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fCsDataGridViewTextBoxColumn.Name = "fCsDataGridViewTextBoxColumn";
            this.fCsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberPhoneDataGridViewTextBoxColumn
            // 
            this.numberPhoneDataGridViewTextBoxColumn.DataPropertyName = "NumberPhone";
            this.numberPhoneDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.numberPhoneDataGridViewTextBoxColumn.Name = "numberPhoneDataGridViewTextBoxColumn";
            this.numberPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberViolationsDataGridViewTextBoxColumn
            // 
            this.numberViolationsDataGridViewTextBoxColumn.DataPropertyName = "NumberViolations";
            this.numberViolationsDataGridViewTextBoxColumn.HeaderText = "Количество нарушений";
            this.numberViolationsDataGridViewTextBoxColumn.Name = "numberViolationsDataGridViewTextBoxColumn";
            this.numberViolationsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menDataGridViewCheckBoxColumn
            // 
            this.menDataGridViewCheckBoxColumn.DataPropertyName = "Men";
            this.menDataGridViewCheckBoxColumn.HeaderText = "Мужской пол";
            this.menDataGridViewCheckBoxColumn.Name = "menDataGridViewCheckBoxColumn";
            this.menDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.lblNum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtbxNumSeats);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtbxId);
            this.panel1.Controls.Add(this.txtbxNumRoom);
            this.panel1.Controls.Add(this.txtbxNumFloor);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 168);
            this.panel1.TabIndex = 4;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNum.ForeColor = System.Drawing.Color.White;
            this.lblNum.Location = new System.Drawing.Point(325, 115);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(170, 24);
            this.lblNum.TabIndex = 18;
            this.lblNum.Text = "Свобоных мест: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(325, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Количество мест:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Номер комнаты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Номер этажа:";
            // 
            // txtbxNumSeats
            // 
            this.txtbxNumSeats.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxNumSeats.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbxNumSeats.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbxNumSeats.BorderRadius = 15;
            this.txtbxNumSeats.BorderSize = 2;
            this.txtbxNumSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNumSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbxNumSeats.Location = new System.Drawing.Point(503, 55);
            this.txtbxNumSeats.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNumSeats.Multiline = false;
            this.txtbxNumSeats.Name = "txtbxNumSeats";
            this.txtbxNumSeats.Names = "textBox1";
            this.txtbxNumSeats.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbxNumSeats.PasswordChar = false;
            this.txtbxNumSeats.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbxNumSeats.PlaceholderText = "Количество мест";
            this.txtbxNumSeats.SignatureOnTop = false;
            this.txtbxNumSeats.Size = new System.Drawing.Size(140, 31);
            this.txtbxNumSeats.TabIndex = 13;
            this.txtbxNumSeats.Texts = "";
            this.txtbxNumSeats.UnderlinedStyle = false;
            this.txtbxNumSeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserTextBox1_KeyPress);
            this.txtbxNumSeats.Leave += new System.EventHandler(this.TxtbxNumSeats_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(156, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Код:";
            // 
            // txtbxId
            // 
            this.txtbxId.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbxId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbxId.BorderRadius = 15;
            this.txtbxId.BorderSize = 2;
            this.txtbxId.Enabled = false;
            this.txtbxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbxId.Location = new System.Drawing.Point(213, 4);
            this.txtbxId.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxId.Multiline = false;
            this.txtbxId.Name = "txtbxId";
            this.txtbxId.Names = "textBox1";
            this.txtbxId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbxId.PasswordChar = false;
            this.txtbxId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbxId.PlaceholderText = "- - -";
            this.txtbxId.SignatureOnTop = false;
            this.txtbxId.Size = new System.Drawing.Size(282, 31);
            this.txtbxId.TabIndex = 11;
            this.txtbxId.Texts = "";
            this.txtbxId.UnderlinedStyle = false;
            // 
            // txtbxNumRoom
            // 
            this.txtbxNumRoom.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxNumRoom.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbxNumRoom.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbxNumRoom.BorderRadius = 15;
            this.txtbxNumRoom.BorderSize = 2;
            this.txtbxNumRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNumRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbxNumRoom.Location = new System.Drawing.Point(175, 108);
            this.txtbxNumRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNumRoom.Multiline = false;
            this.txtbxNumRoom.Name = "txtbxNumRoom";
            this.txtbxNumRoom.Names = "textBox1";
            this.txtbxNumRoom.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbxNumRoom.PasswordChar = false;
            this.txtbxNumRoom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbxNumRoom.PlaceholderText = "Номер комнаты";
            this.txtbxNumRoom.SignatureOnTop = false;
            this.txtbxNumRoom.Size = new System.Drawing.Size(131, 31);
            this.txtbxNumRoom.TabIndex = 6;
            this.txtbxNumRoom.Texts = "";
            this.txtbxNumRoom.UnderlinedStyle = false;
            this.txtbxNumRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserTextBox1_KeyPress);
            // 
            // txtbxNumFloor
            // 
            this.txtbxNumFloor.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxNumFloor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbxNumFloor.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbxNumFloor.BorderRadius = 15;
            this.txtbxNumFloor.BorderSize = 2;
            this.txtbxNumFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNumFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbxNumFloor.Location = new System.Drawing.Point(175, 55);
            this.txtbxNumFloor.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNumFloor.Multiline = false;
            this.txtbxNumFloor.Name = "txtbxNumFloor";
            this.txtbxNumFloor.Names = "textBox1";
            this.txtbxNumFloor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbxNumFloor.PasswordChar = false;
            this.txtbxNumFloor.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbxNumFloor.PlaceholderText = "Номер этажа";
            this.txtbxNumFloor.SignatureOnTop = false;
            this.txtbxNumFloor.Size = new System.Drawing.Size(131, 31);
            this.txtbxNumFloor.TabIndex = 5;
            this.txtbxNumFloor.Texts = "";
            this.txtbxNumFloor.UnderlinedStyle = false;
            this.txtbxNumFloor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserTextBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(186)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::Dormitory.Properties.Resources.Save;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 5);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // tRoomsStudentsTableAdapter
            // 
            this.tRoomsStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.TParentsTableAdapter = null;
            this.tableAdapterManager.TRoomsTableAdapter = null;
            this.tableAdapterManager.TStudentsTableAdapter = null;
            this.tableAdapterManager.TUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dormitory.DataContextTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // RoomCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRooms);
            this.Name = "RoomCard";
            this.Text = "Новая комната";
            this.Load += new System.EventHandler(this.RoomsCard_Load);
            this.panelRooms.ResumeLayout(false);
            this.panelRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRoomsRoomsBindingNavigator)).EndInit();
            this.tRoomsRoomsBindingNavigator.ResumeLayout(false);
            this.tRoomsRoomsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRoomsRoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRoomsRoomsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Panel panelRooms;
        private DataContext dataContext;
        private System.Windows.Forms.BindingSource tRoomsRoomsBindingSource;
        private DataContextTableAdapters.TStudentsRoomsTableAdapter tRoomsStudentsTableAdapter;
        private DataContextTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tRoomsRoomsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView tRoomsRoomsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private Class.Control.UserTextBox txtbxNumFloor;
        private Class.Control.UserTextBox txtbxNumRoom;
        private System.Windows.Forms.Label label3;
        private Class.Control.UserTextBox txtbxId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fCsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberViolationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn menDataGridViewCheckBoxColumn;
        private Class.Control.UserTextBox txtbxNumSeats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}