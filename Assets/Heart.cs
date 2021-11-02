using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public readonly int up = 2;
    public readonly int down = 1;
    public readonly float EPS = 0.05f;

    [SerializeField]
    public float x;
    bool flag;
    // Start is called before the first frame update
    void Start()
    {
        flag = true;
        x=down;
    }

    // Update is called once per frame
    void Update()
    {
        if (x < up && flag)
        {
            x += EPS;
            transform.localScale = new Vector3(x, x, 0);
        }
        if (x >= up)
        {
            flag = false;
        }
        if (x > down && !flag)
        {
            x -= EPS;
            transform.localScale = new Vector3(x, x, 0);
        }
        if (x <= down)
        {
            flag = true;
        }


        //.rectTransform.sizeDelta = new Vector2(1, 1) * Time.deltaTime;
    }
}
