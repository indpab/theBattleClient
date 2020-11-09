using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Exceptions;
using static TheBattleShipClient.Services.RoomsService;
using static TheBattleShipClient.Services.ShipsService;
using static TheBattleShipClient.Services.WeaponsService;

namespace TheBattleShipClient.Services
{
    class Service
    {
        public static async Task<RoomResponse> HostRoom(string token, int roomSizeVal)
        {
            var request = new RoomRequest { Size = roomSizeVal };
            return await Create(token, request);
        }
        public static async Task<RoomResponse> JoinRoom(string token, string roomIdVal)
        {
            return await Join(token, roomIdVal);
        }
        public static async Task<ShotResponse> ShootWeapon(string token, string roomId, int x, int y, int weaponType)
        {
            var weaponRequest = new WeaponRequest
            {
                X = x,
                Y = y,
                WeaponTypeId = weaponType
            };
            try
            {
                return await Shot(token, roomId, weaponRequest);
            }
            catch (ApiException e){
                return new ShotResponse();
            }
        }
        public static async Task<ShipResponse> CreateShip(string token, string roomId, int x, int x_offset, int y, int y_offset, int shipTypeId)
        {
            var shipRequest = new ShipRequest
            {
                X = x,
                XOffset = x_offset,
                Y = y,
                YOffset = y_offset,
                ShipTypeId = shipTypeId
            };
            return await ShipsService.Create(token, roomId, shipRequest);
        }
        public static async Task<ShipResponse> UpdateShip(string token, int shipId, int x, int x_offset, int y, int y_offset, int shipType)
        {
            var shipRequest = new ShipRequest
            {
                X = x,
                XOffset = x_offset,
                Y = y,
                YOffset = y_offset,
                ShipTypeId = shipType
            };
            return await Update(token, shipId, shipRequest);
        }
        public static async Task<bool> HasGuestArrived(string token, string roomId)
        {
            return await CheckGuest(token, roomId);
        }



    }
}
