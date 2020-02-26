using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            IRifle rifle = new BasicRifle();
            Debug.Log("Basic accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("s"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(rifle);
            Debug.Log("Scope Accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("t"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(new WithStabilizer(rifle));
            Debug.Log("Stabilizer + Scope Accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("l"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithLasers(rifle);
            Debug.Log("Laser: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown("u"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithBayonette(rifle);
            Debug.Log("Bayonette: " + rifle.GetAccuracy());
        }
    }
}
