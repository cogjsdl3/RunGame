using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    
    void Start()
    {
        
    }
    public float speed = 10f;
   
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
