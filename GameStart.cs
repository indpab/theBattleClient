using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBattleShipClient.Controllers;
using Newtonsoft.Json.Linq;
using System.Linq;
using TheBattleShipClient.Services;

namespace TheBattleShipClient
{
    public partial class GameStart : Form
    {
        Facafe fack = new Facafe();

        public GameStart()
        {
            InitializeComponent();
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            //this.Dispose();

            //CheckInput();
            Login();
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            //        Task<string> create = fack.Connector.PostAction("Identity/Register",
            //"{\"userName\":\"" + "JONAS" + "\", \"email\":\"" + "mailas@one.lt" + "\", \"password\":\"" + "abc" + "\"}");
            //        var result = create.Result; // result = "" ?
            //        var obj = JObject.Parse(result);
            //        string id = obj["token"].Value<string>();


            //userNameLabel.Text = userNameTextBox.Text;
            //emailLabel.Text = emailTextBox.Text;
            //passwordLabel.Text = passwordTextBox.Text;
            Register();
            
        }

        private async void Register()
        {
            AuthenticationResponse ar = new AuthenticationResponse();
            if (IsValidInput(userNameTextBox.Text, emailTextBox.Text, passwordTextBox.Text)){
                ar =  await IdentityService.Register(new UserRequest { UserName = userNameTextBox.Text, Email = emailTextBox.Text, Password = passwordTextBox.Text });
            }
            else
            {
                return;
            }

            StartGameOption gso = new StartGameOption(ar);

            this.Hide();
            gso.Show();
        }

        private async void Login()
        {
            AuthenticationResponse ar = new AuthenticationResponse();
            if (IsValidInput(userNameTextBox.Text, emailTextBox.Text, passwordTextBox.Text))
            {
                //ar = await IdentityService.Login(new UserRequest { UserName = userNameTextBox.Text, Email = emailTextBox.Text, Password = passwordTextBox.Text });
            }
            else
            {
                return;
            }

            StartGameOption gso = new StartGameOption(ar);

            this.Hide();
            gso.Show();
        }

        private void CheckInput()
        {
            errorLabel.Visible = false;
            if (IsValidInput(userNameTextBox.Text, emailTextBox.Text, passwordTextBox.Text))
            {
                try
                {
                    Task<string> create = fack.Connector.PostAction("Identity/Register",
"{\"userName\":\"" + userNameTextBox.Text + "\", \"email\":\"" + emailTextBox.Text + "\", \"password\":\"" + passwordTextBox.Text + "\"}");
                    var result = create.Result; // result = "" ?
                    var obj = JObject.Parse(result);

                    string id = obj["token"].Value<string>();
                }

                catch (Exception e)
                {
                    errorLabel.Text = e.Message;
                    errorLabel.Visible = true;
                }

                //form1.Show();
            }
        }

        bool IsValidInput(string userName, string email, string password)
        {
            if (userName.Length < 4)
            {
                errorLabel.Text = "Username must be atleast 4 characters.";
                errorLabel.Visible = true;
                return false;
            }
            else if (!IsValidEmail(email))
            {
                errorLabel.Text = "Please check email entered.";
                errorLabel.Visible = true;
                return false;
            }
            else if (!IsValidPass(password))
            {
                return false;
            }

            return true;
        }

        bool IsValidPass(string pass)
        {
            if (pass.Length < 6)
            {
                errorLabel.Text = "Password must be atleast 6 characters.";
                errorLabel.Visible = true;
                return false;
            }
            if (!pass.Any(c => char.IsLetterOrDigit(c))) //Turetu veikt, no idea, kodel neveikia
            {
                errorLabel.Text = "Passwords must have at least one non alphanumeric character.";
                errorLabel.Visible = true;
                return false;
            }
            if (!pass.Any(char.IsDigit))
            {
                errorLabel.Text = "Passwords must have at least one digit ('0'-'9').";
                errorLabel.Visible = true;
                return false;
            }
            if (!pass.Any(char.IsUpper))
            {
                errorLabel.Text = "Password must have at least one uppercase ('A'-'Z').";
                errorLabel.Visible = true;
                return false;
            }
            return true;
        }
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
