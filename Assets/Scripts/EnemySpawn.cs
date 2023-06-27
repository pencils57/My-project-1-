using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefab;

    List<Enemy> EnemyList = new List<Enemy>();

    private void Start()
    {
        //Instantiate(EnemyPrefab, new Vector3(Random.Range(-2.5f, 2.5f), 5, 0), Quaternion.identity);

        //for(int i = 0; i < 10; i++)
        //{
        //    GameObject obj = Instantiate(EnemyPrefab, Vector3.zero, Quaternion.identity, this.transform);
        //    obj.transform.position = new Vector3(Random.Range(-2, 2), Random.Range(5, 10), 0);

        //    Enemy e = new Enemy(Enemy.EnemyType.Basic, 100, 10, 2.0f + i);
        //    obj.GetComponent<EnemyObject>().SetEnemy(e);

        //}

    }

    void Update()
    {
       while(EnemyList.Count < 10)
        {
            CreateEnemy(new Enemy(Enemy.EnemyType.Basic, 100, 10, 3.0f));
        }

    }

    public void CreateEnemy(Enemy enemy)
    {
        EnemyList[0] = enemy;
    }
}
