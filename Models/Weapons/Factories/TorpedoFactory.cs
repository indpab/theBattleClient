﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBattleShipClient.Services;
using static TheBattleShipClient.Services.WeaponsService;

namespace TheBattleShipClient.Models.Weapons.Factories
{
    public class TorpedoFactory : WeaponFactory
    {
        public TorpedoFactory(string token, string roomId)
            : base(token, roomId)
        {
        }

        public override async Task<Weapon> CreateWeapon(int x, int y)
        {
            ShotResponse shot = await Service.ShootWeapon(_token, _roomId, x, y, 2);
            var torpedo = new Torpedo
            {
                Id = shot.WeaponId,
                X = shot.X,
                Y = shot.Y,
                IsSuccessful = shot.Successful,
                ShipTypes = shot.ShipTypes.ToList()
            };
            return torpedo;
        }
    }
}
