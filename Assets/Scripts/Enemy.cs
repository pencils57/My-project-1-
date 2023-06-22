using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private string name;
    private int hp;
    public Enemy(string _name, int _hp)
    {
        name = _name;
        hp = _hp;

    }

    //public string Name()
    //{
    //    return this.name;
    //}

    //public int Hp()
    //{
    //    return this.hp;
    //}

    public void GetEnemyInfo()
    {
       Debug.Log($"Enmey name : {name} , hp : {hp}");
    }
}
