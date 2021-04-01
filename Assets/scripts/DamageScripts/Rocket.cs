using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour, IDamage
{
    //Just used to propel a rocket
    public void TakeDamage()
    {
        transform.position += new Vector3(0, +1, 0);
    }
}
