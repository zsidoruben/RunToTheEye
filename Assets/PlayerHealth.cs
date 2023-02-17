using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public  GameManager manager;
    public CapsuleCollider coll;
    public void Die()
    {
        coll.enabled = false;
        manager.Restart();
    }

}
