using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoritoMovement : MonoBehaviour
{
    Collider targetCollider;
    Vector3 targetPos;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        targetCollider = GameObject.FindGameObjectWithTag("TargetPlane").GetComponent<Collider>();

        Vector3 m_Size = targetCollider.bounds.size;
        m_Size = m_Size / 2;

        targetPos = new Vector3(Random.Range(-m_Size.x, m_Size.x), targetCollider.gameObject.transform.position.y, Random.Range(-m_Size.x, m_Size.z));
        print(targetPos);
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, targetPos, step);
    }
}
