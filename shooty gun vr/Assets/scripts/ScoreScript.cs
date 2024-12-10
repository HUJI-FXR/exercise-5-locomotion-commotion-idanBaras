using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    float score;
    float killCount;
    [SerializeField] float NumEnemies;
    [SerializeField] float comboMult;
    [SerializeField] float comboDigrade;
    [SerializeField] TMPro.TextMeshProUGUI endy;
    [SerializeField] GameObject endCam;
    [SerializeField] GameObject myCam;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        killCount = 0;
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "score: " + score;
        comboMult = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (comboMult > 1)
        {
            comboMult -= Time.deltaTime * comboDigrade;
        }
        else {
            comboMult = 1;
        }
    }

    public void addScore() { 
        score+= comboMult;
        killCount++;
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "score: " + score;
        if (killCount == NumEnemies) {
            endCam.SetActive(true);
            myCam.SetActive(false);
            endy.gameObject.SetActive(true);
            endy.text = "you won!";
        }
        comboMult *= 2;
    }

    public float getScore() { 
        return score;
    }


}
