using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float monsterTimer;
    [SerializeField] float monsterTime;
    [SerializeField] float rotationSpeed;
    [SerializeField] GameObject player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (monsterTimer >= monsterTime)
        {
            monsterTimer = 0;
            float rnd = Random.Range(0f, 1f);
            if (rnd > 0.5)
            {
                transform.Rotate(0, Random.Range(0f, 360f), 0);
            }
        }
        else
        {
            monsterTimer += Time.deltaTime;
            Vector3 direction = Vector3.forward;
            GetComponent<playerMovementScript>().direction = direction;
            Vector3 playerDir = player.transform.position - transform.position;
            float angle = Vector3.AngleBetween(playerDir, transform.forward);
            transform.Rotate(0, angle * rotationSpeed * Time.deltaTime, 0);
        }

    }
}
