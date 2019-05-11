using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float time;
    
    public float misileTime;
    public float waitingTime = 0.1f;
    public float moveSpeed = 20f;
    public float deadLine = 4f;
    private Vector3 vecHome ;
   
    // Start is called before the first frame update
    void Start()
    {
        vecHome.Set(0.0f, -4f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            vecHome.x += 0.1f;
            vecHome = new Vector3(vecHome.x, vecHome.y, vecHome.z);
            
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            vecHome.x += -0.1f;
            vecHome = new Vector3(vecHome.x, vecHome.y, vecHome.z);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            vecHome.y += 0.1f;
            vecHome = new Vector3(vecHome.x, vecHome.y, vecHome.z);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            vecHome.y += -0.1f;
            vecHome = new Vector3(vecHome.x, vecHome.y, vecHome.z);

        }



        time += Time.deltaTime;
      
        if (time >= 0.03f)
        {
            time = 0.0f;
            var spr = GetComponent<SpriteRenderer>();
            spr.color = new Color(Random.Range(0,1f), Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        }

        misileTime += Time.deltaTime;

        if (misileTime > waitingTime)
                {
                    transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
                    misileTime = 0;
                }

        if(transform.position.y >= deadLine)
        {
            transform.position = new Vector3(vecHome.x, vecHome.y, vecHome.z);

        }

       
    }
}
