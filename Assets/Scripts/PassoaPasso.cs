using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassoaPasso : MonoBehaviour
{
    [SerializeField]
    private Button btnProximo;
    [SerializeField]
    private Button btnAnterior;
    [SerializeField]
    private Animator baseGarraAnim;


    void Awake()
    {
        btnProximo.onClick.AddListener(Proximo);
        btnAnterior.onClick.AddListener(Anterior);
    }

    private void Proximo()
    {
        baseGarraAnim.SetBool("basePlacement", true);
    }
    private void Anterior()
    {
        baseGarraAnim.SetBool("basePlacement", false);
    }

}
