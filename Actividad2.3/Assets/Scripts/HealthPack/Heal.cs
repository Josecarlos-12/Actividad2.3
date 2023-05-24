using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
   [SerializeField] private int curaAmount = 5;


   public int GetCuraAmount()
   {
        return curaAmount;
   }
}
