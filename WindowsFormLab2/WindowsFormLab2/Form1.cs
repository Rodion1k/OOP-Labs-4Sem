using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormLab2
{
    public partial class Form1 : Form // выбор текста в говне хз почему ..........................................................................................
    {
        private List<Student> _tempList; // для добавлениея в файл
        private List<Student> _mainList; // для поиска и вывода в окно
        private Student _student;
        private Address _address;
        private string massage = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tempList = new List<Student>();
            _student = new Student();
            _address = new Address();
            _mainList = new List<Student>();
        }
        
        private void TextBoxNameTextChanged(object sender, EventArgs e)
        {
          //  _student.Name = textBoxName.Text;
        }
        private void TextBoxSecondNameTextChanged(object sender, EventArgs e)
        {
           // _student.SecondName = textBoxSecondName.Text;
        }
        private void TextBoxStreetTextChanged(object sender, EventArgs e)
        {
            _address.Street = textBoxStreet.Text;
        }
     
        private void TextBoxApartTextChanged(object sender, EventArgs e)
        {
            _address.NumOfApartment = Convert.ToInt32(textBoxApartm.Text);
        }
        private void TextBoxIndexTextChanged(object sender, EventArgs e)
        {
            _address.Index = Convert.ToInt32(textBoxIndex.Text);
        } 
        private void TextBoxPatronymicTextChanged(object sender, EventArgs e)
        {
            //_student.Patronymic = textBoxPatronymic.Text;
        }
        private void TextBoxHouseTextChanged(object sender, EventArgs e)
        {
            _address.NumOfHouse = Convert.ToInt32(textBoxHouse.Text);
        }
       

        private bool ValidateObject(Student student)
        {
            errorProvider.Clear();
            var results = new List<ValidationResult>();
            var context = new ValidationContext(student);
            if (!Validator.TryValidateObject(student, context, results, true))
            {
                foreach (var error in results)
                    massage += $"{error.ErrorMessage}\n";
                errorProvider.SetError(labelProvider, massage);
                return false;
            }
            return true;
        }
        private void NumericAgeValueChanged(object sender, EventArgs e)
        {
            _student.Age = (Int32)numericAge.Value;
        }

        private void DateTimePickerValueChanged(object sender, EventArgs e)
        {
           // _student.BirthdaDateTime = dateTimePickerBirthdate.Value;
        }

        private void RadioButtonGenderChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if(!button.Checked)
                return;
            switch (button.Text)
            {
                case "M":
                    _student.Gender = Student.HumanGender.Man;
                    break;
                case "W":
                    _student.Gender = Student.HumanGender.Woman;
                    break;
            }
        }
        private void RadioButtonSpecialityChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if(!button.Checked)
                return;
            string tag = (string)button.Tag;
            switch (tag)
            {
                case "P":
                    _student.Speciality = Student.UniversitySpeciality.Poit;
                    break;
                case "I":
                    _student.Speciality = Student.UniversitySpeciality.Isit;
                    break;
                case "M":
                    _student.Speciality = Student.UniversitySpeciality.MobileSystems;
                    break;
                case "D":
                    _student.Speciality = Student.UniversitySpeciality.Designers;
                    break;
                default:
                    break;
                    
            }
        }
        private void AddLanguages()
        {
            var aCollection = checkedListBox.CheckedItems;
            foreach (var aitem in aCollection)
            {
                _student.AddLanguage(aitem.ToString());
            }
        }

        private void InitStudent()
        {
            _student.Name = textBoxName.Text;
            _student.SecondName = textBoxSecondName.Text;
            _student.Patronymic = textBoxPatronymic.Text;
            _student.BirthdaDateTime = dateTimePickerBirthdate.Value;

        }

        private void BoxCourseSelectedIndexChanged(object sender, EventArgs e)
        {
             _student.Course = comboBoxCourse.Text;
        }
        private void BoxTownSelectedIndexChanged(object sender, EventArgs e)
        {
            _address.Town = comboBoxCourse.Text;
        }

        private void BarNumOfExScroll(object sender, EventArgs e)
        {
            _student.NumOfExams = trackBarNumOfEx.Value;
            labelNumOfEx.Text = trackBarNumOfEx.Value.ToString();
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            AddLanguages();
            _student.InitAddress(_address);
            if (ValidateObject(_student)) // ВАЛИДНОСТЬ АДРЕСА ПОЛЕЙ КОТОРЫЙ
            {
                _tempList.Add(_student);// ссылка  ебучая 
                _student = new Student();  
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
            {// String.Format?
                labelShow.Text += aitem.ToString();
            }
            // мб сделать создание новых файлов и возможность выбора между файлами которые показать (есил невлом) 
        }


        private void manToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string result = String.Empty; // проверить запрос
            var kek = _mainList.Where(n => n.Gender == Student.HumanGender.Man).ToList();
            foreach (var VARIABLE in kek)
            {
                result += VARIABLE.ToString();
            }
            MessageBox.Show(
                $"gender query result is:\n{result}",
                @"Result",
                MessageBoxButtons.OK
            );
            
        }
    }
}