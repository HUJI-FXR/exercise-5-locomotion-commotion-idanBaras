using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimYScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float sensitivity;
    [SerializeField] float y;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y = Mathf.Clamp(y + Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime, -90,90);
        transform.rotation = Quaternion.Euler(-y, transform.eulerAngles.y, 0);
    }
}
