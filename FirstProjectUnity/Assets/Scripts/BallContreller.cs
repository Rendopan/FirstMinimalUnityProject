using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallContreller : MonoBehaviour
{
    public float speed;

    private float hInput, vInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.position += new Vector3(hInput * speed * Time.deltaTime, 0, 0);
    }
}
