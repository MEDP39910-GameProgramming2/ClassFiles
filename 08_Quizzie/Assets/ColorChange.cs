using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    SpriteRenderer s;

    private void Start()
    {
        s = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Color c = collision.gameObject.GetComponent<SpriteRenderer>().color;
        s.color = c;
    }

}
