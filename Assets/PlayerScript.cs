using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public bool hasJumped = true;
    public float RotateSpeed = 360f, torqueAmount;
    public int points = 0;
    Vector2 _previousRight;
    private float _angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !hasJumped)
        {
            GetComponent<Rigidbody2D>().velocity += Vector2.up * 8;
            hasJumped = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddTorque(-torqueAmount);
        }
        var currentRight = transform.right;
        _angle += Vector2.SignedAngle(_previousRight, currentRight);
        _previousRight = currentRight;
        if (Mathf.Abs(_angle) >= 360f)
        {
            points += 100;
            _angle -= 360f * Mathf.Sign(_angle);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hasJumped = false;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        transform.GetChild(2).localScale = new Vector3(1, 1, 1);
        transform.GetChild(2).GetComponent<ParticleSystem>().Play();
        points++;
    }
}
