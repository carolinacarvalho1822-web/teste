using UnityEngine;

public class seguir : MonoBehaviour
{
    public Transform jogador;
    public Vector3 distancia;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=jogador.position+distancia;
    }
}
