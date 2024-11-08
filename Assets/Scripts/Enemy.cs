using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
 public Enemy(string name, int health) : base(name, health) { }
        
public void Attack(Character attack, int damage)
{
      PlayerHealth = PlayerHealth - damage;
      Debug.Log(PlayerName + " attacked " + attack.PlayerName + " for " + damage + " damage. " +
                  attack.PlayerName + "'s health is now " + attack.PlayerHealth);
    
}




}
