using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeterito : MonoBehaviour
{
    public GameObject meteorito;
    Vector3 m_Size;
    float countdown = 0;
    public float cooldown = 10; //En segundos

    // Start is called before the first frame update
    void Start()
    {
        //Fetch the Collider from the GameObject
        Collider m_Collider = GetComponent<Collider>();

        //Fetch the size of the Collider volume
        m_Size = m_Collider.bounds.size;
        m_Size = m_Size / 2;

        //Output to the console the size of the Collider volume
        //Debug.Log("Collider Size : " + m_Size);
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown <= 0)
        {
            Vector3 randomPos = new Vector3(Random.Range(-m_Size.x, m_Size.x) + gameObject.transform.position.x, gameObject.transform.position.y, Random.Range(-m_Size.x, m_Size.z));
            Instantiate(meteorito, randomPos, Quaternion.identity);
            countdown = cooldown;
        }
        else
        {
            countdown -= Time.deltaTime;
        }
    }
}
