
using UnityEngine;

namespace Bobo
{
    public class work : MonoBehaviour
    {
        [SerializeField,Header("目標物件")]
        private Transform target;

        private void Update()
        {
            LookAtTarget();
        }
        /// <summary>
        /// 面相目標
        /// </summary>
        private void LookAtTarget()
        {
            transform.LookAt(target);

            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }
}
    }

    
