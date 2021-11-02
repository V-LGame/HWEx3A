using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    [SerializeField]
    bool flag;
    // Start is called before the first frame update
    void Start()
    {
        flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !flag)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
            flag = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && flag)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            flag = false;
        }
    }
}
