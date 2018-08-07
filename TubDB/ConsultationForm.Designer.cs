namespace TubDB
{
    partial class ConsultationForm
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
            System.Windows.Forms.Label label1;
            this.StatusL = new System.Windows.Forms.Label();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.consultationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommentRTB = new System.Windows.Forms.RichTextBox();
            this.OKbut = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultationTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(6, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 16);
            label2.TabIndex = 17;
            label2.Text = "Коментар:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(5, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 16);
            label1.TabIndex = 16;
            label1.Text = "Тип:";
            // 
            // StatusL
            // 
            this.StatusL.AutoSize = true;
            this.StatusL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusL.Location = new System.Drawing.Point(5, 7);
            this.StatusL.Name = "StatusL";
            this.StatusL.Size = new System.Drawing.Size(149, 20);
            this.StatusL.TabIndex = 20;
            this.StatusL.Text = "Заплановано на ...";
            // 
            // typeCB
            // 
            this.typeCB.DataSource = this.consultationTypeBindingSource;
            this.typeCB.DisplayMember = "ct_value";
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(47, 32);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(202, 21);
            this.typeCB.TabIndex = 21;
            this.typeCB.ValueMember = "ct_id";
            // 
            // consultationTypeBindingSource
            // 
            this.consultationTypeBindingSource.DataSource = typeof(DataLibrary.ConsultationType);
            this.consultationTypeBindingSource.CurrentChanged += new System.EventHandler(this.consultationTypeBindingSource_CurrentChanged);
            // 
            // CommentRTB
            // 
            this.CommentRTB.Location = new System.Drawing.Point(8, 79);
            this.CommentRTB.Name = "CommentRTB";
            this.CommentRTB.Size = new System.Drawing.Size(241, 137);
            this.CommentRTB.TabIndex = 22;
            this.CommentRTB.Text = "";
            // 
            // OKbut
            // 
            this.OKbut.Location = new System.Drawing.Point(91, 222);
            this.OKbut.Name = "OKbut";
            this.OKbut.Size = new System.Drawing.Size(75, 23);
            this.OKbut.TabIndex = 23;
            this.OKbut.Text = "OK";
            this.OKbut.UseVisualStyleBackColor = true;
            this.OKbut.Click += new System.EventHandler(this.OKbut_Click_1);
            // 
            // ConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 252);
            this.Controls.Add(this.OKbut);
            this.Controls.Add(this.CommentRTB);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.StatusL);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "ConsultationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Консультація";
            ((System.ComponentModel.ISupportInitialize)(this.consultationTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusL;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.BindingSource consultationTypeBindingSource;
        private System.Windows.Forms.RichTextBox CommentRTB;
        private System.Windows.Forms.Button OKbut;
    }
}