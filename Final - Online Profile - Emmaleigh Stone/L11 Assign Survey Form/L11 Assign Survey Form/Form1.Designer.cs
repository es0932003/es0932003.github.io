
namespace L11_Assign_Survey_Form
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
            this.labelQ1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textDirections = new System.Windows.Forms.TextBox();
            this.radioWinter = new System.Windows.Forms.RadioButton();
            this.radioSpring = new System.Windows.Forms.RadioButton();
            this.radioSummer = new System.Windows.Forms.RadioButton();
            this.radioFall = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFavoriteSeason = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelQ1
            // 
            this.labelQ1.AutoSize = true;
            this.labelQ1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ1.Location = new System.Drawing.Point(66, 196);
            this.labelQ1.Name = "labelQ1";
            this.labelQ1.Size = new System.Drawing.Size(465, 37);
            this.labelQ1.TabIndex = 1;
            this.labelQ1.Text = "What season do you enjoy most?";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Pink;
            this.buttonClear.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(880, 628);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(155, 74);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Pink;
            this.buttonSubmit.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(1063, 628);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(155, 74);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Cambria", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(531, 26);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(232, 43);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Survey Form";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textDirections
            // 
            this.textDirections.BackColor = System.Drawing.Color.Thistle;
            this.textDirections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDirections.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDirections.Location = new System.Drawing.Point(215, 100);
            this.textDirections.Multiline = true;
            this.textDirections.Name = "textDirections";
            this.textDirections.Size = new System.Drawing.Size(852, 55);
            this.textDirections.TabIndex = 14;
            this.textDirections.Text = "Please select the answer that you most agree with for each question, then submit " +
    "the survey. If you make a mistake, click on the clear button to try again.";
            this.textDirections.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioWinter
            // 
            this.radioWinter.AutoSize = true;
            this.radioWinter.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioWinter.Location = new System.Drawing.Point(73, 260);
            this.radioWinter.Name = "radioWinter";
            this.radioWinter.Size = new System.Drawing.Size(127, 36);
            this.radioWinter.TabIndex = 15;
            this.radioWinter.TabStop = true;
            this.radioWinter.Text = "Winter";
            this.radioWinter.UseVisualStyleBackColor = true;
            this.radioWinter.CheckedChanged += new System.EventHandler(this.radioWinter_CheckedChanged);
            // 
            // radioSpring
            // 
            this.radioSpring.AutoSize = true;
            this.radioSpring.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSpring.Location = new System.Drawing.Point(73, 312);
            this.radioSpring.Name = "radioSpring";
            this.radioSpring.Size = new System.Drawing.Size(121, 36);
            this.radioSpring.TabIndex = 16;
            this.radioSpring.TabStop = true;
            this.radioSpring.Text = "Spring";
            this.radioSpring.UseVisualStyleBackColor = true;
            this.radioSpring.CheckedChanged += new System.EventHandler(this.radioSpring_CheckedChanged);
            // 
            // radioSummer
            // 
            this.radioSummer.AutoSize = true;
            this.radioSummer.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSummer.Location = new System.Drawing.Point(73, 365);
            this.radioSummer.Name = "radioSummer";
            this.radioSummer.Size = new System.Drawing.Size(142, 36);
            this.radioSummer.TabIndex = 17;
            this.radioSummer.TabStop = true;
            this.radioSummer.Text = "Summer";
            this.radioSummer.UseVisualStyleBackColor = true;
            this.radioSummer.CheckedChanged += new System.EventHandler(this.radioSummer_CheckedChanged);
            // 
            // radioFall
            // 
            this.radioFall.AutoSize = true;
            this.radioFall.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFall.Location = new System.Drawing.Point(73, 421);
            this.radioFall.Name = "radioFall";
            this.radioFall.Size = new System.Drawing.Size(86, 36);
            this.radioFall.TabIndex = 18;
            this.radioFall.TabStop = true;
            this.radioFall.Text = "Fall";
            this.radioFall.UseVisualStyleBackColor = true;
            this.radioFall.CheckedChanged += new System.EventHandler(this.radioFall_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SlateBlue;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(979, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 19;
            // 
            // textBoxFavoriteSeason
            // 
            this.textBoxFavoriteSeason.BackColor = System.Drawing.Color.PowderBlue;
            this.textBoxFavoriteSeason.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFavoriteSeason.Location = new System.Drawing.Point(722, 303);
            this.textBoxFavoriteSeason.Multiline = true;
            this.textBoxFavoriteSeason.Name = "textBoxFavoriteSeason";
            this.textBoxFavoriteSeason.Size = new System.Drawing.Size(313, 98);
            this.textBoxFavoriteSeason.TabIndex = 20;
            this.textBoxFavoriteSeason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1330, 744);
            this.Controls.Add(this.textBoxFavoriteSeason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioFall);
            this.Controls.Add(this.radioSummer);
            this.Controls.Add(this.radioSpring);
            this.Controls.Add(this.radioWinter);
            this.Controls.Add(this.textDirections);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelQ1);
            this.Name = "Form1";
            this.Text = "Survey Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelQ1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textDirections;
        private System.Windows.Forms.RadioButton radioWinter;
        private System.Windows.Forms.RadioButton radioSpring;
        private System.Windows.Forms.RadioButton radioSummer;
        private System.Windows.Forms.RadioButton radioFall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFavoriteSeason;
    }
}

