using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GarraUIManager : MonoBehaviour
{
    public static void RedirectHome()
    {
        SceneManager.LoadScene("Home");
    }
}
