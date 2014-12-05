using System;
using System.Collections.Generic;
using UnityEngine;
using UnityTest;

public class TestScript : MonoBehaviour {

	Vector2 grav = new Vector2(0f, -9.8f);
	Vector2 grav2 = new Vector2 (0f, 9.8f);

	public void Start() {
		//Pull variables from RobotControllerScript
		GameObject robot = GameObject.Find("robot 1");
		RobotControllerSript robotScript = robot.GetComponent<RobotControllerSript>();

		//Pull Variables from box script
		GameObject box = GameObject.Find ("testCrate");
		box boxScript = box.GetComponent<box> ();

		//Pull variables from trigger script
		GameObject trigger = GameObject.Find ("switch_1");
		trigger triggerScript = trigger.GetComponent<trigger> ();

		//Pull variables from RobotUP Script
		GameObject up = GameObject.Find ("robot_1");
		RobotUP upScript = up.GetComponent<RobotUP> ();

		//Begin Tests 1
		//Test the character is alive when level is loaded
		Assertions.Equals(robotScript.dead, false);
		
		//Test the character is facing right when level is loaded
		Assertions.Equals (robotScript.facingRight, true);

		//Test ground check is working
		Assertions.Equals (robotScript.groundCheck, true);
		//End Tests 1

		//Begin Test 2
		//Test gravity is set properly
		Assertions.Equals(grav, Physics2D.gravity);

		//Test variable tacking gravity is set correctly
		Assertions.Equals (robotScript.jumpdir, 1);
		//End Test 2

		//Begin Test 3
		//Test that Finish is set to false as level is loaded
		Assertions.Equals (boxScript.finish, false);
		//End Test 3

		//Begin Test 4
		//Test the correct animation is set
		Assertions.Equals (triggerScript.doorOpen, "doorOpen");

		//Test that the door is closed when level is loaded
		Assertions.Equals (triggerScript.isOpen, false);
		//End Test 4

		//Begin Test 5
		//Test that gravity is initialized properly
		Assertions.Equals(grav2, Physics2D.gravity);

		//Test gravity variable is set
		Assertions.Equals (upScript.jumpdir, 0);
		//End Test 5


	}
}
