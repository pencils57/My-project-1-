using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyObject : MonoBehaviour
{
    [SerializeField] private Sprite[] enemyImg;
    [SerializeField] private Slider hpBar;

    Enemy enemy = null;

    float mSpeed;
    
    public void SetEnemy(Enemy e)
    {
        this.enemy = e;

        hpBar.maxValue = enemy.Hp;
        hpBar.value = enemy.Hp;

        mSpeed = enemy.Speed;
    }

    public void MoveEnmey()
    {
            this.transform.position += new Vector3(0, -1 * mSpeed * Time.deltaTime, 0);
        //this.transform.position += new Vector3(0, -1 * Time.deltaTime, 0);
    }

    public void DamageHp()
    {
        if(transform.position.y <= -5f)
        {
            hpBar.value -= 10f * Time.deltaTime;
        }

        if(hpBar.value <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        SetEnemy(new Enemy(Enemy.EnemyType.Basic, 100, 10, 1.5f));
    }

    private void Update()
    {
        if (enemy == null) return;
        MoveEnmey();
        DamageHp();
    }


}
