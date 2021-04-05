using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // GameManager을 싱글 톤 처리합니다.
    public static GameManager instance { get; set; }
    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
    }

    public float noteSpeed;
    
    /*
     * Bad : 1
     * Good : 2
     * Perfect : 3
     * MISS : 4
     */
    public enum judges { NONE = 0, BAD, GOOD, PERFECT, MISS};
    
    
    
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
