using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackPortal : MonoBehaviour
{
    [SerializeField] Transform Portal;
     Transform Black;
    [SerializeField] private AudioSource BlackPortalSound;
    private float _time;
    // Start is called before the first frame update
    void Start()
    {
       Black = GameObject.Find("Black").GetComponent<Transform>();
       GameObject child = this.gameObject.transform.GetChild(0).gameObject;
       Portal = child.transform;
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        if (collision.transform == Black)
        {
            
            Black.position = Portal.position;
            _time=BlackPortalSound.clip.length;
            BlackPortalSound.Play();
             Destroy(gameObject,_time);
            
            
            
        }
    
    }
 
}

