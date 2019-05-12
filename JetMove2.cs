using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetMove2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 vec = transform.position;
            vec.y += 0.1f;
            transform.position = new Vector3(vec.x, vec.y, vec.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 vec = transform.position;
            vec.y += -0.1f;
            transform.position = new Vector3(vec.x, vec.y, vec.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 vec = transform.position;
            vec.x += 0.1f;
            transform.position = new Vector3(vec.x, vec.y, vec.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 vec = transform.position;
            vec.x += -0.1f;
            transform.position = new Vector3(vec.x, vec.y, vec.z);
        }
    }
}
