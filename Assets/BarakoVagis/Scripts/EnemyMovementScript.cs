using UnityEngine;
using System.Collections;

public class EnemyMovementScript : MonoBehaviour {

    public Transform targetA;
    public Transform targetB;
    public Transform currentTarget;
    public float speed;
    public float rotationSpeed;
    void Update()
    {
        if (currentTarget == null)
        {
            currentTarget = targetA;
        }
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, step);
        Vector3 vectorToTarget = currentTarget.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag != "Player")
        {
            StartCoroutine(ChangeDirection());
        }
    }

    IEnumerator ChangeDirection()
    {
        float tempSpeedNote = speed;
        speed = 0;
        yield return new WaitForSeconds(3);
        speed = tempSpeedNote;
        currentTarget = currentTarget == targetA ? targetB : targetA;
    }
}
