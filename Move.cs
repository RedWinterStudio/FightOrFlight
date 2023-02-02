using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movement : MonoBehaviour{
    // Start is called before the first frame update;
    
    float roll = 0;
    float pitch = 0;
    float yaw = 0;

    void Start()
    {
	Vector3 Rotation = new Vector3(0, 0, 0);
    }

    // Update is called once per frame;
    void Update()
    {

        Vector3 Rotation(roll, yaw, pitch);
            //inputs;
        if (Input.GetKey("A"))
            yaw = yaw - (2 * Time.deltaTime);
        if (Input.GetKey("D"))
            yaw = yaw + (2 * Time.deltaTime);
        if (Input.GetKey("S"))
            pitch = pitch + (2 * Time.deltaTime);
        if (Input.GetKey("W"))
            pitch = pitch - (2 * Time.deltaTime);
        if (Input.GetKey("Left"))
            roll = roll - (2 * Time.deltaTime);
        if (Input.GetKey("Right"))
            roll = roll + (2 * Time.deltaTime);
            //here is where it actually moves;
        transform.position = (3, 0, 0);
        transform.localEulerAngles = (roll, yaw, pitch);
            //boolets;
        if (Input.GetKey("Up"))
            Debug.Log("Banana");
                //add staple instantieatio n;
        if  (Input.GetKey("Down"))
            Debug.Log("banana");
                //Torpedo? Maybe?;
            //done?;
            // p e r h a p s;

            
            //this is where the code goes.;
    }
}