using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePortal : MonoBehaviour
{
    Transform Portal;
    Transform White;
    [SerializeField] private AudioSource WhitePortalSound;
    private float _time;

    // Start is called before the first frame update
    void Start()
    {
       White = GameObject.Find("White").GetComponent<Transform>();
       GameObject child = this.gameObject.transform.GetChild(0).gameObject;
       Portal = child.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform == White)
        {
            White.position = Portal.position;
            _time = WhitePortalSound.clip.length;
            WhitePortalSound.Play();
            Destroy(gameObject,_time);
        }
    
    }
 
}
