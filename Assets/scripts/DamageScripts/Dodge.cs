using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dodge : MonoBehaviour, IDamage
{
    //This makes enemy dodge
    public void TakeDamage()
    {

        transform.position += new Vector3(Random.Range(1, 10), 0, Random.Range(1, 10));
    }
}
