using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class highScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject texty;
    float high;
    void Start()
    {
        high = loadData();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (texty.GetComponent<ScoreScript>().getScore() > PlayerPrefs.GetFloat("highScore")) { 
            saveData();
        }
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "highscore: " + high;
    }

    public void saveData() {
        PlayerPrefs.SetFloat("highScore", texty.GetComponent<ScoreScript>().getScore());
    }

    public float loadData() {
        return PlayerPrefs.GetFloat("highScore");
    }

}
