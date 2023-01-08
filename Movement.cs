using Photon.Pun;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

int roll = 0;
int pitch = 0;
int yaw = 0;
bool paused = false;

public class Movement : MonoBehaviourPunCallbacks{

    void start(){
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void update(){
        if (photonView.IsMine)
            //cursor locking/unlocking
            if (Input.GetKey(KeyCode.Escape))
                paused = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            while (paused = true)
                if (Input.GetKey(KeyCode.Escape))
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
            //inputs
            if (Input.GetKey("A"))
                yaw = yaw - (2 * Time.DeltaTime);
            if (Input.GetKey("D"))
                yaw = yaw + (2 * Time.DeltaTime);
            if (Input.GetKey("S"))
                pitch = pitch + (2 * Time.DeltaTime);
            if (Input.GetKey("W"))
                pitch = pitch - (2 * Time.DeltaTime);
            if (Input.GetKey("Left"))
                roll = roll - (2 * Time.DeltaTime);
            if (Input.GetKey("Right"))
                roll = roll + (2 * Time.DeltaTime);
            //here is where it actually moves
            transform.position = (3, 0, 0);
            transform.localEulerAngles = (roll, yaw, pitch);
            //boolets
            if (Input.GetKey("Up"))
                //add staple instantieatio n
            if  (Input.GetKey("Down"))
                //Torpedo? Maybe?
            //done?
            // p e r h a p s

            
            //this is where the code goes.
}
}