using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBattleShipClient.Controllers;
using Newtonsoft.Json.Linq;

namespace TheBattleShipClient
{
    public partial class GameStart : Form
    {
        Form1 form1 = new Form1();
        Facafe fack = new Facafe();

        public GameStart()
        {
            InitializeComponent();
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            CheckInput();
        }
        private void hostButton_Click(object sender, EventArgs e)
        {
            //        Task<string> create = fack.Connector.PostAction("Identity/Register",
            //"{\"userName\":\"" + "JONAS" + "\", \"email\":\"" + "mailas@one.lt" + "\", \"password\":\"" + "abc" + "\"}");
            //        var result = create.Result; // result = "" ?
            //        var obj = JObject.Parse(result);
            //        string id = obj["token"].Value<string>();


            //userNameLabel.Text = userNameTextBox.Text;
            //emailLabel.Text = emailTextBox.Text;
            //passwordLabel.Text = passwordTextBox.Text;

            CheckInput();
        }
        private void CheckInput()
        {
            errorLabel.Visible = false;
            if (IsValidInput(userNameTextBox.Text, emailTextBox.Text, passwordTextBox.Text))
            {
                Task<string> create = fack.Connector.PostAction("Identity/Register",
"{\"userName\":\"" + userNameTextBox.Text + "\", \"email\":\"" + emailTextBox.Text + "\", \"password\":\"" + passwordTextBox.Text + "\"}");
                var result = create.Result; // result = "" ?
                var obj = JObject.Parse(result);
                string id = obj["token"].Value<string>();

                //form1.Show();
            }
        }

        bool IsValidInput(string userName, string email, string password)
        {
            if (userName.Length < 3)
            {
                errorLabel.Text = "Username has to be longer than 2 letters";
                errorLabel.Visible = true;
                return false;
            }
            else if (!IsValidEmail(email))
            {
                errorLabel.Text = "Please check email entered.";
                errorLabel.Visible = true;
                return false;
            }
            else if (password.Length < 3)
            {
                errorLabel.Text = "Password has to be longer than 2 letters";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
