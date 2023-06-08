using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    Scene scene;
    public GestureListener script;
    private Rigidbody rb;
    private float spaceShipSpeed = 0;
    public Text score;
    private float gameScore = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            SceneManager.LoadScene(0);
            Debug.Log("Collided");
        }


    }

    // Update is called once per frame
    void Update()
    {
        gameScore += Time.deltaTime;
        int convertedScore = Mathf.RoundToInt(gameScore);
        score.text = convertedScore.ToString();

        if (script.userDetected == true)
        {
            
            spaceShipSpeed = 2f;
            Vector3 vel = rb.velocity;
            if (script.swipeRight == true)
            {
                vel.x = 2 * 2;
                script.swipeRight = false;
            }
            else if(script.swipeLeft == true)
            {
                vel.x = -2 * 2;
                script.swipeLeft = false;
            }
            
                
                vel.z = spaceShipSpeed;
                rb.velocity = vel;

            
          
           

        }
    }
}
