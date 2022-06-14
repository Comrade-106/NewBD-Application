﻿using System;
using System.Windows.Forms;

namespace BD_Application.Domain.Forms.CoachForms {
    public partial class AddCoachForm : Form {
        public AddCoachForm() {
            InitializeComponent();
        }

        private void AddCoachButton_Click(object sender, EventArgs e) {
            if (NickNameBox.Text != String.Empty && NameBox.Text != String.Empty && BirthdayBox.Value != null) {
                try {
                    Coach coach = new Coach(NickNameBox.Text, NameBox.Text, BirthdayBox.Value);

                    //Add coach into DB

                    MessageBox.Show("Coach added successful", "Message!");
                } catch (Exception) {
                    MessageBox.Show("You entered wrong info", "Message!");
                }
            } else {
                MessageBox.Show("You didn`t enter all info", "Message!");
            }
        }
    }
}
