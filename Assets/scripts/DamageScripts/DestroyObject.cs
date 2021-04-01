using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour, IDamage
{
    //Destroy Object
    public void TakeDamage()
    {
        Destroy(gameObject);
    }
}
