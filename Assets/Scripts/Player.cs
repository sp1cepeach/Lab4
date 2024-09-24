using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public GameObject laserPrefab;
    public InputAction playerControls;

    public Rigidbody2D rb;
    private float speed = 6f;
    //private float horizontalScreenLimit = 10f;
    //private float verticalScreenLimit = 6f;
    private bool canShoot = true;

    Vector2 moveDirection = Vector2.zero;

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shooting();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    void Movement()
    {
        moveDirection = playerControls.ReadValue<Vector2>();
        //transform.Translate(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * Time.deltaTime * speed);
        //if (transform.position.x > horizontalScreenLimit || transform.position.x <= -horizontalScreenLimit)
        //{
        //    transform.position = new Vector3(transform.position.x * -1f, transform.position.y, 0);
        //}
        //if (transform.position.y > verticalScreenLimit || transform.position.y <= -verticalScreenLimit)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y * -1, 0);
        //}
    }

    void Shooting()
    {
        //if (Input.GetKeyDown(KeyCode.Space) && canShoot)
        //{
        //    Instantiate(laserPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        //    canShoot = false;
        //    StartCoroutine("Cooldown");
        //}
    }

    private IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(1f);
        canShoot = true;
    }
}
