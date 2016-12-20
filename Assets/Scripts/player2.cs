using UnityEngine;
using System.Collections;

public class player2 : MonoBehaviour {
	public float velocidad = 5f;
	public float salto = 10f;
	public float power =1f;
	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			rb.velocity = new Vector2 (velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3(1, 1, 1);
		}
		if (Input.GetKeyUp (KeyCode.D)) {
			rb.velocity = new Vector2 (0 , rb.velocity.y);
		}
		if (Input.GetKey (KeyCode.A)) {
			rb.velocity = new Vector2 (-velocidad * power, rb.velocity.y);
			transform.localScale = new Vector3(-1, 1, 1);
		}
		if (Input.GetKeyUp (KeyCode.A)) {
			rb.velocity = new Vector2 (0 , rb.velocity.y);
		}
		if (Input.GetKey (KeyCode.W)) {
			rb.velocity = new Vector2 (velocidad * power, rb.velocity.x);
			transform.localScale = new Vector3(1, 1, 1);
		}
		if (Input.GetKeyUp (KeyCode.W)) {
			rb.velocity = new Vector2 (0 , rb.velocity.x);
		}
		if (Input.GetKey (KeyCode.S)) {
			rb.velocity = new Vector2 (-velocidad * power, rb.velocity.x);
			transform.localScale = new Vector3(-1, 1, 1);
		}
		if (Input.GetKeyUp (KeyCode.S)) {
			rb.velocity = new Vector2 (0 , rb.velocity.x);
		}
	}
}