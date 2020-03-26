using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCreate : MonoBehaviour
{
    public bool CriandoGel = false;
    public static int AumentarGel = 1;
    public int GelInterno;


    // Update is called once per frame
    void Update()
    {
        AumentarGel = GlobalCookies.qtdAuto;
        GelInterno = AumentarGel;
        if (CriandoGel == false)
        {
            CriandoGel = true;
            StartCoroutine(GerarGel());
        }
        
    }

    IEnumerator GerarGel ()
    {
        GlobalCookies.CookieCount += GelInterno;
        yield return new WaitForSeconds(1);
        CriandoGel = false;
    }
}
