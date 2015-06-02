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
            btnChangePass.Text = rm.GetString("changepass", ci);
            label1.Text = rm.GetString("oldpass", ci);
            label2.Text = rm.GetString("newpass", ci);
            label3.Text = rm.GetString("confpass", ci);

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
                MessageBox.Show(rm.GetString("fail", ci) + ex.Message);
                //Console.WriteLine(ex);
            }
        }
    }
}
