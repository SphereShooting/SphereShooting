using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GodTouches
{
    public class PlayerController : MonoBehaviour
    {

        Rigidbody rb;

        //回転用
        Vector2 startPos; //タッチした座標
        Quaternion startRot; //タッチしたときの回転
        float width, height, diag; //スクリーンサイズ
        float vertical, horizontal; //変数
        float limitVertical = 0.0f;

        // Start is called before the first frame update
        void Start()
        {
            rb = gameObject.GetComponent<Rigidbody>();
            width = Screen.width;
            height = Screen.height;
            
            //diag = Mathf.Sqrt(Mathf.Pow(width, 2) + Mathf.Pow(height, 2));
        }

        // Update is called once per frame
        void Update()
        {
            
            //float limitHorizontal = 0.0f;
            var phase = GodTouch.GetPhase();
            if (phase == GodPhase.Began)
            {
                //タッチ開始処理
                startPos = GodTouch.GetPosition();
                //startRot = rb.transform.rotation;
            }
            else if (phase == GodPhase.Moved)
            {
                horizontal = (GodTouch.GetPosition().x - startPos.x) / width; //横移動量(-1<tx<1)
                vertical = (GodTouch.GetPosition().y - startPos.y) / height; //縦移動量(-1<ty<1)
                //limitVertical = Mathf.Clamp(vertical, 0.1f, 0.5f);
                //obj.transform.rotation = startRot;
                //obj.transform.Rotate(new Vector3(90 * ty, -90 * tx, 0), Space.World);
                rb.angularVelocity = new Vector3(90 * vertical, -90 * horizontal, 0);
            }
            else if (phase == GodPhase.Ended)
            {
                //タッチ終了
                Debug.Log("TouchEnded");
            }
            else
            {
                limitVertical = 0.1f;
            }

            //rb.angularVelocity = new Vector3(90 * limitVertical, -90 * horizontal, 0);
        }
    }
}
