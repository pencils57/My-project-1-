using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public int mSpeed = 3;
    public int mSpeedX = 3;
    public int mSpeedY = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(mSpeedX * Time.deltaTime, mSpeedY * Time.deltaTime, 0);

        if(this.transform.position.x <= -2 && this.transform.position.y <= -2)
        {
            mSpeedX = 0;
            mSpeedY = mSpeed;
        }
        if(this.transform.position.x <= -2 && transform.position.y >= 2)
        {
            mSpeedX = mSpeed;
            mSpeedY = 0;
        }else if(this.transform.position.x >= 2 && transform.position.y >= 2)
        {
            mSpeedX = 0;
            mSpeedY = -mSpeed;
        }else if(this.transform.position.x >= 2 && transform.position.y <= -2)
        {
            mSpeedX = -mSpeed;
            mSpeedY = 0;
        }

        //if (this.transform.position.y >= 2f)
        //{
        //    mSpeed = -3;
            
        //}
        //else if(this.transform.position.y <= -2f)
        //{
        //    mSpeed = 3;
        //}
    }
}
