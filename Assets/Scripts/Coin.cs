using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Character"))
        {
            coinValue++;
            Destroy(gameObject);
            ScoreManager.instance.ChangeScore(coinValue);
        }
    }
}
