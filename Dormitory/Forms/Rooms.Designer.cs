
namespace Dormitory.Forms
{
    partial class Rooms
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
            this.dataContext = new Dormitory.DataContext();
            this.tRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Dormitory.DataContextTableAdapters.TableAdapterManager();
            this.tRoomsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tRoomsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tRoomsDataGridView = new System.Windows.Forms.DataGridView();
            this.dtgrdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrdNumberRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrdNumberFloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrdNumberSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrdNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tRoomsTableAdapter = new Dormitory.DataContextTableAdapters.TRoomsTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.UpDown = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tRoomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRoomsBindingNavigator)).BeginInit();
            this.tRoomsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRoomsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRoomsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataContext
            // 
            this.dataContext.DataSetName = "DataContext";
            this.dataContext.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRoomsBindingSource
            // 
            this.tRoomsBindingSource.DataMember = "TRooms";
            this.tRoomsBindingSource.DataSource = this.dataContext;
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
            // tRoomsBindingNavigator
            // 
            this.tRoomsBindingNavigator.AddNewItem = null;
            this.tRoomsBindingNavigator.BackColor = System.Drawing.Color.White;
            this.tRoomsBindingNavigator.BindingSource = this.tRoomsBindingSource;
            this.tRoomsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tRoomsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tRoomsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tRoomsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tRoomsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.tRoomsBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.tRoomsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tRoomsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tRoomsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tRoomsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tRoomsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tRoomsBindingNavigator.Name = "tRoomsBindingNavigator";
            this.tRoomsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tRoomsBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tRoomsBindingNavigator.Size = new System.Drawing.Size(1005, 26);
            this.tRoomsBindingNavigator.TabIndex = 0;
            this.tRoomsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 23);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::Dormitory.Properties.Resources.Del;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::Dormitory.Properties.Resources.BackArrowDouble;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::Dormitory.Properties.Resources.BackArrow;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 26);
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
            this.bindingNavigatorSeparator1.BackColor = System.Drawing.Color.Black;
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::Dormitory.Properties.Resources.ForwardArrow;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::Dormitory.Properties.Resources.ForwardArrowDouble;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // tRoomsBindingNavigatorSaveItem
            // 
            this.tRoomsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tRoomsBindingNavigatorSaveItem.Image = global::Dormitory.Properties.Resources.Save;
            this.tRoomsBindingNavigatorSaveItem.Name = "tRoomsBindingNavigatorSaveItem";
            this.tRoomsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tRoomsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tRoomsBindingNavigatorSaveItem.Click += new System.EventHandler(this.TRoomsBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton1.Image = global::Dormitory.Properties.Resources.Add;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton1.Text = "Добавить";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // tRoomsDataGridView
            // 
            this.tRoomsDataGridView.AllowUserToAddRows = false;
            this.tRoomsDataGridView.AllowUserToResizeRows = false;
            this.tRoomsDataGridView.AutoGenerateColumns = false;
            this.tRoomsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tRoomsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tRoomsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tRoomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tRoomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgrdId,
            this.dtgrdNumberRoom,
            this.dtgrdNumberFloor,
            this.dtgrdNumberSeats,
            this.dtgrdNum});
            this.tRoomsDataGridView.DataSource = this.tRoomsBindingSource;
            this.tRoomsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tRoomsDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.tRoomsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tRoomsDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.tRoomsDataGridView.MultiSelect = false;
            this.tRoomsDataGridView.Name = "tRoomsDataGridView";
            this.tRoomsDataGridView.ReadOnly = true;
            this.tRoomsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tRoomsDataGridView.RowHeadersVisible = false;
            this.tRoomsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tRoomsDataGridView.RowTemplate.ReadOnly = true;
            this.tRoomsDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tRoomsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tRoomsDataGridView.Size = new System.Drawing.Size(1005, 481);
            this.tRoomsDataGridView.TabIndex = 1;
            this.tRoomsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TRoomsDataGridView_CellDoubleClick);
            this.tRoomsDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.TRoomsDataGridView_RowsAdded);
            // 
            // dtgrdId
            // 
            this.dtgrdId.DataPropertyName = "Id";
            this.dtgrdId.HeaderText = "Номер";
            this.dtgrdId.Name = "dtgrdId";
            this.dtgrdId.ReadOnly = true;
            // 
            // dtgrdNumberRoom
            // 
            this.dtgrdNumberRoom.DataPropertyName = "NumberRoom";
            this.dtgrdNumberRoom.HeaderText = "Номер комнаты";
            this.dtgrdNumberRoom.Name = "dtgrdNumberRoom";
            this.dtgrdNumberRoom.ReadOnly = true;
            // 
            // dtgrdNumberFloor
            // 
            this.dtgrdNumberFloor.DataPropertyName = "NumberFloor";
            this.dtgrdNumberFloor.HeaderText = "Номер этажа";
            this.dtgrdNumberFloor.Name = "dtgrdNumberFloor";
            this.dtgrdNumberFloor.ReadOnly = true;
            // 
            // dtgrdNumberSeats
            // 
            this.dtgrdNumberSeats.DataPropertyName = "NumberSeats";
            this.dtgrdNumberSeats.HeaderText = "Количество мест (общ.)";
            this.dtgrdNumberSeats.Name = "dtgrdNumberSeats";
            this.dtgrdNumberSeats.ReadOnly = true;
            // 
            // dtgrdNum
            // 
            this.dtgrdNum.HeaderText = "Осталось мест";
            this.dtgrdNum.Name = "dtgrdNum";
            this.dtgrdNum.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.tRoomsDataGridView);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 481);
            this.panel1.TabIndex = 2;
            // 
            // tRoomsTableAdapter
            // 
            this.tRoomsTableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1005, 10);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // UpDown
            // 
            this.UpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UpDown.BackColor = System.Drawing.Color.White;
            this.UpDown.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.UpDown.FlatAppearance.BorderSize = 0;
            this.UpDown.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UpDown.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.UpDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpDown.Image = global::Dormitory.Properties.Resources.BlackDown;
            this.UpDown.Location = new System.Drawing.Point(490, 0);
            this.UpDown.Name = "UpDown";
            this.UpDown.Size = new System.Drawing.Size(25, 25);
            this.UpDown.TabIndex = 3;
            this.UpDown.UseVisualStyleBackColor = false;
            this.UpDown.Click += new System.EventHandler(this.UpDown_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.UpDown);
            this.panel2.Controls.Add(this.tRoomsBindingNavigator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 26);
            this.panel2.TabIndex = 4;
            // 
            // tRoomsBindingSource1
            // 
            this.tRoomsBindingSource1.DataMember = "TRooms";
            this.tRoomsBindingSource1.DataSource = this.dataContext;
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Rooms";
            this.Text = "Родители";
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRoomsBindingNavigator)).EndInit();
            this.tRoomsBindingNavigator.ResumeLayout(false);
            this.tRoomsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRoomsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRoomsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataContext dataContext;
        private System.Windows.Forms.BindingSource tRoomsBindingSource;
        private DataContextTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tRoomsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tRoomsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tRoomsDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DataContextTableAdapters.TRoomsTableAdapter tRoomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrdNumberRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrdNumberFloor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrdNumberSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrdNum;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button UpDown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource tRoomsBindingSource1;
    }
}