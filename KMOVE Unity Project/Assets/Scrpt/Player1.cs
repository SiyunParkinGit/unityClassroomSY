using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 postionVector = new Vector3(GetComponent<Transform>().position.x + h, GetComponent<Transform>().position.y + v, GetComponent<Transform>().position.z);
        this.transform.position = postionVector;
       

    }
}
