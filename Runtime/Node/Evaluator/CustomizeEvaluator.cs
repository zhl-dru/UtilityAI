using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UtilityAI
{
    /// <summary>
    /// ����������д��SceneScriptableObject��
    /// ֱ��ʹ��SceneScriptableObject���ص�ֵ
    /// </summary>
    [CreateNodeMenu("Utility AI/������/�Զ���������")]
    [NodeTitle("�Զ���������")]
    public class CustomizeEvaluator : EvaluatorSingleNode
    {
        public override float Evaluate(IAIContext context)
        {
            return scene.Evaluate(context);
        }
    }
}