using System.Collections;
using System.Collections.Generic;
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
    private ARTrackedImageManager imagemanager;

    void Awake()
    {
        btnProximo.onClick.AddListener(Proximo);
        btnAnterior.onClick.AddListener(Anterior);
    }
//af
    private void Proximo()
    {
        GameObject prefabi =  imagemanager.trackedImagePrefab;
        Animator animator = prefabi.GetComponent<Animator>(); 
        animator.SetBool("anim1bool", true);
    }
    private void Anterior()
    {
        GameObject prefabi = imagemanager.trackedImagePrefab;
        Animator animator = prefabi.GetComponent<Animator>();
        animator.SetBool("anim1bool", false);
    }

}
