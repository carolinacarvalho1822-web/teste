using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class mover2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody variavel;
    public TMP_Text vidas;
    public TMP_Text moedas;
    public AudioSource som;
    public AudioClip sombom;
    public AudioClip sommau;

    void Start()
    {
        variavel.AddForce(0, 20, 800);
    }

    // Update is called once per frame
    void Update()
    {
        variavel.AddForce(0, 0, 2);
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            variavel.AddForce(-4, 0, 0);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            variavel.AddForce(4, 0, 0);
        }
        if (variavel.position.y < -1)
        {
            FindAnyObjectByType<controlador2>().acabou();
        }
    }
    private void OnCollisionEnter(Collision quem)
    {
        if (quem.gameObject.tag == "bateu")
        {
            vidas.text = (int.Parse(vidas.text) - 1).ToString();
            if (int.Parse(vidas.text) <= 0)
            {
                FindAnyObjectByType<controlador2>().acabou();
            }
            som.PlayOneShot(sommau);
        }
    }
    private void OnTriggerEnter(Collider quem)
    {
        if (quem.gameObject.tag == "bom")
        {
            moedas.text = (int.Parse(moedas.text) + 10).ToString();
            som.PlayOneShot(sombom);
        }
    }

}