using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeItem : MonoBehaviour
{
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("in", false);
        animator.SetBool("out", false);
    }

    public void MoveOut()
    {
        animator.SetBool("in", false);
        animator.SetBool("out", true);
    }

    public void MoveIn()
    {
        animator.SetBool("out", false);
        animator.SetBool("in", true);
    }
}
