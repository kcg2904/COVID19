using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject p;
    public Vector2 po;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "4")
        {
           
        }        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        po = p.transform.position;
    }
}
