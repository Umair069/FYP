using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExcerciseTimer : MonoBehaviour
{
    private float ExcerciseTime = 0;
    public GameObject panel;
    public Text performance;
    public Text displayPerformance;
    public Text timer;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        ExcerciseTime = 20;
        
    }

    // Update is called once per frame
    void Update()
    {
        ExcerciseTime -= Time.deltaTime;
        int roundedTime = Mathf.RoundToInt(ExcerciseTime);
        timer.text = roundedTime.ToString();
        Debug.Log(roundedTime);
        if(roundedTime <= 0)
        {
            Time.timeScale = 0;
            panel.SetActive(true);
            int convertedScore  =  int.Parse(performance.text);
            if (convertedScore <= 10)
            {
                displayPerformance.text = "Performed: bad";
            }
            else if(convertedScore > 10 && convertedScore<= 20) {
                displayPerformance.text = "Performed: average";
            }
            else
            {
                displayPerformance.text = "Performed :good";
            }
           
            Debug.Log(convertedScore);
        }
    }
}
