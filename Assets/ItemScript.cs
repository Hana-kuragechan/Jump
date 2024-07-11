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
    /// 獲得アニメーションの再生が終わったら呼ぶ
    /// オブジェクトを破棄する
    /// </summary>
    //void OnGetAnimationFinished()
    //{
    //    Debug.Log("アイテムを破棄します");
    //    Destroy(gameObject);
    //}

    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Get");
      
        Debug.Log(other.gameObject.name + " が接触した");
      
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " が離れた");
    }

  private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
