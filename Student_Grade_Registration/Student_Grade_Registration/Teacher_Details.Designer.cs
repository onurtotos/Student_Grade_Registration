namespace Student_Grade_Registration
{
    partial class Teacher_Details
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.maskedNo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_ex3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_ex1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ex2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label_fail = new System.Windows.Forms.Label();
            this.label_pssd = new System.Windows.Forms.Label();
            this.label_avg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stdidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdexam1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdexam2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdexam3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdavrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdcondtnDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lessontblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stdnt_regDataSet = new Student_Grade_Registration.stdnt_regDataSet();
            this.lesson_tblTableAdapter = new Student_Grade_Registration.stdnt_regDataSetTableAdapters.Lesson_tblTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessontblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdnt_regDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox_surname);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.maskedNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Student";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(202, 173);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(123, 30);
            this.textBox_surname.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 46);
            this.button3.TabIndex = 7;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Name:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(202, 116);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(123, 30);
            this.textBox_name.TabIndex = 2;
            // 
            // maskedNo
            // 
            this.maskedNo.Location = new System.Drawing.Point(202, 62);
            this.maskedNo.Mask = "0000";
            this.maskedNo.Name = "maskedNo";
            this.maskedNo.Size = new System.Drawing.Size(123, 30);
            this.maskedNo.TabIndex = 1;
            this.maskedNo.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student NO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_ex3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox_ex1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_ex2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(381, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 333);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exam Grades";
            // 
            // textBox_ex3
            // 
            this.textBox_ex3.Location = new System.Drawing.Point(138, 176);
            this.textBox_ex3.Name = "textBox_ex3";
            this.textBox_ex3.Size = new System.Drawing.Size(148, 30);
            this.textBox_ex3.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_ex1
            // 
            this.textBox_ex1.Location = new System.Drawing.Point(138, 62);
            this.textBox_ex1.Name = "textBox_ex1";
            this.textBox_ex1.Size = new System.Drawing.Size(148, 30);
            this.textBox_ex1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Exam 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Exam 2:";
            // 
            // textBox_ex2
            // 
            this.textBox_ex2.Location = new System.Drawing.Point(138, 122);
            this.textBox_ex2.Name = "textBox_ex2";
            this.textBox_ex2.Size = new System.Drawing.Size(148, 30);
            this.textBox_ex2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Exam 1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label_fail);
            this.groupBox3.Controls.Add(this.label_pssd);
            this.groupBox3.Controls.Add(this.label_avg);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(738, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 333);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Class Average";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 46);
            this.button4.TabIndex = 12;
            this.button4.Text = "Total Students:";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "00";
            // 
            // label_fail
            // 
            this.label_fail.AutoSize = true;
            this.label_fail.Location = new System.Drawing.Point(213, 173);
            this.label_fail.Name = "label_fail";
            this.label_fail.Size = new System.Drawing.Size(34, 24);
            this.label_fail.TabIndex = 9;
            this.label_fail.Text = "00";
            // 
            // label_pssd
            // 
            this.label_pssd.AutoSize = true;
            this.label_pssd.Location = new System.Drawing.Point(213, 119);
            this.label_pssd.Name = "label_pssd";
            this.label_pssd.Size = new System.Drawing.Size(34, 24);
            this.label_pssd.TabIndex = 8;
            this.label_pssd.Text = "00";
            // 
            // label_avg
            // 
            this.label_avg.AutoSize = true;
            this.label_avg.Location = new System.Drawing.Point(213, 68);
            this.label_avg.Name = "label_avg";
            this.label_avg.Size = new System.Drawing.Size(34, 24);
            this.label_avg.TabIndex = 7;
            this.label_avg.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Failed Students:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Passed Students:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Average:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 372);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1057, 279);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exam Grades";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdidDataGridViewTextBoxColumn,
            this.stdnoDataGridViewTextBoxColumn,
            this.stdnameDataGridViewTextBoxColumn,
            this.stdsurnameDataGridViewTextBoxColumn,
            this.stdexam1DataGridViewTextBoxColumn,
            this.stdexam2DataGridViewTextBoxColumn,
            this.stdexam3DataGridViewTextBoxColumn,
            this.stdavrgDataGridViewTextBoxColumn,
            this.stdcondtnDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.lessontblBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1051, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // stdidDataGridViewTextBoxColumn
            // 
            this.stdidDataGridViewTextBoxColumn.DataPropertyName = "std_id";
            this.stdidDataGridViewTextBoxColumn.HeaderText = "std_id";
            this.stdidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdidDataGridViewTextBoxColumn.Name = "stdidDataGridViewTextBoxColumn";
            this.stdidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stdnoDataGridViewTextBoxColumn
            // 
            this.stdnoDataGridViewTextBoxColumn.DataPropertyName = "std_no";
            this.stdnoDataGridViewTextBoxColumn.HeaderText = "std_no";
            this.stdnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdnoDataGridViewTextBoxColumn.Name = "stdnoDataGridViewTextBoxColumn";
            // 
            // stdnameDataGridViewTextBoxColumn
            // 
            this.stdnameDataGridViewTextBoxColumn.DataPropertyName = "std_name";
            this.stdnameDataGridViewTextBoxColumn.HeaderText = "std_name";
            this.stdnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdnameDataGridViewTextBoxColumn.Name = "stdnameDataGridViewTextBoxColumn";
            // 
            // stdsurnameDataGridViewTextBoxColumn
            // 
            this.stdsurnameDataGridViewTextBoxColumn.DataPropertyName = "std_surname";
            this.stdsurnameDataGridViewTextBoxColumn.HeaderText = "std_surname";
            this.stdsurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdsurnameDataGridViewTextBoxColumn.Name = "stdsurnameDataGridViewTextBoxColumn";
            // 
            // stdexam1DataGridViewTextBoxColumn
            // 
            this.stdexam1DataGridViewTextBoxColumn.DataPropertyName = "std_exam1";
            this.stdexam1DataGridViewTextBoxColumn.HeaderText = "std_exam1";
            this.stdexam1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdexam1DataGridViewTextBoxColumn.Name = "stdexam1DataGridViewTextBoxColumn";
            // 
            // stdexam2DataGridViewTextBoxColumn
            // 
            this.stdexam2DataGridViewTextBoxColumn.DataPropertyName = "std_exam2";
            this.stdexam2DataGridViewTextBoxColumn.HeaderText = "std_exam2";
            this.stdexam2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdexam2DataGridViewTextBoxColumn.Name = "stdexam2DataGridViewTextBoxColumn";
            // 
            // stdexam3DataGridViewTextBoxColumn
            // 
            this.stdexam3DataGridViewTextBoxColumn.DataPropertyName = "std_exam3";
            this.stdexam3DataGridViewTextBoxColumn.HeaderText = "std_exam3";
            this.stdexam3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdexam3DataGridViewTextBoxColumn.Name = "stdexam3DataGridViewTextBoxColumn";
            // 
            // stdavrgDataGridViewTextBoxColumn
            // 
            this.stdavrgDataGridViewTextBoxColumn.DataPropertyName = "std_avrg";
            this.stdavrgDataGridViewTextBoxColumn.HeaderText = "std_avrg";
            this.stdavrgDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stdavrgDataGridViewTextBoxColumn.Name = "stdavrgDataGridViewTextBoxColumn";
            // 
            // stdcondtnDataGridViewCheckBoxColumn
            // 
            this.stdcondtnDataGridViewCheckBoxColumn.DataPropertyName = "std_condtn";
            this.stdcondtnDataGridViewCheckBoxColumn.HeaderText = "std_condtn";
            this.stdcondtnDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.stdcondtnDataGridViewCheckBoxColumn.Name = "stdcondtnDataGridViewCheckBoxColumn";
            // 
            // lessontblBindingSource
            // 
            this.lessontblBindingSource.DataMember = "Lesson_tbl";
            this.lessontblBindingSource.DataSource = this.stdnt_regDataSet;
            // 
            // stdnt_regDataSet
            // 
            this.stdnt_regDataSet.DataSetName = "stdnt_regDataSet";
            this.stdnt_regDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lesson_tblTableAdapter
            // 
            this.lesson_tblTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 46);
            this.button5.TabIndex = 13;
            this.button5.Text = "Failed Students:";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 114);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 46);
            this.button6.TabIndex = 14;
            this.button6.Text = "Passed Students:";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 54);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(174, 46);
            this.button7.TabIndex = 15;
            this.button7.Text = "Class Average:";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Teacher_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1088, 652);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Teacher_Details";
            this.Text = "Teacher_Details";
            this.Load += new System.EventHandler(this.Teacher_Details_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessontblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdnt_regDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.MaskedTextBox maskedNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_ex1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ex2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ex3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_avg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_fail;
        private System.Windows.Forms.Label label_pssd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private stdnt_regDataSet stdnt_regDataSet;
        private System.Windows.Forms.BindingSource lessontblBindingSource;
        private stdnt_regDataSetTableAdapters.Lesson_tblTableAdapter lesson_tblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdexam1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdexam2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdexam3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdavrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stdcondtnDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
    }
}