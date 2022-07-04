using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeterito : MonoBehaviour
{
    GameObject cube;
    Vector3 m_Size;

    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Collider from the GameObject
        Collider m_Collider = GetComponent<Collider>();

        //Fetch the size of the Collider volume
        m_Size = m_Collider.bounds.size;
        m_Size = m_Size / 2;

        //Output to the console the size of the Collider volume
        Debug.Log("Collider Size : " + m_Size);

        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 randomPos = new Vector3(Random.Range(-m_Size.x, m_Size.x), 0, Random.Range(-m_Size.x, m_Size.z));
        Instantiate(cube, randomPos, Quaternion.identity);
    }
}
