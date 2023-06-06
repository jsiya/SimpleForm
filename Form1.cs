using System.Text.Json;

namespace Anket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Person InitializeValues()
        {
            Person person = new();
            person.Name = nameText.Text;
            person.Surname = surnameText.Text;
            person.Father = fatherText.Text;
            person.Country = countryText.Text;
            person.City = cityText.Text;
            person.Phone = phoneText.Text;
            person.Birthdate = dateTimePicker1.Value;
            if (radioButton1.Checked)
                person.Gender = false;
            else
                person.Gender = true;
            return person;
        }

        private void SaveAnket(object sender, MouseEventArgs e)
        {
            Person person = InitializeValues();
            string fileName = nameText.Text + ".json";
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            if (person.Name.Length > 0 && person.Surname.Length > 0 &&
                person.Father.Length > 0 && person.Country.Length > 0
                && person.City.Length > 0 && person.Phone.Length > 0)
            {
                File.WriteAllText(fileName, JsonSerializer.Serialize(person, options));
                nameText.Text = "";
                surnameText.Text = "";
                fatherText.Text = "";
                countryText.Text = "";
                cityText.Text = "";
                phoneText.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                radioButton2.Checked = true;
            }
            else
                MessageBox.Show("Please fill all fields!");
        }

        private void FindPerson(object sender, MouseEventArgs e)
        {
            string fileName = selectedName.Text + ".json";
            Person person = null;
            if (File.Exists(fileName))
            {
                using FileStream fs = new FileStream(fileName, FileMode.Open);
                if (fs.Length > 0)
                    person = JsonSerializer.Deserialize<Person>(fs);
                if(person != null)
                {
                    nameText.Text = person.Name;
                    surnameText.Text = person.Surname;
                    fatherText.Text = person.Father;
                    countryText.Text = person.Country;
                    cityText.Text = person.City;
                    phoneText.Text = person.Phone;
                    dateTimePicker1.Value = person.Birthdate;
                    if (person.Gender) radioButton2.Checked = true;
                    else radioButton1.Checked = true;
                }
            }
            else 
                MessageBox.Show("There is no such Person!");
        }
    }
}