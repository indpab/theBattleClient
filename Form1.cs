using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBattleShipClient.Controllers;
using Newtonsoft.Json.Linq;

namespace TheBattleShipClient
{
    public partial class Form1 : Form
    {
        Facafe fack = new Facafe();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreatePlayer();
        }

        public void CreatePlayer()
        {
            Task<string> create = fack.Connector.PostAction("Identity/Register",
                "{\"userName\":\"" + "JONAS" + "\", \"email\":\"" + "meailemail@mail.com" + "\", \"password\":\"" + "Pass-w0rd" + "\"}");
            var result = create.Result; // result = "" ?
            var obj = JObject.Parse(result);
            string id = obj["token"].Value<string>();
        }
    }
}
