using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]float turnspeed = 180f;
    [SerializeField]float movespeed = 18f;
    [SerializeField]float slowspeed = 13f;
    [SerializeField]float fastspeed = 27f;
    
    void Start()
    {
              
        
    }

    // Update is called once per frame
    void Update()
    {
        float turnspeedvalue = Input.GetAxis("Horizontal")*turnspeed*Time.deltaTime;
        float movespeedvalue = Input.GetAxis("Vertical")*movespeed*Time.deltaTime;
        transform.Rotate(0,0,-turnspeedvalue);
        transform.Translate(0,movespeedvalue,0);
    }

    void OnCollisionEnter2D(Collision2D other){
        movespeed = slowspeed;
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Boost"){
            movespeed = fastspeed;
        }
    }
}
