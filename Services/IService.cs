using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static TheBattleShipClient.Services.RoomsService;
using static TheBattleShipClient.Services.ShipsService;
using static TheBattleShipClient.Services.WeaponsService;

namespace TheBattleShipClient.Services
{
    interface IService
    {
        public Task<RoomResponse> HostRoom(string token, int roomSizeVal);
        public Task<RoomResponse> JoinRoom(string token, string roomIdVal);
        public Task<ShotResponse> ShootWeapon(string token, string roomId, int x, int y, int weaponType);
        public Task<ShipResponse> CreateShip(string token, string roomId, int x, int x_offset, int y, int y_offset, int shipTypeId);
        public Task<ShipResponse> UpdateShip(string token, int shipId, int x, int x_offset, int y, int y_offset, int shipType);
        public Task<bool> HasGuestArrived(string token, string roomId);
    }
}
