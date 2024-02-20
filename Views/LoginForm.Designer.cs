namespace examplemvcwindowsform.Views
{
    partial class LoginForm
    {


        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;

        private void InitializeComponent()
        {
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(100, 150);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(81, 36);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click; // Adiciona o manipulador de eventos Click


            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(74, 49);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(74, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 27);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            ClientSize = new Size(282, 253);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Name = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}