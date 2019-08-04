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
            this.subdivisions = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.keepBeatOne = new System.Windows.Forms.CheckBox();
            this.maxSkip = new System.Windows.Forms.NumericUpDown();
            this.minSkip = new System.Windows.Forms.NumericUpDown();
            this.buttonGo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelTimeSig = new System.Windows.Forms.Panel();
            this.rbSixEight = new System.Windows.Forms.RadioButton();
            this.rbFourFour = new System.Windows.Forms.RadioButton();
            this.rbThreeFour = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numSubdivisionVariations = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.variantSubdivisions = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.subdivisions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSkip)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelTimeSig.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSubdivisionVariations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variantSubdivisions)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.LightSteelBlue;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(12, 12);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(719, 91);
            this.output.TabIndex = 0;
            this.output.Text = "";
            // 
            // subdivisions
            // 
            this.subdivisions.Location = new System.Drawing.Point(6, 16);
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
            this.subdivisions.Size = new System.Drawing.Size(98, 20);
            this.subdivisions.TabIndex = 13;
            this.subdivisions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.subdivisions.ValueChanged += new System.EventHandler(this.Subdivisions_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Subdivisions:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Minimum Subdivisions to Skip:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Maximum Subdivisions to Skip:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // keepBeatOne
            // 
            this.keepBeatOne.AutoSize = true;
            this.keepBeatOne.Checked = true;
            this.keepBeatOne.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keepBeatOne.Location = new System.Drawing.Point(12, 84);
            this.keepBeatOne.Name = "keepBeatOne";
            this.keepBeatOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.keepBeatOne.Size = new System.Drawing.Size(146, 17);
            this.keepBeatOne.TabIndex = 16;
            this.keepBeatOne.Text = "Never Remove Beat One";
            this.keepBeatOne.UseVisualStyleBackColor = true;
            this.keepBeatOne.CheckedChanged += new System.EventHandler(this.KeepBeatOne_CheckedChanged);
            // 
            // maxSkip
            // 
            this.maxSkip.Location = new System.Drawing.Point(169, 51);
            this.maxSkip.Name = "maxSkip";
            this.maxSkip.Size = new System.Drawing.Size(81, 20);
            this.maxSkip.TabIndex = 15;
            this.maxSkip.ValueChanged += new System.EventHandler(this.MaxSkip_ValueChanged);
            // 
            // minSkip
            // 
            this.minSkip.Location = new System.Drawing.Point(169, 19);
            this.minSkip.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.minSkip.Name = "minSkip";
            this.minSkip.Size = new System.Drawing.Size(81, 20);
            this.minSkip.TabIndex = 14;
            this.minSkip.ValueChanged += new System.EventHandler(this.MinSkip_ValueChanged);
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGo.Location = new System.Drawing.Point(296, 287);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(102, 23);
            this.buttonGo.TabIndex = 17;
            this.buttonGo.Text = "&Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panelTimeSig);
            this.groupBox1.Location = new System.Drawing.Point(10, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Signature";
            // 
            // panelTimeSig
            // 
            this.panelTimeSig.Controls.Add(this.rbSixEight);
            this.panelTimeSig.Controls.Add(this.rbFourFour);
            this.panelTimeSig.Controls.Add(this.rbThreeFour);
            this.panelTimeSig.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTimeSig.Location = new System.Drawing.Point(3, 16);
            this.panelTimeSig.Name = "panelTimeSig";
            this.panelTimeSig.Size = new System.Drawing.Size(73, 141);
            this.panelTimeSig.TabIndex = 23;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.subdivisions);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(82, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 141);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxSkip);
            this.groupBox2.Controls.Add(this.minSkip);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.keepBeatOne);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(216, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 160);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subdivision Removal Rules";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.variantSubdivisions);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numSubdivisionVariations);
            this.groupBox3.Location = new System.Drawing.Point(502, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 160);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Subdivision Variations";
            // 
            // numSubdivisionVariations
            // 
            this.numSubdivisionVariations.Location = new System.Drawing.Point(150, 16);
            this.numSubdivisionVariations.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numSubdivisionVariations.Name = "numSubdivisionVariations";
            this.numSubdivisionVariations.Size = new System.Drawing.Size(71, 20);
            this.numSubdivisionVariations.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Replace this many beats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "With this many subdivisions:";
            // 
            // variantSubdivisions
            // 
            this.variantSubdivisions.Location = new System.Drawing.Point(150, 45);
            this.variantSubdivisions.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.variantSubdivisions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.variantSubdivisions.Name = "variantSubdivisions";
            this.variantSubdivisions.Size = new System.Drawing.Size(71, 20);
            this.variantSubdivisions.TabIndex = 3;
            this.variantSubdivisions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(743, 327);
            this.Controls.Add(this.output);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Strumming Rhythm Permutator";
            ((System.ComponentModel.ISupportInitialize)(this.subdivisions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSkip)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelTimeSig.ResumeLayout(false);
            this.panelTimeSig.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSubdivisionVariations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variantSubdivisions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.NumericUpDown subdivisions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox keepBeatOne;
        private System.Windows.Forms.NumericUpDown maxSkip;
        private System.Windows.Forms.NumericUpDown minSkip;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTimeSig;
        private System.Windows.Forms.RadioButton rbSixEight;
        private System.Windows.Forms.RadioButton rbFourFour;
        private System.Windows.Forms.RadioButton rbThreeFour;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown variantSubdivisions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSubdivisionVariations;
    }
}

