using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("player")) {
            collision.gameObject.GetComponent<healthScripy>().gotHit();
        }
        if (collision.gameObject.tag.Equals("bullet")) { 

            gameObject.GetComponent<healthScripy>().gotHit();
            Destroy(collision.gameObject);
        }
    }

    public void gotHitMonster() {
        gameObject.GetComponent<healthScripy>().gotHit();
    }

}
