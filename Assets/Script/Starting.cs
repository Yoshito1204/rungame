using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Starting : MonoBehaviour
{
    public static bool isGameStarted;
    public GameObject startingText;

    // Start is called before the first frame update
    void Start()
    {
        isGameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (SwipeManagement.tap)
        {
            isGameStarted = true;
            Destroy(startingText);
            SceneManager.LoadScene("FirstScene");
        }
    }
}
