
namespace Dormitory.Forms
{
    partial class StudentsCard
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
            this.panelParents = new System.Windows.Forms.Panel();
            this.tParentsStudentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tParentsStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tParentsStudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.userRoom = new Dormitory.Class.Control.UserTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxId = new Dormitory.Class.Control.UserTextBox();
            this.cmbbxGender = new Dormitory.Class.Control.UserComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxNumEr = new Dormitory.Class.Control.UserTextBox();
            this.txtbxNumberPhone = new Dormitory.Class.Control.UserTextBox();
            this.txtbxFCs = new Dormitory.Class.Control.UserTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tParentsStudentsTableAdapter = new Dormitory.DataContextTableAdapters.TParentsStudentsTableAdapter();
            this.tableAdapterManager = new Dormitory.DataContextTableAdapters.TableAdapterManager();
            this.panelParents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tParentsStudentsBindingNavigator)).BeginInit();
            this.tParentsStudentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tParentsStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tParentsStudentsDataGridView)).BeginInit();
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
            // panelParents
            // 
            this.panelParents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelParents.Controls.Add(this.tParentsStudentsBindingNavigator);
            this.panelParents.Controls.Add(this.tParentsStudentsDataGridView);
            this.panelParents.Location = new System.Drawing.Point(0, 201);
            this.panelParents.Margin = new System.Windows.Forms.Padding(0);
            this.panelParents.Name = "panelParents";
            this.panelParents.Size = new System.Drawing.Size(903, 210);
            this.panelParents.TabIndex = 3;
            // 
            // tParentsStudentsBindingNavigator
            // 
            this.tParentsStudentsBindingNavigator.AddNewItem = null;
            this.tParentsStudentsBindingNavigator.BindingSource = this.tParentsStudentsBindingSource;
            this.tParentsStudentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tParentsStudentsBindingNavigator.DeleteItem = null;
            this.tParentsStudentsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tParentsStudentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tParentsStudentsBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tParentsStudentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tParentsStudentsBindingNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.tParentsStudentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tParentsStudentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tParentsStudentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tParentsStudentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tParentsStudentsBindingNavigator.Name = "tParentsStudentsBindingNavigator";
            this.tParentsStudentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tParentsStudentsBindingNavigator.Size = new System.Drawing.Size(903, 23);
            this.tParentsStudentsBindingNavigator.TabIndex = 4;
            this.tParentsStudentsBindingNavigator.Text = "bindingNavigator1";
            // 
            // tParentsStudentsBindingSource
            // 
            this.tParentsStudentsBindingSource.DataMember = "TParentsStudents";
            this.tParentsStudentsBindingSource.DataSource = this.dataContext;
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
            this.toolStripButton2.Text = "Удалить";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Dormitory.Properties.Resources.Add;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
            this.toolStripButton1.Text = "Новый студент";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // tParentsStudentsDataGridView
            // 
            this.tParentsStudentsDataGridView.AllowUserToAddRows = false;
            this.tParentsStudentsDataGridView.AllowUserToDeleteRows = false;
            this.tParentsStudentsDataGridView.AllowUserToResizeRows = false;
            this.tParentsStudentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tParentsStudentsDataGridView.AutoGenerateColumns = false;
            this.tParentsStudentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tParentsStudentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tParentsStudentsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tParentsStudentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tParentsStudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tParentsStudentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.FCs,
            this.NumberPhone});
            this.tParentsStudentsDataGridView.DataSource = this.tParentsStudentsBindingSource;
            this.tParentsStudentsDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.tParentsStudentsDataGridView.Location = new System.Drawing.Point(0, 24);
            this.tParentsStudentsDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.tParentsStudentsDataGridView.MultiSelect = false;
            this.tParentsStudentsDataGridView.Name = "tParentsStudentsDataGridView";
            this.tParentsStudentsDataGridView.ReadOnly = true;
            this.tParentsStudentsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tParentsStudentsDataGridView.RowHeadersVisible = false;
            this.tParentsStudentsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tParentsStudentsDataGridView.RowTemplate.ReadOnly = true;
            this.tParentsStudentsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tParentsStudentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tParentsStudentsDataGridView.Size = new System.Drawing.Size(903, 186);
            this.tParentsStudentsDataGridView.TabIndex = 1;
            this.tParentsStudentsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TParentsStudentsDataGridView_CellMouseDoubleClick);
            // 
            // Num
            // 
            this.Num.DataPropertyName = "Id";
            this.Num.HeaderText = "Код";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // FCs
            // 
            this.FCs.DataPropertyName = "FCs";
            this.FCs.HeaderText = "ФИО";
            this.FCs.Name = "FCs";
            this.FCs.ReadOnly = true;
            // 
            // NumberPhone
            // 
            this.NumberPhone.DataPropertyName = "NumberPhone";
            this.NumberPhone.HeaderText = "Номер телефона";
            this.NumberPhone.Name = "NumberPhone";
            this.NumberPhone.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.userRoom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtbxId);
            this.panel1.Controls.Add(this.cmbbxGender);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtbxNumEr);
            this.panel1.Controls.Add(this.txtbxNumberPhone);
            this.panel1.Controls.Add(this.txtbxFCs);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 198);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(186)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(860, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // userRoom
            // 
            this.userRoom.BackColor = System.Drawing.SystemColors.Window;
            this.userRoom.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.userRoom.BorderFocusColor = System.Drawing.Color.HotPink;
            this.userRoom.BorderRadius = 15;
            this.userRoom.BorderSize = 2;
            this.userRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userRoom.Location = new System.Drawing.Point(534, 49);
            this.userRoom.Margin = new System.Windows.Forms.Padding(4);
            this.userRoom.Multiline = false;
            this.userRoom.Name = "userRoom";
            this.userRoom.Names = "userRoom";
            this.userRoom.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userRoom.PasswordChar = false;
            this.userRoom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.userRoom.PlaceholderText = "Комната проживания";
            this.userRoom.SignatureOnTop = true;
            this.userRoom.Size = new System.Drawing.Size(321, 31);
            this.userRoom.TabIndex = 13;
            this.userRoom.Texts = "";
            this.userRoom.UnderlinedStyle = false;
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
            // cmbbxGender
            // 
            this.cmbbxGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbbxGender.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbbxGender.BorderSize = 1;
            this.cmbbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbbxGender.ForeColor = System.Drawing.Color.DimGray;
            this.cmbbxGender.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbbxGender.Items.AddRange(new object[] {
            "Ж",
            "М"});
            this.cmbbxGender.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbbxGender.ListTextColor = System.Drawing.Color.Black;
            this.cmbbxGender.Location = new System.Drawing.Point(67, 142);
            this.cmbbxGender.Name = "cmbbxGender";
            this.cmbbxGender.Padding = new System.Windows.Forms.Padding(1);
            this.cmbbxGender.Size = new System.Drawing.Size(100, 30);
            this.cmbbxGender.TabIndex = 10;
            this.cmbbxGender.Texts = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Пол:";
            // 
            // txtbxNumEr
            // 
            this.txtbxNumEr.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxNumEr.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbxNumEr.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbxNumEr.BorderRadius = 15;
            this.txtbxNumEr.BorderSize = 2;
            this.txtbxNumEr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNumEr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbxNumEr.Location = new System.Drawing.Point(406, 141);
            this.txtbxNumEr.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNumEr.Multiline = false;
            this.txtbxNumEr.Name = "txtbxNumEr";
            this.txtbxNumEr.Names = "textBox1";
            this.txtbxNumEr.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbxNumEr.PasswordChar = false;
            this.txtbxNumEr.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbxNumEr.PlaceholderText = "0";
            this.txtbxNumEr.SignatureOnTop = false;
            this.txtbxNumEr.Size = new System.Drawing.Size(89, 31);
            this.txtbxNumEr.TabIndex = 7;
            this.txtbxNumEr.Texts = "";
            this.txtbxNumEr.UnderlinedStyle = false;
            this.txtbxNumEr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserTextBox1_KeyPress);
            // 
            // txtbxNumberPhone
            // 
            this.txtbxNumberPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxNumberPhone.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbxNumberPhone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbxNumberPhone.BorderRadius = 15;
            this.txtbxNumberPhone.BorderSize = 2;
            this.txtbxNumberPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNumberPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbxNumberPhone.Location = new System.Drawing.Point(13, 96);
            this.txtbxNumberPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxNumberPhone.Multiline = false;
            this.txtbxNumberPhone.Name = "txtbxNumberPhone";
            this.txtbxNumberPhone.Names = "textBox1";
            this.txtbxNumberPhone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbxNumberPhone.PasswordChar = false;
            this.txtbxNumberPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbxNumberPhone.PlaceholderText = "Номер телефона";
            this.txtbxNumberPhone.SignatureOnTop = true;
            this.txtbxNumberPhone.Size = new System.Drawing.Size(482, 31);
            this.txtbxNumberPhone.TabIndex = 6;
            this.txtbxNumberPhone.Texts = "";
            this.txtbxNumberPhone.UnderlinedStyle = false;
            // 
            // txtbxFCs
            // 
            this.txtbxFCs.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxFCs.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtbxFCs.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtbxFCs.BorderRadius = 15;
            this.txtbxFCs.BorderSize = 2;
            this.txtbxFCs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxFCs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbxFCs.Location = new System.Drawing.Point(13, 49);
            this.txtbxFCs.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxFCs.Multiline = false;
            this.txtbxFCs.Name = "txtbxFCs";
            this.txtbxFCs.Names = "textBox1";
            this.txtbxFCs.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbxFCs.PasswordChar = false;
            this.txtbxFCs.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbxFCs.PlaceholderText = "ФИО";
            this.txtbxFCs.SignatureOnTop = true;
            this.txtbxFCs.Size = new System.Drawing.Size(482, 31);
            this.txtbxFCs.TabIndex = 5;
            this.txtbxFCs.Texts = "";
            this.txtbxFCs.UnderlinedStyle = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(173, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество нарушений:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // tParentsStudentsTableAdapter
            // 
            this.tParentsStudentsTableAdapter.ClearBeforeFill = true;
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
            // StudentsCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelParents);
            this.Name = "StudentsCard";
            this.Text = "Новый студент";
            this.Load += new System.EventHandler(this.StudentsCard_Load);
            this.panelParents.ResumeLayout(false);
            this.panelParents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tParentsStudentsBindingNavigator)).EndInit();
            this.tParentsStudentsBindingNavigator.ResumeLayout(false);
            this.tParentsStudentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tParentsStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tParentsStudentsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Panel panelParents;
        private DataContext dataContext;
        private System.Windows.Forms.BindingSource tParentsStudentsBindingSource;
        private DataContextTableAdapters.TParentsStudentsTableAdapter tParentsStudentsTableAdapter;
        private DataContextTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tParentsStudentsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView tParentsStudentsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Class.Control.UserTextBox txtbxFCs;
        private Class.Control.UserTextBox txtbxNumEr;
        private Class.Control.UserTextBox txtbxNumberPhone;
        private System.Windows.Forms.Label label2;
        private Class.Control.UserComboBox cmbbxGender;
        private System.Windows.Forms.Label label3;
        private Class.Control.UserTextBox txtbxId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn FCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberPhone;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private Class.Control.UserTextBox userRoom;
        private System.Windows.Forms.Button button2;
    }
}