using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public GameObject projectile;
    public Transform fireTransform;
    public float launchVelocity = 700f;

    private void Start()
    {
        InvokeRepeating("Shoot", 2, 2);
    }

    void Shoot()
    {
        GameObject ball = Instantiate(projectile, fireTransform.position,
                                                      fireTransform.rotation);
        ball.GetComponent<Rigidbody>().AddForce(ball.transform.forward * launchVelocity);
    }
}
