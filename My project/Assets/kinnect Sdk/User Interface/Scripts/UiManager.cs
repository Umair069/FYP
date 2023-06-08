using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UiManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void playGame()
    {
        SceneManager.LoadScene("Exercises");
        Debug.Log("Hi");
    }
    public void legsLevel()
    {
        SceneManager.LoadScene("Legs");
    }
    public void armsLevel()
    {
        SceneManager.LoadScene("Arms");
    }

    public void backToExcercise()
    {
        SceneManager.LoadScene("Exercises");
    }
    public void quitGame()
    {
        Application.Quit();
    }

    public void SpaceShipLevel()
    {
        SceneManager.LoadScene("SpaceShip");
    }
    public void legsCube()
    {
        SceneManager.LoadScene("legLevel");
    }
    public void FootBallLevel()
    {
        SceneManager.LoadScene("ball");
    }

    public void ColorPickLevel()
    {
        SceneManager.LoadScene("colorlevel");
    }
    // Update is called once per frame

    public void restartLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
       
        SceneManager.LoadScene(scene.name);
        
    }
    void Update()
    {
        
    }
}
