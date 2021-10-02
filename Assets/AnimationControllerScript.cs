using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllerScript : MonoBehaviour
{
    Animator anim1;
    Animator anim2;
    public GameObject cactus1;
    public GameObject cactus2;
    GameObject imgTarget1;
    GameObject imgTarget2;
    int isCloseKey;
    public float treshHold = 0.3f;
    
    // Start is called before the first frame update
    void Start()
    {
        anim1 = cactus1.GetComponent<Animator>();
        anim2 = cactus2.GetComponent<Animator>();

        imgTarget1 = cactus1.transform.root.gameObject;
        imgTarget2 = cactus2.transform.root.gameObject;

        isCloseKey = Animator.StringToHash("isClose");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(imgTarget1.transform.position, imgTarget2.transform.position);
        bool isClose = anim1.GetBool(isCloseKey);
        if(distance < treshHold && !isClose){
            cactus1.transform.Rotate(0, -90, 0);
            cactus2.transform.Rotate(0, 90, 0);

            anim1.SetBool(isCloseKey, true);
            anim2.SetBool(isCloseKey, true);
        }else if(distance >= treshHold && isClose){
            cactus1.transform.Rotate(0, 90, 0);
            cactus2.transform.Rotate(0, -90, 0);
            
            anim1.SetBool(isCloseKey, false);
            anim2.SetBool(isCloseKey, false);
        }
    }
}
