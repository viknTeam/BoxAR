using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox2 : MonoBehaviour
{
    //Основные параметры
    public float speedBoxTwo; //Скорость персонажа

    //Параметры гемплея персонажа

    private Vector3 boxVector2; //Напаравление персонажа

    //Ссылки на компоненты
    private CharacterController ch_BoxControllerTwo;
    private Animator ch_BoxAnimationTwo;
    private ControlllerBox2 bx_controllrtTwo;


    private void Start()
    {
        ch_BoxControllerTwo = GetComponent<CharacterController>();
        ch_BoxAnimationTwo = GetComponent<Animator>();
        bx_controllrtTwo = GameObject.FindGameObjectWithTag("JoystickTwo").GetComponent<ControlllerBox2>();// Движение с помощью джостика
    }
    private void Update()
    {
        BoxMoveTwo();
    }

    //Метод перемещения персонажа
    private void BoxMoveTwo()
    {
        // Направление движения игрока
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

        ch_BoxControllerTwo.Move(boxVector2 * Time.deltaTime);// Метод движения по направлению

    }
}
