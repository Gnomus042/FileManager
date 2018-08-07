namespace TubDB
{
    partial class Filter
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label EndL;
            System.Windows.Forms.Label ResL;
            System.Windows.Forms.Label BegL;
            System.Windows.Forms.Label DestrL;
            System.Windows.Forms.Label BKL;
            System.Windows.Forms.Label TypeL;
            System.Windows.Forms.Label DiagnosisL;
            System.Windows.Forms.Label BirthL;
            System.Windows.Forms.Label GenderL;
            System.Windows.Forms.Label NameL;
            System.Windows.Forms.Label SurnameL;
            System.Windows.Forms.Label label1;
            this.destructionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClearFBut = new System.Windows.Forms.Button();
            this.OKFBut = new System.Windows.Forms.Button();
            this.ResultDT = new System.Windows.Forms.TextBox();
            this.EndDT = new System.Windows.Forms.DateTimePicker();
            this.BegDT = new System.Windows.Forms.DateTimePicker();
            this.DestructionCB = new System.Windows.Forms.ComboBox();
            this.BKCB = new System.Windows.Forms.ComboBox();
            this.TypeCB = new System.Windows.Forms.ComboBox();
            this.DiagnosisCB = new System.Windows.Forms.ComboBox();
            this.BirthDT = new System.Windows.Forms.DateTimePicker();
            this.GenderCB = new System.Windows.Forms.ComboBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SurnameTB = new System.Windows.Forms.TextBox();
            this.xmlChB = new System.Windows.Forms.CheckBox();
            EndL = new System.Windows.Forms.Label();
            ResL = new System.Windows.Forms.Label();
            BegL = new System.Windows.Forms.Label();
            DestrL = new System.Windows.Forms.Label();
            BKL = new System.Windows.Forms.Label();
            TypeL = new System.Windows.Forms.Label();
            DiagnosisL = new System.Windows.Forms.Label();
            BirthL = new System.Windows.Forms.Label();
            GenderL = new System.Windows.Forms.Label();
            NameL = new System.Windows.Forms.Label();
            SurnameL = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.destructionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EndL
            // 
            EndL.AutoSize = true;
            EndL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            EndL.Location = new System.Drawing.Point(6, 268);
            EndL.Name = "EndL";
            EndL.Size = new System.Drawing.Size(150, 16);
            EndL.TabIndex = 50;
            EndL.Text = "Закінчення лікування";
            EndL.Click += new System.EventHandler(this.EndL_Click);
            // 
            // ResL
            // 
            ResL.AutoSize = true;
            ResL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ResL.Location = new System.Drawing.Point(7, 293);
            ResL.Name = "ResL";
            ResL.Size = new System.Drawing.Size(78, 16);
            ResL.TabIndex = 47;
            ResL.Text = "Результат";
            ResL.Click += new System.EventHandler(this.ResL_Click);
            // 
            // BegL
            // 
            BegL.AutoSize = true;
            BegL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BegL.Location = new System.Drawing.Point(6, 241);
            BegL.Name = "BegL";
            BegL.Size = new System.Drawing.Size(132, 16);
            BegL.TabIndex = 46;
            BegL.Text = "Початок лікування";
            BegL.Click += new System.EventHandler(this.BegL_Click);
            // 
            // DestrL
            // 
            DestrL.AutoSize = true;
            DestrL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            DestrL.Location = new System.Drawing.Point(102, 212);
            DestrL.Name = "DestrL";
            DestrL.Size = new System.Drawing.Size(80, 16);
            DestrL.TabIndex = 45;
            DestrL.Text = "Деструкція";
            DestrL.Click += new System.EventHandler(this.DestrL_Click);
            // 
            // BKL
            // 
            BKL.AutoSize = true;
            BKL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BKL.Location = new System.Drawing.Point(7, 212);
            BKL.Name = "BKL";
            BKL.Size = new System.Drawing.Size(25, 16);
            BKL.TabIndex = 44;
            BKL.Text = "БК";
            BKL.Click += new System.EventHandler(this.BKL_Click);
            // 
            // TypeL
            // 
            TypeL.AutoSize = true;
            TypeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            TypeL.Location = new System.Drawing.Point(7, 186);
            TypeL.Name = "TypeL";
            TypeL.Size = new System.Drawing.Size(33, 16);
            TypeL.TabIndex = 37;
            TypeL.Text = "Тип";
            TypeL.Click += new System.EventHandler(this.TypeL_Click);
            // 
            // DiagnosisL
            // 
            DiagnosisL.AutoSize = true;
            DiagnosisL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            DiagnosisL.Location = new System.Drawing.Point(6, 159);
            DiagnosisL.Name = "DiagnosisL";
            DiagnosisL.Size = new System.Drawing.Size(58, 16);
            DiagnosisL.TabIndex = 36;
            DiagnosisL.Text = "Діагноз";
            DiagnosisL.Click += new System.EventHandler(this.DiagnosisL_Click);
            // 
            // BirthL
            // 
            BirthL.AutoSize = true;
            BirthL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            BirthL.Location = new System.Drawing.Point(7, 131);
            BirthL.Name = "BirthL";
            BirthL.Size = new System.Drawing.Size(123, 16);
            BirthL.TabIndex = 35;
            BirthL.Text = "Дата народження";
            BirthL.Click += new System.EventHandler(this.BirthL_Click);
            // 
            // GenderL
            // 
            GenderL.AutoSize = true;
            GenderL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            GenderL.Location = new System.Drawing.Point(6, 105);
            GenderL.Name = "GenderL";
            GenderL.Size = new System.Drawing.Size(46, 16);
            GenderL.TabIndex = 34;
            GenderL.Text = "Стать";
            GenderL.Click += new System.EventHandler(this.GenderL_Click);
            // 
            // NameL
            // 
            NameL.AutoSize = true;
            NameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            NameL.Location = new System.Drawing.Point(6, 76);
            NameL.Name = "NameL";
            NameL.Size = new System.Drawing.Size(30, 16);
            NameL.TabIndex = 32;
            NameL.Text = "Ім\'я";
            NameL.Click += new System.EventHandler(this.NameL_Click);
            // 
            // SurnameL
            // 
            SurnameL.AutoSize = true;
            SurnameL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            SurnameL.Location = new System.Drawing.Point(6, 50);
            SurnameL.Name = "SurnameL";
            SurnameL.Size = new System.Drawing.Size(70, 16);
            SurnameL.TabIndex = 30;
            SurnameL.Text = "Прізвище";
            SurnameL.Click += new System.EventHandler(this.SurnameL_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(6, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 20);
            label1.TabIndex = 29;
            label1.Text = "Фільтр:";
            // 
            // destructionBindingSource
            // 
            this.destructionBindingSource.DataSource = typeof(DataLibrary.Destruction);
            // 
            // bKBindingSource
            // 
            this.bKBindingSource.DataSource = typeof(DataLibrary.BK);
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataSource = typeof(DataLibrary.Type);
            // 
            // diagnosisBindingSource
            // 
            this.diagnosisBindingSource.DataSource = typeof(DataLibrary.Diagnosis);
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataSource = typeof(DataLibrary.Gender);
            // 
            // ClearFBut
            // 
            this.ClearFBut.Location = new System.Drawing.Point(184, 21);
            this.ClearFBut.Name = "ClearFBut";
            this.ClearFBut.Size = new System.Drawing.Size(75, 23);
            this.ClearFBut.TabIndex = 53;
            this.ClearFBut.Text = "Очистити";
            this.ClearFBut.UseVisualStyleBackColor = true;
            this.ClearFBut.Click += new System.EventHandler(this.ClearFBut_Click);
            // 
            // OKFBut
            // 
            this.OKFBut.Location = new System.Drawing.Point(165, 325);
            this.OKFBut.Name = "OKFBut";
            this.OKFBut.Size = new System.Drawing.Size(75, 23);
            this.OKFBut.TabIndex = 52;
            this.OKFBut.Text = "OK";
            this.OKFBut.UseVisualStyleBackColor = true;
            this.OKFBut.Click += new System.EventHandler(this.OKFBut_Click);
            // 
            // ResultDT
            // 
            this.ResultDT.Location = new System.Drawing.Point(91, 293);
            this.ResultDT.Name = "ResultDT";
            this.ResultDT.Size = new System.Drawing.Size(168, 20);
            this.ResultDT.TabIndex = 51;
            // 
            // EndDT
            // 
            this.EndDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDT.Location = new System.Drawing.Point(165, 264);
            this.EndDT.Name = "EndDT";
            this.EndDT.Size = new System.Drawing.Size(94, 20);
            this.EndDT.TabIndex = 49;
            // 
            // BegDT
            // 
            this.BegDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BegDT.Location = new System.Drawing.Point(136, 238);
            this.BegDT.Name = "BegDT";
            this.BegDT.Size = new System.Drawing.Size(123, 20);
            this.BegDT.TabIndex = 48;
            // 
            // DestructionCB
            // 
            this.DestructionCB.DataSource = this.destructionBindingSource;
            this.DestructionCB.DisplayMember = "destr_value";
            this.DestructionCB.FormattingEnabled = true;
            this.DestructionCB.Location = new System.Drawing.Point(188, 211);
            this.DestructionCB.Name = "DestructionCB";
            this.DestructionCB.Size = new System.Drawing.Size(71, 21);
            this.DestructionCB.TabIndex = 43;
            this.DestructionCB.ValueMember = "destr_id";
            // 
            // BKCB
            // 
            this.BKCB.DataSource = this.bKBindingSource;
            this.BKCB.DisplayMember = "bk_value";
            this.BKCB.FormattingEnabled = true;
            this.BKCB.Location = new System.Drawing.Point(42, 211);
            this.BKCB.Name = "BKCB";
            this.BKCB.Size = new System.Drawing.Size(54, 21);
            this.BKCB.TabIndex = 42;
            this.BKCB.ValueMember = "bk_id";
            // 
            // TypeCB
            // 
            this.TypeCB.DataSource = this.typeBindingSource;
            this.TypeCB.DisplayMember = "type_value";
            this.TypeCB.FormattingEnabled = true;
            this.TypeCB.Location = new System.Drawing.Point(46, 184);
            this.TypeCB.Name = "TypeCB";
            this.TypeCB.Size = new System.Drawing.Size(213, 21);
            this.TypeCB.TabIndex = 41;
            this.TypeCB.ValueMember = "type_id";
            // 
            // DiagnosisCB
            // 
            this.DiagnosisCB.DataSource = this.diagnosisBindingSource;
            this.DiagnosisCB.DisplayMember = "diag_value";
            this.DiagnosisCB.FormattingEnabled = true;
            this.DiagnosisCB.Location = new System.Drawing.Point(70, 157);
            this.DiagnosisCB.Name = "DiagnosisCB";
            this.DiagnosisCB.Size = new System.Drawing.Size(189, 21);
            this.DiagnosisCB.TabIndex = 40;
            this.DiagnosisCB.ValueMember = "diag_id";
            // 
            // BirthDT
            // 
            this.BirthDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDT.Location = new System.Drawing.Point(136, 131);
            this.BirthDT.Name = "BirthDT";
            this.BirthDT.Size = new System.Drawing.Size(123, 20);
            this.BirthDT.TabIndex = 39;
            // 
            // GenderCB
            // 
            this.GenderCB.DataSource = this.genderBindingSource;
            this.GenderCB.DisplayMember = "gen_value";
            this.GenderCB.FormattingEnabled = true;
            this.GenderCB.Location = new System.Drawing.Point(58, 104);
            this.GenderCB.Name = "GenderCB";
            this.GenderCB.Size = new System.Drawing.Size(201, 21);
            this.GenderCB.TabIndex = 38;
            this.GenderCB.ValueMember = "gen_id";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(42, 75);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(217, 20);
            this.NameTB.TabIndex = 33;
            // 
            // SurnameTB
            // 
            this.SurnameTB.Location = new System.Drawing.Point(82, 49);
            this.SurnameTB.Name = "SurnameTB";
            this.SurnameTB.Size = new System.Drawing.Size(177, 20);
            this.SurnameTB.TabIndex = 31;
            // 
            // xmlChB
            // 
            this.xmlChB.AutoSize = true;
            this.xmlChB.Location = new System.Drawing.Point(10, 325);
            this.xmlChB.Name = "xmlChB";
            this.xmlChB.Size = new System.Drawing.Size(110, 17);
            this.xmlChB.TabIndex = 55;
            this.xmlChB.Text = "Формувати XML";
            this.xmlChB.UseVisualStyleBackColor = true;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xmlChB);
            this.Controls.Add(this.ClearFBut);
            this.Controls.Add(this.OKFBut);
            this.Controls.Add(this.ResultDT);
            this.Controls.Add(EndL);
            this.Controls.Add(this.EndDT);
            this.Controls.Add(this.BegDT);
            this.Controls.Add(ResL);
            this.Controls.Add(BegL);
            this.Controls.Add(DestrL);
            this.Controls.Add(BKL);
            this.Controls.Add(this.DestructionCB);
            this.Controls.Add(this.BKCB);
            this.Controls.Add(this.TypeCB);
            this.Controls.Add(this.DiagnosisCB);
            this.Controls.Add(this.BirthDT);
            this.Controls.Add(this.GenderCB);
            this.Controls.Add(TypeL);
            this.Controls.Add(DiagnosisL);
            this.Controls.Add(BirthL);
            this.Controls.Add(GenderL);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(NameL);
            this.Controls.Add(this.SurnameTB);
            this.Controls.Add(SurnameL);
            this.Controls.Add(label1);
            this.Name = "Filter";
            this.Size = new System.Drawing.Size(265, 363);
            ((System.ComponentModel.ISupportInitialize)(this.destructionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource destructionBindingSource;
        private System.Windows.Forms.BindingSource bKBindingSource;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private System.Windows.Forms.BindingSource diagnosisBindingSource;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private System.Windows.Forms.Button ClearFBut;
        private System.Windows.Forms.Button OKFBut;
        private System.Windows.Forms.TextBox ResultDT;
        private System.Windows.Forms.DateTimePicker EndDT;
        private System.Windows.Forms.DateTimePicker BegDT;
        private System.Windows.Forms.ComboBox DestructionCB;
        private System.Windows.Forms.ComboBox BKCB;
        private System.Windows.Forms.ComboBox TypeCB;
        private System.Windows.Forms.ComboBox DiagnosisCB;
        private System.Windows.Forms.DateTimePicker BirthDT;
        private System.Windows.Forms.ComboBox GenderCB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox SurnameTB;
        private System.Windows.Forms.CheckBox xmlChB;
    }
}
