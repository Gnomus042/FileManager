namespace TubDB
{
    partial class MainWindow
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PatientsListDGV = new System.Windows.Forms.DataGridView();
            this.psurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psecnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgenderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pfactAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pregAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdiagnosisIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbkIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pdestructionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potherDiseasesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfirstVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plastVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pphonesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.filter = new TubDB.Filter();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsListDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataSource = typeof(DataLibrary.Gender);
            // 
            // PatientsListDGV
            // 
            this.PatientsListDGV.AllowUserToAddRows = false;
            this.PatientsListDGV.AllowUserToDeleteRows = false;
            this.PatientsListDGV.AutoGenerateColumns = false;
            this.PatientsListDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientsListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsListDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.psurnameDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.psecnameDataGridViewTextBoxColumn,
            this.pbirthdayDataGridViewTextBoxColumn,
            this.pgenderIdDataGridViewTextBoxColumn,
            this.pfactAddressDataGridViewTextBoxColumn,
            this.pregAddressDataGridViewTextBoxColumn,
            this.pdiagnosisIdDataGridViewTextBoxColumn,
            this.ptypeIdDataGridViewTextBoxColumn,
            this.pbkIDDataGridViewTextBoxColumn,
            this.pdestructionIdDataGridViewTextBoxColumn,
            this.potherDiseasesDataGridViewTextBoxColumn,
            this.pfirstVisitDataGridViewTextBoxColumn,
            this.plastVisitDataGridViewTextBoxColumn,
            this.presultDataGridViewTextBoxColumn,
            this.pphonesDataGridViewTextBoxColumn,
            this.pkommentDataGridViewTextBoxColumn,
            this.pidDataGridViewTextBoxColumn});
            this.PatientsListDGV.DataSource = this.patientsBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientsListDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.PatientsListDGV.Location = new System.Drawing.Point(464, 12);
            this.PatientsListDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatientsListDGV.Name = "PatientsListDGV";
            this.PatientsListDGV.ReadOnly = true;
            this.PatientsListDGV.RowHeadersVisible = false;
            this.PatientsListDGV.Size = new System.Drawing.Size(729, 575);
            this.PatientsListDGV.TabIndex = 0;
            // 
            // psurnameDataGridViewTextBoxColumn
            // 
            this.psurnameDataGridViewTextBoxColumn.DataPropertyName = "p_surname";
            this.psurnameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.psurnameDataGridViewTextBoxColumn.Name = "psurnameDataGridViewTextBoxColumn";
            this.psurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "p_name";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            this.pnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // psecnameDataGridViewTextBoxColumn
            // 
            this.psecnameDataGridViewTextBoxColumn.DataPropertyName = "p_secname";
            this.psecnameDataGridViewTextBoxColumn.HeaderText = "По батькові";
            this.psecnameDataGridViewTextBoxColumn.Name = "psecnameDataGridViewTextBoxColumn";
            this.psecnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pbirthdayDataGridViewTextBoxColumn
            // 
            this.pbirthdayDataGridViewTextBoxColumn.DataPropertyName = "p_birthday";
            this.pbirthdayDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            this.pbirthdayDataGridViewTextBoxColumn.Name = "pbirthdayDataGridViewTextBoxColumn";
            this.pbirthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pgenderIdDataGridViewTextBoxColumn
            // 
            this.pgenderIdDataGridViewTextBoxColumn.DataPropertyName = "p_genderId";
            this.pgenderIdDataGridViewTextBoxColumn.DataSource = this.genderBindingSource;
            this.pgenderIdDataGridViewTextBoxColumn.DisplayMember = "gen_value";
            this.pgenderIdDataGridViewTextBoxColumn.HeaderText = "Стать";
            this.pgenderIdDataGridViewTextBoxColumn.Name = "pgenderIdDataGridViewTextBoxColumn";
            this.pgenderIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pgenderIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pgenderIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pgenderIdDataGridViewTextBoxColumn.ValueMember = "gen_id";
            // 
            // pfactAddressDataGridViewTextBoxColumn
            // 
            this.pfactAddressDataGridViewTextBoxColumn.DataPropertyName = "p_factAddress";
            this.pfactAddressDataGridViewTextBoxColumn.HeaderText = "p_factAddress";
            this.pfactAddressDataGridViewTextBoxColumn.Name = "pfactAddressDataGridViewTextBoxColumn";
            this.pfactAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.pfactAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // pregAddressDataGridViewTextBoxColumn
            // 
            this.pregAddressDataGridViewTextBoxColumn.DataPropertyName = "p_regAddress";
            this.pregAddressDataGridViewTextBoxColumn.HeaderText = "p_regAddress";
            this.pregAddressDataGridViewTextBoxColumn.Name = "pregAddressDataGridViewTextBoxColumn";
            this.pregAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.pregAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // pdiagnosisIdDataGridViewTextBoxColumn
            // 
            this.pdiagnosisIdDataGridViewTextBoxColumn.DataPropertyName = "p_diagnosisId";
            this.pdiagnosisIdDataGridViewTextBoxColumn.HeaderText = "p_diagnosisId";
            this.pdiagnosisIdDataGridViewTextBoxColumn.Name = "pdiagnosisIdDataGridViewTextBoxColumn";
            this.pdiagnosisIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdiagnosisIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // ptypeIdDataGridViewTextBoxColumn
            // 
            this.ptypeIdDataGridViewTextBoxColumn.DataPropertyName = "p_typeId";
            this.ptypeIdDataGridViewTextBoxColumn.HeaderText = "p_typeId";
            this.ptypeIdDataGridViewTextBoxColumn.Name = "ptypeIdDataGridViewTextBoxColumn";
            this.ptypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ptypeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // pbkIDDataGridViewTextBoxColumn
            // 
            this.pbkIDDataGridViewTextBoxColumn.DataPropertyName = "p_bkID";
            this.pbkIDDataGridViewTextBoxColumn.HeaderText = "p_bkID";
            this.pbkIDDataGridViewTextBoxColumn.Name = "pbkIDDataGridViewTextBoxColumn";
            this.pbkIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pbkIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pdestructionIdDataGridViewTextBoxColumn
            // 
            this.pdestructionIdDataGridViewTextBoxColumn.DataPropertyName = "p_destructionId";
            this.pdestructionIdDataGridViewTextBoxColumn.HeaderText = "p_destructionId";
            this.pdestructionIdDataGridViewTextBoxColumn.Name = "pdestructionIdDataGridViewTextBoxColumn";
            this.pdestructionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.pdestructionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // potherDiseasesDataGridViewTextBoxColumn
            // 
            this.potherDiseasesDataGridViewTextBoxColumn.DataPropertyName = "p_otherDiseases";
            this.potherDiseasesDataGridViewTextBoxColumn.HeaderText = "p_otherDiseases";
            this.potherDiseasesDataGridViewTextBoxColumn.Name = "potherDiseasesDataGridViewTextBoxColumn";
            this.potherDiseasesDataGridViewTextBoxColumn.ReadOnly = true;
            this.potherDiseasesDataGridViewTextBoxColumn.Visible = false;
            // 
            // pfirstVisitDataGridViewTextBoxColumn
            // 
            this.pfirstVisitDataGridViewTextBoxColumn.DataPropertyName = "p_firstVisit";
            this.pfirstVisitDataGridViewTextBoxColumn.HeaderText = "p_firstVisit";
            this.pfirstVisitDataGridViewTextBoxColumn.Name = "pfirstVisitDataGridViewTextBoxColumn";
            this.pfirstVisitDataGridViewTextBoxColumn.ReadOnly = true;
            this.pfirstVisitDataGridViewTextBoxColumn.Visible = false;
            // 
            // plastVisitDataGridViewTextBoxColumn
            // 
            this.plastVisitDataGridViewTextBoxColumn.DataPropertyName = "p_lastVisit";
            this.plastVisitDataGridViewTextBoxColumn.HeaderText = "p_lastVisit";
            this.plastVisitDataGridViewTextBoxColumn.Name = "plastVisitDataGridViewTextBoxColumn";
            this.plastVisitDataGridViewTextBoxColumn.ReadOnly = true;
            this.plastVisitDataGridViewTextBoxColumn.Visible = false;
            // 
            // presultDataGridViewTextBoxColumn
            // 
            this.presultDataGridViewTextBoxColumn.DataPropertyName = "p_result";
            this.presultDataGridViewTextBoxColumn.HeaderText = "p_result";
            this.presultDataGridViewTextBoxColumn.Name = "presultDataGridViewTextBoxColumn";
            this.presultDataGridViewTextBoxColumn.ReadOnly = true;
            this.presultDataGridViewTextBoxColumn.Visible = false;
            // 
            // pphonesDataGridViewTextBoxColumn
            // 
            this.pphonesDataGridViewTextBoxColumn.DataPropertyName = "p_phones";
            this.pphonesDataGridViewTextBoxColumn.HeaderText = "p_phones";
            this.pphonesDataGridViewTextBoxColumn.Name = "pphonesDataGridViewTextBoxColumn";
            this.pphonesDataGridViewTextBoxColumn.ReadOnly = true;
            this.pphonesDataGridViewTextBoxColumn.Visible = false;
            // 
            // pkommentDataGridViewTextBoxColumn
            // 
            this.pkommentDataGridViewTextBoxColumn.DataPropertyName = "p_komment";
            this.pkommentDataGridViewTextBoxColumn.HeaderText = "p_komment";
            this.pkommentDataGridViewTextBoxColumn.Name = "pkommentDataGridViewTextBoxColumn";
            this.pkommentDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkommentDataGridViewTextBoxColumn.Visible = false;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "p_id";
            this.pidDataGridViewTextBoxColumn.HeaderText = "p_id";
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            this.pidDataGridViewTextBoxColumn.ReadOnly = true;
            this.pidDataGridViewTextBoxColumn.Visible = false;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataSource = typeof(DataLibrary.Patients);
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPatientButton.Location = new System.Drawing.Point(13, 12);
            this.AddPatientButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(165, 54);
            this.AddPatientButton.TabIndex = 1;
            this.AddPatientButton.Text = "Додати пацієнта";
            this.AddPatientButton.UseVisualStyleBackColor = true;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(13, 74);
            this.filter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(419, 513);
            this.filter.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 592);
            this.Controls.Add(this.AddPatientButton);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.PatientsListDGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.Text = "Кабінет лікаря-фтизіатра";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsListDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientsListDGV;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private System.Windows.Forms.Button AddPatientButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn psurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn psecnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pgenderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pfactAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pregAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdiagnosisIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pbkIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pdestructionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potherDiseasesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pfirstVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plastVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pphonesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private Filter filter;
    }
}

