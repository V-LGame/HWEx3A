using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Oscillator : MonoBehaviour
{
    public readonly int end = 6;
    public readonly double EPS = 0.0001;

    [SerializeField]
        private float rx; //end of right
        private float lx; //end of left
        private float x; //first position of x
        private double speed; //the speed
        private bool flag; //Indicates the direction of movement




    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
        rx = end + x;
        lx = -end + x;
                
        flag = true;
        speed = 3;
    }

    // Update is called once per frame
    void Update()
    {

        //If need to go right side.
        if (transform.position.x < this.rx && flag) {                               
            transform.Translate(new Vector3(end + ((float)(speed)), 0, 0) * Time.deltaTime);
            transform.Rotate(new Vector3(0, 0, end + ((float)(speed))) * Time.deltaTime);
        } 
        //If it reached the end right side.
        if (transform.position.x >= this.rx)
        {
            flag = false;

        }
        //If need to go left side.
        if (transform.position.x > this.lx && !flag)
        {
            //speed += 0.2;
            transform.Translate(new Vector3(-end - ((float)(speed)), 0, 0) * Time.deltaTime);
            transform.Rotate(new Vector3(0, 0, -end - ((float)(speed))) * Time.deltaTime);
                           
        }
        //If it reached the end right side.
        if (transform.position.x <= (this.lx))
        {
                           flag = true;
            
        }

    }



}
