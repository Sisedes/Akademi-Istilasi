using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class CharacterControls : MonoBehaviour
{
    [SerializeField] float runspeed;
    [SerializeField] float walkspeed;
    private Rigidbody2D rb;
    Animator animator;
    public bool left;
    [SerializeField] GameObject bulletPrefab;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        left = false;
    }
   
    void Update()
    {
        Movement();
        Animate();
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 shootDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            // Mermi prefabýnýn yönünü karakterin baktýðý yöne göre ayarla
            if (shootDirection.x < 0)
            {
                bullet.transform.localScale = new Vector3(-1, 1, 1);
            }
            else
            {
                bullet.transform.localScale = new Vector3(1, 1, 1);
            }

            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection.normalized * 10f;
            Destroy(bullet, 5f);
        }

    }

    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(horizontalInput * walkspeed, verticalInput * walkspeed);

       
    }

    void Animate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        animator.SetFloat("Speed", Mathf.Abs(horizontalInput) + Mathf.Abs(verticalInput));

        if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            left = true;
        }
        else if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            left = false;
        }
    }

   
}
