using UnityEngine;
using System.Collections;

public class EnemyMovementScript : MonoBehaviour {

    public Transform targetA;
    public Transform targetB;
    public Transform currentTarget;
    public float speed;
    void Update()
    {
        if (currentTarget == null)
        {
            currentTarget = targetA;
        }
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, step);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag != "Player")
        {
            currentTarget = currentTarget == targetA ? targetB : targetA;
        }

    }
}
