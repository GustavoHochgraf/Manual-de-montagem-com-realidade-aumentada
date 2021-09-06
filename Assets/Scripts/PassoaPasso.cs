using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class PassoaPasso : MonoBehaviour
{
    [SerializeField]
    private Button btnProximo;
    [SerializeField]
    private Button btnAnterior;
    //[SerializeField]
    //private Animator baseGarraAnim;
    [SerializeField]
    private int maxiAnim;
    [SerializeField]
    private TextAsset textFile;
    [SerializeField]
    TextMeshProUGUI painelTextoGuia;

    private int contadorAnimacoes = 0;
    List<string> textos = new List<string>();
    private bool inicio;

    void Awake()
    {
        leitorCSV(textFile);
        painelTextoGuia.text = "Posicione o QR Code sobre uma superfície plana e aponte a câmera para ele";
        btnProximo.onClick.AddListener(Proximo);
        btnAnterior.onClick.AddListener(Anterior);
    }
    private void Update()
    {
        if (!FindObjectOfType<ARTrackedImage>())
        {
            inicio = true;
            painelTextoGuia.text = "Posicione o QR Code sobre uma superfície plana e aponte a câmera para ele";
        }else if ((FindObjectOfType<ARTrackedImage>()) && (inicio==true))
        {
            painelTextoGuia.text = textos[contadorAnimacoes];
            inicio = false;
        }

    }
    private void Proximo()
    {
        if (contadorAnimacoes != maxiAnim)
        {
            contadorAnimacoes++;
            ARTrackedImage trackedimage = FindObjectOfType<ARTrackedImage>();
            Animator animator = trackedimage.GetComponent<Animator>();
            animator.SetInteger("animCounter", contadorAnimacoes);
            painelTextoGuia.text = textos[contadorAnimacoes];
        }
    }
    private void Anterior()
    {
        if (contadorAnimacoes != 0)
        {
            contadorAnimacoes--;
            ARTrackedImage trackedimage = FindObjectOfType<ARTrackedImage>();
            Animator animator = trackedimage.GetComponent<Animator>();
            animator.SetInteger("animCounter", contadorAnimacoes);
            painelTextoGuia.text = textos[contadorAnimacoes];
        }
    }

    private void leitorCSV(TextAsset arquivoTexto)
    {
        var lines = arquivoTexto.text.Split("\r\n"[0]);
        foreach (var linha in lines)
        {
            linha.Replace("\n", "");
            textos.Add(linha);
        }
    }
}
