using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFile : MonoBehaviour
{
    Image image;

    private void Start()
    {
        image = GetComponent<Image>();
        image.fillAmount = 0.5f;
    }

    //Nueva funcíón que rellena +0.1f el icono

    public void Healh_Damage(float valor)
    {
        image.fillAmount += valor;
    }

}
