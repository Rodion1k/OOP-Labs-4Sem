using System;

namespace WindowsFormLab2
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
            this.components = new System.ComponentModel.Container();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonIsit = new System.Windows.Forms.RadioButton();
            this.radioButtonPoit = new System.Windows.Forms.RadioButton();
            this.radioButtonMobileSystems = new System.Windows.Forms.RadioButton();
            this.radioButtonDesigners = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBarNumOfEx = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButtonWomen = new System.Windows.Forms.RadioButton();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelNumOfEx = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxApartm = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.comboBoxTowns = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelProvider = new System.Windows.Forms.Label();
            this.labelShow = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.poitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mobileSystemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.womanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumOfEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericAge
            // 
            this.numericAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericAge.Location = new System.Drawing.Point(208, 220);
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(100, 30);
            this.numericAge.TabIndex = 0;
            this.numericAge.ValueChanged += new System.EventHandler(this.NumericAgeValueChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(208, 89);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(188, 30);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.TextBoxNameTextChanged);
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSecondName.Location = new System.Drawing.Point(208, 133);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(188, 30);
            this.textBoxSecondName.TabIndex = 2;
            this.textBoxSecondName.TextChanged += new System.EventHandler(this.TextBoxSecondNameTextChanged);
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatronymic.Location = new System.Drawing.Point(208, 179);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(188, 30);
            this.textBoxPatronymic.TabIndex = 3;
            this.textBoxPatronymic.TextChanged += new System.EventHandler(this.TextBoxPatronymicTextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Second Name:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Patronymic:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Age:";
            // 
            // radioButtonIsit
            // 
            this.radioButtonIsit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonIsit.Location = new System.Drawing.Point(3, 51);
            this.radioButtonIsit.Name = "radioButtonIsit";
            this.radioButtonIsit.Size = new System.Drawing.Size(104, 24);
            this.radioButtonIsit.TabIndex = 9;
            this.radioButtonIsit.TabStop = true;
            this.radioButtonIsit.Tag = "I";
            this.radioButtonIsit.Text = "ISIT";
            this.radioButtonIsit.UseVisualStyleBackColor = true;
            this.radioButtonIsit.CheckedChanged += new System.EventHandler(this.RadioButtonSpecialityChanged);
            // 
            // radioButtonPoit
            // 
            this.radioButtonPoit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPoit.Location = new System.Drawing.Point(3, 21);
            this.radioButtonPoit.Name = "radioButtonPoit";
            this.radioButtonPoit.Size = new System.Drawing.Size(104, 24);
            this.radioButtonPoit.TabIndex = 10;
            this.radioButtonPoit.TabStop = true;
            this.radioButtonPoit.Tag = "P";
            this.radioButtonPoit.Text = "POIT";
            this.radioButtonPoit.UseVisualStyleBackColor = true;
            this.radioButtonPoit.CheckedChanged += new System.EventHandler(this.RadioButtonSpecialityChanged);
            // 
            // radioButtonMobileSystems
            // 
            this.radioButtonMobileSystems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMobileSystems.Location = new System.Drawing.Point(3, 81);
            this.radioButtonMobileSystems.Name = "radioButtonMobileSystems";
            this.radioButtonMobileSystems.Size = new System.Drawing.Size(162, 24);
            this.radioButtonMobileSystems.TabIndex = 11;
            this.radioButtonMobileSystems.TabStop = true;
            this.radioButtonMobileSystems.Tag = "M";
            this.radioButtonMobileSystems.Text = "Mobile Systems";
            this.radioButtonMobileSystems.UseVisualStyleBackColor = true;
            this.radioButtonMobileSystems.CheckedChanged += new System.EventHandler(this.RadioButtonSpecialityChanged);
            // 
            // radioButtonDesigners
            // 
            this.radioButtonDesigners.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDesigners.Location = new System.Drawing.Point(3, 111);
            this.radioButtonDesigners.Name = "radioButtonDesigners";
            this.radioButtonDesigners.Size = new System.Drawing.Size(134, 24);
            this.radioButtonDesigners.TabIndex = 12;
            this.radioButtonDesigners.TabStop = true;
            this.radioButtonDesigners.Tag = "D";
            this.radioButtonDesigners.Text = "Designers";
            this.radioButtonDesigners.UseVisualStyleBackColor = true;
            this.radioButtonDesigners.CheckedChanged += new System.EventHandler(this.RadioButtonSpecialityChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "Speciality:";
            // 
            // dateTimePickerBirthdate
            // 
            this.dateTimePickerBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerBirthdate.Location = new System.Drawing.Point(164, 493);
            this.dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            this.dateTimePickerBirthdate.Size = new System.Drawing.Size(232, 30);
            this.dateTimePickerBirthdate.TabIndex = 14;
            this.dateTimePickerBirthdate.ValueChanged += new System.EventHandler(this.DateTimePickerValueChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(25, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 39);
            this.label7.TabIndex = 15;
            this.label7.Text = "Birthdate:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(25, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(386, 35);
            this.label8.TabIndex = 16;
            this.label8.Text = "Favorite programming languages:";
            // 
            // checkedListBox
            // 
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] { "C#", "C++", "Java", "JavaScript", "Assembler" });
            this.checkedListBox.Location = new System.Drawing.Point(45, 581);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(273, 114);
            this.checkedListBox.TabIndex = 17;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Items.AddRange(new object[] { "First", "Second", "Third", "Fourth" });
            this.comboBoxCourse.Location = new System.Drawing.Point(227, 716);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCourse.TabIndex = 18;
            this.comboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.BoxCourseSelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(27, 716);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 39);
            this.label9.TabIndex = 19;
            this.label9.Text = "Year of study:";
            // 
            // trackBarNumOfEx
            // 
            this.trackBarNumOfEx.Location = new System.Drawing.Point(227, 757);
            this.trackBarNumOfEx.Name = "trackBarNumOfEx";
            this.trackBarNumOfEx.Size = new System.Drawing.Size(217, 56);
            this.trackBarNumOfEx.TabIndex = 20;
            this.trackBarNumOfEx.Scroll += new System.EventHandler(this.BarNumOfExScroll);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(27, 766);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 39);
            this.label10.TabIndex = 21;
            this.label10.Text = "Number of exams:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(25, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Gender:";
            // 
            // radioButtonWomen
            // 
            this.radioButtonWomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWomen.Location = new System.Drawing.Point(87, 10);
            this.radioButtonWomen.Name = "radioButtonWomen";
            this.radioButtonWomen.Size = new System.Drawing.Size(86, 24);
            this.radioButtonWomen.TabIndex = 23;
            this.radioButtonWomen.TabStop = true;
            this.radioButtonWomen.Text = "W";
            this.radioButtonWomen.UseVisualStyleBackColor = true;
            this.radioButtonWomen.CheckedChanged += new System.EventHandler(this.RadioButtonGenderChanged);
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMan.Location = new System.Drawing.Point(6, 11);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(78, 24);
            this.radioButtonMan.TabIndex = 24;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "M";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            this.radioButtonMan.CheckedChanged += new System.EventHandler(this.RadioButtonGenderChanged);
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.BackColor = System.Drawing.Color.White;
            this.buttonAddToList.Location = new System.Drawing.Point(540, 776);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(100, 55);
            this.buttonAddToList.TabIndex = 25;
            this.buttonAddToList.Text = "Add";
            this.buttonAddToList.UseVisualStyleBackColor = false;
            this.buttonAddToList.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // labelNumOfEx
            // 
            this.labelNumOfEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumOfEx.Location = new System.Drawing.Point(240, 789);
            this.labelNumOfEx.Name = "labelNumOfEx";
            this.labelNumOfEx.Size = new System.Drawing.Size(204, 36);
            this.labelNumOfEx.TabIndex = 27;
            this.labelNumOfEx.Text = "0";
            this.labelNumOfEx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(595, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 30);
            this.label12.TabIndex = 29;
            this.label12.Text = "Address";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(501, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 23);
            this.label14.TabIndex = 34;
            this.label14.Text = "Street:";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(501, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 23);
            this.label15.TabIndex = 33;
            this.label15.Text = "Town:";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStreet.Location = new System.Drawing.Point(618, 133);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(188, 30);
            this.textBoxStreet.TabIndex = 31;
            this.textBoxStreet.TextChanged += new System.EventHandler(this.TextBoxStreetTextChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(501, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 23);
            this.label13.TabIndex = 36;
            this.label13.Text = "House:";
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHouse.Location = new System.Drawing.Point(618, 179);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(188, 30);
            this.textBoxHouse.TabIndex = 35;
            this.textBoxHouse.TextChanged += new System.EventHandler(this.TextBoxHouseTextChanged);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(501, 227);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 23);
            this.label16.TabIndex = 38;
            this.label16.Text = "Apartment:";
            // 
            // textBoxApartm
            // 
            this.textBoxApartm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxApartm.Location = new System.Drawing.Point(618, 224);
            this.textBoxApartm.Name = "textBoxApartm";
            this.textBoxApartm.Size = new System.Drawing.Size(188, 30);
            this.textBoxApartm.TabIndex = 37;
            this.textBoxApartm.TextChanged += new System.EventHandler(this.TextBoxApartTextChanged);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(501, 270);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 23);
            this.label17.TabIndex = 40;
            this.label17.Text = "Index:";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIndex.Location = new System.Drawing.Point(618, 267);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(188, 30);
            this.textBoxIndex.TabIndex = 39;
            this.textBoxIndex.TextChanged += new System.EventHandler(this.TextBoxIndexTextChanged);
            // 
            // comboBoxTowns
            // 
            this.comboBoxTowns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTowns.FormattingEnabled = true;
            this.comboBoxTowns.Items.AddRange(new object[] { "Minsk", "Brest", "Bobruisk" });
            this.comboBoxTowns.Location = new System.Drawing.Point(618, 89);
            this.comboBoxTowns.Name = "comboBoxTowns";
            this.comboBoxTowns.Size = new System.Drawing.Size(188, 28);
            this.comboBoxTowns.TabIndex = 41;
            this.comboBoxTowns.SelectedIndexChanged += new System.EventHandler(this.BoxTownSelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMan);
            this.groupBox1.Controls.Add(this.radioButtonWomen);
            this.groupBox1.Location = new System.Drawing.Point(208, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 41);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonPoit);
            this.groupBox2.Controls.Add(this.radioButtonIsit);
            this.groupBox2.Controls.Add(this.radioButtonMobileSystems);
            this.groupBox2.Controls.Add(this.radioButtonDesigners);
            this.groupBox2.Location = new System.Drawing.Point(90, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 141);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(661, 776);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 55);
            this.buttonSave.TabIndex = 44;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(777, 776);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 55);
            this.button2.TabIndex = 45;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ButtonShowClick);
            // 
            // labelProvider
            // 
            this.labelProvider.Location = new System.Drawing.Point(777, 723);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(100, 35);
            this.labelProvider.TabIndex = 28;
            // 
            // labelShow
            // 
            this.labelShow.Location = new System.Drawing.Point(501, 395);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(358, 234);
            this.labelShow.TabIndex = 46;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.searchToolStripMenuItem, this.sortingByToolStripMenuItem, this.saveToolStripMenuItem, this.aboutUsMenuItem });
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1062, 28);
            this.MainMenu.TabIndex = 47;
            this.MainMenu.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.specialityToolStripMenuItem1, this.genderToolStripMenuItem });
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // specialityToolStripMenuItem1
            // 
            this.specialityToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.poitToolStripMenuItem, this.isitToolStripMenuItem, this.mobileSystemsToolStripMenuItem, this.designersToolStripMenuItem });
            this.specialityToolStripMenuItem1.Name = "specialityToolStripMenuItem1";
            this.specialityToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.specialityToolStripMenuItem1.Text = "Speciality";
            // 
            // poitToolStripMenuItem
            // 
            this.poitToolStripMenuItem.Name = "poitToolStripMenuItem";
            this.poitToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.poitToolStripMenuItem.Text = "Poit";
            // 
            // isitToolStripMenuItem
            // 
            this.isitToolStripMenuItem.Name = "isitToolStripMenuItem";
            this.isitToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.isitToolStripMenuItem.Text = "Isit";
            // 
            // mobileSystemsToolStripMenuItem
            // 
            this.mobileSystemsToolStripMenuItem.Name = "mobileSystemsToolStripMenuItem";
            this.mobileSystemsToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.mobileSystemsToolStripMenuItem.Text = "Mobile Systems";
            // 
            // designersToolStripMenuItem
            // 
            this.designersToolStripMenuItem.Name = "designersToolStripMenuItem";
            this.designersToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.designersToolStripMenuItem.Text = "Designers";
            // 
            // genderToolStripMenuItem
            // 
            this.genderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.manToolStripMenuItem, this.womanToolStripMenuItem });
            this.genderToolStripMenuItem.Name = "genderToolStripMenuItem";
            this.genderToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.genderToolStripMenuItem.Text = "Gender";
            // 
            // manToolStripMenuItem
            // 
            this.manToolStripMenuItem.Name = "manToolStripMenuItem";
            this.manToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.manToolStripMenuItem.Text = "Man";
            this.manToolStripMenuItem.Click += new System.EventHandler(this.manToolStripMenuItem_Click);
            // 
            // womanToolStripMenuItem
            // 
            this.womanToolStripMenuItem.Name = "womanToolStripMenuItem";
            this.womanToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.womanToolStripMenuItem.Text = "Woman";
            // 
            // sortingByToolStripMenuItem
            // 
            this.sortingByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.yearToolStripMenuItem, this.secondNameToolStripMenuItem, this.specialityToolStripMenuItem });
            this.sortingByToolStripMenuItem.Name = "sortingByToolStripMenuItem";
            this.sortingByToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.sortingByToolStripMenuItem.Text = "Sorting by";
            // 
            // yearToolStripMenuItem
            // 
            this.yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            this.yearToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.yearToolStripMenuItem.Text = "Year";
            // 
            // secondNameToolStripMenuItem
            // 
            this.secondNameToolStripMenuItem.Name = "secondNameToolStripMenuItem";
            this.secondNameToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.secondNameToolStripMenuItem.Text = "Second Name";
            // 
            // specialityToolStripMenuItem
            // 
            this.specialityToolStripMenuItem.Name = "specialityToolStripMenuItem";
            this.specialityToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.specialityToolStripMenuItem.Text = "Speciality";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // aboutUsMenuItem
            // 
            this.aboutUsMenuItem.Name = "aboutUsMenuItem";
            this.aboutUsMenuItem.Size = new System.Drawing.Size(80, 24);
            this.aboutUsMenuItem.Text = "About us";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1062, 843);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxTowns);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxApartm);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxHouse);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.labelNumOfEx);
            this.Controls.Add(this.buttonAddToList);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trackBarNumOfEx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerBirthdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.numericAge);
            this.Controls.Add(this.MainMenu);
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumOfEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem aboutUsMenuItem;

        private System.Windows.Forms.ToolStripMenuItem genderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem womanToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem specialityToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem poitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mobileSystemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designersToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem specialityToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem secondNameToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem yearToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem sortingByToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;

        private System.Windows.Forms.MenuStrip MainMenu;

        private System.Windows.Forms.Label labelShow;

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAddToList;

        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxTowns;
        private System.Windows.Forms.TextBox textBoxIndex;

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxApartm;

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxStreet;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label labelProvider;
        private System.Windows.Forms.Label labelNumOfEx;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.RadioButton radioButtonWomen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBarNumOfEx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonDesigners;
        private System.Windows.Forms.RadioButton radioButtonPoit;
        private System.Windows.Forms.RadioButton radioButtonMobileSystems;
        private System.Windows.Forms.RadioButton radioButtonIsit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericAge;
        #endregion
    }
}