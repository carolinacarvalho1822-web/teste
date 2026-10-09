using UnityEngine;

public class mover : MonoBehaviour
{
public Rigidbody variavel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        variavel.AddForce(0, 20, 100);
    }

    // Update is called once per frame
    void Update()
    {
        variavel.AddForce(0, 0, 5);
    }
}
