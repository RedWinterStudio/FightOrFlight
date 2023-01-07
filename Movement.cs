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
            if (Input.GetKey(KeyCode.Escape))
                paused = true;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            while (paused = true)
                if (Input.GetKey(KeyCode.Escape))
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
            
            
            //this is where the code goes.
}
}