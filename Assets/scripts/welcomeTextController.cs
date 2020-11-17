using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class welcomeTextController : MonoBehaviour
{

    public GameObject playerPosition;
    public GameObject welcomeText;
    // Start is called before the first frame update
    void Start()
    {
              
    }

    // Update is called once per frame
    void Update() //destroying the text that is displayed after walking past a certain point
    {
        if (playerPosition.transform.position.x > 0)
        {
            print("reached 13");
            Destroy(welcomeText);
        }
    }
}
