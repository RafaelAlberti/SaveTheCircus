using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;


public class JugadorMovimiento : MonoBehaviour
{
   [SerializeField] private PlayerInput input;

    public float maxspeed = 10f;
    public float speed = 2f;

    private Rigidbody2D bodypersonaje;
    private Vector3 inputVector;
  
    void Start()
    {
        bodypersonaje = GetComponent<Rigidbody2D>();
        
    }


    private void OnMovimiento(InputValue valor) {

        Vector2 movimentoInput = valor.Get<Vector2>();
        inputVector = new Vector3(movimentoInput.x, 0, movimentoInput.y);
        bodypersonaje.AddForce(Vector2.right * speed * inputVector);
    }

   
}
