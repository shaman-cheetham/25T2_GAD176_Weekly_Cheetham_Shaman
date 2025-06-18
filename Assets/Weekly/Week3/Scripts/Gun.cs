using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GunGame
{
    public class Gun : MonoBehaviour, ICollectable, IShootable
    {
        private int damage = 20;

        private int rpm = 600;

        public void Collect()
        {
            //When the gun is collected, we want
            Debug.Log("Gun has been collected");
        }

        public void FireWeapon()
        {

        }
    }
}

