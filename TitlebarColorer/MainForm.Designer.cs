using System.Windows.Forms;

namespace TitlebarColorer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.trbRed = new System.Windows.Forms.TrackBar();
            this.trbGreen = new System.Windows.Forms.TrackBar();
            this.trbBlue = new System.Windows.Forms.TrackBar();
            this.lbGreen = new System.Windows.Forms.Label();
            this.lbRed = new System.Windows.Forms.Label();
            this.lbBlue = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.cbOption1 = new System.Windows.Forms.CheckBox();
            this.cbOption2 = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.colorPreview = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize) (this.trbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // trbRed
            // 
            this.trbRed.BackColor = System.Drawing.SystemColors.Control;
            this.trbRed.LargeChange = 10;
            this.trbRed.Location = new System.Drawing.Point(12, 12);
            this.trbRed.Maximum = 255;
            this.trbRed.Name = "trbRed";
            this.trbRed.Size = new System.Drawing.Size(299, 37);
            this.trbRed.TabIndex = 0;
            this.trbRed.Value = 255;
            // 
            // trbGreen
            // 
            this.trbGreen.LargeChange = 10;
            this.trbGreen.Location = new System.Drawing.Point(12, 55);
            this.trbGreen.Maximum = 255;
            this.trbGreen.Name = "trbGreen";
            this.trbGreen.Size = new System.Drawing.Size(299, 37);
            this.trbGreen.TabIndex = 1;
            this.trbGreen.Value = 255;
            // 
            // trbBlue
            // 
            this.trbBlue.LargeChange = 10;
            this.trbBlue.Location = new System.Drawing.Point(12, 98);
            this.trbBlue.Maximum = 255;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Size = new System.Drawing.Size(299, 37);
            this.trbBlue.TabIndex = 2;
            this.trbBlue.Value = 255;
            // 
            // lbGreen
            // 
            this.lbGreen.ForeColor = System.Drawing.Color.Green;
            this.lbGreen.Location = new System.Drawing.Point(317, 55);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(55, 37);
            this.lbGreen.TabIndex = 3;
            this.lbGreen.Text = "G: 255";
            this.lbGreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRed
            // 
            this.lbRed.ForeColor = System.Drawing.Color.Red;
            this.lbRed.Location = new System.Drawing.Point(317, 12);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(55, 37);
            this.lbRed.TabIndex = 4;
            this.lbRed.Text = "R: 255";
            this.lbRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBlue
            // 
            this.lbBlue.ForeColor = System.Drawing.Color.Blue;
            this.lbBlue.Location = new System.Drawing.Point(317, 98);
            this.lbBlue.Name = "lbBlue";
            this.lbBlue.Size = new System.Drawing.Size(55, 37);
            this.lbBlue.TabIndex = 5;
            this.lbBlue.Text = "B: 255";
            this.lbBlue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb1
            // 
            this.lb1.Location = new System.Drawing.Point(12, 138);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(79, 26);
            this.lb1.TabIndex = 6;
            this.lb1.Text = "Apply to:";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbOption1
            // 
            this.cbOption1.Checked = true;
            this.cbOption1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOption1.Location = new System.Drawing.Point(97, 141);
            this.cbOption1.Name = "cbOption1";
            this.cbOption1.Size = new System.Drawing.Size(155, 26);
            this.cbOption1.TabIndex = 7;
            this.cbOption1.Text = "Active Titlebar Color";
            this.cbOption1.UseVisualStyleBackColor = true;
            // 
            // cbOption2
            // 
            this.cbOption2.Checked = true;
            this.cbOption2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOption2.Location = new System.Drawing.Point(97, 173);
            this.cbOption2.Name = "cbOption2";
            this.cbOption2.Size = new System.Drawing.Size(165, 26);
            this.cbOption2.TabIndex = 8;
            this.cbOption2.Text = "Inactive Titlebar Color";
            this.cbOption2.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnApply.Location = new System.Drawing.Point(297, 201);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // colorPreview
            // 
            this.colorPreview.BackColor = System.Drawing.Color.White;
            this.colorPreview.Location = new System.Drawing.Point(12, 201);
            this.colorPreview.Name = "colorPreview";
            this.colorPreview.Size = new System.Drawing.Size(76, 23);
            this.colorPreview.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 236);
            this.Controls.Add(this.colorPreview);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cbOption2);
            this.Controls.Add(this.cbOption1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lbBlue);
            this.Controls.Add(this.lbRed);
            this.Controls.Add(this.lbGreen);
            this.Controls.Add(this.trbBlue);
            this.Controls.Add(this.trbGreen);
            this.Controls.Add(this.trbRed);
            this.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 275);
            this.MinimumSize = new System.Drawing.Size(400, 275);
            this.Name = "MainForm";
            this.Text = "TitlebarZ";
            ((System.ComponentModel.ISupportInitialize) (this.trbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel colorPreview;

        private System.Windows.Forms.Button btnApply;

        private System.Windows.Forms.CheckBox cbOption2;

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.CheckBox cbOption1;

        private System.Windows.Forms.Label lbGreen;
        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.Label lbBlue;

        private System.Windows.Forms.TrackBar trbBlue;
        private System.Windows.Forms.TrackBar trbGreen;
        private System.Windows.Forms.TrackBar trbRed;

        #endregion
    }
}