using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Animator Animator;
    public float Speed;
    public float Deadzone;

    void Start()
    {
        Animator = GetComponent<Animator>();
    }
    void Update()
    {
        var horizontalMovement = Input.GetAxis("Horizontal");
        var verticalMovement = Input.GetAxis("Vertical");

        var direction = new Vector2(horizontalMovement, verticalMovement);

        var moveUp = verticalMovement > Deadzone;
        var moveDown = verticalMovement < -Deadzone;
        var moveLeft = horizontalMovement < -Deadzone;
        var moveRight = horizontalMovement > Deadzone;


        Animator.SetBool("Up", moveUp);
        Animator.SetBool("Down", moveDown);
        Animator.SetBool("Left", moveLeft);
        Animator.SetBool("Right", moveRight);

        if ((moveUp || moveDown || moveLeft || moveRight) == true)
            transform.Translate(Speed * Time.deltaTime * direction);

        Debug.Log(direction);
    }
}