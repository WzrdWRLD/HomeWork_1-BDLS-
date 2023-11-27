using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // �������� ��������� Animator �� �������
        animator = GetComponent<Animator>();
    }

    public void Silly()
    {
        // ���������� ������� � ����������� ��������
        animator.SetTrigger("silly");
    }
    public void Twerk()
    {
        // ���������� ������� � ����������� ��������
        animator.SetTrigger("twerk");
    }
}