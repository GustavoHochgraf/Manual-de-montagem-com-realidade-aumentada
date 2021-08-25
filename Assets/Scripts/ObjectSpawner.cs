using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    private PlacementIndicatorScript placementIndicator;
    private GameObject btnPrend;
    private TextMeshProUGUI texto;
    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicatorScript>();
        btnPrend = GameObject.Find("BtnPrender");
        texto = btnPrend.GetComponentInChildren<TextMeshProUGUI>();
    }

    public void Spawner()
    {
        if (SceneManager.GetActiveScene().name == "GarraRobotica")
        {
            if (!GameObject.Find("base3d(Clone)"))
            {
                GameObject obj = Instantiate(objectToSpawn,
                placementIndicator.transform.position, placementIndicator.transform.rotation);
                obj.SetActive(true);
                placementIndicator.enabled = false;
                texto.text = "Soltar";

            }
            else
            {
                GameObject objj;
                objj = GameObject.Find("base3d(Clone)");
                Destroy(objj);
                placementIndicator.enabled = true;
                texto.text = "Prender";
            }

        }

    }
}
