using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclineHealth : MonoBehaviour, IDamage
{
    [SerializeField] private int health;
    public void TakeDamage()
    {
        //Declining health
        health--;

        //Destroys object (cylinder dies)
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
