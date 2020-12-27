using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
public class MoveCharacter : MonoBehaviour
{

    private int idx = Animator.StringToHash("x");
    private int idy = Animator.StringToHash("y");
    private Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        if(Mathf.FloorToInt(x) != 0 || Mathf.FloorToInt(y) != 0)
        {
            anim.SetFloat(idx, x);
            anim.SetFloat(idy, y);

            transform.localPosition += new Vector3(x, y) * 0.05f;
        }
    }
}
