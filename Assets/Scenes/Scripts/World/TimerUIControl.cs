using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerUIControl : MonoBehaviour
{
    public float sec;
    public float min;

    [SerializeField] Text seconds;
    [SerializeField] Text minutes;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sec < 10f)
        {
            seconds.text = ": 0" + sec.ToString("f0");
            minutes.text = min.ToString("f0");
        }

        else 
        {
            seconds.text = ": " + sec.ToString("f0");
            minutes.text = min.ToString("f0");
        }

        if (sec >= 0)
        {
            sec -= Time.deltaTime;
        }


        if (sec <= 0)
        {
            if (min > 0)
             {   
                min -= 1;
             }
            sec = 59;
        }

        if (sec <= 0 && min <= 0)
        {
            SceneManager.LoadScene("Level1");
        }
    }
    
}
