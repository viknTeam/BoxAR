using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHeal = 100;// ��������� �������� 
    public int currentHeal;
    public Text text;

    void Start()
    {
        currentHeal = maxHeal;// ����������� ���-�� ����� �������� ��� ������ ����
    }
    void UpDate()
    {
        text.text = "��������: " + currentHeal;
    }

    public void TakeDemage(int demage)
    {
        currentHeal -= demage; 

        animator.SetTrigger("Hurt"); // �������� ��������� �����
        if(currentHeal <= 0)
        {
            The();
        }
    }
    void The()
    {

        animator.SetBool("Rest", true);// �������� ���������
        
        GetComponent<Collider>().enabled = false;// ���������� ��������� ��� ���������
        GetComponent<MovemenTwo>().enabled = false;// ���������� ������� ��� ���������
        GetComponent<HitBox2>().enabled = false;//���������� ������� �����


        
    }
}
