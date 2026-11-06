using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class mover : MonoBehaviour
{
public Rigidbody variavel;
public TMP_Text vida;
public TMP_Text pontos;
public AudioSource som;
public AudioClip sombom;
public AudioClip sommau;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      variavel.AddForce(0, 20, 800);
    }

    // Update is called once per frame
    void Update()
    {
        variavel.AddForce(0, 0, 3);
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            variavel.AddForce(-8, 0, 0);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            variavel.AddForce(8, 0, 0);
        }
        if (variavel.position.y < -1)
        {
            FindAnyObjectByType<controlador>().acabou();
        }
    }
    private void OnCollisionEnter(Collision quem)
    {
        if (quem.gameObject.tag =="bateu")
        {
            vida.text = (int.Parse(vida.text) - 1).ToString();
           if(int.Parse(vida.text) <=0)
        {
            FindAnyObjectByType<controlador>().acabou();
        }
        som.PlayOneShot(sommau);
        }
    }
    private void OnTriggerEnter(Collider quem)
    {
        if (quem.gameObject.tag == "bom")
        {
            pontos.text = (int.Parse(pontos.text) + 10).ToString();
           som.PlayOneShot(sombom);
        }
    }
}
