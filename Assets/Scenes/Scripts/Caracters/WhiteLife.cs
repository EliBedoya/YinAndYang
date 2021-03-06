using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhiteLife : MonoBehaviour
{
    public bool isDead = false;
    ParticleSystem WhiteExplotion;

    SpriteRenderer WhiteBody;

    WhiteMovement WhiteWalking;
    [SerializeField]
    private AudioSource DeathWhiteSound;
    // Start is called before the first frame update
    void Start()
    {
        GameObject child = this.gameObject.transform.GetChild(0).gameObject;
        WhiteExplotion = child.GetComponent<ParticleSystem>();
        WhiteBody = GetComponent<SpriteRenderer>();
        WhiteWalking = GetComponent<WhiteMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == true)
        {
            Scene scene = SceneManager.GetActiveScene(); 
            SceneManager.LoadScene(scene.name);
        }
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag != "Blanco" && col.gameObject.tag != "Player" && col.gameObject.tag != "Wall")
        {
            DeathWhiteSound.Play();
            isDead = true;
           
            WhiteBody.enabled = false;
            WhiteWalking.enabled = false;
            WhiteExplotion.Play(true);

        }
    }
    
}
