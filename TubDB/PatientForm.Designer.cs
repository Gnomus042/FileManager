namespace TubDB
{
    partial class PatientForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label10;
            this.ModeLabel = new System.Windows.Forms.Label();
            this.AnalysisShowBut = new System.Windows.Forms.Button();
            this.ResultTB = new System.Windows.Forms.TextBox();
            this.TestsDGV = new System.Windows.Forms.DataGridView();
            this.colNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planedTests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.missedTests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentRTB = new System.Windows.Forms.RichTextBox();
            this.EndDT = new System.Windows.Forms.DateTimePicker();
            this.BegDT = new System.Windows.Forms.DateTimePicker();
            this.OtherDisTB = new System.Windows.Forms.TextBox();
            this.DestrCB = new System.Windows.Forms.ComboBox();
            this.destructionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BKCB = new System.Windows.Forms.ComboBox();
            this.bKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DiagnosisCB = new System.Windows.Forms.ComboBox();
            this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SecnameTB = new System.Windows.Forms.TextBox();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.BirtdayDT = new System.Windows.Forms.DateTimePicker();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.FactAddRTB = new System.Windows.Forms.RichTextBox();
            this.RegAddRTB = new System.Windows.Forms.RichTextBox();
            this.SavePatientBut = new System.Windows.Forms.Button();
            this.DeletePatientBut = new System.Windows.Forms.Button();
            this.CreatePatientBut = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label20 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destructionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModeLabel.Location = new System.Drawing.Point(12, 13);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(86, 25);
            this.ModeLabel.TabIndex = 1;
            this.ModeLabel.Text = "Режим:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(12, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Прізвище";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(12, 80);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(37, 20);
            label3.TabIndex = 4;
            label3.Text = "Ім\'я";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(12, 110);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(99, 20);
            label4.TabIndex = 5;
            label4.Text = "По батькові";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(13, 142);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(36, 13);
            label5.TabIndex = 6;
            label5.Text = "Стать";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(181, 142);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(98, 13);
            label6.TabIndex = 7;
            label6.Text = "Дата народження";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(13, 173);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(52, 13);
            label7.TabIndex = 8;
            label7.Text = "Телефон";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(13, 202);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(97, 13);
            label8.TabIndex = 9;
            label8.Text = "Фактична адреса";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(13, 298);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(99, 13);
            label9.TabIndex = 10;
            label9.Text = "Адреса реєстрації";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.AnalysisShowBut);
            groupBox1.Controls.Add(this.ResultTB);
            groupBox1.Controls.Add(this.TestsDGV);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(this.CommentRTB);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(this.EndDT);
            groupBox1.Controls.Add(this.BegDT);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(this.OtherDisTB);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(this.DestrCB);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(this.BKCB);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(this.TypeCB);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(this.DiagnosisCB);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new System.Drawing.Point(403, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(341, 461);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // AnalysisShowBut
            // 
            this.AnalysisShowBut.Location = new System.Drawing.Point(260, 293);
            this.AnalysisShowBut.Name = "AnalysisShowBut";
            this.AnalysisShowBut.Size = new System.Drawing.Size(75, 23);
            this.AnalysisShowBut.TabIndex = 37;
            this.AnalysisShowBut.Text = "Деталі";
            this.AnalysisShowBut.UseVisualStyleBackColor = true;
            this.AnalysisShowBut.Click += new System.EventHandler(this.AnalysisShowBut_Click);
            // 
            // ResultTB
            // 
            this.ResultTB.Location = new System.Drawing.Point(73, 263);
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.Size = new System.Drawing.Size(262, 20);
            this.ResultTB.TabIndex = 36;
            // 
            // TestsDGV
            // 
            this.TestsDGV.AllowUserToAddRows = false;
            this.TestsDGV.AllowUserToDeleteRows = false;
            this.TestsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TestsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNames,
            this.planedTests,
            this.missedTests});
            this.TestsDGV.Location = new System.Drawing.Point(6, 320);
            this.TestsDGV.Name = "TestsDGV";
            this.TestsDGV.ReadOnly = true;
            this.TestsDGV.RowHeadersVisible = false;
            this.TestsDGV.Size = new System.Drawing.Size(329, 135);
            this.TestsDGV.TabIndex = 35;
            this.TestsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TestsDGV_CellContentClick);
            // 
            // colNames
            // 
            this.colNames.HeaderText = "   ";
            this.colNames.Name = "colNames";
            this.colNames.ReadOnly = true;
            // 
            // planedTests
            // 
            this.planedTests.HeaderText = "Заплановано";
            this.planedTests.Name = "planedTests";
            this.planedTests.ReadOnly = true;
            // 
            // missedTests
            // 
            this.missedTests.HeaderText = "Пропущено";
            this.missedTests.Name = "missedTests";
            this.missedTests.ReadOnly = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label20.Location = new System.Drawing.Point(7, 293);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(68, 20);
            label20.TabIndex = 34;
            label20.Text = "Аналізи";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(8, 266);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(59, 13);
            label19.TabIndex = 32;
            label19.Text = "Результат";
            // 
            // CommentRTB
            // 
            this.CommentRTB.Location = new System.Drawing.Point(10, 218);
            this.CommentRTB.Name = "CommentRTB";
            this.CommentRTB.Size = new System.Drawing.Size(325, 39);
            this.CommentRTB.TabIndex = 21;
            this.CommentRTB.Text = "";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(7, 202);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(57, 13);
            label18.TabIndex = 31;
            label18.Text = "Коментар";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(6, 176);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(150, 13);
            label17.TabIndex = 30;
            label17.Text = "Дата завершення лікування";
            // 
            // EndDT
            // 
            this.EndDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDT.Location = new System.Drawing.Point(161, 170);
            this.EndDT.Name = "EndDT";
            this.EndDT.Size = new System.Drawing.Size(174, 20);
            this.EndDT.TabIndex = 21;
            // 
            // BegDT
            // 
            this.BegDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BegDT.Location = new System.Drawing.Point(139, 144);
            this.BegDT.Name = "BegDT";
            this.BegDT.Size = new System.Drawing.Size(196, 20);
            this.BegDT.TabIndex = 22;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(6, 150);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(127, 13);
            label16.TabIndex = 29;
            label16.Text = "Дата початку лікування";
            // 
            // OtherDisTB
            // 
            this.OtherDisTB.Location = new System.Drawing.Point(111, 118);
            this.OtherDisTB.Name = "OtherDisTB";
            this.OtherDisTB.Size = new System.Drawing.Size(224, 20);
            this.OtherDisTB.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(7, 121);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(102, 13);
            label15.TabIndex = 28;
            label15.Text = "Інші захворювання";
            // 
            // DestrCB
            // 
            this.DestrCB.DataSource = this.destructionBindingSource;
            this.DestrCB.DisplayMember = "destr_value";
            this.DestrCB.FormattingEnabled = true;
            this.DestrCB.Location = new System.Drawing.Point(199, 91);
            this.DestrCB.Name = "DestrCB";
            this.DestrCB.Size = new System.Drawing.Size(136, 21);
            this.DestrCB.TabIndex = 27;
            this.DestrCB.ValueMember = "destr_id";
            // 
            // destructionBindingSource
            // 
            this.destructionBindingSource.DataSource = typeof(DataLibrary.Destruction);
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(129, 94);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(64, 13);
            label14.TabIndex = 26;
            label14.Text = "Деструкція";
            // 
            // BKCB
            // 
            this.BKCB.DataSource = this.bKBindingSource;
            this.BKCB.DisplayMember = "bk_value";
            this.BKCB.FormattingEnabled = true;
            this.BKCB.Location = new System.Drawing.Point(39, 91);
            this.BKCB.Name = "BKCB";
            this.BKCB.Size = new System.Drawing.Size(77, 21);
            this.BKCB.TabIndex = 25;
            this.BKCB.ValueMember = "bk_id";
            // 
            // bKBindingSource
            // 
            this.bKBindingSource.DataSource = typeof(DataLibrary.BK);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(7, 94);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(21, 13);
            label13.TabIndex = 24;
            label13.Text = "БК";
            // 
            // TypeCB
            // 
            this.TypeCB.DataSource = this.typeBindingSource;
            this.TypeCB.DisplayMember = "type_value";
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Location = new System.Drawing.Point(39, 64);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(296, 21);
            this.TypeCB.TabIndex = 23;
            this.TypeCB.ValueMember = "type_id";
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataSource = typeof(DataLibrary.Type);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(7, 67);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(26, 13);
            label12.TabIndex = 22;
            label12.Text = "Тип";
            // 
            // DiagnosisCB
            // 
            this.DiagnosisCB.DataSource = this.diagnosisBindingSource;
            this.DiagnosisCB.DisplayMember = "diag_value";
            this.DiagnosisCB.FormattingEnabled = true;
            this.DiagnosisCB.Location = new System.Drawing.Point(60, 37);
            this.DiagnosisCB.Name = "DiagnosisCB";
            this.DiagnosisCB.Size = new System.Drawing.Size(275, 21);
            this.DiagnosisCB.TabIndex = 21;
            this.DiagnosisCB.ValueMember = "diag_id";
            // 
            // diagnosisBindingSource
            // 
            this.diagnosisBindingSource.DataSource = typeof(DataLibrary.Diagnosis);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(7, 40);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(47, 13);
            label11.TabIndex = 21;
            label11.Text = "Діагноз";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label10.Location = new System.Drawing.Point(6, 10);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(205, 20);
            label10.TabIndex = 21;
            label10.Text = "Інформація про лікування";
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataSource = typeof(DataLibrary.Gender);
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(99, 50);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(287, 20);
            this.SurnameTB.TabIndex = 12;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(55, 80);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(331, 20);
            this.NameTB.TabIndex = 13;
            // 
            // SecnameTB
            // 
            this.SecnameTB.ForeColor = System.Drawing.SystemColors.MenuText;
            this.SecnameTB.Location = new System.Drawing.Point(117, 110);
            this.SecnameTB.Name = "SecnameTB";
            this.SecnameTB.Size = new System.Drawing.Size(269, 20);
            this.SecnameTB.TabIndex = 14;
            // 
            // GenderCB
            // 
            this.GenderCB.DataSource = this.genderBindingSource;
            this.GenderCB.DisplayMember = "gen_value";
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Location = new System.Drawing.Point(54, 136);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(121, 21);
            this.GenderCB.TabIndex = 15;
            this.GenderCB.ValueMember = "gen_id";
            this.GenderCB.SelectedIndexChanged += new System.EventHandler(this.GenderCB_SelectedIndexChanged);
            // 
            // BirtdayDT
            // 
            this.BirtdayDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirtdayDT.Location = new System.Drawing.Point(285, 137);
            this.BirtdayDT.Name = "BirtdayDT";
            this.BirtdayDT.Size = new System.Drawing.Size(101, 20);
            this.BirtdayDT.TabIndex = 16;
            // 
            // PhoneTB
            // 
            this.PhoneTB.ForeColor = System.Drawing.SystemColors.MenuText;
            this.PhoneTB.Location = new System.Drawing.Point(71, 170);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(315, 20);
            this.PhoneTB.TabIndex = 17;
            // 
            // FactAddRTB
            // 
            this.FactAddRTB.Location = new System.Drawing.Point(16, 218);
            this.FactAddRTB.Name = "FactAddRTB";
            this.FactAddRTB.Size = new System.Drawing.Size(370, 77);
            this.FactAddRTB.TabIndex = 18;
            this.FactAddRTB.Text = "";
            // 
            // RegAddRTB
            // 
            this.RegAddRTB.Location = new System.Drawing.Point(16, 314);
            this.RegAddRTB.Name = "RegAddRTB";
            this.RegAddRTB.Size = new System.Drawing.Size(370, 77);
            this.RegAddRTB.TabIndex = 19;
            this.RegAddRTB.Text = "";
            // 
            // SavePatientBut
            // 
            this.SavePatientBut.Location = new System.Drawing.Point(16, 397);
            this.SavePatientBut.Name = "SavePatientBut";
            this.SavePatientBut.Size = new System.Drawing.Size(96, 31);
            this.SavePatientBut.TabIndex = 36;
            this.SavePatientBut.Text = "Зберегти зміни";
            this.SavePatientBut.UseVisualStyleBackColor = true;
            this.SavePatientBut.Click += new System.EventHandler(this.SavePatientBut_Click);
            // 
            // DeletePatientBut
            // 
            this.DeletePatientBut.Location = new System.Drawing.Point(118, 397);
            this.DeletePatientBut.Name = "DeletePatientBut";
            this.DeletePatientBut.Size = new System.Drawing.Size(124, 31);
            this.DeletePatientBut.TabIndex = 37;
            this.DeletePatientBut.Text = "Видалити пацієнта";
            this.DeletePatientBut.UseVisualStyleBackColor = true;
            this.DeletePatientBut.Click += new System.EventHandler(this.DeletePatientBut_Click);
            // 
            // CreatePatientBut
            // 
            this.CreatePatientBut.Location = new System.Drawing.Point(248, 397);
            this.CreatePatientBut.Name = "CreatePatientBut";
            this.CreatePatientBut.Size = new System.Drawing.Size(138, 31);
            this.CreatePatientBut.TabIndex = 38;
            this.CreatePatientBut.Text = "Створити пацієнта";
            this.CreatePatientBut.UseVisualStyleBackColor = true;
            this.CreatePatientBut.Click += new System.EventHandler(this.CreatePatientBut_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 461);
            this.Controls.Add(this.CreatePatientBut);
            this.Controls.Add(this.DeletePatientBut);
            this.Controls.Add(this.SavePatientBut);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.RegAddRTB);
            this.Controls.Add(this.FactAddRTB);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(this.BirtdayDT);
            this.Controls.Add(this.GenderCB);
            this.Controls.Add(this.SecnameTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.SurnameTB);
            this.Controls.Add(label9);
            this.Controls.Add(label8);
            this.Controls.Add(label7);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.ModeLabel);
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пацієнт";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destructionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox SecnameTB;
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private System.Windows.Forms.DateTimePicker BirtdayDT;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.RichTextBox FactAddRTB;
        private System.Windows.Forms.RichTextBox RegAddRTB;
        private System.Windows.Forms.DataGridView TestsDGV;
        private System.Windows.Forms.RichTextBox CommentRTB;
        private System.Windows.Forms.DateTimePicker EndDT;
        private System.Windows.Forms.DateTimePicker BegDT;
        private System.Windows.Forms.TextBox OtherDisTB;
        private System.Windows.Forms.ComboBox DestrCB;
        private System.Windows.Forms.ComboBox BKCB;
        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.ComboBox DiagnosisCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn planedTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn missedTests;
        private System.Windows.Forms.BindingSource diagnosisBindingSource;
        private System.Windows.Forms.BindingSource destructionBindingSource;
        private System.Windows.Forms.BindingSource bKBindingSource;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private System.Windows.Forms.Button SavePatientBut;
        private System.Windows.Forms.Button DeletePatientBut;
        private System.Windows.Forms.Button CreatePatientBut;
        private System.Windows.Forms.TextBox ResultTB;
        private System.Windows.Forms.Button AnalysisShowBut;
        private System.Windows.Forms.Label ModeLabel;
    }
}