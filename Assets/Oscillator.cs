using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Oscillator : MonoBehaviour
{
    public readonly int end = 6;
    public readonly double EPS = 0.0001;

    [SerializeField]
        private float rx;
        private float lx;
        private float x;
        private double speed;
        private bool flag;
    //private float z;




    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
        rx = end + x;
        lx = -end + x;
                
        flag = true;
        speed = 3;
        //speedl = -5;
    }

    // Update is called once per frame
    void Update()
    {


        if (transform.position.x < this.rx && flag) {                               
            transform.Translate(new Vector3(end + ((float)(speed)), 0, 0) * Time.deltaTime);
            transform.Rotate(new Vector3(0, 0, end + ((float)(speed))) * Time.deltaTime);
        } 

        if (transform.position.x >= this.rx)
        {
            flag = false;
            //speed = 2 * (-speed);
            //speed = 7;

        }
/*        else if (transform.position.x >= this.x - EPS && transform.position.x <= this.x + EPS)
        {

            speed = 20;
        }*/
        if (transform.position.x > this.lx && !flag)
        {
            //speed += 0.2;
            transform.Translate(new Vector3(-end - ((float)(speed)), 0, 0) * Time.deltaTime);
            transform.Rotate(new Vector3(0, 0, -end - ((float)(speed))) * Time.deltaTime);
            //z -= 2;
                           
        }
        if (transform.position.x <= (this.lx))
        {
                           flag = true;
            
        }

    }



}
