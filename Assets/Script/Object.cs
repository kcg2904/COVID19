using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.ExceptionServices;
using Unity.Collections;

public class Object : MonoBehaviour
{
    public GameObject prefab;
    private Rigidbody2D ri;
    private float dt = 0.2f;
    private float nt = 0.0f;

    void a(float x)
    {
        Instantiate(prefab, new Vector3(x, 28.6f, 0), Quaternion.identity).name = x.ToString();
        

    }
    void Start()
    {
        ri = GetComponent<Rigidbody2D>();
 
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "qur")
        {
            Debug.Log("qur부닥침");
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "123")
        {
            Debug.Log("123");
            ri.simulated = false;
        }
    }

   void Update()
   {
            if (Time.time > nt)
            {
                nt = Time.time + dt;
                float x = Random.Range(-60f, 60f);
                int g = Random.Range(1, 10);
                ri.gravityScale = g;
                a(x);
            }

    }
}
