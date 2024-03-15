using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeta2 : MonoBehaviour
{
    public float velocidadDeGiro = 0.2f;
    private float velocidad = 0.1f;
    public Transform punto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        planetRotation();
        planetRotationSun();
    }
    private void planetRotation()
    {
        transform.rotation *= Quaternion.Euler(new Vector3(0, velocidad, 0) * Time.deltaTime);
      
    }

    public void planetRotationSun()
    {
        this.transform.RotateAround(punto.transform.position, Vector3.up, velocidadDeGiro * Time.deltaTime);
    }
}
