namespace EightQueen
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
            this.label1 = new System.Windows.Forms.Label();
            this.popsize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Gen = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.crossprob = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Mutprob = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.fitness = new System.Windows.Forms.Label();
            this.startbut = new System.Windows.Forms.Button();
            this.OptimizedMode = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SolutionToShow = new System.Windows.Forms.NumericUpDown();
            this.board1 = new EightQueen.Board();
            ((System.ComponentModel.ISupportInitialize)(this.popsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossprob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mutprob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionToShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(655, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Population size :";
            // 
            // popsize
            // 
            this.popsize.Location = new System.Drawing.Point(784, 55);
            this.popsize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.popsize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.popsize.Name = "popsize";
            this.popsize.Size = new System.Drawing.Size(68, 20);
            this.popsize.TabIndex = 2;
            this.popsize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(655, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Generations :";
            // 
            // Gen
            // 
            this.Gen.Location = new System.Drawing.Point(784, 107);
            this.Gen.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(68, 20);
            this.Gen.TabIndex = 4;
            this.Gen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(653, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Crossover Prob :";
            // 
            // crossprob
            // 
            this.crossprob.DecimalPlaces = 2;
            this.crossprob.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.crossprob.Location = new System.Drawing.Point(784, 155);
            this.crossprob.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.crossprob.Name = "crossprob";
            this.crossprob.Size = new System.Drawing.Size(68, 20);
            this.crossprob.TabIndex = 6;
            this.crossprob.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(655, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mutation Prob :";
            // 
            // Mutprob
            // 
            this.Mutprob.DecimalPlaces = 2;
            this.Mutprob.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Mutprob.Location = new System.Drawing.Point(784, 203);
            this.Mutprob.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Mutprob.Name = "Mutprob";
            this.Mutprob.Size = new System.Drawing.Size(68, 20);
            this.Mutprob.TabIndex = 8;
            this.Mutprob.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(689, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Solution fitness  :";
            // 
            // fitness
            // 
            this.fitness.AutoSize = true;
            this.fitness.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fitness.Location = new System.Drawing.Point(803, 312);
            this.fitness.Name = "fitness";
            this.fitness.Size = new System.Drawing.Size(0, 18);
            this.fitness.TabIndex = 10;
            // 
            // startbut
            // 
            this.startbut.Font = new System.Drawing.Font("Mangal", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbut.Location = new System.Drawing.Point(709, 375);
            this.startbut.Name = "startbut";
            this.startbut.Size = new System.Drawing.Size(101, 39);
            this.startbut.TabIndex = 11;
            this.startbut.Text = "Start";
            this.startbut.UseVisualStyleBackColor = true;
            this.startbut.Click += new System.EventHandler(this.startbut_Click);
            // 
            // OptimizedMode
            // 
            this.OptimizedMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OptimizedMode.AutoSize = true;
            this.OptimizedMode.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptimizedMode.Location = new System.Drawing.Point(680, 502);
            this.OptimizedMode.Name = "OptimizedMode";
            this.OptimizedMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OptimizedMode.Size = new System.Drawing.Size(152, 23);
            this.OptimizedMode.TabIndex = 13;
            this.OptimizedMode.Text = ": Optimized mode";
            this.OptimizedMode.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(656, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Show solution number :";
            // 
            // SolutionToShow
            // 
            this.SolutionToShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SolutionToShow.Location = new System.Drawing.Point(794, 249);
            this.SolutionToShow.Name = "SolutionToShow";
            this.SolutionToShow.Size = new System.Drawing.Size(58, 20);
            this.SolutionToShow.TabIndex = 15;
            this.SolutionToShow.ValueChanged += new System.EventHandler(this.SolutionToShow_ValueChanged);
            // 
            // board1
            // 
            this.board1.Dock = System.Windows.Forms.DockStyle.Left;
            this.board1.Location = new System.Drawing.Point(0, 0);
            this.board1.Name = "board1";
            this.board1.Size = new System.Drawing.Size(649, 648);
            this.board1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 648);
            this.Controls.Add(this.SolutionToShow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OptimizedMode);
            this.Controls.Add(this.startbut);
            this.Controls.Add(this.fitness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Mutprob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.crossprob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.popsize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.board1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Eight Queen";
            ((System.ComponentModel.ISupportInitialize)(this.popsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossprob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mutprob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionToShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Board board1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown popsize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Gen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown crossprob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Mutprob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fitness;
        private System.Windows.Forms.Button startbut;
        private System.Windows.Forms.CheckBox OptimizedMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown SolutionToShow;
    }
}

