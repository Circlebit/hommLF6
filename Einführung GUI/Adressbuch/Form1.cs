using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adressbuch
{
    public partial class Form1 : Form
    {
        private List<Person> Persons { get; set; }

        public Form1()
        {
            InitializeComponent();
            Persons = new List<Person>();
        }

        private void button_AddEntry_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person();
            newPerson.FirstName = textBox_FirstName.Text;
            newPerson.LastName = textBox_LastName.Text;
            newPerson.Birthday = dateTimePicker_Birthday.Value.Date;
        }

        private void showPersons_Click(object sender, EventArgs e)
        {
            string personsTxt = "";
            foreach(Person p in Persons)
            {
                personsTxt += (p.FirstName + " " + p.LastName + " " + p.Birthday.ToString() + "\n");
            }
            MessageBox.Show(personsTxt);
        }
    }
}
