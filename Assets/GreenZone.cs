using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenZone : MonoBehaviour
{
    [SerializeField]
    private Animator m_Animator;

    bool open;

    private void Start()
    {
        open = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            open = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            open = false;
        }
    }

    private void OnMouseOver()
    {
        Debug.Log("ok");
        if(open)
        {
            m_Animator.SetBool("open", true);
        }else {
            m_Animator.SetBool("open", false);
        }
    }
}
