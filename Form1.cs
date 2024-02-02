/*
  Name: Selepe Tumelo
  Surname: Thinane
  Student: 220050062

 */

using System;
using System.Windows.Forms;

namespace Big_Data
{
    public partial class Form : System.Windows.Forms.Form
    {
        private DataManager dataManager;
        private Data[] filteredData;
        private int currentIndex;

        public Form()
        {
            InitializeComponent();
            dataManager = new DataManager();
            filteredData = new Data[0];
            currentIndex = -1;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            try
            {
                dataManager.ReadFromFile();
                filteredData = dataManager.DetermineDomain(".com");
                if (filteredData.Length > 0)
                {
                    currentIndex = 0;
                    GetRecord(filteredData[currentIndex]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data from file: " + ex.Message);
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (filteredData.Length > 0)
            {
                currentIndex = 0;
                GetRecord(filteredData[currentIndex]);
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (filteredData.Length > 0 && currentIndex < filteredData.Length - 1)
            {
                currentIndex++;
                GetRecord(filteredData[currentIndex]);
            }
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (filteredData.Length > 0 && currentIndex > 0)
            {
                currentIndex--;
                GetRecord(filteredData[currentIndex]);
            }
        }

        private void combtn_CheckedChanged_1(object sender, EventArgs e)
        {
            filteredData = dataManager.DetermineDomain(".com");
            currentIndex = -1;
            ClearFields();
        }

        private void govbtn_CheckedChanged(object sender, EventArgs e)
        {
            filteredData = dataManager.DetermineDomain(".gov");
            currentIndex = -1;
            ClearFields();
        }

        private void edubtn_CheckedChanged(object sender, EventArgs e)
        {
            filteredData = dataManager.DetermineDomain(".edu");
            currentIndex = -1;
            ClearFields();
        }

        private void rubtn_CheckedChanged(object sender, EventArgs e)
        {
            filteredData = dataManager.DetermineDomain(".ru");
            currentIndex = -1;
            ClearFields();
        }

        private void ukbtn_CheckedChanged(object sender, EventArgs e)
        {
            filteredData = dataManager.DetermineDomain(".uk");
            currentIndex = -1;
            ClearFields();
        }

        private void jpbtn_CheckedChanged(object sender, EventArgs e)
        {
            filteredData = dataManager.DetermineDomain(".ju");
            currentIndex = -1;
            ClearFields();
        }

        private void GetRecord(Data record)
        {
            NumberTextbox.Text = record.Number.ToString();
            NameTextbox.Text = record.Name;
            SurnameTextbox.Text = record.Surname;
            EmailTextbox.Text = record.Email;
            FemaleRB.Checked = record.Gender == "Female";
            MaleRB.Checked = record.Gender == "Male";
            IPaddressTextbox.Text = record.IP;
        }


        private void ClearFields()
        {
            NumberTextbox.Clear();
            NameTextbox.Clear();
            SurnameTextbox.Clear();
            EmailTextbox.Clear();
            FemaleRB.Checked = false;
            MaleRB.Checked = false;
            IPaddressTextbox.Clear();
        }
        
    }
}