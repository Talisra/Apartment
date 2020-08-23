using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    private Animator _animator;
    private bool isOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _animator.SetTrigger("Open");
            isOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (isOpen && other.gameObject.tag == "Player")
        {
            _animator.SetTrigger("Close");
            isOpen = false;
        }
    }
}
