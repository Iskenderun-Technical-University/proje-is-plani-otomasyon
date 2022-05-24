
namespace is_takip_programi
{
    partial class CalisandanGelenBildirim
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Görüntüle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "ÇALIŞANLARDAN GELEN BİLDİRİMLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 307);
            this.dataGridView1.TabIndex = 4;
            // 
            // Görüntüle
            // 
            this.Görüntüle.BackColor = System.Drawing.Color.Black;
            this.Görüntüle.ForeColor = System.Drawing.Color.Transparent;
            this.Görüntüle.Location = new System.Drawing.Point(778, 154);
            this.Görüntüle.Margin = new System.Windows.Forms.Padding(4);
            this.Görüntüle.Name = "Görüntüle";
            this.Görüntüle.Size = new System.Drawing.Size(120, 53);
            this.Görüntüle.TabIndex = 6;
            this.Görüntüle.Text = "Görüntüle";
            this.Görüntüle.UseVisualStyleBackColor = false;
            this.Görüntüle.Click += new System.EventHandler(this.Görüntüle_Click);
            // 
            // CalisandanGelenBildirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(911, 517);
            this.Controls.Add(this.Görüntüle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalisandanGelenBildirim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalisandanGelenBildirim";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.CalisandanGelenBildirim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Görüntüle;
    }
}