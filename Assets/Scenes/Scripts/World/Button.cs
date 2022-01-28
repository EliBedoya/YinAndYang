using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] GameObject portalOn;
    // Start is called before the first frame update

    private void OnTriggerStay2D(Collider2D other)
    {
        portalOn.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        portalOn.SetActive(false);
    }

}
