﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public static BackgroundLoop Instance;
    public GameObject OBJ;
   public enum Direction{
        Horizontal,
        Vertical
    }

   private void Awake()
   {
       Instance = this;
   }

   public Direction MoveDirection;
    public GameObject[] levels;
    private Camera mainCamera;
    private Vector2 screenBounds;
    public float choke;
    public float scrollSpeed;
    public bool Horizontal;
    public bool Vertical;
    void Start()
    {
        mainCamera = gameObject.GetComponent<Camera>();
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
        foreach (GameObject obj in levels)
        {
            if (MoveDirection==Direction.Horizontal)
            {
                loadChildObjects(obj);
            }
            else if (MoveDirection == Direction.Vertical)
            {
                loadChildObjectsVertical(obj);

            }
        }
    }
    void loadChildObjects(GameObject obj)
    {
        float objectWidth = obj.GetComponent<SpriteRenderer>().bounds.size.x - choke;
        int childsNeeded = (int)Mathf.Ceil(screenBounds.x * 2 / objectWidth);
        GameObject clone = Instantiate(obj) as GameObject;
        for (int i = 0; i <= childsNeeded; i++)
        {
            GameObject c = Instantiate(clone) as GameObject;
            c.transform.SetParent(obj.transform);
           
                c.transform.position = new Vector3(objectWidth * i, obj.transform.position.y, obj.transform.position.z);
           
            
            c.name = obj.name + i;
        }

        OBJ = obj;
        Destroy(clone);
        Destroy(obj.GetComponent<SpriteRenderer>());
    }

    public void Toggle(bool s)
    {
        OBJ.SetActive(s);
        OBJ.transform.GetChild(0).gameObject.SetActive(s);
        OBJ.transform.GetChild(1).gameObject.SetActive(s);
    }
    void loadChildObjectsVertical(GameObject obj)
    {
        float objectWidth = obj.GetComponent<SpriteRenderer>().bounds.size.y - choke;
        int childsNeeded = (int)Mathf.Ceil(screenBounds.y * 2 / objectWidth);
        GameObject clone = Instantiate(obj) as GameObject;
        for (int i = 0; i <= childsNeeded; i++)
        {
            GameObject c = Instantiate(clone) as GameObject;
            c.transform.SetParent(obj.transform);
           
                c.transform.position = new Vector3(obj.transform.position.x,objectWidth*i, obj.transform.position.z);
           
            
            c.name = obj.name + i;
        }
        Destroy(clone);
        Destroy(obj.GetComponent<SpriteRenderer>());
    }
    void repositionChildObjects(GameObject obj)
    {
        Transform[] children = obj.GetComponentsInChildren<Transform>();
        if (children.Length > 1)
        {
            GameObject firstChild = children[1].gameObject;
            GameObject lastChild = children[children.Length - 1].gameObject;
            float halfObjectWidth = lastChild.GetComponent<SpriteRenderer>().bounds.extents.x - choke;
            if (transform.position.x + screenBounds.x > lastChild.transform.position.x + halfObjectWidth)
            {
                firstChild.transform.SetAsLastSibling();
                firstChild.transform.position = new Vector3(lastChild.transform.position.x + halfObjectWidth * 2, lastChild.transform.position.y, lastChild.transform.position.z);
            }
            else if (transform.position.x - screenBounds.x < firstChild.transform.position.x - halfObjectWidth)
            {
                lastChild.transform.SetAsFirstSibling();
                lastChild.transform.position = new Vector3(firstChild.transform.position.x - halfObjectWidth * 2, firstChild.transform.position.y, firstChild.transform.position.z);
            }
        }
    }
    void repositionChildObjectsVertical(GameObject obj)
    {
        Transform[] children = obj.GetComponentsInChildren<Transform>();
        if (children.Length > 1)
        {
            GameObject firstChild = children[1].gameObject;
            GameObject lastChild = children[children.Length - 1].gameObject;
            float halfObjectWidth = lastChild.GetComponent<SpriteRenderer>().bounds.extents.y - choke;
            if (transform.position.y + screenBounds.y > lastChild.transform.position.y+ halfObjectWidth)
            {
                firstChild.transform.SetAsLastSibling();
                firstChild.transform.position = new Vector3(lastChild.transform.position.x , lastChild.transform.position.y + halfObjectWidth * 2, lastChild.transform.position.z);
            }
            else if (transform.position.y - screenBounds.y < firstChild.transform.position.y - halfObjectWidth)
            {
                lastChild.transform.SetAsFirstSibling();
                lastChild.transform.position = new Vector3(firstChild.transform.position.x, firstChild.transform.position.y - halfObjectWidth * 2, firstChild.transform.position.z);
            }
        }
    }
    void Update()
    {

        Vector3 velocity = Vector3.zero;
        Vector3 desiredPosition = transform.position + new Vector3(scrollSpeed, 0, 0);
        Vector3 smoothPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, 0.3f);
        transform.position = smoothPosition;

    }
    void LateUpdate()
    {
        foreach (GameObject obj in levels)
        {
            if (MoveDirection == Direction.Horizontal)
            {
                repositionChildObjects(obj);
            }
            else if (MoveDirection == Direction.Vertical)
            {
                repositionChildObjectsVertical(obj);
            }
        }
    }
}