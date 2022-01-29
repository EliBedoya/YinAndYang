using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackLife : MonoBehaviour
{
    public bool isDead = false;
    ParticleSystem BlackExplotion;

    SpriteRenderer BlackBody;

    BlackMovement BlackWalking;
    [SerializeField] 
    private AudioSource DeathBlackSound ;
    // Start is called before the first frame update
    void Start()
    {
        GameObject child = this.gameObject.transform.GetChild(0).gameObject;
        BlackExplotion = child.GetComponent<ParticleSystem>();
        BlackBody = GetComponent<SpriteRenderer>();
        BlackWalking = GetComponent<BlackMovement>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag != "Negro" && col.gameObject.tag != "Player" && col.gameObject.tag != "Wall")
        {
            
            DeathBlackSound.Play();
            isDead = true;
            BlackBody.enabled = false;
            BlackWalking.enabled = false;
            BlackExplotion.Play(true);
            
        }

        

    }

}

