using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D Rb;
    public Animator Anim;
    public float Speed = 10f;

    private float _horizontal;
    private float _vertical;

    private bool _isFacingRight = false;

    void Start()
    {
        
    }

    void Update()
    {
        Rb.velocity = new Vector2(_horizontal*Speed, _vertical*Speed);
        if(!_isFacingRight && _horizontal > 0f)
        {
            Flip();
        }
        else if(_isFacingRight && _horizontal < 0f)
        {
            Flip();
        }
        Animations();

    }
    private void Flip()
    {
        _isFacingRight = !_isFacingRight;
        Vector3 _localScale = transform.localScale;
        _localScale.x *= -1f;
        transform.localScale = _localScale;
    }
    private void Animations()
    {
        if (_horizontal != 0f || _vertical != 0f)
        {
            if (_vertical >= math.abs(_horizontal))
            {
                Anim.SetBool("isUp", true);
                Anim.SetBool("isDown", false);
                Anim.SetBool("isLeft", false);
            }
            else if (_vertical <= -math.abs(_horizontal))
            {
                Anim.SetBool("isUp", false);
                Anim.SetBool("isDown", true);
                Anim.SetBool("isLeft", false);
            }
            else if (_vertical < math.abs(_horizontal) && _vertical > -math.abs(_horizontal))
            {
                Anim.SetBool("isUp", false);
                Anim.SetBool("isDown", false);
                Anim.SetBool("isLeft", true);
            }
        }
        else
        {
            Anim.SetBool("isUp", false);
            Anim.SetBool("isDown", false);
            Anim.SetBool("isLeft", false);
        }
    }
    public void Move(InputAction.CallbackContext _context)
    {
        _horizontal = _context.ReadValue<Vector2>().x;
        _vertical = _context.ReadValue<Vector2>().y;
    }
}
