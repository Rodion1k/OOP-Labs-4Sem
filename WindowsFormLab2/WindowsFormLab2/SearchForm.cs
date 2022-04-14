using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormLab2.Strategy;

namespace WindowsFormLab2
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void ButtonSearchClick(object sender, EventArgs e)
        {
            labelResult.Text = String.Empty;
            List<Student> list = new List<Student>();
            XmlSerializeWrapper.Deserialize(ref list,"students.xml");
            SearchManager searchManager = new SearchManager(list);
            if (!string.IsNullOrWhiteSpace(textBoxName.Text) && Student.CheckTextBox(textBoxName.Text))
            {
              // list.Where(n => n.Name == textBoxName.Text).Select(n => n.ToString()).ToList().ForEach(n => labelResult.Text += n);
              searchManager.Searchable = new NameSearch(textBoxName.Text);
              list = searchManager.Search();
              //list = list.Where(n => n.Name == textBoxName.Text).ToList();
            }
            if (!string.IsNullOrWhiteSpace(textBoxSecondName.Text) && Student.CheckTextBox(textBoxSecondName.Text))
            {
                list = list.Where(n => n.SecondName == textBoxSecondName.Text).ToList();
            }
            if (!string.IsNullOrWhiteSpace(textBoxSecondName.Text) && Student.CheckTextBox(textBoxSecondName.Text))
            {
                list = list.Where(n => n.SecondName == textBoxSecondName.Text).ToList();
            }
            if (!string.IsNullOrWhiteSpace(textBoxPatronymic.Text) && Student.CheckTextBox(textBoxPatronymic.Text))
            {
                list = list.Where(n => n.Patronymic == textBoxPatronymic.Text).ToList();
            }
            if (numericStudyYear.Value != 0)
            {
                list = list.Where(n => n.Course == numericStudyYear.Value).ToList();
            }
            if (!string.IsNullOrEmpty(comboBoxSpeciality.Text))
            {
                switch (comboBoxSpeciality.Text)
                {
                    case "Poit":
                        list = list.Where(n => n.Speciality == Student.UniversitySpeciality.Poit).ToList();
                        break;
                    case "Isit":
                        list = list.Where(n => n.Speciality == Student.UniversitySpeciality.Isit).ToList();
                        break;
                    case "Designers":
                        list = list.Where(n => n.Speciality == Student.UniversitySpeciality.Designers).ToList();
                        break;
                    case "Mobile Systems":
                        list = list.Where(n => n.Speciality == Student.UniversitySpeciality.MobileSystems).ToList();
                        break;
                }
            }

            if (list.Count == 0)
                labelResult.Text = @"Empty";
            list.Select(n => n.ToString()).ToList().ForEach(n => labelResult.Text += n);
        }

    }
}