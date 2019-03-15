using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlatform : MonoBehaviour
{

    public GameObject platform_prefab;
    float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 2) {
            GameObject p;
            p = Instantiate(platform_prefab, new Vector2(Random.Range(-9, 9), -6), Quaternion.identity);

            p.transform.localScale = new Vector2(Random.Range(3,8), 0.2f);

            timer = 0;
        }

    }
}
