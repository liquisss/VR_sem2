using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnHold : MonoBehaviour
{
    private Material originalMaterial;
    private Renderer objectRenderer;
    private bool isHeld = false;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalMaterial = objectRenderer.material;
    }

    public void OnHeldUpdate(Hand hand)
    {
        if (hand.GetStandardInteractionButtonDown())
        {
            isHeld = !isHeld;
            if (isHeld)
            {
                objectRenderer.material.color = Color.red; // Меняем цвет объекта на красный при удержании
            }
            else
            {
                objectRenderer.material = originalMaterial; // Возвращаем оригинальный цвет объекта при отпускании
            }
        }
    }
}
