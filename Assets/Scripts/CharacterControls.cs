using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class CharacterControls : MonoBehaviour
{
    [SerializeField] float runspeed;
    [SerializeField] float walkspeed;
    Rigidbody2D CharacterRB;
    void Start()
    {
        CharacterRB=GetComponent<Rigidbody2D>();
    }

    void Move(Vector3 direction)
    {
        transform.position += direction * walkspeed * Time.deltaTime;
    }
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow))
        {
            Move(Vector3.up);
        }
        else if (Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.DownArrow))
        {
            Move(Vector3.down);
        }
        else if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
        {
            Move(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow))
        {
            Move(Vector3.right);
        }

    }
}
