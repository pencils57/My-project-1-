using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, 10 * Time.deltaTime, 0);

        if(this.transform.position.y > 15)
        {
            Destroy(this.gameObject);
        }
    }
}
