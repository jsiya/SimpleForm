namespace Anket
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saveBtn = new Button();
            anketPanel = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            gender = new Label();
            birthdate = new Label();
            dateTimePicker1 = new DateTimePicker();
            phone = new Label();
            city = new Label();
            country = new Label();
            fatherName = new Label();
            surname = new Label();
            name = new Label();
            phoneText = new TextBox();
            cityText = new TextBox();
            countryText = new TextBox();
            fatherText = new TextBox();
            surnameText = new TextBox();
            nameText = new TextBox();
            selectedName = new TextBox();
            loadBtn = new Button();
            anketPanel.SuspendLayout();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.DarkKhaki;
            saveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.ForeColor = Color.FromArgb(64, 64, 0);
            saveBtn.Location = new Point(12, 547);
            saveBtn.Name = "saveBtn";
            saveBtn.Padding = new Padding(10);
            saveBtn.Size = new Size(424, 55);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.MouseClick += SaveAnket;
            // 
            // anketPanel
            // 
            anketPanel.BackColor = Color.FloralWhite;
            anketPanel.Controls.Add(radioButton2);
            anketPanel.Controls.Add(radioButton1);
            anketPanel.Controls.Add(gender);
            anketPanel.Controls.Add(birthdate);
            anketPanel.Controls.Add(dateTimePicker1);
            anketPanel.Controls.Add(phone);
            anketPanel.Controls.Add(city);
            anketPanel.Controls.Add(country);
            anketPanel.Controls.Add(fatherName);
            anketPanel.Controls.Add(surname);
            anketPanel.Controls.Add(name);
            anketPanel.Controls.Add(phoneText);
            anketPanel.Controls.Add(cityText);
            anketPanel.Controls.Add(countryText);
            anketPanel.Controls.Add(fatherText);
            anketPanel.Controls.Add(surnameText);
            anketPanel.Controls.Add(nameText);
            anketPanel.Location = new Point(12, 63);
            anketPanel.Name = "anketPanel";
            anketPanel.Padding = new Padding(30);
            anketPanel.Size = new Size(424, 467);
            anketPanel.TabIndex = 1;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.FlatAppearance.CheckedBackColor = Color.White;
            radioButton2.ForeColor = SystemColors.ControlText;
            radioButton2.Location = new Point(164, 388);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 29);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(316, 388);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 29);
            radioButton1.TabIndex = 15;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Location = new Point(18, 392);
            gender.Name = "gender";
            gender.Size = new Size(69, 25);
            gender.TabIndex = 14;
            gender.Text = "Gender";
            // 
            // birthdate
            // 
            birthdate.AutoSize = true;
            birthdate.Location = new Point(18, 328);
            birthdate.Name = "birthdate";
            birthdate.Size = new Size(90, 25);
            birthdate.TabIndex = 13;
            birthdate.Text = "Birth Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(164, 322);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(227, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Location = new Point(18, 259);
            phone.Name = "phone";
            phone.Size = new Size(62, 25);
            phone.TabIndex = 11;
            phone.Text = "Phone";
            // 
            // city
            // 
            city.AutoSize = true;
            city.Location = new Point(18, 215);
            city.Name = "city";
            city.Size = new Size(42, 25);
            city.TabIndex = 10;
            city.Text = "City";
            // 
            // country
            // 
            country.AutoSize = true;
            country.Location = new Point(18, 172);
            country.Name = "country";
            country.Size = new Size(75, 25);
            country.TabIndex = 9;
            country.Text = "Country";
            // 
            // fatherName
            // 
            fatherName.AutoSize = true;
            fatherName.Location = new Point(18, 110);
            fatherName.Name = "fatherName";
            fatherName.Size = new Size(121, 25);
            fatherName.TabIndex = 8;
            fatherName.Text = "Father's name";
            // 
            // surname
            // 
            surname.AutoSize = true;
            surname.Location = new Point(18, 71);
            surname.Name = "surname";
            surname.Size = new Size(82, 25);
            surname.TabIndex = 7;
            surname.Text = "Surname";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(18, 30);
            name.Name = "name";
            name.Size = new Size(59, 25);
            name.TabIndex = 6;
            name.Text = "Name";
            // 
            // phoneText
            // 
            phoneText.Location = new Point(164, 253);
            phoneText.Name = "phoneText";
            phoneText.Size = new Size(227, 31);
            phoneText.TabIndex = 5;
            // 
            // cityText
            // 
            cityText.Location = new Point(164, 209);
            cityText.Name = "cityText";
            cityText.Size = new Size(227, 31);
            cityText.TabIndex = 4;
            // 
            // countryText
            // 
            countryText.Location = new Point(164, 166);
            countryText.Name = "countryText";
            countryText.Size = new Size(227, 31);
            countryText.TabIndex = 3;
            // 
            // fatherText
            // 
            fatherText.Location = new Point(164, 104);
            fatherText.Name = "fatherText";
            fatherText.Size = new Size(227, 31);
            fatherText.TabIndex = 2;
            // 
            // surnameText
            // 
            surnameText.Location = new Point(164, 65);
            surnameText.Name = "surnameText";
            surnameText.Size = new Size(227, 31);
            surnameText.TabIndex = 1;
            // 
            // nameText
            // 
            nameText.Location = new Point(164, 24);
            nameText.Name = "nameText";
            nameText.Size = new Size(227, 31);
            nameText.TabIndex = 0;
            // 
            // selectedName
            // 
            selectedName.Location = new Point(30, 12);
            selectedName.Name = "selectedName";
            selectedName.PlaceholderText = "Old Anket";
            selectedName.Size = new Size(249, 31);
            selectedName.TabIndex = 2;
            // 
            // loadBtn
            // 
            loadBtn.BackColor = Color.FloralWhite;
            loadBtn.ForeColor = Color.DarkOliveGreen;
            loadBtn.Location = new Point(304, 12);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(112, 34);
            loadBtn.TabIndex = 3;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = false;
            loadBtn.MouseClick += FindPerson;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(448, 614);
            Controls.Add(loadBtn);
            Controls.Add(selectedName);
            Controls.Add(anketPanel);
            Controls.Add(saveBtn);
            MaximizeBox = false;
            MaximumSize = new Size(470, 670);
            MinimumSize = new Size(470, 670);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anket";
            anketPanel.ResumeLayout(false);
            anketPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveBtn;
        private Panel anketPanel;
        private Label fatherName;
        private Label surname;
        private Label name;
        private TextBox phoneText;
        private TextBox cityText;
        private TextBox countryText;
        private TextBox fatherText;
        private TextBox surnameText;
        private TextBox nameText;
        private Label phone;
        private Label city;
        private Label country;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label gender;
        private Label birthdate;
        private DateTimePicker dateTimePicker1;
        private TextBox selectedName;
        private Button loadBtn;
    }
}