using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeta2 : MonoBehaviour
{
    public float velocidad = 0.1f, velocidadDeGiro = 0.2f;
    public Transform punto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        venusRotation();
        venusRotationSun();
    }
    private void venusRotation()
    {
        transform.rotation *= Quaternion.Euler(new Vector3(0, velocidad, 0));
      
    }

    public void venusRotationSun()
    {
        this.transform.RotateAround(punto.transform.position, Vector3.up, velocidadDeGiro);
    }
}
