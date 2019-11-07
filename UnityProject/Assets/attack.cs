using UnityEngine;

public class attack : MonoBehaviour
{
    public float speed = 1.5f;
    [Header("對話")]
    public string[] say_start = { "你好" } ;



    [Header("任務")]
    public bool complete = false;
    public int countp_layer = 0;
    public int count_Finish = 10;
}
