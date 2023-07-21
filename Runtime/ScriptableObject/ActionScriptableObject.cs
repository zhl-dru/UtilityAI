using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UtilityAI
{
    /// <summary>
    /// Action��һ������
    /// AI��������ִ�еķ���
    /// </summary>
    public abstract class ActionScriptableObject : ScriptableObject, IAction
    {
        public abstract void Execute(IAIContext context);
    }
}