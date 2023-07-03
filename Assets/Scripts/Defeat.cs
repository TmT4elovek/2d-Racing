using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Defeat : MonoBehaviour
{
    private Rigidbody2D rb;
    private float xpos;
    private float ypos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Проверяем, вышла ли машинка за границы экрана
        xpos = transform.position.x;
        ypos = transform.position.y;
        
        if (xpos <= -10.1f || xpos >= 10.1f || ypos >= 4.51f || ypos <= -4.51f)
        {
            // Уничтожаем объект машинки
            Destroy(gameObject);

            // Пишем в консоль поражение
            Debug.Log("Defeat");
        } 
    }
}