using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    private float velocidad = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sunRotatio()
    {
        transform.rotation *= Quaternion.Euler(new Vector3(0, velocidad, 0));
    }
}
