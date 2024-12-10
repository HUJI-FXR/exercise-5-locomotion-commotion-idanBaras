using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScripy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float initialHealth;
    [SerializeField] float currentHealth;
    [SerializeField] TMPro.TextMeshProUGUI texty;
    [SerializeField] TMPro.TextMeshProUGUI textyEndy;
    [SerializeField] GameObject endCam;
    [SerializeField] GameObject myCam;
    float hit_timer;
    void Start()
    {
        currentHealth = initialHealth;
        hit_timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0) {
            if (gameObject.tag.Equals("enemy"))
            {
                texty.GetComponent<ScoreScript>().addScore();
            }
            if (gameObject.tag.Equals("player")) { 
                endCam.SetActive(true);
                myCam.SetActive(false);
                textyEndy.gameObject.SetActive(true);
                textyEndy.text = "you dead";
            }
            Destroy(gameObject);
        }
        hit_timer += Time.deltaTime;
    }

    public void gotHit() {
        if (hit_timer > 0.2) {
            currentHealth = currentHealth - 1;
            hit_timer = 0;
        }
    }

    public float getCurrentHealth() { 
        return currentHealth;
    }

    public float getInitialHealth()
    {
        return initialHealth;
    }

}
