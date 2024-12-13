using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject cherry;
    public GameObject strawberry;
    public bool first;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && first)
        {
            first = false;
            Instantiate(cherry);
        }
        else
        {
            first = true;
        }
    }
}
