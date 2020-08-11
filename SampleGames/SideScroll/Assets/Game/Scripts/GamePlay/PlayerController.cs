using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationDamping = 20f;
    public float speed = 10f;
    public int gravity = 0;
    public Animator animator;

    private float verticalVel; // Used for continuing momentum while in air    
    private CharacterController controller;
    
    [SerializeField] private GameObject playerDeathEffect;
    
    [SerializeField] private AudioSource deathSE;

    private void Start()
    {
        controller = (CharacterController) GetComponent(typeof(CharacterController));
    }

    private float UpdateMovement()
    {
        // Movement
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        var inputVec = new Vector3(x, 0, z);
        inputVec *= speed;

        controller.Move((inputVec + Vector3.up * -gravity + new Vector3(0, verticalVel, 0)) * Time.deltaTime);

        // Rotation
        if (inputVec != Vector3.zero)
            transform.rotation = Quaternion.Slerp(transform.rotation,
                Quaternion.LookRotation(inputVec),
                Time.deltaTime * rotationDamping);

        return inputVec.magnitude;
    }

    private void AnimationControl()
    {
        if (Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d") || Input.GetKey("w"))
        {
            animator.SetBool("Moving", true);
        }
        else
        {
            animator.SetBool("Moving", false);
        }

        animator.SetBool("Angry", Input.GetKey("space"));

        animator.SetBool("Scared", Input.GetKey("mouse 0"));
    }

    private void Update()
    {
        UpdateMovement();
        AnimationControl();


        if (controller.isGrounded)
            verticalVel = 0f; // Remove any persistent velocity after landing
    }

    private void Dead()
    {
        deathSE.Play();
        var _effect = Instantiate(playerDeathEffect);
        _effect.transform.position = transform.position;
        
        gameObject.SetActive(false);
    }
}