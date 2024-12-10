using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public Vector3 direction;
    [SerializeField] float speed;
    [SerializeField] float jumpHeight;
    [SerializeField] bool grounded;
    void Start()
    {
        grounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = Quaternion.Euler(0,transform.rotation.eulerAngles.y,0) * direction * speed;
    }

    public void jump() {
        if (Input.GetKey(KeyCode.Space) && grounded) {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.tag.Equals("enemy"))
        {
            grounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (!collision.gameObject.tag.Equals("enemy"))
        {
            grounded = false;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (!collision.gameObject.tag.Equals("enemy"))
        {
            grounded = true;
        }
    }

}
