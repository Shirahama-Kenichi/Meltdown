using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aim : MonoBehaviour
{
 
    
    public GameObject mainCamera;
    public GameObject aimCamera;
   
    public GameObject follow2;
    public GameObject follow1;
    public GameObject botella;
    public GameObject mira;

    Vector3 dir;
    GameObject i;
    public Transform mano;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(1))
        {
            if (Input.GetMouseButtonDown(0) && ControlCharacter1.botellas > 0)
            {
                i = Instantiate(botella, mano.transform.position, Quaternion.identity);
                dir = mira.transform.position - mano.transform.position;
                i.GetComponent<Rigidbody>().AddForce(dir * 100f, ForceMode.Force);
                ControlCharacter1.botellas -= 1;
                print(ControlCharacter1.botellas);
            }

        }
    }

   
    
}

