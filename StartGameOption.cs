using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TheBattleShipClient.Services;

namespace TheBattleShipClient
{
    public partial class StartGameOption : Form
    {
        AuthenticationResponse ar { get; set; }
        public StartGameOption(AuthenticationResponse ar)
        {
            InitializeComponent();
            this.ar = ar;

        }

        private void hostSelectionRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton host = sender as RadioButton;

            if (host.Checked)
            {
                roomSizeLabel.Show();
                roomSize.Show();
            }
            else
            {
                roomSizeLabel.Hide();
                roomSize.Hide();
            }
        }

        private void joinSelectionRadio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton join = sender as RadioButton;

            if (join.Checked)
            {
                roomIdLabel.Show();
                roomId.Show();
            }
            else
            {
                roomIdLabel.Hide();
                roomId.Hide();
            }
        }

        private async void startGameButton_Click(object sender, EventArgs e)
        {
            RadioButton host = hostSelectionRadio;
            RadioButton join = joinSelectionRadio;
            RoomsService.RoomResponse rs = new RoomsService.RoomResponse();

            if (host.Checked)
            {
                if(roomSize.SelectedItem != null)
                {
                    var roomSizeVal = Convert.ToInt32(roomSize.SelectedItem.ToString());
                    rs = await RoomsService.CreateRoom(ar.Token, new RoomsService.RoomRequest { Size = roomSizeVal });
                }
                else
                {
                    return;
                }
            }
            else if (join.Checked)
            {
                var roomIdVal = roomId.Text;
                rs = await RoomsService.JoinRoom(ar.Token, roomIdVal);
            }

            Game g = new Game(rs);
            this.Hide();
            g.Show();
        }
    }
}
