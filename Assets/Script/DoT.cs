using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DoT : MonoBehaviour
{

    public Text TitleText1;
    public Text TitleText2;
    public Text TitleText3;
    public Text TitleText4;

    public AudioClip sound1;
    
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        StartCoroutine("TextPrint");

        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public IEnumerator TextPrint()
    {
        TitleText1.DOFade(255, 1f);
        audioSource.PlayOneShot(sound1);

        yield return new WaitForSeconds(1);

        TitleText2.DOFade(255, 1f);
        audioSource.PlayOneShot(sound1);

        yield return new WaitForSeconds(1);

        TitleText3.DOFade(255, 1f);
        audioSource.PlayOneShot(sound1);

        yield return new WaitForSeconds(1);

        TitleText4.DOFade(255, 1f);
        audioSource.PlayOneShot(sound1);

        yield return new WaitForSeconds(1);

        audioSource.Play();

    }

    
}
