using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyGamePlayerController : MonoBehaviour
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
        var z = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        var inputVec = new Vector3(0, y, z);
        inputVec *= speed;

        controller.Move(inputVec * Time.deltaTime);

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
    }

    private void Dead()
    {
        deathSE.Play();
        var _effect = Instantiate(playerDeathEffect);
        _effect.transform.position = transform.position;
        
        gameObject.SetActive(false);
    }
}