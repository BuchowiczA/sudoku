namespace Sudoku
{
    partial class SudokuForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.beginnerLevel = new System.Windows.Forms.RadioButton();
            this.intermediateLevel = new System.Windows.Forms.RadioButton();
            this.advancedLevel = new System.Windows.Forms.RadioButton();
            this.checkButton = new System.Windows.Forms.Button();
            this.ngButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.beginnerLevel);
            this.panel1.Controls.Add(this.intermediateLevel);
            this.panel1.Controls.Add(this.advancedLevel);
            this.panel1.Controls.Add(this.checkButton);
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 840);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 747);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(101, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Level";
            // 
            // beginnerLevel
            // 
            this.beginnerLevel.AutoSize = true;
            this.beginnerLevel.Location = new System.Drawing.Point(202, 811);
            this.beginnerLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.beginnerLevel.Name = "beginnerLevel";
            this.beginnerLevel.Size = new System.Drawing.Size(89, 24);
            this.beginnerLevel.TabIndex = 6;
            this.beginnerLevel.TabStop = true;
            this.beginnerLevel.Text = "Beginner";
            this.beginnerLevel.UseVisualStyleBackColor = true;
            // 
            // intermediateLevel
            // 
            this.intermediateLevel.AutoSize = true;
            this.intermediateLevel.Location = new System.Drawing.Point(310, 811);
            this.intermediateLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.intermediateLevel.Name = "intermediateLevel";
            this.intermediateLevel.Size = new System.Drawing.Size(115, 24);
            this.intermediateLevel.TabIndex = 5;
            this.intermediateLevel.TabStop = true;
            this.intermediateLevel.Text = "Intermediate";
            this.intermediateLevel.UseVisualStyleBackColor = true;
            // 
            // advancedLevel
            // 
            this.advancedLevel.AutoSize = true;
            this.advancedLevel.Location = new System.Drawing.Point(442, 811);
            this.advancedLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.advancedLevel.Name = "advancedLevel";
            this.advancedLevel.Size = new System.Drawing.Size(96, 24);
            this.advancedLevel.TabIndex = 4;
            this.advancedLevel.TabStop = true;
            this.advancedLevel.Text = "Advanced";
            this.advancedLevel.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(0, 747);
            this.checkButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(160, 93);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // ngButton
            // 
            this.ngButton.Location = new System.Drawing.Point(471, 864);
            this.ngButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ngButton.Name = "ngButton";
            this.ngButton.Size = new System.Drawing.Size(160, 93);
            this.ngButton.TabIndex = 1;
            this.ngButton.Text = "New Game";
            this.ngButton.UseVisualStyleBackColor = true;
            this.ngButton.Click += new System.EventHandler(this.ngButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(14, 864);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(160, 93);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // SudokuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 1055);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.ngButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SudokuForm";
            this.Text = "Sudoku";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button ngButton;
        private Button checkButton;
        private Button clearButton;
        private RadioButton beginnerLevel;
        private RadioButton intermediateLevel;
        private RadioButton advancedLevel;
        private Label label1;
    }
}