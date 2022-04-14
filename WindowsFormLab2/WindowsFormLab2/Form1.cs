using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using WindowsFormLab2.AbstractFactory;
using WindowsFormLab2.Strategy;

namespace WindowsFormLab2
{
    public partial class Form1 : Form
    {
        private List<Student> _tempList; // для добавлениея в файл
        private List<Student> _mainList; // для поиска и вывода в окно
        private Student _student;
        private string _massage = string.Empty;
        private Timer _timer;
        private SearchManager specSearchManager;

        public Form1()
        {
            InitializeComponent();
            _timer = new Timer() { Interval = 1000 };
            _timer.Tick += timer_Tick;
            _timer.Start();
            specSearchManager = new SearchManager(_mainList);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            toolDateStatusLabel.Text = DateTime.Now.ToLongDateString();
            toolTimeStatusLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tempList = new List<Student>();
            //_student = new Student();
            _mainList = new List<Student>();
        }

        #region InitObject

        private void ChooseSpeciality()
        {
            if (radioButtonPoit.Checked)
                _student.Speciality = Student.UniversitySpeciality.Poit;
            else if (radioButtonIsit.Checked)
                _student.Speciality = Student.UniversitySpeciality.Isit;
            else if (radioButtonMobileSystems.Checked)
                _student.Speciality = Student.UniversitySpeciality.MobileSystems;
            else if (radioButtonDesigners.Checked)
                _student.Speciality = Student.UniversitySpeciality.Designers;
        }

        private void ChooseCourse()
        {
            switch (comboBoxCourse.Text)
            {
                case "First":
                    _student.Course = 1;
                    break;
                case "Second":
                    _student.Course = 2;
                    break;
                case "Third":
                    _student.Course = 3;
                    break;
                case "Fourth":
                    _student.Course = 4;
                    break;
            }
        }

        private void ChooseGender()
        {
            if (radioButtonMan.Checked)
                _student.Gender = Student.HumanGender.Man;
            else if (radioButtonWomen.Checked)
                _student.Gender = Student.HumanGender.Woman;
        }

        private void AddLanguages()
        {
            var aCollection = checkedListBox.CheckedItems;
            foreach (var item in aCollection)
            {
                _student.AddLanguage(item.ToString());
            }
        }

        private void InitStudent()
        {
            _student.Name = textBoxName.Text;
            _student.SecondName = textBoxSecondName.Text;
            _student.Patronymic = textBoxPatronymic.Text;
            _student.BirthdaDateTime = dateTimePickerBirthdate.Value;
            _student.Age = (Int32)numericAge.Value;
            ChooseCourse();
            _student.NumOfExams = trackBarNumOfEx.Value;
            _student.AddressP.Street = textBoxStreet.Text;
            _student.AddressP.NumOfApartment = textBoxApartm.Text;
            _student.AddressP.NumOfHouse = textBoxHouse.Text;
            _student.AddressP.Index = textBoxIndex.Text;
            _student.AddressP.Town = comboBoxTowns.Text;
            ChooseSpeciality();
            ChooseGender();
            AddLanguages();
        }

        #endregion

        #region ValidateObject

        private bool ValidateObject()
        {
            errorProvider.Clear();
            var results = new List<ValidationResult>();
            var context = new ValidationContext(_student);
            if (!(Validator.TryValidateObject(_student, context, results, true) & ValidateAddress()))
            {
                foreach (var error in results)
                    _massage += $"{error.ErrorMessage}\n";
                errorProvider.SetError(labelProvider, _massage);
                return false;
            }

            return true;
        }

        private bool ValidateAddress()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(_student.AddressP);
            if (!Validator.TryValidateObject(_student.AddressP, context, results, true))
            {
                foreach (var error in results)
                    _massage += $"{error.ErrorMessage}\n";
                return false;
            }

            return true;
        }

        #endregion

        #region MainButtons

        private void ButtonAddClick(object sender, EventArgs e)
        {
            // фабрика
            _student = new SimpleStudent();
            if (radioButtonYes.Checked)
                //_student = new Student(new MilitaryStudentFactory());
                if (radioButtonNO.Checked)
                    //_student = new Student(new  new SimpleStudentFactory()); 

                    InitStudent();
            // _student.Age = 2;
            // _student.Course = 2;
            // _student.Gender = Student.HumanGender.Man;
            // _student.Name = "Dff";
            // _student.SecondName = "Dff";
            // _student.Patronymic = "Dff";
            // _student.Speciality = Student.UniversitySpeciality.Isit;
            // _student.NumOfExams = 2;
            // _student.AddressP.Index = "ds2233";
            // _student.AddressP.Street = "Dff";
            // _student.AddressP.Town = "Mosf";
            // _student.AddressP.NumOfApartment = "22";
            // _student.AddressP.NumOfHouse = "220";
            if (ValidateObject())
            {
                _tempList.Add(_student);
                //_student = new Student();
                toolCountLabel.Text = _mainList.Count.ToString();
                toolStripStatusLabel.Text = @"student has been added";
            }
        }

        private void ButtonSaveClick(object sender, EventArgs e)
        {
            XmlSerializeWrapper.Serialize(_tempList, "students.xml");
            _mainList.AddRange(_tempList.ToArray());
            _tempList.Clear();
        }

        private void ButtonShowClick(object sender, EventArgs e)
        {
            labelShow.Text = String.Empty;
            List<Student> list = new List<Student>();
            XmlSerializeWrapper.Deserialize(ref list, "students.xml");
            foreach (var aitem in list)
                labelShow.Text += aitem.ToString();
            toolStripStatusLabel.Text = @"Deserialize and show students";
        }

        #endregion

        #region QueryClickEvents

        private void ManToolStripMenuItemClick(object sender, EventArgs e)
        {
            string result = String.Empty;
            var list = _mainList.Where(n => n.Gender == Student.HumanGender.Man).ToList();
            foreach (var student in list)
                result += student.ToString();
            MessageBox.Show(
                $"gender query result is:\n{result}",
                @"Result",
                MessageBoxButtons.OK
            );
        }

        private void WomanToolStripMenuItemClick(object sender, EventArgs e)
        {
            string result = String.Empty;
            var list = _mainList.Where(n => n.Gender == Student.HumanGender.Woman).ToList();
            foreach (var student in list)
                result += student.ToString();
            MessageBox.Show(
                $"gender query result is:\n{result}",
                @"Result",
                MessageBoxButtons.OK
            );
        }

        private void PoitToolStripMenuItemClick(object sender, EventArgs e)
        {
            string result = String.Empty;
            var list = _mainList.Where(n => n.Speciality == Student.UniversitySpeciality.Poit).ToList();
            foreach (var student in list)
            {
                result += student.ToString();
            }

            MessageBox.Show(
                $"gender query result is:\n{result}",
                @"Result",
                MessageBoxButtons.OK
            );
        }

        private void IsitToolStripMenuItemClick(object sender, EventArgs e)
        {
            string result = String.Empty;
            var list = _mainList.Where(n => n.Speciality == Student.UniversitySpeciality.Isit).ToList();
            foreach (var student in list)
            {
                result += student.ToString();
            }

            MessageBox.Show(
                $"gender query result is:\n{result}",
                @"Result",
                MessageBoxButtons.OK
            );
        }

        private void MobileSystemsToolStripMenuItemClick(object sender, EventArgs e)
        {
            string result = String.Empty;

            specSearchManager.Searchable = new SpecialitySearch(Student.UniversitySpeciality.MobileSystems);
            var list = specSearchManager.Search();
            //var list = _mainList.Where(n => n.Speciality == Student.UniversitySpeciality.MobileSystems).ToList();
            foreach (var student in list)
            {
                result += student.ToString();
            }

            MessageBox.Show(
                $"gender query result is:\n{result}",
                @"Result",
                MessageBoxButtons.OK
            );
        }

        private void DesignersToolStripMenuItemClick(object sender, EventArgs e)
        {
            string result = String.Empty;
            var list = _mainList.Where(n => n.Speciality == Student.UniversitySpeciality.Designers).ToList();
            foreach (var student in list)
            {
                result += student.ToString();
            }

            MessageBox.Show(
                $"gender query result is:\n{result}",
                @"Result",
                MessageBoxButtons.OK
            );
        }

        #endregion

        #region Sorts

        private void YearToolStripMenuItemClick(object sender, EventArgs e)
        {
            labelShow.Text = String.Empty;
            if (_mainList.Count == 0)
                XmlSerializeWrapper.Deserialize(ref _mainList, "students.xml");
            _mainList = _mainList.OrderBy(n => n.Course).ToList();
            foreach (var item in _mainList)
                labelShow.Text += item.ToString();
            XmlSerializeWrapper.Serialize(_mainList, "SortYear.xml");
        }

        private void SpecialityToolStripMenuItemClick(object sender, EventArgs e)
        {
            labelShow.Text = String.Empty;
            if (_mainList.Count == 0)
                XmlSerializeWrapper.Deserialize(ref _mainList, "students.xml");
            _mainList = _mainList.OrderBy(n => n.Speciality).ToList();
            foreach (var aitem in _mainList)
                labelShow.Text += aitem.ToString();
            XmlSerializeWrapper.Serialize(_mainList, "SortSpeciality.xml");
        }

        private void SecondNameToolStripMenuItemClick(object sender, EventArgs e)
        {
            labelShow.Text = String.Empty;
            if (_mainList.Count == 0)
                XmlSerializeWrapper.Deserialize(ref _mainList, "students.xml");
            _mainList = _mainList.OrderBy(n => n.SecondName).ToList();
            foreach (var item in _mainList)
                labelShow.Text += item.ToString();
            XmlSerializeWrapper.Serialize(_mainList, "SortSecondName.xml");
        }

        #endregion

        private void StripMenuItem1Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm();
            form.Show();
        }

        private void BarNumOfExScroll(object sender, EventArgs e)
        {
            labelNumOfEx.Text = trackBarNumOfEx.Value.ToString();
        }

        private void AboutUsMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Vaisera Rodion Leonidovich (Version: 3.0)",
                @"About Us",
                MessageBoxButtons.OK
            );
        }
    }
}