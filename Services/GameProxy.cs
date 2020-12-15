using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace TheBattleShipClient.Services
{
    //protective proxy
    [Authorize]
    class GameProxy : IService
    {
        Service realService = new Service();

        public async Task<ShipsService.ShipResponse> CreateShip(string token, string roomId, int x, int x_offset, int y, int y_offset, int shipTypeId)
        {
            if (token == null)
            {
                throw new ArgumentNullException(nameof(token));

            }
            else
            {
                return await realService.CreateShip(token, roomId, x, x_offset, y, y_offset, shipTypeId);
            }
        }

        public async Task<bool> HasGuestArrived(string token, string roomId)
        {
            if (token == null)
            {
                throw new ArgumentNullException(nameof(token));

            }
            else
            {
                return await realService.HasGuestArrived(token, roomId);
            }
        }

        public async Task<RoomsService.RoomResponse> HostRoom(string token, int roomSizeVal)
        {
            if (token == null)
            {
                throw new ArgumentNullException(nameof(token));

            }
            else
            {
                return await realService.HostRoom(token, roomSizeVal);
            }
        }

        public async Task<RoomsService.RoomResponse> JoinRoom(string token, string roomIdVal)
        {
            if (token == null)
            {
                throw new ArgumentNullException(nameof(token));

            }
            else
            {
                return await realService.JoinRoom(token, roomIdVal);
            }
        }

        public async Task<WeaponsService.ShotResponse> ShootWeapon(string token, string roomId, int x, int y, int weaponType)
        {
            if (token == null)
            {
                throw new ArgumentNullException(nameof(token));

            }
            else
            {
                return await realService.ShootWeapon(token, roomId, x, y, weaponType);
            }
        }

        public async Task<ShipsService.ShipResponse> UpdateShip(string token, int shipId, int x, int x_offset, int y, int y_offset, int shipType)
        {
            if (token == null)
            {
                throw new ArgumentNullException(nameof(token));

            }
            else
            {
                return await realService.UpdateShip(token, shipId, x, x_offset, y, y_offset, shipType);
            }
        }
    }
}
