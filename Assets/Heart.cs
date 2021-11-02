using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public readonly int up = 2; // grow to...
    public readonly int down = 1; // decrease to...
    public readonly float EPS = 0.05f; // The pace of change

    [SerializeField]
    public float x;
    bool flag;  //true =grow, false = decrease
    
    // Start is called before the first frame update
    void Start()
    {
        flag = true;
        x=down;
    }

    // Update is called once per frame
    void Update()
    {
        if (x < up && flag) //when grow
        {
            x += EPS;
            transform.localScale = new Vector3(x, x, 0);
        }
        if (x >= up) //end grow
        {
            flag = false;
        }
        if (x > down && !flag) //when decrease
        {
            x -= EPS;
            transform.localScale = new Vector3(x, x, 0);
        }
        if (x <= down) //end decrease
        {
            flag = true;
        }

    }
}
