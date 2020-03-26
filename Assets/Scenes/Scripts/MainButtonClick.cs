using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonClick : MonoBehaviour
{
    public GameObject TextBox;

    // Método de Fabricação

    public void Fazer ()
    {
        GlobalCookies.CookieCount++;
    }

    // Método de Venda

    public void Vender ()
    {
        if (GlobalCookies.CookieCount == 0)
        {
            TextBox.GetComponent<Text>().text = "Não há estoque suficiente!!!";
            TextBox.GetComponent<Animation>().Play("AvisoAnim");
        }
        else
        {
            GlobalCookies.CookieCount--;
            GlobalCookies.CashCount += 9.90;
        }
    }
}
