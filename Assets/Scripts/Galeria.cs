using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Galeria : MonoBehaviour
{
    public void EnableGaleria(Animator anim)
    {
        anim.SetBool("GaleriaBool", true);
    }
    public void DisableGaleria(Animator anim)
    {
        anim.SetBool("GaleriaBool", false);
    }
    public void EnableHome(Animator anim)
    {
        anim.SetBool("HomeBool", false);
    }
    public void DisableHome(Animator anim)
    {
        anim.SetBool("HomeBool", true);
    }
    public void EnableSobre(Animator anim)
    {
        anim.SetBool("SobreBool", true);
    }
    public void DisableSobre(Animator anim)
    {
        anim.SetBool("SobreBool", false);
    }
    public static void RedirectGarra()
    {
        SceneManager.LoadScene("GarraRobotica");
    }
}
