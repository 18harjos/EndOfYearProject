using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMove : MonoBehaviour
{
    public float speed = 8f;
    public float lifeDuration = 2f;

    private float lifeTimer;

    // Start is called before the first frame update
    void Start() //Creating a timer until the bullet is destroyed
    {
        lifeTimer = lifeDuration;
    }

    // Update is called once per frame
    void Update() //testing if the bullet has run out of time and if so destoying it
    {
        transform.position += transform.forward * speed * Time.deltaTime;

        lifeTimer -= Time.deltaTime;
        if (lifeTimer <= 0f)
        {
            Destroy(gameObject);

        }
     }
}
