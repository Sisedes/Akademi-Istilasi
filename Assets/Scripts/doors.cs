using UnityEngine;
using UnityEngine.SceneManagement;

public class doors : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            if (collision.gameObject.CompareTag("Character"))
            {
                SceneManager.LoadScene(2);
            }
        }
        else if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            if (collision.gameObject.CompareTag("Character"))
            {
                SceneManager.LoadScene(4);
            }
        }
    }
}
