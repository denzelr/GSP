using UnityEngine;
using System.Collections;

public class RobotControllerSript : MonoBehaviour {

	public float maxSpeed = 10f;
	private bool facingRight = true;
	Animator anim;
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 700f;
	float damping = 64;
	public int jumpdir;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		//anim.SetFloat ("Vspeed", rigidbody2D.velocity.y);
		//anim.SetFloat ("Hspeed", rigidbody2D.velocity.x);


		float move = Input.GetAxis("Horizontal");
		float movev = Input.GetAxis("Vertical");

		if (jumpdir == 0 || jumpdir == 1){
			anim.SetFloat ("Speed", Mathf.Abs(move));
			anim.SetFloat ("Vspeed", Mathf.Abs(0));
			rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);
		}
		else if (jumpdir == 2 || jumpdir == 3) {
			anim.SetFloat ("Speed", Mathf.Abs(0));
			anim.SetFloat ("Vspeed", Mathf.Abs(movev));
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, movev * maxSpeed);
		}

		if (move > 0 && !facingRight || (jumpdir == 2 && movev > 0 && facingRight) || (jumpdir == 3 && movev > 0 && !facingRight))
						Flip ();
		else if (move < 0 && facingRight || (jumpdir == 2 && movev < 0 && !facingRight) || (jumpdir == 3 && movev < 0 && facingRight))
						Flip ();

	}

	void Update(){
		/*if(grounded && Input.GetKeyDown(KeyCode.Space) && jumpdir == 0){
			anim.SetBool("Ground", false);
			rigidbody2D.AddForce(new Vector2(0, jumpForce));
		}
		if(grounded && Input.GetKeyDown(KeyCode.Space) && jumpdir == 1){
			anim.SetBool("Ground", false);
			rigidbody2D.AddForce(new Vector2(0, -jumpForce));
		}
		if(grounded && Input.GetKeyDown(KeyCode.Space) && jumpdir == 2){
			anim.SetBool("Ground", false);
			rigidbody2D.AddForce(new Vector2(jumpForce, 0));
		}
		if(grounded && Input.GetKeyDown(KeyCode.Space) && jumpdir == 3){
			anim.SetBool("Ground", false);
			rigidbody2D.AddForce(new Vector2(-jumpForce, 0));
		}*/
		if (Input.GetKeyDown(KeyCode.I)) {
			if (grounded == true){
			Physics2D.gravity = new Vector2(0f,9.81f);
			Vector3 targetUp = new Vector3(0, -1, 0);
			transform.up = Vector3.Slerp(transform.up, targetUp, Time.deltaTime * damping);
			jumpdir = 0;
			}
		}
		if (Input.GetKeyDown(KeyCode.K)) {
			if (grounded == true){
			Physics2D.gravity = new Vector2(0f,-9.81f);
			Vector3 targetdown = new Vector3(0, 1, 0);
			transform.up = Vector3.Slerp(transform.up, targetdown, Time.deltaTime * damping);
			jumpdir = 1;
			}
		}
		if (Input.GetKeyDown(KeyCode.J)) {
			if (grounded == true){
			Physics2D.gravity = new Vector2(-9.81f,0f);
			Vector3 targetleft = new Vector3(1, 0, 0);
			transform.up = Vector3.Slerp(transform.up, targetleft, Time.deltaTime * damping);
			jumpdir = 2;
			}
		}
		if (Input.GetKeyDown(KeyCode.L)) {
			if (grounded == true){
			Physics2D.gravity = new Vector2(9.81f,0f);
			Vector3 targetright = new Vector3(-1, 0, 0);
			transform.up = Vector3.Slerp(transform.up, targetright, Time.deltaTime * damping);
			jumpdir = 3;
			}
		}
	}

	void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
