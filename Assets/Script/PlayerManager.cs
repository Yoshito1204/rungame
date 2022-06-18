using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public PlayerController chara;
    public static bool gameOver;
    public GameObject gameOverPanel;
    AudioSource audioSource;

    public static bool isGameStarted;

   // public static int numberOfPapers;
    //public Text papersText;
    //public Life lifePanel;
    public TextMeshProUGUI scoreText;
   

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            audioSource.Stop();
        }
        else
        {
            gameOverPanel.SetActive(false);
            
        }

        int score = Score();
        scoreText.text = "Score : " + score + "m";




        
        isGameStarted = true;

    }

    int Score()
    {
        return (int)chara.transform.position.z;
    }
}
