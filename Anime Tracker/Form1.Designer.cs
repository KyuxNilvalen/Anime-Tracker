namespace Anime_Tracker
{
    partial class Form1
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label scoreLabel;
            System.Windows.Forms.Label epLabel;
            System.Windows.Forms.Label totalEpLabel;
            System.Windows.Forms.Label typeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.animeListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.animeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animeListDataSet = new Anime_Tracker.animeListDataSet();
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
            this.animeListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.animeListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.epTextBox = new System.Windows.Forms.TextBox();
            this.totalEpTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.animeListTableAdapter = new Anime_Tracker.animeListDataSetTableAdapters.animeListTableAdapter();
            this.tableAdapterManager = new Anime_Tracker.animeListDataSetTableAdapters.TableAdapterManager();
            nameLabel = new System.Windows.Forms.Label();
            scoreLabel = new System.Windows.Forms.Label();
            epLabel = new System.Windows.Forms.Label();
            totalEpLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animeListBindingNavigator)).BeginInit();
            this.animeListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animeListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(507, 81);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new System.Drawing.Point(725, 107);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new System.Drawing.Size(38, 13);
            scoreLabel.TabIndex = 8;
            scoreLabel.Text = "Score:";
            // 
            // epLabel
            // 
            epLabel.AutoSize = true;
            epLabel.Location = new System.Drawing.Point(631, 137);
            epLabel.Name = "epLabel";
            epLabel.Size = new System.Drawing.Size(33, 13);
            epLabel.TabIndex = 10;
            epLabel.Text = "Ep #:";
            // 
            // totalEpLabel
            // 
            totalEpLabel.AutoSize = true;
            totalEpLabel.Location = new System.Drawing.Point(713, 137);
            totalEpLabel.Name = "totalEpLabel";
            totalEpLabel.Size = new System.Drawing.Size(50, 13);
            totalEpLabel.TabIndex = 12;
            totalEpLabel.Text = "Total Ep:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(512, 107);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 6;
            typeLabel.Text = "Type:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 29);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(155, 36);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "My Anime";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(123, 65);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(44, 13);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Ver. 0.2";
            // 
            // animeListBindingNavigator
            // 
            this.animeListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.animeListBindingNavigator.BindingSource = this.animeListBindingSource;
            this.animeListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.animeListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.animeListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.animeListBindingNavigatorSaveItem});
            this.animeListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.animeListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.animeListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.animeListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.animeListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.animeListBindingNavigator.Name = "animeListBindingNavigator";
            this.animeListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.animeListBindingNavigator.Size = new System.Drawing.Size(824, 25);
            this.animeListBindingNavigator.TabIndex = 0;
            this.animeListBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // animeListBindingSource
            // 
            this.animeListBindingSource.DataMember = "animeList";
            this.animeListBindingSource.DataSource = this.animeListDataSet;
            // 
            // animeListDataSet
            // 
            this.animeListDataSet.DataSetName = "animeListDataSet";
            this.animeListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // animeListBindingNavigatorSaveItem
            // 
            this.animeListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.animeListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("animeListBindingNavigatorSaveItem.Image")));
            this.animeListBindingNavigatorSaveItem.Name = "animeListBindingNavigatorSaveItem";
            this.animeListBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.animeListBindingNavigatorSaveItem.Text = "Save Data";
            this.animeListBindingNavigatorSaveItem.Click += new System.EventHandler(this.animeListBindingNavigatorSaveItem_Click);
            // 
            // animeListDataGridView
            // 
            this.animeListDataGridView.AutoGenerateColumns = false;
            this.animeListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.animeListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animeListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.animeListDataGridView.DataSource = this.animeListBindingSource;
            this.animeListDataGridView.Location = new System.Drawing.Point(18, 81);
            this.animeListDataGridView.Name = "animeListDataGridView";
            this.animeListDataGridView.Size = new System.Drawing.Size(483, 595);
            this.animeListDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Score";
            this.dataGridViewTextBoxColumn3.HeaderText = "Score";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ep #";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ep #";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 55;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total Ep";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total Ep";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 72;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn6.HeaderText = "Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 56;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeListBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(551, 77);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(255, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeListBindingSource, "Score", true));
            this.scoreTextBox.Location = new System.Drawing.Point(769, 103);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(37, 20);
            this.scoreTextBox.TabIndex = 9;
            // 
            // epTextBox
            // 
            this.epTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeListBindingSource, "Ep #", true));
            this.epTextBox.Location = new System.Drawing.Point(670, 133);
            this.epTextBox.Name = "epTextBox";
            this.epTextBox.Size = new System.Drawing.Size(37, 20);
            this.epTextBox.TabIndex = 11;
            // 
            // totalEpTextBox
            // 
            this.totalEpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeListBindingSource, "Total Ep", true));
            this.totalEpTextBox.Location = new System.Drawing.Point(769, 133);
            this.totalEpTextBox.Name = "totalEpTextBox";
            this.totalEpTextBox.Size = new System.Drawing.Size(37, 20);
            this.totalEpTextBox.TabIndex = 13;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animeListBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(551, 103);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(168, 20);
            this.typeTextBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(227, 31);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 35);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "&Save Table";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(731, 159);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 15;
            this.updateButton.Text = "&Update Item";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(628, 159);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(91, 23);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "&Add New Item";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // animeListTableAdapter
            // 
            this.animeListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.animeListTableAdapter = this.animeListTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Anime_Tracker.animeListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(824, 850);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(scoreLabel);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(epLabel);
            this.Controls.Add(this.epTextBox);
            this.Controls.Add(totalEpLabel);
            this.Controls.Add(this.totalEpTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.animeListDataGridView);
            this.Controls.Add(this.animeListBindingNavigator);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Anime Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animeListBindingNavigator)).EndInit();
            this.animeListBindingNavigator.ResumeLayout(false);
            this.animeListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animeListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label versionLabel;
        private animeListDataSet animeListDataSet;
        private System.Windows.Forms.BindingSource animeListBindingSource;
        private animeListDataSetTableAdapters.animeListTableAdapter animeListTableAdapter;
        private animeListDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator animeListBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton animeListBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView animeListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.TextBox epTextBox;
        private System.Windows.Forms.TextBox totalEpTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
    }
}

