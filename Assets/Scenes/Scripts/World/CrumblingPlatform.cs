using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrumblingPlatform : MonoBehaviour
{
    [SerializeField] float timer=1;
    Rigidbody2D crumblingPlatformRB;
    bool collision = false;
    private float _time;

    // Start is called before the first frame update
    void Start()
    {
        crumblingPlatformRB = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collision == true)
        {
            timer -= Time.deltaTime;
            _time =+ timer;

            Destroy(gameObject,_time);

        }

        if (timer <= 0)
        {
            crumblingPlatformRB.bodyType = RigidbodyType2D.Dynamic;
        }
    
    }


    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            Debug.Log ("colisioné");
            collision = true;
            
            
        }
    }
}
