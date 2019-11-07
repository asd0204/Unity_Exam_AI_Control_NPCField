using UnityEngine;

public class Robotball : MonoBehaviour {
    public float speed = 10f;
    public float jump = 1.5f;
    public string foxName = "機器球";
    public bool pass = false;
    public bool isGround;

    private Rigidbody r2d;

    private void Start()
    {
        r2d = GetComponent<Rigidbody>();

    }

    //每秒60次，如果電腦太差執行次數會少於60次
    private void Update()
    {
        if (Input.GetKey(KeyCode.D)) Turn(0);
        if (Input.GetKey(KeyCode.A)) Turn(180);

    }

    //每禎0.002秒`,遊戲速度設置放這比較好，放void Update速度會依個人電腦決定
    private void FixedUpdate()
    {
        Jump();
        walk();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = true;
        Debug.Log("碰到了" + collision.gameObject);
    }

    /// <summary>
    ///走路
    /// </summary>
    private void walk()
    {
        r2d.AddForce(new Vector2(speed * Input.GetAxis("Horizontal"), 0));
        r2d.AddForce(new Vector2(0, speed * Input.GetAxis("Vertical")));
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            isGround = false;
            r2d.AddForce(new Vector2(0, jump));
        }

    }

    /// <summary>
    /// 方向
    /// </summary>
    /// <param name="direction">左180右0</param>
    private void Turn(int direction)
    {
        transform.eulerAngles = new Vector3(0, direction, 0);
    }
}
