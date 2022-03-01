using Commons.Enums;
using Core.Contracts;
using Core.DTOs;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingApp
{
    
    public partial class VoterReg : Form
    {
        private readonly IRegistrationService _regService;
        private readonly Database _database;
        private Gender _gender;


        public VoterReg(IRegistrationService registrationService, Database database)
        {
            InitializeComponent();
            _regService = registrationService;
            _database = database;
        }

        private void VoterReg_Load(object sender, EventArgs e)
        {
            GenderSelector.SelectedIndex = 0;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            _regService.RegisterNewVoter(new VoterRegDTO
            {
                FirstName = firstName.Text,
                MiddleName = middleName.Text,
                LastName = lastName.Text,
                DateOfBirth = dateTimePicker1.Value,
                Gender = GenderSelector.Text == "Male" ? Gender.Male: Gender.Female,
                //PollingUnit = PollingUnit.Text.ToString()
            });

            MessageBox.Show("Voter Registered");
            ClearGrid();
        }

        public void ClearGrid()
        {
            firstName.Text = "";
            middleName.Text = "";
            lastName.Text = "";
            GenderSelector.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.UtcNow;
        }

        private void label1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void ViewVoterList_Click(object sender, EventArgs e)
        {
            VoterList voterList = new VoterList(_database);
            voterList.Show();
        }
    }
}
