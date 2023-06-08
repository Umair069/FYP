using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    
    private Vector3 spawnPosition;
    public KickLogic script;
    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Box")
        {
            transform.position = spawnPosition;
            script.Kick = false;
            
        }
        
    }
}
