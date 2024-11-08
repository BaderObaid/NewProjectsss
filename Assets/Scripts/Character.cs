using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Character
{
  private string name = "GrandWarrior"; 

public string PlayerName
{ 
   get { return name; } 
   set {name = value; }

}
  private  int health = 100; 

  public int PlayerHealth
  {
   get { return health;}
   set { if (value > 100) health = 100;
        else if (value < 0) health = 0; 
        else health = value; }

  }
 
public Character(string name, int health)
    {
        PlayerName = name;
        PlayerHealth = health;
    }

void Start()
{
PlayerName = "GrandZero";
Debug.Log(PlayerName);

PlayerHealth = 150; 
Debug.Log(PlayerHealth);
}

}

