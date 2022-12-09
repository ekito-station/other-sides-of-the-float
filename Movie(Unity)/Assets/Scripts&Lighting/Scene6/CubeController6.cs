﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController6 : MonoBehaviour
{
  public float startTime1 = 0.1f;
  public float speed1 = 0.025f;
  Vector3 goal1 = new Vector3(-20.523f,-0.28f,-3.731f);
  public float rotateTime = 1.5f;
  public float startTime2 = 1.7f;
  public float speed2 = 0.005f;
  Vector3 goal2 = new Vector3(-20.3765f,-0.3779f,-3.8157f);
  float seconds;

  // Start is called before the first frame update
  void Start()
  {
    Invoke("Rotate", rotateTime);
  }

  // Update is called once per frame
  void Update()
  {
    seconds += Time.deltaTime;
    if (seconds >= startTime1 && seconds < startTime2)
    {
      transform.position = Vector3.MoveTowards(transform.position, goal1, speed1);
    }
    if (seconds >= startTime2)
    {
      transform.position = Vector3.MoveTowards(transform.position, goal2, speed2);
    }
  }

  void Rotate()
  {
    transform.Rotate(new Vector3(0,0,-30));
  }
}
