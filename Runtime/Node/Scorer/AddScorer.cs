using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UtilityAI
{
    [CreateNodeMenu("Utility AI/�Ʒ���/�ӷ��Ʒ���")]
    [NodeTitle("�ӷ��Ʒ���")]
    public class AddScorer : ScorerNode
    {
        public override float Scorer(IAIContext context)
        {
            float score = 0;
            var evaluators = GetAllOnPort<EvaluatorNode>(nameof(evaluator));
            foreach (var evaluator in evaluators)
            {
                Step(evaluator,
                    (EvaluatorSingleNode single) =>
                    {
                        score += single.Evaluate(context);
                    });
            }
            return score;
        }
    }

}