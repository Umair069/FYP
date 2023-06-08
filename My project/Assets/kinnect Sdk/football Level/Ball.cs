using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public KickLogic script;
    public Rigidbody rb;
   
    int thrust = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(script.Kick == true)
        {
            Debug.Log(script.Kick);
            rb.AddForce(0, 0, thrust, ForceMode.Impulse);
            

        }
       
    }
}
