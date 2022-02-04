using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhiteUIControl : MonoBehaviour
{
    public int counter;
    [SerializeField] Text counterText;

    [SerializeField] int counterLimit;

     LevelController levelC; 

    // Start is called before the first frame update
    void Start()
    {
        levelC = GameObject.Find("LevelController").GetComponent<LevelController>();
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = counter.ToString();

        if (counter >= counterLimit)
        {
            levelC.whiteReady=true;
        }
    }
}
