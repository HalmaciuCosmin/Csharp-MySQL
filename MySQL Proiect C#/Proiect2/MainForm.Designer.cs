namespace Proiect2
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdaugaAngajat = new System.Windows.Forms.Button();
            this.EmiteFluturas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateAngajat = new System.Windows.Forms.Button();
            this.Sterge = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.button_PDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // AdaugaAngajat
            // 
            this.AdaugaAngajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdaugaAngajat.Location = new System.Drawing.Point(619, 61);
            this.AdaugaAngajat.Name = "AdaugaAngajat";
            this.AdaugaAngajat.Size = new System.Drawing.Size(159, 41);
            this.AdaugaAngajat.TabIndex = 1;
            this.AdaugaAngajat.Text = "AdaugaAngajat";
            this.AdaugaAngajat.UseVisualStyleBackColor = true;
            this.AdaugaAngajat.Click += new System.EventHandler(this.AdaugaAngajat_Click);
            // 
            // EmiteFluturas
            // 
            this.EmiteFluturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmiteFluturas.Location = new System.Drawing.Point(619, 292);
            this.EmiteFluturas.Name = "EmiteFluturas";
            this.EmiteFluturas.Size = new System.Drawing.Size(159, 40);
            this.EmiteFluturas.TabIndex = 2;
            this.EmiteFluturas.Text = "EmiteFluturas";
            this.EmiteFluturas.UseVisualStyleBackColor = true;
            this.EmiteFluturas.Click += new System.EventHandler(this.EmiteFluturas_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // UpdateAngajat
            // 
            this.UpdateAngajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAngajat.Location = new System.Drawing.Point(619, 120);
            this.UpdateAngajat.Name = "UpdateAngajat";
            this.UpdateAngajat.Size = new System.Drawing.Size(159, 41);
            this.UpdateAngajat.TabIndex = 4;
            this.UpdateAngajat.Text = "UpdateAngajat";
            this.UpdateAngajat.UseVisualStyleBackColor = true;
            this.UpdateAngajat.Click += new System.EventHandler(this.UpdateAngajat_Click);
            // 
            // Sterge
            // 
            this.Sterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sterge.Location = new System.Drawing.Point(619, 179);
            this.Sterge.Name = "Sterge";
            this.Sterge.Size = new System.Drawing.Size(159, 40);
            this.Sterge.TabIndex = 5;
            this.Sterge.Text = "StergeAngajat";
            this.Sterge.UseVisualStyleBackColor = true;
            this.Sterge.Click += new System.EventHandler(this.Sterge_Click);
            // 
            // Import
            // 
            this.Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Import.Location = new System.Drawing.Point(619, 236);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(159, 40);
            this.Import.TabIndex = 6;
            this.Import.Text = "ImportaAngajati";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // button_PDF
            // 
            this.button_PDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PDF.Location = new System.Drawing.Point(619, 342);
            this.button_PDF.Name = "button_PDF";
            this.button_PDF.Size = new System.Drawing.Size(159, 40);
            this.button_PDF.TabIndex = 7;
            this.button_PDF.Text = "Export PDF";
            this.button_PDF.UseVisualStyleBackColor = true;
            this.button_PDF.Click += new System.EventHandler(this.button_PDF_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 403);
            this.Controls.Add(this.button_PDF);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Sterge);
            this.Controls.Add(this.UpdateAngajat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmiteFluturas);
            this.Controls.Add(this.AdaugaAngajat);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AdaugaAngajat;
        private System.Windows.Forms.Button EmiteFluturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateAngajat;
        private System.Windows.Forms.Button Sterge;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button button_PDF;
    }
}