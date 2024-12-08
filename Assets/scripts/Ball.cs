using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * speed,
            Space.World);
        if (transform.position.z <= Camera.main.transform.position.z-10)
        {
            Destroy(this);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("player"))
        {
            FindObjectOfType<GameManager>().EndLife();
        }
    }

    public void destroyTheBall()
    {
        GameManager.score++;
        Debug.Log(GameManager.score);
        Destroy(gameObject);
    }


}
