using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllerScript : MonoBehaviour
{
    Animator anim1;
    Animator anim2;
    public GameObject cactus1;
    public GameObject cactus2;
    public GameObject imgTarget1;
    public GameObject imgTarget2;
    
    public float treshHold = 0.3f;
    
    // Start is called before the first frame update
    void Start()
    {
        anim1 = cactus1.GetComponent<Animator>();
        anim2 = cactus2.GetComponent<Animator>();

        imgTarget1 = cactus1.transform.root.gameObject;
        imgTarget2 = cactus2.transform.root.gameObject;

        Debug.Log(imgTarget1);
        Debug.Log(imgTarget2);
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector3.Distance(imgTarget1.transform.position, imgTarget2.transform.position);

        if(distance < treshHold){
            anim1.SetBool("isClose", true);
            anim2.SetBool("isClose", true);
        }else{
            anim1.SetBool("isClose", false);
            anim2.SetBool("isClose", false);
        }


        
    }
}
