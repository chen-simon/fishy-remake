using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionReference move;
    

    public float _maxSpeed;
    public float _acceleration;
    public float _deceleration;

    private Vector2 _velocity;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 moveDir = move.action.ReadValue<Vector2>();

        _velocity += moveDir * Time.deltaTime * _acceleration;
        _velocity = Vector2.ClampMagnitude(_velocity, _maxSpeed);

        if (moveDir == Vector2.zero)
        {
            Vector2 decelerationDirection = -_velocity.normalized;
            _velocity += decelerationDirection * Time.deltaTime * _deceleration;
        }
            
        transform.position += (Vector3)_velocity * Time.deltaTime;
    }
}
