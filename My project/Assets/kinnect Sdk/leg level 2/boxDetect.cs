using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxDetect : MonoBehaviour
{
    public GameObject cube;
    public Text score;
    private int gameScore = 0;
    
    public randomBoxSpawn script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Box")

        {
            gameScore = gameScore + 1;
            score.text = gameScore.ToString();
            cube.SetActive(false);
            
            script.Invoke("spawn", 2);
        }
    }
}

