using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eagle : MonoBehaviour
{
    //float�^��ϐ�moveState�Ő錾���܂��B
    public float moveState;
    //float�^��ϐ�speed�Ő錾���܂��B
    public float speed;
    //Vector3�^��ϐ�vector�Ő錾���܂��B
    Vector3 vector;

    // Start is called before the first frame update
    void Start()
    {
        //�����ʒu��ۑ����܂��B
        vector = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //x���Ɉړ�����ړ��͈͂ƃX�s�[�h�̌v�Z�����܂��B
        float y = moveState * Mathf.Sin(Time.time * speed);
        //������ꂽ���l������x���̃|�W�V���������肵�܂��B
        transform.localPosition = vector + new Vector3(0, y, 0);
    }
}
