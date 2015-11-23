/*
 *  CxPassword -- Desktop utility for remote access environments to change Active Directory password of the user
 *  Copyright (C) 2015  Kristof Imre Szabo
 *
 *  This program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2 of the License, or
 *  (at your option) any later version.
 *  
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *  
 *  You should have received a copy of the GNU General Public License along
 *  with this program; if not, write to the Free Software Foundation, Inc.,
 *  51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Resources;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Text.RegularExpressions;

namespace CxPassword
{
    public partial class Form1 : Form
    {
        private ResourceManager rm;
        private CultureInfo ci;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lUserName.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            //ci = new CultureInfo("it");
            ci = Thread.CurrentThread.CurrentCulture;
            rm = new ResourceManager("CxPassword.Strings", Assembly.GetExecutingAssembly());
            btnCancel.Text = rm.GetString("cancel", ci);
            btnChangePass.Text = rm.GetString("ok", ci);
            label1.Text = rm.GetString("oldpass", ci);
            label2.Text = rm.GetString("newpass", ci);
            label3.Text = rm.GetString("confpass", ci);
            this.Text = rm.GetString("changepass", ci);


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            String sDomainUser;
            String sDomain;
            String sUser;
            try
            {
                sDomainUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                String[] fields = sDomainUser.Split('\\');
                sDomain = fields[0];
                sUser = fields[1];
                using (var context = new PrincipalContext(ContextType.Domain, sDomain))
                using (var user = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, sUser))
                {
                    if (tbPassNew1.Text == tbPassNew2.Text)
                    {
                        user.ChangePassword(tbPassOld.Text, tbPassNew1.Text);
                        MessageBox.Show(rm.GetString("success", ci));
                        System.Windows.Forms.Application.Exit();

                    }
                    else {
                        MessageBox.Show(rm.GetString("nomatch", ci));
                    }
                    
                }

            }
            catch (Exception ex)
            {
                Regex cleanmessage = new Regex("\\([^\\(\\)]+\\)$");
                String Message = cleanmessage.Replace(ex.Message, "");
                MessageBox.Show(rm.GetString("fail", ci) + Message);
                //Console.WriteLine(ex);
            }
        }
    }
}
