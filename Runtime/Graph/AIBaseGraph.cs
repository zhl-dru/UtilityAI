using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using XNode;

namespace UtilityAI
{
    public abstract class AIBaseGraph : NodeGraph
    {
        public T GetUniqueNode<T>(T t) where T : Node
        {
            if (t != null)
            {
                return t;
            }
            else
            {
                t = FindUniqueNode<T>();
                if (t == null)
                {
                    Debug.LogError(string.Format("ͼ��{0}��û��{1}�ڵ�", name, nameof(T)));
                }
                return t;
            }
        }

        /// <summary>
        /// ����ͼ���еĵ�һ���ض����͵Ľڵ�
        /// û���ر�ı�֤,Ӧ���������ڲ��ұ��Ϊ[DisallowMultipleNodes]�Ľڵ�
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T FindUniqueNode<T>() where T : Node
        {
            var result = nodes.FirstOrDefault(x => x is T);
            if (result != null)
            {
                return result as T;
            }
            return null;
        }
    }
}