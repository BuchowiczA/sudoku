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
            panel1 = new Panel();
            label1 = new Label();
            beginnerLevel = new RadioButton();
            intermediateLevel = new RadioButton();
            advancedLevel = new RadioButton();
            checkButton = new Button();
            ngButton = new Button();
            clearButton = new Button();
            resButton = new Button();
            hintButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(beginnerLevel);
            panel1.Controls.Add(intermediateLevel);
            panel1.Controls.Add(advancedLevel);
            panel1.Controls.Add(checkButton);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(617, 840);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-2, 765);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(300, 46);
            label1.TabIndex = 7;
            label1.Text = "Poziom trudności";
            label1.Click += label1_Click;
            // 
            // beginnerLevel
            // 
            beginnerLevel.AutoSize = true;
            beginnerLevel.Location = new Point(3, 815);
            beginnerLevel.Margin = new Padding(3, 4, 3, 4);
            beginnerLevel.Name = "beginnerLevel";
            beginnerLevel.Size = new Size(114, 24);
            beginnerLevel.TabIndex = 6;
            beginnerLevel.TabStop = true;
            beginnerLevel.Text = "Początkujący";
            beginnerLevel.UseVisualStyleBackColor = true;
            // 
            // intermediateLevel
            // 
            intermediateLevel.AutoSize = true;
            intermediateLevel.Location = new Point(123, 815);
            intermediateLevel.Margin = new Padding(3, 4, 3, 4);
            intermediateLevel.Name = "intermediateLevel";
            intermediateLevel.Size = new Size(180, 24);
            intermediateLevel.TabIndex = 5;
            intermediateLevel.TabStop = true;
            intermediateLevel.Text = "Średniozaawansowany";
            intermediateLevel.UseVisualStyleBackColor = true;
            // 
            // advancedLevel
            // 
            advancedLevel.AutoSize = true;
            advancedLevel.Location = new Point(309, 816);
            advancedLevel.Margin = new Padding(3, 4, 3, 4);
            advancedLevel.Name = "advancedLevel";
            advancedLevel.Size = new Size(131, 24);
            advancedLevel.TabIndex = 4;
            advancedLevel.TabStop = true;
            advancedLevel.Text = "Zaawansowany";
            advancedLevel.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(457, 743);
            checkButton.Margin = new Padding(3, 4, 3, 4);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(160, 93);
            checkButton.TabIndex = 2;
            checkButton.Text = "Sprawdź";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // ngButton
            // 
            ngButton.Location = new Point(178, 917);
            ngButton.Margin = new Padding(3, 4, 3, 4);
            ngButton.Name = "ngButton";
            ngButton.Size = new Size(123, 93);
            ngButton.TabIndex = 1;
            ngButton.Text = "Nowa gra";
            ngButton.UseVisualStyleBackColor = true;
            ngButton.Click += ngButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(12, 917);
            clearButton.Margin = new Padding(3, 4, 3, 4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(123, 93);
            clearButton.TabIndex = 3;
            clearButton.Text = "Wyczyść";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // resButton
            // 
            resButton.Location = new Point(344, 917);
            resButton.Margin = new Padding(3, 4, 3, 4);
            resButton.Name = "resButton";
            resButton.Size = new Size(123, 93);
            resButton.TabIndex = 4;
            resButton.Text = "Pokaż rozwiązanie";
            resButton.UseVisualStyleBackColor = true;
            resButton.Click += resButton_Click;
            // 
            // hintButton
            // 
            hintButton.Location = new Point(510, 917);
            hintButton.Margin = new Padding(3, 4, 3, 4);
            hintButton.Name = "hintButton";
            hintButton.Size = new Size(123, 93);
            hintButton.TabIndex = 5;
            hintButton.Text = "Pokaż podpowiedź";
            hintButton.UseVisualStyleBackColor = true;
            hintButton.Click += hintButton_Click;
            // 
            // SudokuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 1055);
            Controls.Add(hintButton);
            Controls.Add(resButton);
            Controls.Add(clearButton);
            Controls.Add(ngButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SudokuForm";
            Text = "Sudoku";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Button resButton;
        private Button hintButton;
    }
}