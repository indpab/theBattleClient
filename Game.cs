﻿using System;
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
using TheBattleShipClient.Models.Maps;
using TheBattleShipClient.Models.Ships.Command;
using TheBattleShipClient.Models.Ships.Bridge;
using TheBattleShipClient.Models.Ships.Decorator;
using static TheBattleShipClient.Services.MapsService;
using static TheBattleShipClient.Services.WeaponsService;
using TheBattleShipClient.Models.Weapons.Factories;
using TheBattleShipClient.Models.Weapons.Factories.Adapter;
using TheBattleShipClient.Models.Weapons;
using TheBattleShipClient.Models.Ships.Algorithms;
using TheBattleShipClient.Models.Ships.Composite;
using TheBattleShipClient.Models.Ships.Mediator;
using TheBattleShipClient.Models.Ships.Interpreter;
using TheBattleShipClient.Models.Communication.Mediator;
using TheBattleShipClient.Models.Communication.Interpreter;

namespace TheBattleShipClient
{
    public partial class Game : Form, IGameObserver
    {
        string _token;
        string _roomId;
        private Map map;
        bool gameStarted = false;
        Services.RoomsService.RoomResponse RoomResponse { get; set; }
        TextBox roomIdTextBox;
        TextBox chatTextBox;
        TextBox messageTextBox;
        Button sendMessageButton;
        Random rand = new Random();
        Facafe fack = new Facafe();
        GameSubject gameSubject;
        Visualization visualization = new ColorBlue();
        int colorChange = 10;

        Mediator chatMediator = new Mediator();
        Participant hostPlayer;
        Notificator notificator;
        Participant systemParticipant;
        CheatExpression cheatExpression;

        public void UpdateState()
        {
            UpdateJoinedState();
            UpdatePlayerState();
        }

        public void UpdateJoinedState()
        {
            if (gameSubject.JoinedState == true)
            {
                joinedStatus.Text = "Enemy has joined";
                startGameButton.Enabled = true;
            }
            else
            {
                joinedStatus.Text = "Enemy is not connected";
            }
        }

        public async void UpdatePlayerState()
        {
            if (gameSubject.PlayerState == true)
            {
                Ship shotShip = await map.UpdateMap(visualization);
                yourTurnText.Text = "Your Turn !";
                enemyButtons.ForEach(x => x.Enabled = true);
                map.buttons.ForEach(x => x.Enabled = true);
            }

            else
            {

                yourTurnText.Text = "Wait for your turn";
            }
            MediatorProcess();
        }

        private async void ShootButtonClick(object sender, EventArgs e)
        {
            int xCord;
            if (!((Button)sender).Text.Last().Equals('0'))
                xCord = Convert.ToInt32(((Button)sender).Text.Last().ToString()) - 1;
            else
                xCord = 9;

            int yCord = Array.IndexOf(letters, ((Button)sender).Text[0]);

            WeaponFactory weaponFactory = null;
            if (torpedoRadioButton.Checked)
            {
                weaponFactory = new TorpedoFactory(_token, _roomId);
            }
            else if (bombRadioButton.Checked)
            {
                weaponFactory = new MineFactoryAdapter(_token, _roomId);
            }
            else if (mineRadioButton.Checked)
            {
                weaponFactory = new BombFactory(_token, _roomId);
            }

            try
            {
                Weapon weapon = await weaponFactory.CreateWeapon(xCord, yCord);
                enemyButtons.ForEach(x => x.Enabled = false);
                map.buttons.ForEach(x => x.Enabled = false);
                gameSubject.StartObservingGame(_token, _roomId);
            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show("Please select a weapon type");
            }


            if (colorChange < 255)
            {
                ((Button)sender).UseVisualStyleBackColor = false;
                ((Button)sender).BackColor = Color.FromArgb(255 - colorChange, 255 - colorChange, 255 - colorChange);
                colorChange += 10;
            }
        }
        private async void startGame_Click(object sender, EventArgs e)
        {
            gameStarted = true;
            map.StartGameMap();
            gameSubject.StartObservingGame(_token, _roomId);
            gameSubject.isStarted = gameStarted;
            turnShipButton.Hide();
            undoButton.Hide();
            startGameButton.Hide();
            await notificator.Send("You started the game!", _roomId, _token);
        }

        private void MovingAlgorithmClick(object sender, EventArgs e)
        {

        }

        private void DecoratorClick(object sender, EventArgs e)
        {
            Ship theShip = map.GetShipByButton((Button)sender);
            if ( theShip != null)
            {
                if (((Button)sender).BackColor != Color.White && theShip != null)
                {
                    visualization.draw(theShip.GetButtons(), new Dead(new Named(theShip)));
                }
            }

        }

        private void VisualizationClick(object sender, EventArgs e)
        {
            if (colorRedRadioButton.Checked)
            {
                visualization = new ColorRed();
            }
            else if (ColorBlueRadioButton.Checked)
            {
                visualization = new ColorBlue();
            }
            else if (ColorGreenRadioButton.Checked)
            {
                visualization = new ColorGreen();
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

        public Game(RoomsService.RoomResponse rr, string token)
        {
            RoomResponse = rr;
            _token = token;
            _roomId = rr.Id;
            InitializeComponent();
            map = new Map(_token, _roomId, xxy, xxy, myButtons);
            cheatExpression = new CheatExpression();
            cheatExpression.setButtons(map.buttons);
        }
        private void CreateRoomIdTextBox()
        {
            roomIdTextBox = new TextBox();
            roomIdTextBox.Text = RoomResponse.Id;
            roomIdTextBox.Size = new Size(200, 20);
            roomIdTextBox.Location = new Point(50, 10);
            this.Controls.Add(this.roomIdTextBox);
        }

        private void CreateChatTextBox()
        {
            chatTextBox = new TextBox();
            chatTextBox.Text = "Hi" + Environment.NewLine;
            chatTextBox.Size = new Size(420, 200);
            chatTextBox.Location = new Point(1300, 30);
            chatTextBox.BackColor = Color.White;
            chatTextBox.Multiline = true;
            this.Controls.Add(this.chatTextBox);

            messageTextBox = new TextBox();
            messageTextBox.Text = "";
            messageTextBox.Size = new Size(300, 100);
            messageTextBox.Location = new Point(1300, 250);
            this.Controls.Add(this.messageTextBox);

            sendMessageButton = new Button();
            sendMessageButton.Location = new Point(1610, 250);
            sendMessageButton.Name = "senMessageButton";
            sendMessageButton.Size = new Size(100, 30);
            sendMessageButton.TabIndex = 2;
            sendMessageButton.Text = "Send Message";
            sendMessageButton.UseVisualStyleBackColor = true;
            sendMessageButton.Click += new System.EventHandler(this.SendMessageButtonClick);
            this.Controls.Add(this.sendMessageButton);
        }

        private async void Game_Load(object sender, EventArgs e)
        {
            gameSubject = new GameSubject();
            gameSubject.Attach(this);
            gameSubject.StartObserving(_token, _roomId);

            var submarine_builder = new SubmarineShipGroupsBuilder(_token, _roomId);
            var submarine_director = new BuildShipGroupsDirector(submarine_builder);
            var destroyer_builder = new DestroyerShipGroupsBuilder(_token, _roomId);
            var destroyer_director = new BuildShipGroupsDirector(destroyer_builder);

            var mapResponse = await MapsService.GetMap(_token, _roomId);
            var submarineLimits = mapResponse.ShipGroups.Where(x => x.ShipType.IsSubmarine).OrderBy(x => x.ShipType.Size).Select(x => x.Limit).ToList();
            var destroyerLimits = mapResponse.ShipGroups.Where(x => !x.ShipType.IsSubmarine).OrderBy(x => x.ShipType.Size).Select(x => x.Limit).ToList();
            var submarineGroups = submarine_director.ConstructShipGroups(submarineLimits);
            var destroyerGroups = destroyer_director.ConstructShipGroups(destroyerLimits);

            map.ShipGroups = destroyerGroups.Concat(submarineGroups).ToList();

            groupIndex = map.ShipGroups.Count - 1;
            shipIndex = map.ShipGroups.ToList()[groupIndex].Ships.Count;
            iterLimit = countShips();
            CreateRoomIdTextBox();
            CreateChatTextBox();
            visualization = new ColorBlue();
            MediatorStart();
        }

        private void MediatorStart()
        {
            hostPlayer = new Participant(chatMediator, chatTextBox);
            notificator = new Notificator(chatMediator, chatTextBox);
            systemParticipant = new Participant(chatMediator, chatTextBox);
            chatMediator.AddComunicator(hostPlayer);
            chatMediator.AddComunicator(notificator);
        }

        private async void UpdateChat()
        {
            var messages = await CommunicationService.GetAllMessagesByRoomId(_token, _roomId);
            foreach (var item in messages)
            {
                chatTextBox.AppendText(item.MessageContent + Environment.NewLine);
            }
        }

        private async void MediatorProcess()
        {
            if (messageTextBox.Text.Length < 1)
            {
                return;
            }
            chatTextBox.Text = "";
            CommandExpression commanExpression = new CommandExpression();
            commanExpression.setTextBox(chatTextBox);
            string message = (commanExpression).Interpret(messageTextBox.Text);
            message = (new CurseExpression()).Interpret(message);
            message = cheatExpression.Interpret(message);

            await hostPlayer.Send(message, _roomId, _token);
            UpdateChat();
            messageTextBox.Text = "";
        }

        private void SendMessageButtonClick(object sender, EventArgs e)
        {
            MediatorProcess();
        }

        private Ship GetCurrentShip()
        {
            if (groupIndex == 1 && shipIndex == 0)
            {
                startGameButton.Show();
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
            else if (shipIndex != 0)
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

        private void setColor(bool isSubmarine)
        {
            if (isSubmarine)
                color = Color.Aqua;
            else
                color = Color.Coral;
        }

        private void drawShip(Ship ship, int xCord, int yCord)
        {
            int buttonIndex = xCord + yCord * xxy;

            myButtons[buttonIndex].BackColor = color;
            ship.button = null;
            ship.button = new ButtonComposite(myButtons[buttonIndex]);
            //ship.buttons.Clear();
            if (ship.horizontal)
            {
                
                for (int i = 1; i < ship.HP; i++)
                {
                    ButtonLeaf button = new ButtonLeaf(myButtons[buttonIndex]);
                    ((ButtonComposite)ship.button).AddChild(button);
                    myButtons[buttonIndex++].BackColor = color;
                }
                

                //for (int i = 0; i < ship.HP; i++)
                //{
                    
                //    ship.buttons.Add(myButtons[buttonIndex]);
                //    myButtons[buttonIndex++].BackColor = color;

                //}
            }
            else
            {
                for (int i = 1; i < ship.HP; i++)
                {
                    myButtons[buttonIndex].BackColor = color;
                    ButtonLeaf button = new ButtonLeaf(myButtons[buttonIndex]);
                    ((ButtonComposite)ship.button).AddChild(button);
                    buttonIndex += xxy;
                }
            }
        }


        private async void PlayerGridButtonClicked(object sender, EventArgs e)
        {
            Point thisPoint = map.getButtonCoordinates((Button)sender);
            int xCord = thisPoint.X;
            int yCord = thisPoint.Y;

            bool isSuccess = true;
            if (placedShipsCount < iterLimit)
            {
                if (isSuccess)
                    currShip = GetCurrentShip();

                currShip.InitializeButtons();

                var newship = currShip;
                newship.setCordinates(xCord, yCord);
                var validationResult = map.ValidateCoordinatesInitial(newship);
                if (validationResult != null)
                {
                    MessageBox.Show(validationResult);
                    isSuccess = false;
                    PlaceUndo();
                    return;
                }
                invoker.ClickButton(new PlaceShipCommand(currShip, xCord, yCord));
                bool isSubmarine = map.ShipGroups.ToList()[groupIndex].ShipType.IsSubmarine;
                setColor(isSubmarine);
                drawShip(currShip, xCord, yCord);
                await notificator.Send("Ship Placed!", _roomId, _token);
                placedShipsCount++;
                isSuccess = true;
            }
            else if (gameStarted)
            {
                try
                {
                    Ship ship = map.getShipByCoordinates(xCord, yCord);
                    IMotionAlgorithm motionAlgorithm = new MoveStraightSlowAlgorithm();
                    if (moveStraightFast.Checked)
                    {
                        motionAlgorithm = new MoveStraightFastAlgorithm();
                    }
                    else if (turnAround.Checked)
                    {
                        motionAlgorithm = new TurnAroundAlgorithm();
                    }

                    ship.SetMotionAlgoritm(motionAlgorithm);
                    Ship dummy_ship = ship.ShallowClone();
                    dummy_ship.Move();
                    var validationResult = map.ValidateCoordinates(dummy_ship);
                    if (validationResult == null)
                    {
                        color = Color.White;
                        drawShip(ship, ship.X, ship.Y);

                        setColor(map.IsSubmarine(ship));
                        ship.Move();
                        drawShip(ship, ship.X, ship.Y);
                        await ship.Update();
                    }

                    gameSubject.StartObservingGame(_token, _roomId);

                }
                catch (NullReferenceException ne)
                {
                    
                }
            }
            if (placedShipsCount == iterLimit)
            {
                await notificator.Send("You have placed all your ships !", _roomId, _token);
            }
            UpdateChat();
        }

        private void turnShip_Click(object sender, EventArgs e)
        {
            color = Color.White;
            drawShip(currShip, currShip.X, currShip.Y);
            bool isSubmarine = map.ShipGroups.ToList()[groupIndex].ShipType.IsSubmarine;
            setColor(isSubmarine);
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
                bool isSubmarine = map.ShipGroups.ToList()[groupIndex].ShipType.IsSubmarine;

                setColor(isSubmarine);

                if (lastComm is TurnShipCommand)
                {
                    temp.Rotate(!temp.horizontal);
                    color = Color.White;
                    drawShip(temp, temp.X, temp.Y);
                    setColor(isSubmarine);
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


