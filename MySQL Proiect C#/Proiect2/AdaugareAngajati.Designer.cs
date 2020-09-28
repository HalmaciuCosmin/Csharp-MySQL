namespace Proiect2
{
    partial class AdaugareAngajati
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Angajat = new System.Windows.Forms.TextBox();
            this.textBox_CNP = new System.Windows.Forms.TextBox();
            this.textBox_Procent = new System.Windows.Forms.TextBox();
            this.textBox_Salar = new System.Windows.Forms.TextBox();
            this.Adaugare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNPAngajat";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "SalarAngajat";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ProcentajulMuncii";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "NumeAngajat";
            // 
            // textBox_Angajat
            // 
            this.textBox_Angajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Angajat.Location = new System.Drawing.Point(190, 47);
            this.textBox_Angajat.Name = "textBox_Angajat";
            this.textBox_Angajat.Size = new System.Drawing.Size(166, 29);
            this.textBox_Angajat.TabIndex = 4;
            // 
            // textBox_CNP
            // 
            this.textBox_CNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CNP.Location = new System.Drawing.Point(190, 113);
            this.textBox_CNP.Name = "textBox_CNP";
            this.textBox_CNP.Size = new System.Drawing.Size(166, 29);
            this.textBox_CNP.TabIndex = 5;
            // 
            // textBox_Procent
            // 
            this.textBox_Procent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Procent.Location = new System.Drawing.Point(190, 186);
            this.textBox_Procent.Name = "textBox_Procent";
            this.textBox_Procent.Size = new System.Drawing.Size(166, 29);
            this.textBox_Procent.TabIndex = 6;
            // 
            // textBox_Salar
            // 
            this.textBox_Salar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Salar.Location = new System.Drawing.Point(189, 253);
            this.textBox_Salar.Name = "textBox_Salar";
            this.textBox_Salar.Size = new System.Drawing.Size(166, 29);
            this.textBox_Salar.TabIndex = 7;
            // 
            // Adaugare
            // 
            this.Adaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adaugare.Location = new System.Drawing.Point(47, 326);
            this.Adaugare.Name = "Adaugare";
            this.Adaugare.Size = new System.Drawing.Size(271, 51);
            this.Adaugare.TabIndex = 8;
            this.Adaugare.Text = "Adaugare";
            this.Adaugare.UseVisualStyleBackColor = true;
            this.Adaugare.Click += new System.EventHandler(this.Adaugare_Click);
            // 
            // AdaugareAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 403);
            this.Controls.Add(this.Adaugare);
            this.Controls.Add(this.textBox_Salar);
            this.Controls.Add(this.textBox_Procent);
            this.Controls.Add(this.textBox_CNP);
            this.Controls.Add(this.textBox_Angajat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugareAngajati";
            this.Text = "AdaugareAngajati";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Angajat;
        private System.Windows.Forms.TextBox textBox_CNP;
        private System.Windows.Forms.TextBox textBox_Procent;
        private System.Windows.Forms.TextBox textBox_Salar;
        private System.Windows.Forms.Button Adaugare;
    }
}