namespace CxPassword
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassOld = new System.Windows.Forms.TextBox();
            this.tbPassNew1 = new System.Windows.Forms.TextBox();
            this.tbPassNew2 = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbPassOld
            // 
            resources.ApplyResources(this.tbPassOld, "tbPassOld");
            this.tbPassOld.Name = "tbPassOld";
            // 
            // tbPassNew1
            // 
            resources.ApplyResources(this.tbPassNew1, "tbPassNew1");
            this.tbPassNew1.Name = "tbPassNew1";
            // 
            // tbPassNew2
            // 
            resources.ApplyResources(this.tbPassNew2, "tbPassNew2");
            this.tbPassNew2.Name = "tbPassNew2";
            // 
            // btnChangePass
            // 
            resources.ApplyResources(this.btnChangePass, "btnChangePass");
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lUserName
            // 
            resources.ApplyResources(this.lUserName, "lUserName");
            this.lUserName.Name = "lUserName";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lUserName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.tbPassNew2);
            this.Controls.Add(this.tbPassNew1);
            this.Controls.Add(this.tbPassOld);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassOld;
        private System.Windows.Forms.TextBox tbPassNew1;
        private System.Windows.Forms.TextBox tbPassNew2;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lUserName;
    }
}

