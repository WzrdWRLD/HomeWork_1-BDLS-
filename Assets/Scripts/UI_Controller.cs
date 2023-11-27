using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Получаем компонент Animator из объекта
        animator = GetComponent<Animator>();
    }

    public void Silly()
    {
        // Активируем триггер в контроллере анимаций
        animator.SetTrigger("silly");
    }
    public void Twerk()
    {
        // Активируем триггер в контроллере анимаций
        animator.SetTrigger("twerk");
    }
}