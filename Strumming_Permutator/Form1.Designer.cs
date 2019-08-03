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
            this.output = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.subdivisions = new System.Windows.Forms.NumericUpDown();
            this.minSkip = new System.Windows.Forms.NumericUpDown();
            this.maxSkip = new System.Windows.Forms.NumericUpDown();
            this.keepBeatOne = new System.Windows.Forms.CheckBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbSixEight = new System.Windows.Forms.RadioButton();
            this.rbFourFour = new System.Windows.Forms.RadioButton();
            this.rbThreeFour = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subdivisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSkip)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.LightSteelBlue;
            this.output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(225, 3);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(515, 255);
            this.output.TabIndex = 0;
            this.output.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.output, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.subdivisions, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.minSkip, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.maxSkip, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.keepBeatOne, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonGo, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(216, 255);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // subdivisions
            // 
            this.subdivisions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subdivisions.Location = new System.Drawing.Point(111, 83);
            this.subdivisions.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.subdivisions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.subdivisions.Name = "subdivisions";
            this.subdivisions.Size = new System.Drawing.Size(102, 20);
            this.subdivisions.TabIndex = 1;
            this.subdivisions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minSkip
            // 
            this.minSkip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minSkip.Location = new System.Drawing.Point(111, 109);
            this.minSkip.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.minSkip.Name = "minSkip";
            this.minSkip.Size = new System.Drawing.Size(102, 20);
            this.minSkip.TabIndex = 3;
            // 
            // maxSkip
            // 
            this.maxSkip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxSkip.Location = new System.Drawing.Point(111, 135);
            this.maxSkip.Name = "maxSkip";
            this.maxSkip.Size = new System.Drawing.Size(102, 20);
            this.maxSkip.TabIndex = 4;
            // 
            // keepBeatOne
            // 
            this.keepBeatOne.AutoSize = true;
            this.keepBeatOne.Checked = true;
            this.keepBeatOne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keepBeatOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keepBeatOne.Location = new System.Drawing.Point(111, 161);
            this.keepBeatOne.Name = "keepBeatOne";
            this.keepBeatOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.keepBeatOne.Size = new System.Drawing.Size(102, 17);
            this.keepBeatOne.TabIndex = 5;
            this.keepBeatOne.Text = "Keep Beat One";
            this.keepBeatOne.UseVisualStyleBackColor = true;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(111, 184);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(102, 23);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "&Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 80);
            this.label1.TabIndex = 7;
            this.label1.Text = "Time Signature:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Subdivisions:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Min Skip:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max Skip:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSixEight);
            this.panel1.Controls.Add(this.rbFourFour);
            this.panel1.Controls.Add(this.rbThreeFour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(111, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 74);
            this.panel1.TabIndex = 11;
            // 
            // rbSixEight
            // 
            this.rbSixEight.AutoSize = true;
            this.rbSixEight.Location = new System.Drawing.Point(9, 53);
            this.rbSixEight.Name = "rbSixEight";
            this.rbSixEight.Size = new System.Drawing.Size(42, 17);
            this.rbSixEight.TabIndex = 2;
            this.rbSixEight.Text = "6/8";
            this.rbSixEight.UseVisualStyleBackColor = true;
            this.rbSixEight.CheckedChanged += new System.EventHandler(this.RbSixEight_CheckedChanged);
            // 
            // rbFourFour
            // 
            this.rbFourFour.AutoSize = true;
            this.rbFourFour.Location = new System.Drawing.Point(9, 29);
            this.rbFourFour.Name = "rbFourFour";
            this.rbFourFour.Size = new System.Drawing.Size(42, 17);
            this.rbFourFour.TabIndex = 1;
            this.rbFourFour.Text = "4/4";
            this.rbFourFour.UseVisualStyleBackColor = true;
            this.rbFourFour.CheckedChanged += new System.EventHandler(this.RbFourFour_CheckedChanged);
            // 
            // rbThreeFour
            // 
            this.rbThreeFour.AutoSize = true;
            this.rbThreeFour.Location = new System.Drawing.Point(9, 5);
            this.rbThreeFour.Name = "rbThreeFour";
            this.rbThreeFour.Size = new System.Drawing.Size(42, 17);
            this.rbThreeFour.TabIndex = 0;
            this.rbThreeFour.Text = "3/4";
            this.rbThreeFour.UseVisualStyleBackColor = true;
            this.rbThreeFour.CheckedChanged += new System.EventHandler(this.RbThreeFour_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(743, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "Strumming Rhythm Permutator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subdivisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSkip)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown subdivisions;
        private System.Windows.Forms.NumericUpDown minSkip;
        private System.Windows.Forms.NumericUpDown maxSkip;
        private System.Windows.Forms.CheckBox keepBeatOne;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbSixEight;
        private System.Windows.Forms.RadioButton rbFourFour;
        private System.Windows.Forms.RadioButton rbThreeFour;
    }
}

