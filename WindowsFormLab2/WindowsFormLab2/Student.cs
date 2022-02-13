using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace WindowsFormLab2
{
    [Serializable]
    [XmlType("student")]
    public class Student:IValidatableObject
    {
        public enum HumanGender
        {
            Man = 1,
            Woman,
        }
        public enum UniversitySpeciality
        {
            Poit = 1,
            Isit,
            MobileSystems,
            Designers,
        }

        public Student()
        {
            _addressP = new Address();
            _languages = new List<string>();
        }
        
        private static Regex _validTextBox = new Regex(@"^([A-Z]|[А-Я])([a-z]|[а-я])+");
        private  static Regex _validIndex = new Regex(@"\w\w\w\w\w\w");
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "secondName")]
        public string SecondName { get; set; }
        [XmlElement(ElementName = "patronymic")]
        public string Patronymic { get; set; }
        [XmlElement(ElementName = "age")]
        public int Age { get; set; }
        [XmlElement(ElementName = "numOfExams")]
        public int NumOfExams { get; set; }
        [XmlElement(ElementName = "gender")]
        public HumanGender Gender { get; set; }
        [XmlElement(ElementName = "speciality")]
        public UniversitySpeciality Speciality { get; set; }
        [XmlElement(ElementName = "birthday")]
        public DateTime BirthdaDateTime { get; set; }
        [XmlElement(ElementName = "course")]
        public string Course { get; set; }
        [XmlArray("languages")]
        [XmlArrayItem("language")]
        public List<string> _languages;
        [XmlElement(ElementName = "address")]
        public Address _addressP;
        public void AddLanguage(string lang)
        {
            if(!_languages.Contains(lang))
                _languages.Add(lang);
        }

        public void InitAddress(Address address)
        {
            _addressP.Index = address.Index;
            _addressP.Street = address.Street;
            _addressP.Town = address.Town;
            _addressP.NumOfApartment =address.NumOfApartment;
            _addressP.NumOfHouse = address.NumOfHouse;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            if(string.IsNullOrWhiteSpace(this.Name))
                errors.Add(new ValidationResult("name field is empty"));
            if(string.IsNullOrWhiteSpace(this.SecondName))
                errors.Add(new ValidationResult("second name field is empty"));
            if(string.IsNullOrWhiteSpace(this.Patronymic))
                errors.Add(new ValidationResult("patronymic field is empty"));
            if(string.IsNullOrWhiteSpace(this.Course))
                errors.Add(new ValidationResult("year of study field is empty"));
            if(!CheckTextBox(this.Name)) 
                errors.Add(new ValidationResult("invalid name field"));
            if(!CheckTextBox(this.SecondName)) 
                errors.Add(new ValidationResult("invalid second name field"));
            if(!CheckTextBox(this.Patronymic)) 
                errors.Add(new ValidationResult("invalid patronymic field"));
            if(this.Gender == 0)
                errors.Add(new ValidationResult("gender field is empty"));
            if(this.Speciality == 0)
                errors.Add(new ValidationResult("speciality field is empty"));
            if(string.IsNullOrWhiteSpace(this.Course))
                errors.Add(new ValidationResult("Course field is empty"));
            if(string.IsNullOrWhiteSpace(this._addressP.Street))
                errors.Add(new ValidationResult("Street field is empty"));
            if(string.IsNullOrWhiteSpace(this._addressP.Town))
                errors.Add(new ValidationResult("Town field is empty"));
            if(this._addressP.NumOfHouse == 0)
                errors.Add(new ValidationResult("House field is empty"));
            if(this._addressP.NumOfApartment == 0)
                errors.Add(new ValidationResult("Apartment field is empty"));
            if(this._addressP.Index == 0)
                errors.Add(new ValidationResult("Index field is empty"));
            if(!CheckTextBox(this._addressP.Street)) 
                errors.Add(new ValidationResult("invalid Street field"));
            if(!CheckTextBox(this._addressP.Town)) 
                errors.Add(new ValidationResult("invalid Town field"));
            return errors;
        }
        private bool CheckTextBox(string str)
        {
            if (str is null)
                return false;
            return _validTextBox.IsMatch(str) && str.Length < 20;
        }

        public override string ToString()=>$@"Student: ({Name},{SecondName},{Age},{Speciality})"+'\n';
    }
}