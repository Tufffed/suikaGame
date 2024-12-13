using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combine : MonoBehaviour
{
    public GameObject me;
    public GameObject other;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (me.GetComponent<CircleCollider2D>().IsTouching(other.GetComponent<CircleCollider2D>()))
        {
            Debug.Log("working");
        }
    }
}
