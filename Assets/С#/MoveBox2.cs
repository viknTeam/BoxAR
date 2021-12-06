using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox2 : MonoBehaviour
{
    //�������� ���������
    public float speedBoxTwo; //�������� ���������

    //��������� ������� ���������

    private Vector3 boxVector2; //������������ ���������

    //������ �� ����������
    private CharacterController ch_BoxControllerTwo;
    private Animator ch_BoxAnimationTwo;
    private ControlllerBox2 bx_controllrtTwo;


    private void Start()
    {
        ch_BoxControllerTwo = GetComponent<CharacterController>();
        ch_BoxAnimationTwo = GetComponent<Animator>();
        bx_controllrtTwo = GameObject.FindGameObjectWithTag("JoystickTwo").GetComponent<ControlllerBox2>();// �������� � ������� ��������
    }
    private void Update()
    {
        BoxMoveTwo();
    }

    //����� ����������� ���������
    private void BoxMoveTwo()
    {
        // ����������� �������� ������
        boxVector2 = Vector3.zero;
        boxVector2.x = bx_controllrtTwo.Horizontal() * speedBoxTwo;
        boxVector2.z = bx_controllrtTwo.Vertical() * speedBoxTwo;

        if (boxVector2.x != 0 || boxVector2.z != 0)
            ch_BoxAnimationTwo.SetBool("Move2", true);
        else ch_BoxAnimationTwo.SetBool("Move2", false);

        if (Vector3.Angle(Vector3.forward, boxVector2) > 1f)
        {
            Vector3 direct = Vector3.RotateTowards(transform.forward, boxVector2, speedBoxTwo, 0.0f);
            transform.rotation = Quaternion.LookRotation(direct);
        }

        ch_BoxControllerTwo.Move(boxVector2 * Time.deltaTime);// ����� �������� �� �����������

    }
}
