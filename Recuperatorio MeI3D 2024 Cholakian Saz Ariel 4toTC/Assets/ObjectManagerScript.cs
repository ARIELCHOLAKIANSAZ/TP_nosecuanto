using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectManagerScript : MonoBehaviour
{
    public Text txtAdv;
    public InputField inputCan;
    public GameObject[] objetos;
    public GameObject txtAdvObj;

    public void ButtonAceptarPressed()
    {
        int objeto = Random.Range(0, 4);
        int cantidad;
        int.TryParse(inputCan.text, out cantidad);
        if (cantidad > 0 && cantidad <= objetos.Length)
        {
            for (int i = 0; i < cantidad; i += 1)
            {
                objetos[objeto].SetActive(true);
                Instantiate(objetos[objeto]);
                objetos[objeto].SetActive(false);
            }
            txtAdvObj.SetActive(false);
        }
        else
        {
            if (inputCan.text == "")
            {
                txtAdvObj.SetActive(true);
                txtAdv.text = "Debe ingresar un valor";
                inputCan.text = "";
            }
            else
            {
                txtAdvObj.SetActive(true);
                txtAdv.text = "Ingreso no valido";
                inputCan.text = "";
            }
        }
    }
}
