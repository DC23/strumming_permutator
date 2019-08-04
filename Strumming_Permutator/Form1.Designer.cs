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
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelLHS = new System.Windows.Forms.Panel();
            this.subdivisions = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTimeSig = new System.Windows.Forms.Panel();
            this.rbSixEight = new System.Windows.Forms.RadioButton();
            this.keepBeatOne = new System.Windows.Forms.CheckBox();
            this.maxSkip = new System.Windows.Forms.NumericUpDown();
            this.minSkip = new System.Windows.Forms.NumericUpDown();
            this.rbFourFour = new System.Windows.Forms.RadioButton();
            this.rbThreeFour = new System.Windows.Forms.RadioButton();
            this.substituteBeat = new System.Windows.Forms.CheckBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.tableLayoutMain.SuspendLayout();
            this.panelLHS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subdivisions)).BeginInit();
            this.panelTimeSig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSkip)).BeginInit();
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
            this.output.Size = new System.Drawing.Size(515, 318);
            this.output.TabIndex = 0;
            this.output.Text = "";
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 2;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutMain.Controls.Add(this.output, 1, 0);
            this.tableLayoutMain.Controls.Add(this.panelLHS, 0, 0);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 1;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMain.Size = new System.Drawing.Size(743, 324);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // panelLHS
            // 
            this.panelLHS.Controls.Add(this.subdivisions);
            this.panelLHS.Controls.Add(this.minSkip);
            this.panelLHS.Controls.Add(this.maxSkip);
            this.panelLHS.Controls.Add(this.substituteBeat);
            this.panelLHS.Controls.Add(this.keepBeatOne);
            this.panelLHS.Controls.Add(this.label1);
            this.panelLHS.Controls.Add(this.label2);
            this.panelLHS.Controls.Add(this.label3);
            this.panelLHS.Controls.Add(this.label4);
            this.panelLHS.Controls.Add(this.buttonGo);
            this.panelLHS.Controls.Add(this.panelTimeSig);
            this.panelLHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLHS.Location = new System.Drawing.Point(3, 3);
            this.panelLHS.Name = "panelLHS";
            this.panelLHS.Size = new System.Drawing.Size(216, 318);
            this.panelLHS.TabIndex = 1;
            // 
            // subdivisions
            // 
            this.subdivisions.Location = new System.Drawing.Point(106, 86);
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
            this.subdivisions.TabIndex = 13;
            this.subdivisions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.subdivisions.ValueChanged += new System.EventHandler(this.Subdivisions_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Time Signature:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Subdivisions:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Min Skip:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Max Skip:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelTimeSig
            // 
            this.panelTimeSig.Controls.Add(this.rbSixEight);
            this.panelTimeSig.Controls.Add(this.rbFourFour);
            this.panelTimeSig.Controls.Add(this.rbThreeFour);
            this.panelTimeSig.Location = new System.Drawing.Point(106, 118);
            this.panelTimeSig.Name = "panelTimeSig";
            this.panelTimeSig.Size = new System.Drawing.Size(102, 74);
            this.panelTimeSig.TabIndex = 22;
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
            // keepBeatOne
            // 
            this.keepBeatOne.AutoSize = true;
            this.keepBeatOne.Checked = true;
            this.keepBeatOne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keepBeatOne.Location = new System.Drawing.Point(109, 213);
            this.keepBeatOne.Name = "keepBeatOne";
            this.keepBeatOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.keepBeatOne.Size = new System.Drawing.Size(99, 17);
            this.keepBeatOne.TabIndex = 16;
            this.keepBeatOne.Text = "Keep Beat One";
            this.keepBeatOne.UseVisualStyleBackColor = true;
            this.keepBeatOne.CheckedChanged += new System.EventHandler(this.KeepBeatOne_CheckedChanged);
            // 
            // maxSkip
            // 
            this.maxSkip.Location = new System.Drawing.Point(106, 35);
            this.maxSkip.Name = "maxSkip";
            this.maxSkip.Size = new System.Drawing.Size(102, 20);
            this.maxSkip.TabIndex = 15;
            this.maxSkip.ValueChanged += new System.EventHandler(this.MaxSkip_ValueChanged);
            // 
            // minSkip
            // 
            this.minSkip.Location = new System.Drawing.Point(106, 60);
            this.minSkip.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.minSkip.Name = "minSkip";
            this.minSkip.Size = new System.Drawing.Size(102, 20);
            this.minSkip.TabIndex = 14;
            this.minSkip.ValueChanged += new System.EventHandler(this.MinSkip_ValueChanged);
            // 
            // rbFourFour
            // 
            this.rbFourFour.AutoSize = true;
            this.rbFourFour.Checked = true;
            this.rbFourFour.Location = new System.Drawing.Point(9, 29);
            this.rbFourFour.Name = "rbFourFour";
            this.rbFourFour.Size = new System.Drawing.Size(42, 17);
            this.rbFourFour.TabIndex = 1;
            this.rbFourFour.TabStop = true;
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
            // substituteBeat
            // 
            this.substituteBeat.AutoSize = true;
            this.substituteBeat.Location = new System.Drawing.Point(59, 263);
            this.substituteBeat.Name = "substituteBeat";
            this.substituteBeat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.substituteBeat.Size = new System.Drawing.Size(98, 17);
            this.substituteBeat.TabIndex = 12;
            this.substituteBeat.Text = "Substitute Beat";
            this.substituteBeat.UseVisualStyleBackColor = true;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(49, 286);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(102, 23);
            this.buttonGo.TabIndex = 17;
            this.buttonGo.Text = "&Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(743, 596);
            this.Controls.Add(this.tableLayoutMain);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Text = "Strumming Rhythm Permutator";
            this.tableLayoutMain.ResumeLayout(false);
            this.panelLHS.ResumeLayout(false);
            this.panelLHS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subdivisions)).EndInit();
            this.panelTimeSig.ResumeLayout(false);
            this.panelTimeSig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSkip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.Panel panelLHS;
        private System.Windows.Forms.NumericUpDown subdivisions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelTimeSig;
        private System.Windows.Forms.RadioButton rbSixEight;
        private System.Windows.Forms.CheckBox keepBeatOne;
        private System.Windows.Forms.NumericUpDown maxSkip;
        private System.Windows.Forms.NumericUpDown minSkip;
        private System.Windows.Forms.RadioButton rbFourFour;
        private System.Windows.Forms.RadioButton rbThreeFour;
        private System.Windows.Forms.CheckBox substituteBeat;
        private System.Windows.Forms.Button buttonGo;
    }
}

