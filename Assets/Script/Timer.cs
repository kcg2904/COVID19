using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text tt;
    private float time;
    

    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        string[] ttt = time.ToString().Split('.');
        
        tt.text = ttt[0]+"."+ttt[1].Substring(0,2);
    }
}
