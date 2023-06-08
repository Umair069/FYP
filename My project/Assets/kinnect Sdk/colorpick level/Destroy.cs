using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject box;
    public int count =0;
    public randomSpawn script;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 boxPos = box.transform.position;
        if(boxPos == transform.position)
        {
            box.SetActive(false);
            
            script.spawn();

        }
    }
}
