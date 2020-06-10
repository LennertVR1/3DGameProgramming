using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public float inputX;
    public float inputY;
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        inputY = Input.GetAxis("Vertical");
        inputX = Input.GetAxis("Horizontal");
        animator.SetFloat("InputY", inputY);
        animator.SetFloat("InputX", inputX);
    }
}
