using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : Item
{
        [SerializeField]
        Sprite thumbnail;
   protected Tool()
    {
    equipable = true;
    }
}
