
namespace Dormitory.Forms
{
    partial class Settings
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
            this.tUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tUsersTableAdapter = new Dormitory.DataContextTableAdapters.TUsersTableAdapter();
            this.tableAdapterManager = new Dormitory.DataContextTableAdapters.TableAdapterManager();
            this.tUsersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.tUsersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UpDown = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgrdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrdPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgrdAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUsersBindingNavigator)).BeginInit();
            this.tUsersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tUsersDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataContext
            // 
            this.dataContext.DataSetName = "DataContext";
            this.dataContext.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tUsersBindingSource
            // 
            this.tUsersBindingSource.DataMember = "TUsers";
            this.tUsersBindingSource.DataSource = this.dataContext;
            // 
            // tUsersTableAdapter
            // 
            this.tUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TParentsTableAdapter = null;
            this.tableAdapterManager.TRoomsTableAdapter = null;
            this.tableAdapterManager.TStudentsTableAdapter = null;
            this.tableAdapterManager.TUsersTableAdapter = this.tUsersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Dormitory.DataContextTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tUsersBindingNavigator
            // 
            this.tUsersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tUsersBindingNavigator.BackColor = System.Drawing.Color.White;
            this.tUsersBindingNavigator.BindingSource = this.tUsersBindingSource;
            this.tUsersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tUsersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tUsersBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tUsersBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tUsersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tUsersBindingNavigatorSaveItem,
            this.bindingNavigatorAddNewItem});
            this.tUsersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tUsersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tUsersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tUsersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tUsersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tUsersBindingNavigator.Name = "tUsersBindingNavigator";
            this.tUsersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tUsersBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tUsersBindingNavigator.Size = new System.Drawing.Size(800, 26);
            this.tUsersBindingNavigator.TabIndex = 0;
            this.tUsersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::Dormitory.Properties.Resources.Add;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.BackColor = System.Drawing.Color.White;
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
            // tUsersBindingNavigatorSaveItem
            // 
            this.tUsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tUsersBindingNavigatorSaveItem.Image = global::Dormitory.Properties.Resources.Save;
            this.tUsersBindingNavigatorSaveItem.Name = "tUsersBindingNavigatorSaveItem";
            this.tUsersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tUsersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tUsersBindingNavigatorSaveItem.Click += new System.EventHandler(this.tUsersBindingNavigatorSaveItem_Click);
            // 
            // tUsersDataGridView
            // 
            this.tUsersDataGridView.AllowUserToAddRows = false;
            this.tUsersDataGridView.AllowUserToResizeRows = false;
            this.tUsersDataGridView.AutoGenerateColumns = false;
            this.tUsersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tUsersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tUsersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tUsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgrdId,
            this.dtgrdName,
            this.dtgrdPassword,
            this.dtgrdAdmin});
            this.tUsersDataGridView.DataSource = this.tUsersBindingSource;
            this.tUsersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tUsersDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.tUsersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tUsersDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.tUsersDataGridView.MultiSelect = false;
            this.tUsersDataGridView.Name = "tUsersDataGridView";
            this.tUsersDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tUsersDataGridView.RowHeadersVisible = false;
            this.tUsersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tUsersDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tUsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tUsersDataGridView.Size = new System.Drawing.Size(800, 365);
            this.tUsersDataGridView.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.tUsersDataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 365);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.UpDown);
            this.panel2.Controls.Add(this.tUsersBindingNavigator);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 26);
            this.panel2.TabIndex = 3;
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
            this.UpDown.Location = new System.Drawing.Point(388, 1);
            this.UpDown.Name = "UpDown";
            this.UpDown.Size = new System.Drawing.Size(25, 25);
            this.UpDown.TabIndex = 4;
            this.UpDown.UseVisualStyleBackColor = false;
            this.UpDown.Click += new System.EventHandler(this.UpDown_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 10);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // dtgrdId
            // 
            this.dtgrdId.DataPropertyName = "Id";
            this.dtgrdId.HeaderText = "Код";
            this.dtgrdId.Name = "dtgrdId";
            this.dtgrdId.ReadOnly = true;
            // 
            // dtgrdName
            // 
            this.dtgrdName.DataPropertyName = "Name";
            this.dtgrdName.HeaderText = "Логин";
            this.dtgrdName.Name = "dtgrdName";
            // 
            // dtgrdPassword
            // 
            this.dtgrdPassword.DataPropertyName = "Password";
            this.dtgrdPassword.HeaderText = "Пароль";
            this.dtgrdPassword.Name = "dtgrdPassword";
            // 
            // dtgrdAdmin
            // 
            this.dtgrdAdmin.DataPropertyName = "Admin";
            this.dtgrdAdmin.FalseValue = "false";
            this.dtgrdAdmin.HeaderText = "Права администратора";
            this.dtgrdAdmin.Name = "dtgrdAdmin";
            this.dtgrdAdmin.TrueValue = "true";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Settings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUsersBindingNavigator)).EndInit();
            this.tUsersBindingNavigator.ResumeLayout(false);
            this.tUsersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tUsersDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataContext dataContext;
        private System.Windows.Forms.BindingSource tUsersBindingSource;
        private DataContextTableAdapters.TUsersTableAdapter tUsersTableAdapter;
        private DataContextTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tUsersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private System.Windows.Forms.ToolStripButton tUsersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tUsersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button UpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgrdPassword;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dtgrdAdmin;
    }
}