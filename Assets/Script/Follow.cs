using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    //Vector3�^��ϐ�vector�Ő錾���܂��B
    Vector3 vector;

    //GameObject�^��ϐ�Target�Ő錾���܂��B
    public GameObject target;
    //float�^��ϐ�followSpeed�Ő錾���܂��B
    public float followSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //�ʒu��Target�̈ʒu�����ɐݒ肷���B
        vector = target.transform.position - transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        //�ʒu���擾���ăX�s�[�h�����킹�Ă�����B
        transform.position = Vector3.Lerp(
            transform.position,
            target.transform.position - vector,
            Time.deltaTime * followSpeed);
    }
}
