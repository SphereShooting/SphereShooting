using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GodTouches {
    public class PlayerControllerQuick : MonoBehaviour
    {
        public GameObject stage;
        Vector2 startPos;
        Quaternion startRot;
        float width, height;
        float vertical, horizontal;

        // Start is called before the first frame update
        void Start()
        {
            width = Screen.width;
            height = Screen.height;
        }

        // Update is called once per frame
        void Update()
        {
            var phase = GodTouch.GetPhase();
            if(phase == GodPhase.Began)
            {
                startPos = GodTouch.GetPosition();
                startRot = stage.transform.rotation;
            }
            else if(phase == GodPhase.Moved)
            {
                horizontal = (GodTouch.GetPosition().x - startPos.x) / width;
                vertical = (GodTouch.GetPosition().y - startPos.y) / height;
                stage.transform.rotation = startRot;
                stage.transform.Rotate(new Vector3(90 * vertical, -90 * horizontal, 0), Space.World);
            }
        }
    }
}
