using System.ComponentModel;

namespace WindowsFormLab2
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericStudyYear = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSpeciality = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericStudyYear)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(158, 61);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(160, 26);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecondName.Location = new System.Drawing.Point(158, 100);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(160, 26);
            this.textBoxSecondName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name\r\n";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Second Name";
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(324, 63);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(294, 309);
            this.labelResult.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(475, 398);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(143, 51);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearchClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Patronymic";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatronymic.Location = new System.Drawing.Point(158, 141);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(160, 26);
            this.textBoxPatronymic.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 31);
            this.label6.TabIndex = 47;
            this.label6.Text = "Year of Study:";
            // 
            // numericStudyYear
            // 
            this.numericStudyYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericStudyYear.Location = new System.Drawing.Point(158, 180);
            this.numericStudyYear.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            this.numericStudyYear.Name = "numericStudyYear";
            this.numericStudyYear.Size = new System.Drawing.Size(100, 26);
            this.numericStudyYear.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 39);
            this.label9.TabIndex = 49;
            this.label9.Text = "Speciality:";
            // 
            // comboBoxSpeciality
            // 
            this.comboBoxSpeciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSpeciality.FormattingEnabled = true;
            this.comboBoxSpeciality.Items.AddRange(new object[] { "Poit", "Isit", "Mobile Systems", "Designers" });
            this.comboBoxSpeciality.Location = new System.Drawing.Point(158, 219);
            this.comboBoxSpeciality.Name = "comboBoxSpeciality";
            this.comboBoxSpeciality.Size = new System.Drawing.Size(121, 25);
            this.comboBoxSpeciality.TabIndex = 48;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxSpeciality);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericStudyYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxName);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericStudyYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxSpeciality;

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericStudyYear;


        private System.Windows.Forms.TextBox textBoxPatronymic;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelResult;

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        #endregion
    }
}