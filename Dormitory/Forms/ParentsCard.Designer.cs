
namespace Dormitory.Forms
{
    partial class ParentsCard
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
            this.tParentsParentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tParentsParentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.tParentsParentsDataGridView = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxId = new Dormitory.Class.Control.UserTextBox();
            this.txtbxNumberPhone = new Dormitory.Class.Control.UserTextBox();
            this.txtbxFCs = new Dormitory.Class.Control.UserTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tParentsStudentsTableAdapter = new Dormitory.DataContextTableAdapters.TParentsStudentsTableAdapter();
            this.tableAdapterManager = new Dormitory.DataContextTableAdapters.TableAdapterManager();
            this.panelParents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tParentsParentsBindingNavigator)).BeginInit();
            this.tParentsParentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tParentsParentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tParentsParentsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
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
            this.panelParents.Controls.Add(this.tParentsParentsBindingNavigator);
            this.panelParents.Controls.Add(this.tParentsParentsDataGridView);
            this.panelParents.Location = new System.Drawing.Point(0, 171);
            this.panelParents.Margin = new System.Windows.Forms.Padding(0);
            this.panelParents.Name = "panelParents";
            this.panelParents.Size = new System.Drawing.Size(863, 200);
            this.panelParents.TabIndex = 3;
            // 
            // tParentsParentsBindingNavigator
            // 
            this.tParentsParentsBindingNavigator.AddNewItem = null;
            this.tParentsParentsBindingNavigator.BindingSource = this.tParentsParentsBindingSource;
            this.tParentsParentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tParentsParentsBindingNavigator.DeleteItem = null;
            this.tParentsParentsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tParentsParentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tParentsParentsBindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tParentsParentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tParentsParentsBindingNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.tParentsParentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tParentsParentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tParentsParentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tParentsParentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tParentsParentsBindingNavigator.Name = "tParentsParentsBindingNavigator";
            this.tParentsParentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tParentsParentsBindingNavigator.Size = new System.Drawing.Size(863, 23);
            this.tParentsParentsBindingNavigator.TabIndex = 4;
            this.tParentsParentsBindingNavigator.Text = "bindingNavigator1";
            // 
            // tParentsParentsBindingSource
            // 
            this.tParentsParentsBindingSource.DataMember = "TParentsStudents";
            this.tParentsParentsBindingSource.DataSource = this.dataContext;
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
            this.toolStripButton1.Text = "Добавить";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // tParentsParentsDataGridView
            // 
            this.tParentsParentsDataGridView.AllowUserToAddRows = false;
            this.tParentsParentsDataGridView.AllowUserToDeleteRows = false;
            this.tParentsParentsDataGridView.AllowUserToResizeRows = false;
            this.tParentsParentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tParentsParentsDataGridView.AutoGenerateColumns = false;
            this.tParentsParentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tParentsParentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tParentsParentsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tParentsParentsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tParentsParentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tParentsParentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.FCs,
            this.NumberPhone});
            this.tParentsParentsDataGridView.DataSource = this.tParentsParentsBindingSource;
            this.tParentsParentsDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.tParentsParentsDataGridView.Location = new System.Drawing.Point(0, 24);
            this.tParentsParentsDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.tParentsParentsDataGridView.MultiSelect = false;
            this.tParentsParentsDataGridView.Name = "tParentsParentsDataGridView";
            this.tParentsParentsDataGridView.ReadOnly = true;
            this.tParentsParentsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tParentsParentsDataGridView.RowHeadersVisible = false;
            this.tParentsParentsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tParentsParentsDataGridView.RowTemplate.ReadOnly = true;
            this.tParentsParentsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tParentsParentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tParentsParentsDataGridView.Size = new System.Drawing.Size(863, 176);
            this.tParentsParentsDataGridView.TabIndex = 1;
            this.tParentsParentsDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TParentsParentsDataGridView_CellMouseDoubleClick);
            // 
            // Num
            // 
            this.Num.DataPropertyName = "IdS";
            this.Num.HeaderText = "Код";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // FCs
            // 
            this.FCs.DataPropertyName = "FCsS";
            this.FCs.HeaderText = "ФИО";
            this.FCs.Name = "FCs";
            this.FCs.ReadOnly = true;
            // 
            // NumberPhone
            // 
            this.NumberPhone.DataPropertyName = "NumPhS";
            this.NumberPhone.HeaderText = "Номер телефона";
            this.NumberPhone.Name = "NumberPhone";
            this.NumberPhone.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtbxId);
            this.panel1.Controls.Add(this.txtbxNumberPhone);
            this.panel1.Controls.Add(this.txtbxFCs);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 168);
            this.panel1.TabIndex = 4;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
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
            // ParentsCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelParents);
            this.Name = "ParentsCard";
            this.Text = "Новый родитель";
            this.Load += new System.EventHandler(this.ParentsCard_Load);
            this.panelParents.ResumeLayout(false);
            this.panelParents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tParentsParentsBindingNavigator)).EndInit();
            this.tParentsParentsBindingNavigator.ResumeLayout(false);
            this.tParentsParentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tParentsParentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tParentsParentsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Panel panelParents;
        private DataContext dataContext;
        private System.Windows.Forms.BindingSource tParentsParentsBindingSource;
        private DataContextTableAdapters.TParentsStudentsTableAdapter tParentsStudentsTableAdapter;
        private DataContextTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tParentsParentsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView tParentsParentsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private Class.Control.UserTextBox txtbxFCs;
        private Class.Control.UserTextBox txtbxNumberPhone;
        private System.Windows.Forms.Label label3;
        private Class.Control.UserTextBox txtbxId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn FCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberPhone;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}