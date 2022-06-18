using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    //Vector3型を変数vectorで宣言します。
    Vector3 vector;

    //GameObject型を変数Targetで宣言します。
    public GameObject target;
    //float型を変数followSpeedで宣言します。
    public float followSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //位置をTargetの位置を元に設定するよ。
        vector = target.transform.position - transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        //位置を取得してスピードも合わせていくよ。
        transform.position = Vector3.Lerp(
            transform.position,
            target.transform.position - vector,
            Time.deltaTime * followSpeed);
    }
}
