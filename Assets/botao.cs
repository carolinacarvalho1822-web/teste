using UnityEngine;
using UnityEngine.SceneManagement;

public class botao : MonoBehaviour
{
    public void abrir ()
    {
        SceneManager.LoadScene("Nivel 1");
    }
}