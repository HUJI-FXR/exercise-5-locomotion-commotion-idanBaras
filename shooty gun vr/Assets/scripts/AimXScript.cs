using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimXScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float sensitivity;
    [SerializeField] float x;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, x, 0);
    }
}
