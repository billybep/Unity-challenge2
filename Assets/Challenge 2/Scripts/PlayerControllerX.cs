using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float spawnDelay = 2.0f;
    private float timer = 1.0f;


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timer > spawnDelay)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timer = 1.0f;
            }
        }
        timer += Time.deltaTime;
    }
}
