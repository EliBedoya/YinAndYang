using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackLife : MonoBehaviour
{
    bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == true)
        {
            SceneManager.LoadScene("Level2");
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag != "Negro" && col.gameObject.tag != "Player" && col.gameObject.tag != "Wall")
        {
            isDead = true;
        }
    }

}

