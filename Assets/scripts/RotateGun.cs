using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGun : MonoBehaviour
{
    // Start is called before the first frame update
    public GrapplingGun grappling;

    private Quaternion DesiredRotation;
    private float rotationSpeed = 5f;


    private void Update()
    {
        if (!grappling.IsGrappling())
        {
            DesiredRotation = transform.parent.rotation;
        }

        else {
            DesiredRotation = Quaternion.LookRotation(grappling.GetGrapplePoint() - transform.position);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, DesiredRotation, Time.deltaTime * rotationSpeed);
    }
}
