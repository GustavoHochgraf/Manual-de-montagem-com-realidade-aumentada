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
    private 

    void Awake()
    {
        btnProximo.onClick.AddListener(Proximo);
        btnAnterior.onClick.AddListener(Anterior);
    }
    private void Proximo()
    {
        ARTrackedImage trackedimage = FindObjectOfType<ARTrackedImage>();
        Animator animator = trackedimage.GetComponent<Animator>();
        animator.SetBool("anim1bool", true);
    }
    private void Anterior()
    {
        ARTrackedImage trackedimage = FindObjectOfType<ARTrackedImage>();
        Animator animator = trackedimage.GetComponent<Animator>();
        animator.SetBool("anim1bool", false);
    }

}
