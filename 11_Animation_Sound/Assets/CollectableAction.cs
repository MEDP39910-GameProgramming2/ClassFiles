using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableAction : MonoBehaviour
{

    AudioSource audioo;
    Collider2D c;
    SpriteRenderer s;
    Animator anim;
    float distance;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        audioo = GetComponent<AudioSource>();
        c = GetComponent<Collider2D>();
        s = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        distance = Vector2.Distance(player.transform.position, transform.position);
        anim.SetFloat("number", distance);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioo.Play();
        c.enabled = false;
        //s.enabled = false;
        anim.SetTrigger("isCollected");

    }

}
