namespace TubDB
{
    partial class SputumTestForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.StatusL = new System.Windows.Forms.Label();
            this.OKbut = new System.Windows.Forms.Button();
            this.inoTB = new System.Windows.Forms.TextBox();
            this.skopTB = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StatusL
            // 
            this.StatusL.AutoSize = true;
            this.StatusL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusL.Location = new System.Drawing.Point(8, 9);
            this.StatusL.Name = "StatusL";
            this.StatusL.Size = new System.Drawing.Size(149, 20);
            this.StatusL.TabIndex = 31;
            this.StatusL.Text = "Заплановано на ...";
            // 
            // OKbut
            // 
            this.OKbut.Location = new System.Drawing.Point(97, 88);
            this.OKbut.Name = "OKbut";
            this.OKbut.Size = new System.Drawing.Size(75, 23);
            this.OKbut.TabIndex = 30;
            this.OKbut.Text = "OK";
            this.OKbut.UseVisualStyleBackColor = true;
            this.OKbut.Click += new System.EventHandler(this.OKbut_Click);
            // 
            // inoTB
            // 
            this.inoTB.Location = new System.Drawing.Point(97, 62);
            this.inoTB.Name = "inoTB";
            this.inoTB.Size = new System.Drawing.Size(155, 20);
            this.inoTB.TabIndex = 24;
            // 
            // skopTB
            // 
            this.skopTB.Location = new System.Drawing.Point(67, 34);
            this.skopTB.Name = "skopTB";
            this.skopTB.Size = new System.Drawing.Size(185, 20);
            this.skopTB.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(9, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 16);
            label2.TabIndex = 17;
            label2.Text = "Інокуляція:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(8, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 16);
            label1.TabIndex = 16;
            label1.Text = "Скопія:";
            // 
            // SputumTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 117);
            this.Controls.Add(this.StatusL);
            this.Controls.Add(this.OKbut);
            this.Controls.Add(this.inoTB);
            this.Controls.Add(this.skopTB);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "SputumTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аналіз мокроти";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusL;
        private System.Windows.Forms.Button OKbut;
        private System.Windows.Forms.TextBox inoTB;
        private System.Windows.Forms.TextBox skopTB;
    }
}