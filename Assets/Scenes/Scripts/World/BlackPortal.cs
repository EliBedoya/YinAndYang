using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackPortal : MonoBehaviour
{
    [SerializeField] Transform [] Portal;
    [SerializeField] Transform Black;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform == Black)
        {
            Black.position = Portal[1].position;
            Destroy(gameObject);
        }
    
    }
 
}

