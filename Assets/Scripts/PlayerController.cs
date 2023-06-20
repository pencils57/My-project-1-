using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int mSpeed;

    public bool a;

    public Vector3 moveVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveVector = new Vector3(mSpeed, 0, 0);
        this.transform.position = Vector3.Lerp(this.transform.position, moveVector, 3 *Time.deltaTime);
    }

    public void moveLeft()
    {
        mSpeed-=2;
    }

    public void moveRight()
    {
        mSpeed+=2;

    }
}
