using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Cuando el usuario presione el BtnAceptar
//debe escribirse un mensaje en la consola
//si el texto delinputPassword coincide
//con una conrtaseña predefinida por ustedes
//escribir "Acces Granted"
//sino escribir "Acces Denied"
public class LoginManager : MonoBehaviour
{
    public InputField inputPassword;
    public Text mensajeAcceso;
    string contraseñaPredefinida = "miContraseña";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickBtnAceptar()
    {
        string contraseñaIngresada = inputPassword.text;

        if (contraseñaIngresada == contraseñaPredefinida)
        {
            mensajeAcceso.text = "Acceso Concedido";
            Debug.Log("Acceso Concedido");
        }
        else
        {
            mensajeAcceso.text = "Acceso Denegado";
            Debug.Log("Acceso Denegado");
        }
    }
}