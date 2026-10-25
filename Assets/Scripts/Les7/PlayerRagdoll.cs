using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRagdoll : MonoBehaviour, IDamage
{
    RagdollHandler handler;
    MoveRagdoll moveRagdoll;
    Animator animator;

    private void Start()
    {
        handler = GetComponent<RagdollHandler>();
        animator = GetComponent<Animator>();
        moveRagdoll = GetComponent<MoveRagdoll>();

        handler.Initialize();
    }

    public void TakeDamage(Vector3 force, Vector3 hitPosition)
    {
        handler.Hit(force, hitPosition);
        EnableRagdoll();
    }

    private void EnableRagdoll()
    {
        animator.enabled = false;
        moveRagdoll.enabled = false;
        handler.Enable();
    }
}
