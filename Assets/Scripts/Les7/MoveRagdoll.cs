using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRagdoll : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;
    [SerializeField]
    private float speedTurn = 1000;
    [SerializeField]
    private string nameH = "Horizontal";
    [SerializeField]
    private string nameV = "Vertical";
    [SerializeField]
    private KeyCode keyAttack;

    public bool isAttack = false;

    Animator animator;
    bool isMove = true;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void DisableMove()
    {
        isMove = false;
    }

    void Update()
    {
        if (isMove)
        {
            float move = Input.GetAxis(nameV) * speed * Time.deltaTime;
            float turn = Input.GetAxis(nameH) * speedTurn;

            if (move != 0 || turn != 0) animator.SetBool("isMove", true);
            else animator.SetBool("isMove", false);

            transform.Translate(0, 0, move);
            transform.Rotate(0, turn, 0);

            if (Input.GetKey(keyAttack))
                animator.SetTrigger("isAttack");
        }
    }
}
