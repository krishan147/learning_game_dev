using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character
{
    public string name;
    public int exp = 0;

    public Character()
    {
        name = "Not assigned";
    }

    public Character(string name)
    {
        this.name = name;
    }

    public void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
    }

}

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponStats()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", name, damage);
    }


}