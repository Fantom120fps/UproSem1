using UnityEngine;

public class CollisionPlayers : MonoBehaviour
{
    [SerializeField]
    private Transform parent;

    void Start()
    {
        foreach (Collider col in parent.GetComponentsInChildren<Collider>())
            Physics.IgnoreCollision(GetComponent<Collider>(), col);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponentInParent<IDamage>() != null)
        {
            if (GetComponentInParent<MoveRagdoll>().isAttack)
            {
                Vector3 direction = (collision.contacts[0].point - transform.position).normalized;
                direction.y = 0;

                collision.gameObject.GetComponentInParent<IDamage>().TakeDamage(direction, collision.contacts[0].point);
            }
        }
    }
}