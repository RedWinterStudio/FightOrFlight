using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainColliders : MonoBehaviour{

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Terrain")
            Destroy(gameObject); 
            
    }







}