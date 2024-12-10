using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float bulletSpeed;
    [SerializeField] Camera cam;
    Rigidbody rb;
    void Start()
    {

        transform.Rotate(0, -90, -1*cam.transform.rotation.eulerAngles.x);
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.right * bulletSpeed);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
