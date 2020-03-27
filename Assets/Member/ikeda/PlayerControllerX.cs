using UnityEngine;

namespace GodTouches
{
    public class PlayerControllerX : MonoBehaviour
    {
        private Rigidbody rb;
        private float sPos, ePos;
        float vX, vY, vZ;
        float xMin, xMax;
        float yMin, yMax;
        bool trigger;

        // Start is called before the first frame update
        private void Start()
        {
            rb = gameObject.GetComponent<Rigidbody>();
            xMin = 0.2f; xMax = 1.0f;
            yMin = 0.2f; yMax = 1.0f;
        }

        // Update is called once per frame
        private void Update()
        {
            var phase = GodTouch.GetPhase();
            vY = -1.0f;

            //タッチされたときとあとの処理
            if (phase == GodPhase.Began)
            {
                //タッチ開始
                sPos = GodTouch.GetPosition().x;
            }
            else if (phase == GodPhase.Ended)
            {
                //タッチされた場所の開始位置と最終位置を比較して上ならspeedを上げる
                //下ならspeedを下げる
                ePos = GodTouch.GetPosition().x;
                trigger = true;
                
            }

            //タッチされている間の処理
            if (phase == GodPhase.Stationary)
            {
                Debug.Log("Idle");
                vY = -0.2f;
                
            }else if (Input.GetMouseButton(0))
            {
                Debug.Log("Idle");
                vY = -0.2f;
                
            }

            if(sPos > ePos && trigger)
            {
                vX += 0.3f;
                trigger = false;
                Debug.Log(vX);
            }
            else if(sPos < ePos && trigger)
            {
                vX -= 0.3f;
                trigger = false;
                Debug.Log(vX);
            }
            rb.angularVelocity = new Vector3(vY, vX, vZ);
        }
    }
}