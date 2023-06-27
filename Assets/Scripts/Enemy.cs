using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    enum EnemyType
    {
        Basic = 0,
        Boss
    }

    private EnemyType enemyType;
    private int hp;
    private int atk;
    private float speed;
    public Enemy(EnemyType type, int _hp, int _atk, float _speed)
    {
        enemyType = type;
        hp = _hp;
        atk = _atk;
        speed = _speed; 

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
