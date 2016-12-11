using UnityEngine;
using System.Collections;

public class SecurityCameraScript : MonoBehaviour
{

    public float speed = 1.5f;
    public float rotationZStart;
    public float rotationZEnd;
    Quaternion qStart, qEnd;
    private float startTime;

    void Start()
    {
        qStart = Quaternion.AngleAxis(rotationZStart, Vector3.forward);
        qEnd = Quaternion.AngleAxis(rotationZEnd, Vector3.forward);
    }

    void Update()
    {
        startTime += Time.deltaTime;
        transform.rotation = Quaternion.Lerp(qStart, qEnd, (Mathf.Sin(startTime * speed) + 1.0f) / 2.0f);
    }

}
