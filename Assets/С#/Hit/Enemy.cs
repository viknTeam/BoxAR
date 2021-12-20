using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHeal = 100;// Переменая здоровья 
    int currentHeal;
    

    void Start()
    {
        currentHeal = maxHeal;// Возвращения кол-во очков здоровья при начале игры
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

        this.enabled = false;// Отключения текущего скрипта при поражении 
    }
}
