using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomBoxSpawn : MonoBehaviour
{
    public GameObject cubePrefab;
    public boxDetect script;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }

    public void spawn()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-1.665f, -2.412f), 0.275f, Random.Range(0.505f, 0.703f));
        script.cube =Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        script.cube.SetActive(true);
        
    }

}
