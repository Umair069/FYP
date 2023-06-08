using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;

public class randomSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cubePrefab;
    public Destroy script;
    private GameObject temp;
    public Text Score;
    private int gameScore = 0;
    
   

    public void spawn()
    {
        gameScore++;
        Score.text =  gameScore.ToString();
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-1.4f, -1.2f), 0.9037f, Random.Range(0.4f, 0.2f));
        script.box = Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        script.box.SetActive(true);
    }
}
