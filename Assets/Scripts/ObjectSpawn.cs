using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectSpawn : MonoBehaviour
{
    public InputActionProperty createCube;
    public GameObject objectToCreate;
    // Start is called before the first frame update
    void Start()
    {
        createCube.action.performed += cxt => {
            var o = Instantiate(objectToCreate);
            o.transform.position = transform.position;
        };
    }
}
