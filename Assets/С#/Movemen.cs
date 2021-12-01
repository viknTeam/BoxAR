using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemen : MonoBehaviour
{
    //�������� ���������
    public float speedBoxOne; //�������� ���������

    //��������� ������� ���������
    
    private Vector3 boxVector; //������������ ���������

    //������ �� ����������
    private CharacterController ch_BoxController;
    private Animator ch_BoxAnimation;


    private void Start()
    {
        ch_BoxController = GetComponent<CharacterController>();
        ch_BoxAnimation = GetComponent<Animator>();

    }
    private void Update()
    {
        BoxMove();
    }

    //����� ����������� ���������
    private void BoxMove()
    {
        boxVector = Vector3.zero;
        boxVector.x = -Input.GetAxis("Horizontal") * speedBoxOne;
        boxVector.z = -Input.GetAxis("Vertical") * speedBoxOne;

        if (boxVector.x != 0 || boxVector.z != 0)
            ch_BoxAnimation.SetBool("Move", true);
        else ch_BoxAnimation.SetBool("Move", false);
        
        if (Vector3.Angle(Vector3.forward, boxVector) > 1f)
        {
            Vector3 direct = Vector3.RotateTowards(transform.forward, boxVector, speedBoxOne, 0.0f);
            transform.rotation = Quaternion.LookRotation(direct);
        }

        ch_BoxController.Move(-boxVector * Time.deltaTime);// ����� �������� �� �����������

    }

    
}