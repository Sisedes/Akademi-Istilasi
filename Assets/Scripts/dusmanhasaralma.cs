using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanhasaralma : MonoBehaviour
{
    public static float dusmansayýsý = 8;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "atestopu")
        {
            dusmansayýsý--;
            gameObject.SetActive(false);
        }
    }
}
