using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
   public int coins=0;
    public void AddCoin(int coin)
    {
        coins=coins+coin;
    }
}
