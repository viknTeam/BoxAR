using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnenmyTwo : MonoBehaviour
{
    public Animator animatorTwo;
    public int maxHealTwo = 100;//Переменная здоровья
    public int currentHealTwo;
    public Text textTwo;


    void Start()
    {
        currentHealTwo = maxHealTwo;// Возвращения кол-во очков здоровья в исходное положения
        
    }
    void UpDate()
    {
        textTwo.text = "Здоровье: " + currentHealTwo;
    }
    public void TackDemage(int demageTwo)
    {
        currentHealTwo -= demageTwo;
        animatorTwo.SetTrigger("HurtTwo");//Анимация полученя атаки
        if (currentHealTwo <= 0)
        {
            TheTwo();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        
    }
    void TheTwo()
    {
        animatorTwo.SetBool("RestTwo", true);//Анимация проигрыша

        GetComponent<Collider>().enabled = false;//Отключения колайдера
        GetComponent<Movemen>().enabled = false;//Отключения скрипта хотьбы
        GetComponent<HitBox1>().enabled = false;//Отключения скрипта ататки
       
      
        
    }
   
}
