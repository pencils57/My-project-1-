using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public enum EnemyType
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
        this.enemyType = type;
        hp = _hp;
        atk = _atk;
        speed = _speed;

    }


    public int Hp
    {
        get
        {
            return this.hp;
        }
        
    }

    public float Speed
    {
        get
        {
            return this.speed;
        }

    }

    public void GetEnemyInfo()
    {
       Debug.Log($"Enmey name :, hp : {hp}");
    }
}
