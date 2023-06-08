using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WayPoints : MonoBehaviour
{
    public GameObject[] waypoints;   
    int current = 0;
    public float speed;
    public KickLogic script;
   
    void Update()
    {
        if(script.Kick == true)
        {
            speed = 4;
            Vector3 newPos = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, speed * Time.deltaTime);
            transform.position = newPos;
            
           
        }
        
      

     
    }

   
}
