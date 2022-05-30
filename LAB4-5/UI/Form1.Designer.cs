namespace LAB4_5
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
            this.questInfoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questDBDataSet = new LAB4_5.QuestDBDataSet();
            this.questInfoesTableAdapter = new LAB4_5.QuestDBDataSetTableAdapters.QuestInfoesTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.questDBDataSet1 = new LAB4_5.QuestDBDataSet1();
            this.questInfoesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.questInfoesTableAdapter1 = new LAB4_5.QuestDBDataSet1TableAdapters.QuestInfoesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.questDBDataSet2 = new LAB4_5.QuestDBDataSet2();
            this.questInfoesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.questInfoesTableAdapter2 = new LAB4_5.QuestDBDataSet2TableAdapters.QuestInfoesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfQuestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitMemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfMemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeTimeFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeTimeToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.questInfoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questInfoesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questInfoesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // questInfoesBindingSource
            // 
            this.questInfoesBindingSource.DataMember = "QuestInfoes";
            this.questInfoesBindingSource.DataSource = this.questDBDataSet;
            // 
            // questDBDataSet
            // 
            this.questDBDataSet.DataSetName = "QuestDBDataSet";
            this.questDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questInfoesTableAdapter
            // 
            this.questInfoesTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(120, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Забронювати квест";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(431, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 62);
            this.button3.TabIndex = 3;
            this.button3.Text = "Пошук квесту";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label4.Location = new System.Drawing.Point(196, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Виберіть назву квесту для бронювання ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(50, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(6, 2);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(431, 323);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 22);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(445, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введіть назву квесту";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label5.Location = new System.Drawing.Point(426, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = " ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1200, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 22);
            this.textBox1.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1200, 323);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 22);
            this.textBox3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.label6.Location = new System.Drawing.Point(116, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(116, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 17;
            // 
            // questDBDataSet1
            // 
            this.questDBDataSet1.DataSetName = "QuestDBDataSet1";
            this.questDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questInfoesBindingSource1
            // 
            this.questInfoesBindingSource1.DataMember = "QuestInfoes";
            this.questInfoesBindingSource1.DataSource = this.questDBDataSet1;
            // 
            // questInfoesTableAdapter1
            // 
            this.questInfoesTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameOfQuestDataGridViewTextBoxColumn,
            this.limitMemberDataGridViewTextBoxColumn,
            this.numberOfMemberDataGridViewTextBoxColumn,
            this.freeTimeFromDataGridViewTextBoxColumn,
            this.freeTimeToDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.questInfoesBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(-55, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(909, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // questDBDataSet2
            // 
            this.questDBDataSet2.DataSetName = "QuestDBDataSet2";
            this.questDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questInfoesBindingSource2
            // 
            this.questInfoesBindingSource2.DataMember = "QuestInfoes";
            this.questInfoesBindingSource2.DataSource = this.questDBDataSet2;
            // 
            // questInfoesTableAdapter2
            // 
            this.questInfoesTableAdapter2.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameOfQuestDataGridViewTextBoxColumn
            // 
            this.nameOfQuestDataGridViewTextBoxColumn.DataPropertyName = "NameOfQuest";
            this.nameOfQuestDataGridViewTextBoxColumn.HeaderText = "NameOfQuest";
            this.nameOfQuestDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameOfQuestDataGridViewTextBoxColumn.Name = "nameOfQuestDataGridViewTextBoxColumn";
            this.nameOfQuestDataGridViewTextBoxColumn.Width = 125;
            // 
            // limitMemberDataGridViewTextBoxColumn
            // 
            this.limitMemberDataGridViewTextBoxColumn.DataPropertyName = "LimitMember";
            this.limitMemberDataGridViewTextBoxColumn.HeaderText = "LimitMember";
            this.limitMemberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.limitMemberDataGridViewTextBoxColumn.Name = "limitMemberDataGridViewTextBoxColumn";
            this.limitMemberDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberOfMemberDataGridViewTextBoxColumn
            // 
            this.numberOfMemberDataGridViewTextBoxColumn.DataPropertyName = "NumberOfMember";
            this.numberOfMemberDataGridViewTextBoxColumn.HeaderText = "NumberOfMember";
            this.numberOfMemberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberOfMemberDataGridViewTextBoxColumn.Name = "numberOfMemberDataGridViewTextBoxColumn";
            this.numberOfMemberDataGridViewTextBoxColumn.Width = 125;
            // 
            // freeTimeFromDataGridViewTextBoxColumn
            // 
            this.freeTimeFromDataGridViewTextBoxColumn.DataPropertyName = "freeTimeFrom";
            this.freeTimeFromDataGridViewTextBoxColumn.HeaderText = "freeTimeFrom";
            this.freeTimeFromDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.freeTimeFromDataGridViewTextBoxColumn.Name = "freeTimeFromDataGridViewTextBoxColumn";
            this.freeTimeFromDataGridViewTextBoxColumn.Width = 125;
            // 
            // freeTimeToDataGridViewTextBoxColumn
            // 
            this.freeTimeToDataGridViewTextBoxColumn.DataPropertyName = "freeTimeTo";
            this.freeTimeToDataGridViewTextBoxColumn.HeaderText = "freeTimeTo";
            this.freeTimeToDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.freeTimeToDataGridViewTextBoxColumn.Name = "freeTimeToDataGridViewTextBoxColumn";
            this.freeTimeToDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questInfoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questInfoesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questInfoesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QuestDBDataSet questDBDataSet;
        private System.Windows.Forms.BindingSource questInfoesBindingSource;
        private QuestDBDataSetTableAdapters.QuestInfoesTableAdapter questInfoesTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private QuestDBDataSet1 questDBDataSet1;
        private System.Windows.Forms.BindingSource questInfoesBindingSource1;
        private QuestDBDataSet1TableAdapters.QuestInfoesTableAdapter questInfoesTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QuestDBDataSet2 questDBDataSet2;
        private System.Windows.Forms.BindingSource questInfoesBindingSource2;
        private QuestDBDataSet2TableAdapters.QuestInfoesTableAdapter questInfoesTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfQuestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitMemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfMemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeTimeFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freeTimeToDataGridViewTextBoxColumn;
    }
}

