using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private string name;
    private string job;
    private int hp;
    private int atk;

    public Character(string _name, string _job, int _hp, int _atk)
    {
        name = _name;
        job = _job;
        hp = _hp;
        atk = _atk;
    }

    string Name
    {
        get
        {
            return this.name;
        }
    }

    string Job
    {
        get
        {
            return this.job;
        }
    }
    int Hp
    {
        get
        {
            return this.hp;
        }
    }

    int Atk
    {
        get
        {
            return this.atk;
        }
    }

    public void Getinfo()
    {
        Debug.Log($"Name : {name}, Job : {job}, Hp : {hp}, Atk : {atk}");
    }
}
    // Start is called before the first frame update
   

