namespace Strumming_Permutator
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.subdivisions = new System.Windows.Forms.NumericUpDown();
            this.beats = new System.Windows.Forms.NumericUpDown();
            this.minSkip = new System.Windows.Forms.NumericUpDown();
            this.maxSkip = new System.Windows.Forms.NumericUpDown();
            this.keepBeatOne = new System.Windows.Forms.CheckBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subdivisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSkip)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SlateGray;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(259, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(251, 255);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.beats, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.subdivisions, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.minSkip, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.maxSkip, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.keepBeatOne, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonGo, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(250, 152);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // subdivisions
            // 
            this.subdivisions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subdivisions.Location = new System.Drawing.Point(128, 29);
            this.subdivisions.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.subdivisions.Name = "subdivisions";
            this.subdivisions.Size = new System.Drawing.Size(119, 20);
            this.subdivisions.TabIndex = 1;
            // 
            // beats
            // 
            this.beats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.beats.Location = new System.Drawing.Point(128, 3);
            this.beats.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.beats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.beats.Name = "beats";
            this.beats.Size = new System.Drawing.Size(119, 20);
            this.beats.TabIndex = 2;
            this.beats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minSkip
            // 
            this.minSkip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minSkip.Location = new System.Drawing.Point(128, 55);
            this.minSkip.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.minSkip.Name = "minSkip";
            this.minSkip.Size = new System.Drawing.Size(119, 20);
            this.minSkip.TabIndex = 3;
            // 
            // maxSkip
            // 
            this.maxSkip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxSkip.Location = new System.Drawing.Point(128, 81);
            this.maxSkip.Name = "maxSkip";
            this.maxSkip.Size = new System.Drawing.Size(119, 20);
            this.maxSkip.TabIndex = 4;
            // 
            // keepBeatOne
            // 
            this.keepBeatOne.AutoSize = true;
            this.keepBeatOne.Checked = true;
            this.keepBeatOne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keepBeatOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keepBeatOne.Location = new System.Drawing.Point(128, 107);
            this.keepBeatOne.Name = "keepBeatOne";
            this.keepBeatOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.keepBeatOne.Size = new System.Drawing.Size(119, 17);
            this.keepBeatOne.TabIndex = 5;
            this.keepBeatOne.Text = "Keep Beat One";
            this.keepBeatOne.UseVisualStyleBackColor = true;
            // 
            // buttonGo
            // 
            this.buttonGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGo.Location = new System.Drawing.Point(128, 130);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(119, 23);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "&Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Beats to the bar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Subdivisions:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Min Skip:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max Skip:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(513, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subdivisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSkip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown beats;
        private System.Windows.Forms.NumericUpDown subdivisions;
        private System.Windows.Forms.NumericUpDown minSkip;
        private System.Windows.Forms.NumericUpDown maxSkip;
        private System.Windows.Forms.CheckBox keepBeatOne;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

