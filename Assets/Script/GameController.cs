using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{

    public CharaMove chara;
    public TextMeshProUGUI scoreText;
    


    // Update is called once per frame
    void Update()
    {
        int score = Score();
        scoreText.text = "Score : " + score + "m";

        
    }

    int Score()
    {
        return (int)chara.transform.position.z;
    }
}
