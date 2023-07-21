using Sirenix.OdinInspector;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UtilityAI
{
    /// <summary>
    /// ָ��һ������n
    /// ���ӵ÷���ߵ�n�����������ѡ��һ��
    /// ��n�������п��ö���ʱ,�����ж��������ѡ��
    /// </summary>
    [CreateNodeMenu("Utility AI/ѡ����/���ѡ����")]
    [NodeTitle("���ѡ����")]
    public class RandomSelector : SelectorNode
    {
        [LabelText("����")]
        [ShowInInspector]
        private int count;

        public override IAction Select(IAIContext context)
        {
            List<ValueIndexPair> pairs = new List<ValueIndexPair>();
            List<BinderSingleNode> binderList = new List<BinderSingleNode>();
            var binders = GetAllOnPort<BinderNode>(nameof(binder));
            foreach (var binder in binders)
            {
                Step(binder,
                    (BinderSingleNode single) =>
                    {
                        float value = single.Scorers.Scorer(context);
                        binderList.Add(single);
                        pairs.Add(new ValueIndexPair(value, binderList.Count - 1));
                    }
                    );
            }
            List<BinderSingleNode> resultList = new List<BinderSingleNode>();
            int i = 0;
            foreach (var pair in pairs.OrderByDescending(x => x.Score))
            {
                resultList.Add(binderList[pair.Index]);
                i++;
                if (i > count - 1) break;
            }
            int index = Random.Range(0, resultList.Count);
            return resultList[index].Action;
        }

        private struct ValueIndexPair
        {
            public float Score;
            public int Index;

            public ValueIndexPair(float score, int index)
            {
                Score = score;
                Index = index;
            }
        }
    }
}