using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using WindowsFormLab2.AbstractFactory;

namespace WindowsFormLab2
{
    public interface IStudent
    {
        void StartLearning();
     
    }
    [XmlInclude(typeof(SimpleStudent))]
    [XmlInclude(typeof(MilitaryStudent))]
    [Serializable]
    [XmlType("student")]
    public abstract class Student : IValidatableObject
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
            AddressP = new Address();
            Languages = new List<string>();
        }

        public Student(StudentFactory factory)
        {
            _weapon = factory.CreateWeapon();
            AddressP = new Address();
            Languages = new List<string>();
        }

        private Weapon _weapon;
       
        private static Regex _validTextBox = new Regex(@"^([A-Z]|[А-Я])([a-z]|[а-я])+$");

        [XmlElement(ElementName = "name")] public string Name { get; set; }

        [XmlElement(ElementName = "secondName")]
        public string SecondName { get; set; }

        [XmlElement(ElementName = "patronymic")]
        public string Patronymic { get; set; }

        [XmlElement(ElementName = "age")] public int Age { get; set; }

        [XmlElement(ElementName = "numOfExams")]
        public int NumOfExams { get; set; }

        [XmlElement(ElementName = "gender")] public HumanGender Gender { get; set; }

        [XmlElement(ElementName = "speciality")]
        public UniversitySpeciality Speciality { get; set; }

        [XmlElement(ElementName = "birthday")] public DateTime BirthdaDateTime { get; set; }
        [XmlElement(ElementName = "course")] public int Course { get; set; }

        [XmlArray("languages")] [XmlArrayItem("language")]
        public List<string> Languages;

        [XmlElement(ElementName = "address")] public Address AddressP;

        public void AddLanguage(string lang)
        {
            if (!Languages.Contains(lang))
                Languages.Add(lang);
        }

        // public void InitAddress(Address address)
        // {
        //     _addressP.Index = address.Index;
        //     _addressP.Street = address.Street;
        //     _addressP.Town = address.Town;
        //     _addressP.NumOfApartment =address.NumOfApartment;
        //     _addressP.NumOfHouse = address.NumOfHouse;
        // }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            if (string.IsNullOrWhiteSpace(this.Name))
                errors.Add(new ValidationResult("name field is empty"));
            if (string.IsNullOrWhiteSpace(this.SecondName))
                errors.Add(new ValidationResult("second name field is empty"));
            if (string.IsNullOrWhiteSpace(this.Patronymic))
                errors.Add(new ValidationResult("patronymic field is empty"));
            if (!CheckTextBox(this.Name))
                errors.Add(new ValidationResult("invalid name field"));
            if (!CheckTextBox(this.SecondName))
                errors.Add(new ValidationResult("invalid second name field"));
            if (!CheckTextBox(this.Patronymic))
                errors.Add(new ValidationResult("invalid patronymic field"));
            if (this.Gender == 0)
                errors.Add(new ValidationResult("gender field is empty"));
            if (this.Speciality == 0)
                errors.Add(new ValidationResult("speciality field is empty"));
            if (this.Course == 0)
                errors.Add(new ValidationResult("Course field is empty"));
            return errors;
        }

        public static bool CheckTextBox(string str)
        {
            if (str is null)
                return false;
            return _validTextBox.IsMatch(str) && str.Length < 20;
        }

        public override string ToString() => $@"Student: ({Name},{SecondName},{Age},{Speciality})" + '\n';
        public void StartSmiling() => Console.WriteLine(@"студент начал улыбатьcя");

    }
    
    [Serializable]
    public class SimpleStudent:Student,IStudent
    {
        public void StartLearning()
        {
            Console.WriteLine(@"student start reading");
        }

       
    }
    
    [Serializable]
    public class MilitaryStudent:Student
    {
        public void StartShooting()
        {
            Console.WriteLine(@"student start shooting");
        }
        
    }

    public abstract class Weapon
    {
        
    }
    public class Gun:Weapon 
    {
        
    }
    public class Arbalet:Weapon
    {
                
    }

}