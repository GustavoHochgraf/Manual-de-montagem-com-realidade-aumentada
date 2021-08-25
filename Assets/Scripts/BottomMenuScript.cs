using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomMenuScript : MonoBehaviour
{
    public static void RedirectHome()
    {
        SceneManager.LoadScene("Home", LoadSceneMode.Single);
    }
    public static void RedirectGaleria()
    {
        SceneManager.LoadScene("Galeria", LoadSceneMode.Single);
    }
    public static void RedirectSobre()
    {
        SceneManager.LoadScene("Sobre", LoadSceneMode.Single);
    }
}
