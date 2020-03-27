using UnityEngine;

namespace GodTouches
{
    public class PlayerController_Flick : MonoBehaviour
    {
        Rigidbody rb;
        private Vector3 startPos;
        private Vector3 endPos;
        string Direction;
        float x, y;

        private void Flick()
        {
            var phase = GodTouch.GetPhase();
            if (phase == GodPhase.Began)
            {
                startPos = GodTouch.GetPosition();
            }
            if (phase == GodPhase.Ended)
            {
                endPos = GodTouch.GetPosition();
                GetDireciton();
            }
        }

        private void GetDireciton()
        {
            float directionX = endPos.x - startPos.x;
            float directionY = endPos.y - startPos.x;
            string Direction;

            if (Mathf.Abs(directionY) < Mathf.Abs(directionX))
            {
                if (30 < directionX)
                {
                    //右フリック
                    Direction = "right";
                }
                else if (-30 > directionX)
                {
                    //左フリック
                    Direction = "left";
                }
            }
            else if (Mathf.Abs(directionX) < Mathf.Abs(directionY)){
                if (30 < directionY)
                {
                    //上フリ
                    Direction = "up";
                }
                else if (-30 > directionY)
                {
                    //下フリ
                    Direction = "down";
                }
            }
            else
            {
                Direction = "touch";
            }
        }

        void Start()
        {
            rb = gameObject.GetComponent<Rigidbody>();
            float x = 1.0f;
        }
        void Update()
        {
            Flick();
            switch (Direction)
            {
                case "up":
                    x += 1.0f;
                    break;
                case "down":
                    x += 0.3f;
                    break;
                case "right":
                    y += -0.5f;
                    break;
                case "left":
                    y += 0.5f;
                    break;
                case "touch":
                    x = 0.5f;
                    break;
            }
            rb.angularVelocity = new Vector3(x, y, 0);
        }
    }
}
