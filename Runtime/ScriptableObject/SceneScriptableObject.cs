using UnityEngine;

namespace UtilityAI
{
    /// <summary>
    /// Scene����һ���龳
    /// ����AIContext���һ�ִ���
    /// ����ʣ������ֵ�ı���
    /// ͨ������AIContext,Ӧ������һ��[0f,1f]�ڵ�ֵ
    /// </summary>
    public abstract class SceneScriptableObject : ScriptableObject, IEvaluator
    {
        public abstract float Evaluate(IAIContext context);
    }
}