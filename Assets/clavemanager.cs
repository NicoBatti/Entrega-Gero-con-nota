using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class clavemanager : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TextMeshProUGUI txtMensaje;

    string clave = "tic2025";

    // Start is called before the first frame update
    void Start()
    {
        txtMensaje.text = "";   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ComprobarClaveIngresada()
    {
        string claveIngresada = inputClave.text;
        if (claveIngresada != clave)
        {
            txtMensaje.text = "Acceso denegado";
        }
        else
        {
            txtMensaje.text = "Le damos la bienvenida";
        }
    }
}
