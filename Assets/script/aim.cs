using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aim : MonoBehaviour
{
    //public float speed = 3f;
    public float moveSpeed = 10f;
    private float BoundRotation;
    private float BoundRotationRight;
    
    // Start is called before the first frame update
    void Start()
    {
         //gameObject obj = this.gameObject; 
         //Debug.Log(obj.gameObject.tag);
         //BoundRotation = transform.rotation.z*100f;  
         //codigo que jenny no va a ver por perezosa
         //así que te quitaré un punto y coma para que te falle
         //hack by kp
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag=="turret_right"){
            //-------------La rotacion va de 5 a 70, por cambio de pivot
            BoundRotationRight = (transform.rotation.z) * 100f;
            Debug.Log(BoundRotationRight); 
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //transform.Rotate(Vector3.forward * -moveSpeed * Time.deltaTime);

                if (BoundRotationRight>=-40){
                    transform.Rotate(Vector3.forward * -moveSpeed * Time.deltaTime);
                }
                else
                {
                    Debug.Log("se salió del limite superior");
                }

            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                //transform.Rotate(Vector3.forward * moveSpeed * Time.deltaTime);

                if (BoundRotationRight<=-10)
                {
                    transform.Rotate(Vector3.forward * moveSpeed * Time.deltaTime);
                }
                else
                {
                    Debug.Log("se salió del limite inferior");
                }
            }             
        } 
        //--------------------------------------------------------left right
        
        //Debug.Log(BoundRotation);
        if(gameObject.tag=="turret_left"){
            BoundRotation = transform.rotation.z*100f;
            //-------------La rotacion va de 5 a 70, por cambio de pivot
            //Debug.Log(); 
            if (Input.GetKey(KeyCode.W))
            {
                if(BoundRotation<=40){
                    transform.Rotate(Vector3.forward * moveSpeed * Time.deltaTime);
                }
                else
                {
                    Debug.Log("se salió del limite superior");
                }
                
            }
            if (Input.GetKey(KeyCode.S))
            {
                if(BoundRotation>=10)
                {
                    transform.Rotate(Vector3.forward * - moveSpeed * Time.deltaTime);
                }
                else
                {
                    Debug.Log("se salió del limite inferior");
                }
            }             
        }

        
    }
}
