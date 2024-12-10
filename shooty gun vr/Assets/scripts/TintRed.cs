using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TintRed : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float curHP;
    [SerializeField] float initHP;
    [SerializeField] float lifeRate;
    [SerializeField] GameObject sphere;

    void Start()
    {
       sphere.GetComponent<Renderer>().material = Instantiate(GetComponent<Renderer>().material);
    }

    // Update is called once per frame
    void Update()
    {
        curHP = GetComponent<healthScripy>().getCurrentHealth();
        initHP = GetComponent<healthScripy>().getInitialHealth();
        lifeRate = curHP / initHP;
        sphere.GetComponent<Renderer>().material.color= lifeRate * Color.white + (1f - lifeRate) * Color.red;
    }
}
