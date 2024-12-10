using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    [SerializeField] GameObject g;
    float health;

    // Start is called before the first frame update
    void Start()
    {
        health = g.GetComponent<healthScripy>().getCurrentHealth();
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "HP: " + health;
    }

    // Update is called once per frame
    void Update()
    {
        health = g.GetComponent<healthScripy>().getCurrentHealth();
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "HP: " + health;
    }
}
