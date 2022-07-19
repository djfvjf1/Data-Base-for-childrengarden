
namespace ChildrenDB
{
    partial class ElderGroup
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формаОплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.month1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detishkiDataSet2 = new ChildrenDB.DetishkiDataSet2();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.data2FIO2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.daysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayAttenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fIO2Attendance2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data2TableAdapter = new ChildrenDB.DetishkiDataSet2TableAdapters.Data2TableAdapter();
            this.fIO2TableAdapter = new ChildrenDB.DetishkiDataSet2TableAdapters.FIO2TableAdapter();
            this.attendance2TableAdapter = new ChildrenDB.DetishkiDataSet2TableAdapters.Attendance2TableAdapter();
            this.name1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payFormDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detishkiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2FIO2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIO2Attendance2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(422, 453);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(249, 87);
            this.button5.TabIndex = 16;
            this.button5.Text = "Сохранить внесенные в таблицу данные";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(967, 582);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 38);
            this.button4.TabIndex = 12;
            this.button4.Text = "Обновить таблицу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1186, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фамилииToolStripMenuItem,
            this.формаОплатыToolStripMenuItem});
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(93, 21);
            this.searchToolStripMenuItem.Text = "Поиск детей";
            // 
            // фамилииToolStripMenuItem
            // 
            this.фамилииToolStripMenuItem.Name = "фамилииToolStripMenuItem";
            this.фамилииToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.фамилииToolStripMenuItem.Text = "Фамилии";
            this.фамилииToolStripMenuItem.Click += new System.EventHandler(this.фамилииToolStripMenuItem_Click);
            // 
            // формаОплатыToolStripMenuItem
            // 
            this.формаОплатыToolStripMenuItem.Name = "формаОплатыToolStripMenuItem";
            this.формаОплатыToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.формаОплатыToolStripMenuItem.Text = "Форма оплаты";
            this.формаОплатыToolStripMenuItem.Click += new System.EventHandler(this.формаОплатыToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.month1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.data2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(144, 369);
            this.dataGridView1.TabIndex = 17;
            // 
            // month1DataGridViewTextBoxColumn
            // 
            this.month1DataGridViewTextBoxColumn.DataPropertyName = "Month1";
            this.month1DataGridViewTextBoxColumn.HeaderText = "Month1";
            this.month1DataGridViewTextBoxColumn.Name = "month1DataGridViewTextBoxColumn";
            // 
            // data2BindingSource
            // 
            this.data2BindingSource.DataMember = "Data2";
            this.data2BindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.detishkiDataSet2;
            this.bindingSource1.Position = 0;
            // 
            // detishkiDataSet2
            // 
            this.detishkiDataSet2.DataSetName = "DetishkiDataSet2";
            this.detishkiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name1DataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.payFormDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.data2FIO2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(274, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(545, 369);
            this.dataGridView2.TabIndex = 18;
            // 
            // data2FIO2BindingSource
            // 
            this.data2FIO2BindingSource.DataMember = "Data2FIO2";
            this.data2FIO2BindingSource.DataSource = this.data2BindingSource;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.daysDataGridViewTextBoxColumn,
            this.dayAttenDataGridViewCheckBoxColumn});
            this.dataGridView3.DataSource = this.fIO2Attendance2BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(889, 61);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(244, 369);
            this.dataGridView3.TabIndex = 19;
            // 
            // daysDataGridViewTextBoxColumn
            // 
            this.daysDataGridViewTextBoxColumn.DataPropertyName = "Days";
            this.daysDataGridViewTextBoxColumn.HeaderText = "Days";
            this.daysDataGridViewTextBoxColumn.Name = "daysDataGridViewTextBoxColumn";
            // 
            // dayAttenDataGridViewCheckBoxColumn
            // 
            this.dayAttenDataGridViewCheckBoxColumn.DataPropertyName = "DayAtten";
            this.dayAttenDataGridViewCheckBoxColumn.HeaderText = "DayAtten";
            this.dayAttenDataGridViewCheckBoxColumn.Name = "dayAttenDataGridViewCheckBoxColumn";
            // 
            // fIO2Attendance2BindingSource
            // 
            this.fIO2Attendance2BindingSource.DataMember = "FIO2Attendance2";
            this.fIO2Attendance2BindingSource.DataSource = this.data2FIO2BindingSource;
            // 
            // data2TableAdapter
            // 
            this.data2TableAdapter.ClearBeforeFill = true;
            // 
            // fIO2TableAdapter
            // 
            this.fIO2TableAdapter.ClearBeforeFill = true;
            // 
            // attendance2TableAdapter
            // 
            this.attendance2TableAdapter.ClearBeforeFill = true;
            // 
            // name1DataGridViewTextBoxColumn
            // 
            this.name1DataGridViewTextBoxColumn.DataPropertyName = "Name1";
            this.name1DataGridViewTextBoxColumn.HeaderText = "Name1";
            this.name1DataGridViewTextBoxColumn.Name = "name1DataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // payFormDataGridViewTextBoxColumn
            // 
            this.payFormDataGridViewTextBoxColumn.DataPropertyName = "PayForm";
            this.payFormDataGridViewTextBoxColumn.HeaderText = "PayForm";
            this.payFormDataGridViewTextBoxColumn.Name = "payFormDataGridViewTextBoxColumn";
            // 
            // ElderGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 632);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ElderGroup";
            this.Text = "ElderGroup";
            this.Load += new System.EventHandler(this.ElderGroup_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detishkiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data2FIO2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIO2Attendance2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формаОплатыToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DetishkiDataSet2 detishkiDataSet2;
        private System.Windows.Forms.BindingSource data2BindingSource;
        private DetishkiDataSet2TableAdapters.Data2TableAdapter data2TableAdapter;
        private System.Windows.Forms.BindingSource data2FIO2BindingSource;
        private DetishkiDataSet2TableAdapters.FIO2TableAdapter fIO2TableAdapter;
        private System.Windows.Forms.BindingSource fIO2Attendance2BindingSource;
        private DetishkiDataSet2TableAdapters.Attendance2TableAdapter attendance2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn month1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dayAttenDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payFormDataGridViewTextBoxColumn;
    }
}