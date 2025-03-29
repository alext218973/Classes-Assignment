using JetBrains.Annotations;
using UnityEngine;

public class MovingSpike : MonoBehaviour
{

    static float i = -23f;
 

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {


        i += 0.2f;
        if (i >= 23f)  // Reset i to -23f after reaching 23f
        {
            i = -23f;
        } 

        MovingHorizontally Spike = new MovingHorizontally();
        Spike.GetT();

        transform.position = Vector3.Lerp(new Vector3(i,-3.5f,0.2145f) ,new Vector3 (-i, -3.5f, 0.2145f),
            Mathf.PingPong(Spike.GetT(), 1));
    }
}

    class MovingHorizontally
    {

        private float _speed = 0.001f;
        private float t;

        public float GetSpeed()
        {
            return _speed;
        }
        public float GetT()
        {
            t += Time.deltaTime * _speed;
            return t;
        }
    }  



