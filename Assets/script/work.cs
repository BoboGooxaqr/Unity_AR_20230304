
using UnityEngine;

namespace Bobo
{
    public class work : MonoBehaviour
    {
        [SerializeField,Header("�ؼЪ���")]
        private Transform target;

        private void Update()
        {
            LookAtTarget();
        }
        /// <summary>
        /// ���ۥؼ�
        /// </summary>
        private void LookAtTarget()
        {
            transform.LookAt(target);

            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }
}
    }

    
