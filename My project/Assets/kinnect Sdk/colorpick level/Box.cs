using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Box : MonoBehaviour
{
    
    public GameObject handRight;
    
    public GameObject basket;
    public GameObject empty;
    
    public int count = 0;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 basketPos = basket.transform.position;
        Vector3 handPos = handRight.transform.position;
        Vector3 emptyPos = empty.transform.position;
     
        if (Vector3.Distance(handPos, transform.position) < 0.4f)
        {
            transform.position = new Vector3(handPos.x, handPos.y, handPos.z);
        }
       
        if (Vector3.Distance(basketPos, transform.position) < 0.5f)
        {

            transform.position = empty.transform.position;
            

        }
        
       


    }
}
