﻿using eDentalist.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentalist.WinUI
{
    public partial class frmLogin : Form
    {
        //private readonly APIService _apiService = new APIService("Material"); //temporary
        private readonly APIService _apiService = new APIService("User/Login");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                var login = new UserLoginRequest()
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                var userLogin = await _apiService.Login<Model.User>(login);
                APIService.Role = userLogin.UserRole.Name;
                APIService.UserID = userLogin.UserID;

                frmIndex frm = new frmIndex();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
