using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public bool canShoot = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && canShoot == true)
        {
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = transform.position;
            bulletObject.transform.forward = transform.forward;
                       
        }

    }


}
