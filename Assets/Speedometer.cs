using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Speedometer : MonoBehaviour
{
    public TMP_Text speedText;
    public Rigidbody2D targetObject;

    private void Update()
    {
        // Получите текущую скорость объекта
        float speed = targetObject.velocity.magnitude;

        // Отображение скорости на текстовом элементе
        speedText.text = "Speed: " + speed.ToString("F2");
    }
}