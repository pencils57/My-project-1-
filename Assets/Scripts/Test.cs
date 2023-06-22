using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    int a;
    int[] arra = new int[10];

    Enemy[] Enemyarr = new Enemy[10];

    List<int> lista = new List<int>();

    List<Enemy> EnemyList = new List<Enemy>();

    // Start is called before the first frame update
    void Start()
    {
        //1¹ø
        EnemyList[0] = new Enemy("name", 10);
        //2¹ø
        Enemy e = new Enemy("name", 10);
        EnemyList[0] = e;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
