using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    void Start()
    {
        Enemy e1 = new Enemy("elf", 10);
        Enemy e2 = new Enemy("dragon", 100);

        e1.GetEnemyInfo();
        e2.GetEnemyInfo();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
