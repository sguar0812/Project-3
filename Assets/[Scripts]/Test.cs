using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{   
    public string name1 = "Santi";

    // Start is called before the first frame update
    bool answer1 = true && true;
    void Start()
    {
        Debug.Log(answer1);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello " + name1);
    }
}
