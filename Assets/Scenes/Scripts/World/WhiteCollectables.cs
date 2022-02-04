using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteCollectables : MonoBehaviour
{
    WhiteUIControl whiteUIRef;
    [SerializeField]
    private AudioSource CoinWhiteSound;
    private float _time;

    // Start is called before the first frame update
    void Start()
    {
        whiteUIRef = GameObject.Find("WhiteUI").GetComponent<WhiteUIControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        
        whiteUIRef.counter+=1;
        _time = CoinWhiteSound.clip.length;
        CoinWhiteSound.Play();

        Destroy(gameObject,_time);

    }
        

}
