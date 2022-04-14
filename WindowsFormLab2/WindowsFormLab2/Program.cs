using System;
using System.Windows.Forms;
using WindowsFormLab2.Adapter;
using WindowsFormLab2.Builder;
using WindowsFormLab2.Command;

namespace WindowsFormLab2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static ProgramSettings _settings;

        [STAThread]
        static void Main()
        {
            // синглтон
            _settings = ProgramSettings.GetInstance("kek");
            // билдер 
            StudentBuilder builder = new MilitaryBuilder();
            Creator creator = new Creator(builder);
            creator.Construct();
            Student student = builder.GetResult();
            // адаптер
            Univer univer = new Univer();
            univer.Educate(new SimpleStudent());
            IStudent adapter = new StudentAdapter(new MilitaryStudent());
            adapter.StartLearning();
            // Command 
            Director director = new Director();
            director.SetCommand(new DirectorCommand(student));
            director.EncourageStudent();
            // Prototype
            Address address = new Address();
            IAddress proto = address.Clone();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}