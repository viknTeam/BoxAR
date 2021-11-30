using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemen : MonoBehaviour
{
    //Основные параметры
    public float speedBoxOne; //Скорость персонажа

    //Параметры гемплея персонажа
    private float grvitiForse; //Гравитация персонажа
    private Vector3 boxVector; //Напаравление персонажа

    //Ссылки на компоненты
    private CharacterController ch_BoxController;
    private Animation ch_BoxAnimation;


    private void Start()
    {
        ch_BoxController = GetComponent<CharacterController>();
        ch_BoxAnimation = GetComponent<Animation>();

    }

    //Метод перемещения персонажа
    private void BoxMove()
    {
     boxVector = Vector3.zero;
     boxVector.x = Input.GetAxis("Horizontal") * speedBoxOne;
     boxVector.z = Input.GetAxis("Vertical") * speedBoxOne;

    }

    
}