using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour {
	new Rigidbody2D rigidbody;
	PlayerInput input;
	InputAction move;

	public float speed = 1f;

	void Start() {
		rigidbody = GetComponent<Rigidbody2D>();
		input = GetComponent<PlayerInput>();
		move = input.actions["Move"];
	}

	void FixedUpdate() {
		rigidbody.velocity = move.ReadValue<Vector2>() * speed;
	}
}
