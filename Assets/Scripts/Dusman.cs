using UnityEngine;
using UnityEngine.SceneManagement;

public class Dusman : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
            SceneManager.LoadScene(5); 
        }
    }
}
