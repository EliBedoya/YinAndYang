using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeIn : MonoBehaviour
{
    BlackLife blackDead;
    WhiteLife whiteDead;
    Animator Transition;

    bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        Transition = this.GetComponent<Animator>();
        blackDead = GameObject.Find("Black").GetComponent<BlackLife>();
        whiteDead = GameObject.Find("White").GetComponent<WhiteLife>();
    }

    // Update is called once per frame
    void Update()
    {
        if (blackDead.isDead == true || whiteDead.isDead == true)
        {
            isDead = true;
        }


        if (isDead == true)
        {
            Transition.SetBool("Dead",true);
        }
    }

    public void ResetLevel()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);

    }
}
