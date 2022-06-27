using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            this.transform.forward = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
        }

        float h = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        Vector3 postionVector = new Vector3(h, 0, v);
        this.transform.position += postionVector;
       

    }
}