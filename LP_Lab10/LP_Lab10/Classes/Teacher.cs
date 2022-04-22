namespace LP_Lab10.Classes
{
    public class Teacher
    {
        private string _name;
        private string _pulpit;
        private string _shortName;
        private string _gender;

        public Teacher(string shortName, string name, string gender, string pulpit)
        {
            this._shortName = shortName;
            this._name = name;
            this._gender = gender;
            this._pulpit = pulpit;
        }
    }
}