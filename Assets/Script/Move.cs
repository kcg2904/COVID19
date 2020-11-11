using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public Text con;
    [SerializeField]private int cont = 3;
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "COVID")
        {
            cont -= 1;
            con.text = cont.ToString();
        }
        if (col.gameObject.tag == "Mask")
        {
            cont += 1;
            con.text = cont.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(5, 0));

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-5, 0));
        }
    }
}
