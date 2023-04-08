using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        else if (collision.CompareTag("goblin") || collision.CompareTag("Serseri") || collision.CompareTag("gunMan"))
        {
            Destroy(gameObject);
        }
    }
}
