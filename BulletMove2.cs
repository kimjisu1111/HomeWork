using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove2 : MonoBehaviour
{
    public float time;
    public float deadLine = 4.0f;
    private Vector3 vecHome;
    public float misileTime;
    public float waitingTime = 0.05f;
    public float moveSpeed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        vecHome.Set(0.2f, -4f, 0f);  // 우측미사일 초기 위치 설정
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 0.03f) {
            var spr = GetComponent<SpriteRenderer>();
            spr.color = new Color(Random.Range(0.0f, 100f), Random.Range(0.0f, 1f), Random.Range(0.0f, 1f), Random.Range(0.0f, 1f));
            time = 0;
        }  //색깔 바꾸기

        Vector3 vec = transform.position;



        if (Input.GetKey(KeyCode.W))
        {
            vecHome.y += 0.1f;
            vecHome = new Vector3(vecHome.x, vecHome.y, vecHome.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            vecHome.y += -0.1f;
            vecHome = new Vector3(vecHome.x, vecHome.y, vecHome.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            vecHome.x += 0.1f;
            vecHome = new Vector3(vecHome.x, vecHome.y, vecHome.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            vecHome.x += -0.1f;
            vecHome = new Vector3(vecHome.x, vecHome.y, vecHome.z);
        }


        if (vec.y > deadLine)
        {
            transform.position = new Vector3(vecHome.x, vecHome.y, vecHome.z);
        }

        misileTime += Time.deltaTime;

        if (misileTime > waitingTime)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            misileTime = 0;
        }

    }
}
