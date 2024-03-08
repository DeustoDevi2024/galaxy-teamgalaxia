using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    private float velocidad = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sunRotation();
    }
    public void sunRotation()
    {
        this.transform.Rotate(new Vector3(0, velocidad, 0));
    }
}
