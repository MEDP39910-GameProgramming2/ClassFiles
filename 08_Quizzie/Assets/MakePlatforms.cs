using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlatforms : MonoBehaviour
{

    public GameObject platform_prefab;
    float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 1;
        for (int i = 0; i < 10; i++) {
            Instantiate(platform_prefab, new Vector2(Random.Range(-20, 20), Random.Range(6.3f, -8.8f)), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0) {
            Instantiate(platform_prefab, new Vector2(20, Random.Range(6.3f, -8.8f)), Quaternion.identity);
            timer = 1;
        }

    }
}
