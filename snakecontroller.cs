using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Settings

    [SerializeField] private float MoveSpeed = 5;
    [SerializeField] private Rigidbody rigidbody;
    //public float SteerSpeed = 180;
    

    // References
    public GameObject BodyPrefab;

    // Lists

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

        // Move forward
        var direction = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));

        
        rigidbody.velocity = direction * MoveSpeed;
        
        }
    }