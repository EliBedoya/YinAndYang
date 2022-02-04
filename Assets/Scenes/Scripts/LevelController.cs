using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public bool blackReday;
    public bool whiteReady;

    public bool blackOnDoor;

    public bool whiteOnDoor;
    [SerializeField]string level;

    [SerializeField] Animator [] doors;
    [SerializeField] private AudioSource backgroundSound;
    // Start is called before the first frame update
    void Start()
    {
        backgroundSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (blackReday == true)
        {
            doors[0].SetBool("BlackCollectablesReady",true);
        }

         if (whiteReady == true)
        {
            doors[1].SetBool("WhiteCollectablesReady",true);
        }

        if (blackOnDoor == true && whiteOnDoor == true)
        {
            SceneManager.LoadScene(level);

        }
    }
}
