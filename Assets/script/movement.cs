using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 3f;
    private Rigidbody2D rb;
    //private GameObject tank; 
    // Start is called before the first frame update
    void Start()
    {

        //tank = GetComponent<GameObject>();
        rb = GetComponent<Rigidbody2D>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag=="tank_left"){        
            if (Input.GetKey(KeyCode.D))
            {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            //Debug.Log("hola"+gameObject.tag);
            }
            if (Input.GetKey(KeyCode.A))
            {
            rb.velocity = new Vector2(- speed, rb.velocity.y);
            }
        }
        if(gameObject.tag=="tank_right"){ 
            if (Input.GetKey(KeyCode.RightArrow))
            {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            //Debug.Log("hola"+gameObject.tag);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
            rb.velocity = new Vector2(- speed, rb.velocity.y);
            }    
        }
        
    }
    /* void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
        {
            Debug.Log("Detected key code: " + e.keyCode);
        }
        ups aquí tambien te hackearon
    }*/
}
