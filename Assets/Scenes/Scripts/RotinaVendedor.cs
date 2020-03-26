using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RotinaVendedor : MonoBehaviour
{
    public bool vendendo = false;
    public int Gel, Saler;

    public GameObject TextBox;

    // Update is called once per frame
    void Update()
    {
        Gel = GlobalCookies.CookieCount;
        Saler = GlobalCookies.qtdSaler;
        if (vendendo == false)
        {
            vendendo = true;
            StartCoroutine(Negociar());
        }

        IEnumerator Negociar()
        {
            if (Gel-Saler < 0)
            {
                if (Gel > 0)
                {
                    GlobalCookies.CookieCount -= Gel;
                    GlobalCookies.CashCount += 9.90*Gel;
                }
                else
                {
                    TextBox.GetComponent<Text>().text = "Não há estoque suficiente!!!";
                    TextBox.GetComponent<Animation>().Play("AvisoAnim");
                }
            }
            else
            {
                GlobalCookies.CookieCount -= Saler;
                GlobalCookies.CashCount += 9.90*Saler;
            }
            yield return new WaitForSeconds(1);
            vendendo = false;
        }
        

    }
}
