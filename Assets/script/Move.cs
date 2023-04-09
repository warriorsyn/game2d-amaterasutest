using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform character;
    public Rigidbody2D characterBody;

    public Animator animator;
    public float vel = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<Transform>();
        characterBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("breathing", false);
            animator.SetBool("walking", true);

            animator.transform.Translate(new Vector2(vel * Time.deltaTime, 0));
        }
        else if(Input.GetKey(KeyCode.A))
        {
            animator.SetBool("breathing", false);
            animator.SetBool("walking", true);

            animator.transform.Translate(new Vector2(-(vel * Time.deltaTime), 0));

        }
        else
        {
            animator.SetBool("breathing", true);
            animator.SetBool("walking", false);

        }
    }
}
