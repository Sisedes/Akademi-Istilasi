using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class CharacterControls : MonoBehaviour
{
    [SerializeField] float runspeed;
    [SerializeField] float walkspeed;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
   // void Move(Vector3 direction)
    //{
      //  transform.position += direction * walkspeed * Time.deltaTime;
    //}
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(horizontalInput * walkspeed, verticalInput * walkspeed);

    }
}
