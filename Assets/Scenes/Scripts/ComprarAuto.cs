using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprarAuto : MonoBehaviour
{
    public GameObject AutoGel;
    public GameObject VendedorGel;
    public double precoSaler, custo;
    public int Salers;
    public AudioSource playSound;
    


    // Funcionamento do AutoGel
    public void GeradorGel()
    {
        playSound.Play();
        AutoGel.SetActive(true);
        GlobalCookies.CashCount -= GlobalCookies.ValorAuto;
        GlobalCookies.ValorAuto *= 2;
        GlobalCookies.qtdAuto += 1;
    }

    //Funcionamento do Saler
    public void ContrataVend()
    {
        VendedorGel.SetActive(true);
        GlobalCookies.CashCount -= GlobalCookies.ValorSaler;
        custo = GlobalCookies.ValorSaler;
        GlobalCookies.qtdSaler += 1;
        GlobalCookies.ValorSaler *= 2;
        StartCoroutine(Salario(custo));
    }

    IEnumerator Salario (double custo)
    {
        while (0 < 1)
        {
            yield return new WaitForSeconds(10);
            GlobalCookies.CashCount -= custo;
        }
    }
}
