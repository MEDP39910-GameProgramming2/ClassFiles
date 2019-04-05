using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleLogic : MonoBehaviour
{

    bool hitButton;
    bool getKey;
    public GameObject key;

    // Start is called before the first frame update
    void Start()
    {
        hitButton = false;
        getKey = false;
        key.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if we have not hit the button
        if (!hitButton)
        {
            // wait until we hit the button
            if (collision.gameObject.tag == "button")
            {
                hitButton = true;
                // turn the key on
                key.SetActive(true);
                // turn button green to confirm it's been pressed
                collision.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            }
        }

        // if i have not collected the key
        if (!getKey)
        {
            // wait until we touch the key
            if (collision.gameObject.tag == "key")
            {
                getKey = true;
                // hide the key because we collected it
                key.SetActive(false);
            }
        }
        else
        {
            // once we get the key, we wait until we hit the door
            if (collision.gameObject.tag == "door")
            {
                // then turn it green and disable the collider so we can pass through
                collision.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
                collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }
}

