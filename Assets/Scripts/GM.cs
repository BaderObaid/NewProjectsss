using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    void Start()
    {
    PlayerZero Zero = new PlayerZero();
    PlayerZero Hero = new PlayerZero();

    Zero.InitializePlayer("PlayerZero is the Ultimate Warrior",90);
    Hero.InitializePlayer("PlayerHero is underdog Warrior", 65);
    PlayerZero.ShowPlayerCount();

    Zero.Heal(10);
    Hero.Heal(35);


    } 





}
