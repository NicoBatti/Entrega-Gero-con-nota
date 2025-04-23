using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class clavemanager : MonoBehaviour
{
    public TMP_InputField usuario;
    public TMP_InputField inputClave;
    public TextMeshProUGUI txtMensaje;

    string usuarioClave = "ELJUEGO";
    string clave = "ELJUEGO";

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
        string usuarioIngresado = usuario.text;
        string claveIngresada = inputClave.text;
        if (claveIngresada != clave || usuarioIngresado != usuarioClave)
        {
            txtMensaje.text = "Acceso denegado";
        }
        else
        {
            txtMensaje.text = "Le damos la bienvenida";
        }
    }
}
