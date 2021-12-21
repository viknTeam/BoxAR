using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHeal = 100;// Переменая здоровья 
    public int currentHeal;
    public Text text;

    void Start()
    {
        currentHeal = maxHeal;// Возвращения кол-во очков здоровья при начале игры
    }
    void UpDate()
    {
        text.text = "Здоровье: " + currentHeal;
    }

    public void TakeDemage(int demage)
    {
        currentHeal -= demage; 

        animator.SetTrigger("Hurt"); // Анимация получения атаки
        if(currentHeal <= 0)
        {
            The();
        }
    }
    void The()
    {

        animator.SetBool("Rest", true);// Анимация проигрыша
        
        GetComponent<Collider>().enabled = false;// Отключения колайдера при поражении
        GetComponent<MovemenTwo>().enabled = false;// Отключения скрипта при поражения
        GetComponent<HitBox2>().enabled = false;//Отключения скрипта атаки


        
    }
}
