using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovemenTwo : MonoBehaviour
{
    //�������� ���������
    public float speedBoxOne; //�������� ���������

    //��������� ������� ���������

    private Vector3 boxVector; //������������ ���������

    //������ �� ����������
    private CharacterController ch_BoxControllerTwo;
    private Animator ch_BoxAnimationTwo;
    private ControllerTwo bx_controllrtTwo;


    private void Start()
    {
        ch_BoxControllerTwo = GetComponent<CharacterController>();
        ch_BoxAnimationTwo = GetComponent<Animator>();
        bx_controllrtTwo = GameObject.FindGameObjectWithTag("JoystickTwo").GetComponent<ControllerTwo>();// �������� � ������� ��������
    }
    private void Update()
    {
        BoxMove();
    }

    //����� ����������� ���������
    private void BoxMove()
    {
        // ����������� �������� ������
        boxVector = Vector3.zero;
        boxVector.x = bx_controllrtTwo.Horizontal() * speedBoxOne;
        boxVector.z = -bx_controllrtTwo.Vertical() * speedBoxOne;

        if (boxVector.x != 0 || boxVector.z != 0)
            ch_BoxAnimationTwo.SetBool("MoveTwo", true);
        else ch_BoxAnimationTwo.SetBool("MoveTwo", false);

        if (Vector3.Angle(Vector3.forward, boxVector) > 1f)
        {
            Vector3 direct = Vector3.RotateTowards(transform.forward, boxVector, speedBoxOne, 0.0f);
            transform.rotation = Quaternion.LookRotation(direct);
        }

        ch_BoxControllerTwo.Move(boxVector * Time.deltaTime);// ����� �������� �� �����������

    }
}
