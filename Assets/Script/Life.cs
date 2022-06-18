using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public GameObject[] lifes;

    /* //　ライフゲージ全削除＆HP分作成
     public void SetLifeGauge(int life)
     {
         //　体力を一旦全削除
         for (int i = 0; i < lifes.Length; i++)
         {
             Destroy(transform.GetChild(i).gameObject);
         }
         //　現在の体力数分のライフゲージを作成
         for (int i = 0; i < life; i++)
         {
             Instantiate<GameObject>(lifes, transform);
         }
     }
     //　ダメージ分だけ削除
     public void SetLifeGauge2(int damage)
     {
         for (int i = 0; i < damage; i++)
         {
             //　最後のライフゲージを削除
             Destroy(transform.GetChild(i).gameObject);
             //Destroy(transform.GetChild(transform.childCount - 1 - i).gameObject);
         }
     }*/

    public void UpdateLife(int life)
    {
        for (int i = 0; i < lifes.Length; i++)
        {
            if (i < life) lifes[i].SetActive(true);
            else lifes[i].SetActive(false);
        }

    }
}


