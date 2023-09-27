using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static PlayerManager Instance { get; private set; }
    public GameObject player;
    public InputManager inputManager;
    PlayerLocalMotion playerLocalMotion;

    
    public float Movementspeed;
    
    
    public float Rotatationspeed;
    public Rigidbody rigidBody;

    private void Awake()
    {
        if (Instance != null && Instance != this) {Destroy(this);}
        else { Instance = this;}
        inputManager = player.GetComponent<InputManager>();
        playerLocalMotion = player.GetComponent<PlayerLocalMotion>();
        rigidBody = player.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        inputManager.HandleAllInput();
    }
    private void FixedUpdate()
    {
        playerLocalMotion.HandleAllMovement();
    }

}
