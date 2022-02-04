using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCollectables : MonoBehaviour
{
    BlackUIControl blackUIRef;
    [SerializeField]
    private AudioSource CoinBlackSound;
    private float _time;

    // Start is called before the first frame update
    void Start()
    {
        blackUIRef = GameObject.Find("BlackUI").GetComponent<BlackUIControl>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        
        blackUIRef.counter+=1;
        _time=CoinBlackSound.clip.length;
        CoinBlackSound.Play();
        Destroy(gameObject,_time);
        
        
    }
        
}
