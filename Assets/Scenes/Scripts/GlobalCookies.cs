using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCookies : MonoBehaviour
{
    public static int CookieCount, qtdAuto, qtdSaler = 0;
    public static double CashCount, ValorAuto = 200, ValorSaler = 40;
    
    
    public GameObject CookieDisplay;
    public GameObject CashDisplay;
    public GameObject Worker;
    public GameObject Valor, ValorS;
    public GameObject Dados;
    public GameObject gameOver;
    public GameObject Saler, Vendedor;

    public int InternalCookie;
    public double InternalCash;

    //Método de Ativar/Desativar um Botão 
    public static void IObutton (double val, GameObject botao)
    {
        if (CashCount >= val)
        {
            botao.GetComponent<Button>().interactable = true;

        }
        else
        {
            botao.GetComponent<Button>().interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        InternalCookie = CookieCount;
        InternalCash = CashCount;
        Dados.GetComponent<Text>().text = "Autogel: " + qtdAuto + " @ " + qtdAuto + "/s";
        Vendedor.GetComponent<Text>().text = "Vendedor: " + qtdSaler + " @ " + 9.90*qtdSaler + "/s";
        CookieDisplay.GetComponent<Text>().text = "Estoque: " + InternalCookie;
        CashDisplay.GetComponent<Text>().text = "Dinheiro: " + InternalCash.ToString("C");
        Valor.GetComponent<Text>().text = "Comprar AutoGel R$" + ValorAuto;
        ValorS.GetComponent<Text>().text = "Contratar Vendedor R$" + ValorSaler+"/10s";


        // Rotina de Ativar/Desativar Botão de Compra do Autogel

        IObutton(ValorAuto, Worker);

        // Rotina de Ativar/Desativar Botão de Contratção do Vendedor

        IObutton(ValorSaler, Saler);


        // Condição de Chamada do Game Over
        if (CashCount < 0)
        {
            gameOver.SetActive(true);
        }
    }
}
