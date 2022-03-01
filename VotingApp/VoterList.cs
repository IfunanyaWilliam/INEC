using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Commons.Enums;
using Core.Contracts;
using Core.DTOs;
using Core.Persistence;
using Core.Services;
using Data;

namespace VotingApp
{
    public partial class VoterList : Form
    {
        private readonly Database _database;

        public VoterList(Database database)
        {
            InitializeComponent();
            _database = database;
            DisplayVoters();
        }


        private void VoterViewPanel_Paint(object sender, PaintEventArgs e)
        {
           // MessageBox.Show("Just came to life");
        }

        public void DisplayVoters()
        {
            var voterList = _database.VoterTable;
            foreach (var voter in voterList)
            {
                Display_table.Rows.Add(voter.FirstName, voter.MiddleName, voter.LastName, voter.Gender, voter.DateOfBirth.Date.ToString("dd/MM/yyyy"));
            }

        }

        private void VoterGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Display_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
