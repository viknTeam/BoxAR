using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox2 : MonoBehaviour
{
    public Animator animTwo;
    public Transform attacPoint_g, attacPointTwo_g, attacPointTr_g;// ���������� ����� �����

    public float attacRange_g, attacRangeTwo_g, attacRangeTr_g = 0.5f;// ������ ����� �����
    public LayerMask layerMaskTwo;

    public void AttacTwo()
    {
        animTwo.SetTrigger("HitTwo");// ��������� �������� �����
        Collider[] hitPoint_g = Physics.OverlapSphere(attacPoint_g.position, attacRange_g, layerMaskTwo);// ��������� ������� ����� � ����������
        foreach (Collider enimTwo in hitPoint_g)// ���� ������� ����� � ���������� ���������, ���������� �������� ����������
        {
            enimTwo.GetComponent<Enemy>().TakeDemage(20);// ���-�� ���������� �����
        }
    }
    public void AttacTwoBc()
    {
        animTwo.SetTrigger("HitTwo2");// ��������� ������ �������� �����
        Collider[] hitPointTwo_g = Physics.OverlapSphere(attacPointTwo_g.position, attacRangeTwo_g, layerMaskTwo);// ��������� ������� ����� � ����������
        foreach (Collider enimTwo in hitPointTwo_g)// ���� ������� ����� � ���������� ���������, ���������� �������� ����������
        {
            enimTwo.GetComponent<Enemy>().TakeDemage(40);// ���-�� ��������� �����
        }
    }
    public void AttacTwoHc()
    {
        animTwo.SetTrigger("HitTwo3");// ��������� ������ �������� �����
        Collider[] hitPointTr_g = Physics.OverlapSphere(attacPointTr_g.position, attacRangeTr_g, layerMaskTwo);// ��������� ������� ����� � ����������
        foreach (Collider enimTwo in hitPointTr_g)// ���� ������� ����� � ���������� ���������, ���������� �������� ����������
        {
            enimTwo.GetComponent<Enemy>().TakeDemage(100);// ���-�� ���������� �����
        }
    }
    void OnDrawGizmosSelected()// �������������� ���� ����� �����
    {
        if(attacPoint_g == null)
            return;
        Gizmos.DrawWireSphere(attacPoint_g.position, attacRange_g);
        Gizmos.DrawWireSphere(attacPointTwo_g.position, attacRangeTwo_g);
        Gizmos.DrawWireSphere(attacPointTr_g.position, attacRangeTr_g);
    }
    
        


    
}
