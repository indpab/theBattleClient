using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBattleShipClient.Controllers;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using TheBattleShipClient.Services;
using System.Drawing.Text;
using TheBattleShipClient.Services.Communication;
using TheBattleShipClient.Models.Ships;
using TheBattleShipClient.Models.Ships.Builder;
using TheBattleShipClient.Models;
using System.Linq;
using TheBattleShipClient.Models.Ships.Command;
using static TheBattleShipClient.Services.MapsService;

namespace TheBattleShipClient
{
    public partial class Game : Form, IGameObserver
    {
        string _token;
        string _roomId;
        private Map map;
        Services.RoomsService.RoomResponse RoomResponse { get; set; }
        Random rand = new Random();
        Facafe fack = new Facafe();
        GameSubject gameSubject;

        private void startGame_Click(object sender, EventArgs e)
        {

        }
        public void UpdateState()
        {
            if (gameSubject.PlayerState == true)
            {
                MessageBox.Show("Your Turn!");
            }
            else
            {
                MessageBox.Show("Wait for your turn");
            }
            if (gameSubject.JoinedState == true)
            {
                MessageBox.Show("State Changed");
            }
        }


        #region Build Map Pre Game

        Color color;
        int iterLimit;
        Ship currShip;
        Invoker invoker = new Invoker();
        int placedShipsCount = 0;
        int groupIndex;
        int shipIndex;

        public Game(RoomsService.RoomResponse rr, string token, GameSubject gs)
        {
            RoomResponse = rr;
            _token = token;
            _roomId = rr.Id;
            InitializeComponent();
            map = new Map(_token, _roomId, xxy, xxy, myButtons);
            gameSubject = gs;
            gameSubject.Attach(this);
        }

        private async void Game_Load(object sender, EventArgs e)
        {
            
            var submarine_builder = new SubmarineShipGroupsBuilder(_token, _roomId);
            var submarine_director = new BuildShipGroupsDirector(submarine_builder);
            var destroyer_builder = new DestroyerShipGroupsBuilder(_token, _roomId);
            var destroyer_director = new BuildShipGroupsDirector(destroyer_builder);

            var mapResponse = await MapsService.GetMap(_token, _roomId);
            var submarineLimits = mapResponse.ShipGroups.Where(x => x.ShipType.IsSubmarine).OrderBy(x => x.ShipType.Size).Select(x => x.Limit).ToList();
            var destroyerLimits = mapResponse.ShipGroups.Where(x => !x.ShipType.IsSubmarine).OrderBy(x => x.ShipType.Size).Select(x => x.Limit).ToList();
            var submarineGroups = submarine_director.ConstructShipGroups(submarineLimits);
            var destroyerGroups = destroyer_director.ConstructShipGroups(destroyerLimits);
            
            map.ShipGroups = submarineGroups.Concat(destroyerGroups).ToList();
            
            groupIndex = map.ShipGroups.Count - 1;
            shipIndex = map.ShipGroups.ToList()[groupIndex].Ships.Count;
            iterLimit = countShips();
        }



        private void SetPlaceShipInfo()
        {
            shipPlaceInfo.Text = shipPlaceInfo.Text.Remove(shipPlaceInfo.Text.Length - 1);
            if (currShip.HP == 1)
                shipPlaceInfo.Text += 4;
            else
                shipPlaceInfo.Text += currShip.HP - 1;
        }

        private void SetPlaceShipInfo(double hp)
        {
            shipPlaceInfo.Text = shipPlaceInfo.Text.Remove(shipPlaceInfo.Text.Length - 1);
            shipPlaceInfo.Text += hp;
        }

        private Ship GetCurrentShip()
        {
            if (groupIndex == 1 && shipIndex == 0)
            {
                startGameButton.Enabled = true;
            }
            shipIndex -= 1;
            if (shipIndex > -1)
            {
                return map.ShipGroups.ToList()[groupIndex].Ships.ToList()[shipIndex];
            }
            else
            {
                while (shipIndex <= -1)
                {
                    groupIndex -= 1;
                    shipIndex = map.ShipGroups.ToList()[groupIndex].Ships.Count - 1;
                }
                return map.ShipGroups.ToList()[groupIndex].Ships.ToList()[shipIndex];
            }
        }

        private void PlaceUndo()
        {
            if (groupIndex != map.ShipGroups.Count - 1)
            {
                if (shipIndex == 0)
                {
                    groupIndex += 1;
                }
                else
                {
                    shipIndex += 1;
                }
            }
            else if (shipIndex !=0)
            {
                shipIndex += 1;
            }

        }

        private int countShips()
        {
            int temp = 0;
            foreach (var shipGroup in map.ShipGroups)
            {
                temp += shipGroup.Limit;
            }
            return temp;
        }

        private void setColor()
        {
            if (map.ShipGroups.ToList()[groupIndex].ShipType.IsSubmarine)
                color = Color.Coral;
            else
                color = Color.Aqua;
        }

        private void drawShip(Ship ship, int xCord, int yCord)
        {
            int buttonIndex = xCord + yCord * xxy;

            myButtons[buttonIndex].BackColor = color;
            if (ship.horizontal)
            {
                for (int i = 0; i < ship.HP; i++)
                {
                    myButtons[buttonIndex++].BackColor = color;
                }
            }
            else
            {
                for (int i = 0; i < ship.HP; i++)
                {
                    myButtons[buttonIndex].BackColor = color;
                    buttonIndex += xxy;
                }
            }
        }

        private void BuildConfiguration(object sender, EventArgs e)
        {
            bool isSuccess = true;
            if (placedShipsCount < iterLimit)
            {
                string text = ((Button)sender).Text.ToString();
                int xCord;
                if (!text.Last().Equals('0'))
                    xCord = Convert.ToInt32(text.Last().ToString()) - 1;
                else
                    xCord = 9;

                int yCord = Array.IndexOf(letters, text[0]);


                if (isSuccess)
                    currShip = GetCurrentShip();

                //invoker.ClickButton(new PlaceShipCommand(currShip, xCord, yCord));
                var newship = currShip;
                newship.setCordinates(xCord, yCord);
                var validationResult = map.ValidateCoordinates(newship);
                if (validationResult != null)
                {
                    MessageBox.Show(validationResult);
                    isSuccess = false;
                    PlaceUndo();
                    return;
                }
                invoker.ClickButton(new PlaceShipCommand(currShip, xCord, yCord));
                setColor();
                drawShip(currShip, xCord, yCord);
                SetPlaceShipInfo();

                placedShipsCount++;
                isSuccess = true;
            }
        }

        private void turnShip_Click(object sender, EventArgs e)
        {
            color = Color.White;
            drawShip(currShip, currShip.X, currShip.Y);
            setColor();
            invoker.ClickButton(new TurnShipCommand(currShip));
            drawShip(currShip, currShip.X, currShip.Y);
        }

        private void undo_Click(object sender, EventArgs e)
        {
            if (invoker.getCommandsCount() > 0)
            {
                IShipCommand lastComm = invoker.ClickUndo();
                Ship temp = lastComm.getShip();

                color = Color.White;
                drawShip(temp, temp.X, temp.Y);
                setColor();

                if (lastComm is TurnShipCommand)
                {
                    temp.Rotate(!temp.horizontal);
                    color = Color.White;
                    drawShip(temp, temp.X, temp.Y);
                    setColor();
                    temp.Rotate(!temp.horizontal);
                    drawShip(temp, temp.X, temp.Y);
                }
                if (lastComm is PlaceShipCommand)
                {
                    PlaceUndo();
                    iterLimit++;
                }
            }
            startGameButton.Enabled = false;
        }
        #endregion

    }

}


