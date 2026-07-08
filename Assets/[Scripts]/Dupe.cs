using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dupe : MonoBehaviour
{
    public GameObject cube;

    public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(cube, spawn.position, spawn.rotation);
    }
}
