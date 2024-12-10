using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;
        if (Input.GetKey(KeyCode.A)) {
            dir += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            dir += Vector3.right;
        }
        if (Input.GetKey(KeyCode.W))
        {
            dir += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            dir += Vector3.back;
        }
        GetComponent<playerMovementScript>().direction = dir;
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<playerMovementScript>().jump();
        }
    }
}
