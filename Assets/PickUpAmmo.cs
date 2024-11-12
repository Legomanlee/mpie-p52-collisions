using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAmmo : MonoBehaviour
{
    public float ammo = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other){
        Debug.Log("anything");
        if (other.gameObject.tag == "ammo"){
            ammo = ammo + 20.0f;
            other.gameObject.SetActive(false);
        }
    }

    public void OnMouseDown(){
        if (ammo > 0){
            ammo = ammo - 1;
            Ray ray =  Camera.main.ViewportPointToRay(new Vector3(0.5f ,0.5f ,0.0f));

            RaycastHit result; 
            Physics.Raycast(ray, out result);

            GameObject g = result.collider.gameObject;
            Animation a = g.transform.parent.GetComponent<Animation>();
            a.Play("LowerBridge");
        }
    }
}
