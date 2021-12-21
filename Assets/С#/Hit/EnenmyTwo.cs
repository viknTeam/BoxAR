using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnenmyTwo : MonoBehaviour
{
    public Animator animatorTwo;
    public int maxHealTwo = 100;//���������� ��������
    public int currentHealTwo;
    public Text textTwo;


    void Start()
    {
        currentHealTwo = maxHealTwo;// ����������� ���-�� ����� �������� � �������� ���������
        
    }
    void UpDate()
    {
        textTwo.text = "��������: " + currentHealTwo;
    }
    public void TackDemage(int demageTwo)
    {
        currentHealTwo -= demageTwo;
        animatorTwo.SetTrigger("HurtTwo");//�������� �������� �����
        if (currentHealTwo <= 0)
        {
            TheTwo();
        }
    }
    void TheTwo()
    {
        animatorTwo.SetBool("RestTwo", true);//�������� ���������

        GetComponent<Collider>().enabled = false;//���������� ���������
        GetComponent<Movemen>().enabled = false;//���������� ������� ������
        GetComponent<HitBox1>().enabled = false;//���������� ������� ������
       
      
        
    }
   
}
