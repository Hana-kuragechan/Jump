using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Item : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        //_audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
      
    }

    /// <summary>
    /// �l���A�j���[�V�����̍Đ����I�������Ă�
    /// �I�u�W�F�N�g��j������
    /// </summary>
    //void OnGetAnimationFinished()
    //{
    //    Debug.Log("�A�C�e����j�����܂�");
    //    Destroy(gameObject);
    //}

    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Get");
      
        Debug.Log(other.gameObject.name + " ���ڐG����");
      
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " �����ꂽ");
    }

  private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
