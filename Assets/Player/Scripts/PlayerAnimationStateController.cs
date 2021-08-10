using UnityEngine;

public class PlayerAnimationStateController : MonoBehaviour
{
    private Animator animator;
    private InputManager inputManager;

    private int velocityHash;

    void Start()
    {
        animator = GetComponent<Animator>();
        inputManager = InputManager.Instance;
    }

    void Update()
    {
        if (inputManager.PlayerIsMovingThisFrame())
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }


}
