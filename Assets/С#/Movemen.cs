using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemen : MonoBehaviour
{
    //�������� ���������
    public float speedBoxOne; //�������� ���������

    //��������� ������� ���������
    private float grvitiForse; //���������� ���������
    private Vector3 boxVector; //������������ ���������

    //������ �� ����������
    private CharacterController ch_BoxController;
    private Animation ch_BoxAnimation;


    private void Start()
    {
        ch_BoxController = GetComponent<CharacterController>();
        ch_BoxAnimation = GetComponent<Animation>();

    }

    //����� ����������� ���������
    private void BoxMove()
    {
     boxVector = Vector3.zero;
     boxVector.x = Input.GetAxis("Horizontal") * speedBoxOne;
     boxVector.z = Input.GetAxis("Vertical") * speedBoxOne;

    }

    
}