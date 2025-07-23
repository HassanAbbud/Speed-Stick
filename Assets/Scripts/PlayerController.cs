using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public LayerMask coloredWallMask;
    public LayerMask neutralWallMask;

    private Rigidbody2D rb;
    private bool canJump = true;
    public enum CubeColor { Red, Green, Blue, Yellow }
    public CubeColor currentFacingColor = CubeColor.Red;
    private bool isSticking = false;

    public enum CubeDirection { Top, Bottom, Left, Right }

    [System.Serializable]
    public class CubeFace
    {
        public CubeDirection direction;
        public CubeColor color;
    }

    public CubeFace[] faces = new CubeFace[4];


    void Start() => rb = GetComponent<Rigidbody2D>();

    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space) && canJump) Jump();

        RotateCube();

        TryStickToWall();

    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(h * moveSpeed, rb.linearVelocity.y);
    }

    void Jump()
    {
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        canJump = false;
    }

    void RotateFacesLeft()
    {
        foreach (var face in faces)
        {
            face.direction = face.direction switch
            {
                CubeDirection.Top => CubeDirection.Left,
                CubeDirection.Left => CubeDirection.Bottom,
                CubeDirection.Bottom => CubeDirection.Right,
                CubeDirection.Right => CubeDirection.Top,
                _ => face.direction
            };
        }
    }

    void RotateFacesRight()
    {
        foreach (var face in faces)
        {
            face.direction = face.direction switch
            {
                CubeDirection.Top => CubeDirection.Right,
                CubeDirection.Right => CubeDirection.Bottom,
                CubeDirection.Bottom => CubeDirection.Left,
                CubeDirection.Left => CubeDirection.Top,
                _ => face.direction
            };
        }
    }


    void RotateCube()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(0, 0, 90);
            RotateFacesLeft();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(0, 0, -90);
            RotateFacesRight();
        }

    }

    void StickToWall()
    {
        isSticking = true;
        rb.linearVelocity = Vector2.zero;
        rb.gravityScale = 0f;
        canJump = true;
    }

    void UnstickFromWall()
    {
        if (isSticking)
        {
            rb.gravityScale = 1f;
            isSticking = false;
        }
    }


    void TryStickToWall()
    {
        float h = Input.GetAxisRaw("Horizontal");
        if (h == 0) return;

        Vector2 direction = (h < 0) ? Vector2.left : Vector2.right;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 0.6f, coloredWallMask);

        if (hit.collider != null)
        {
            WallColor wall = hit.collider.GetComponent<WallColor>();
            CubeColor faceColor = GetColorInDirection(direction);

            if (wall != null && wall.wallColor == faceColor)
            {
                StickToWall();
            }

        }
        else
        {
            UnstickFromWall();
        }
    }

    CubeColor GetColorInDirection(Vector2 dir)
    {
        CubeDirection targetDir;

        if (dir == Vector2.left) targetDir = CubeDirection.Left;
        else if (dir == Vector2.right) targetDir = CubeDirection.Right;
        else if (dir == Vector2.up) targetDir = CubeDirection.Top;
        else if (dir == Vector2.down) targetDir = CubeDirection.Bottom;
        else return CubeColor.Red; // default fallback

        foreach (var face in faces)
        {
            if (face.direction == targetDir)
                return face.color;
        }

        return CubeColor.Red; // fallback
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ColoredWall") ||
            collision.gameObject.CompareTag("NeutralWall"))
        {
            canJump = true;
        }
    }


    //bool IsMatchingColor(Collision2D col)
    //{
    //    // logic to compare cube face and wall color
    //    return col.gameObject.CompareTag("ColoredWall");
    //}

    internal void EnableDoubleJump()
    {
        throw new NotImplementedException();
    }
}