namespace UtilityAI
{
    [CreateNodeMenu("Utility AI/ѡ����/ȡ��ѡ����")]
    [NodeTitle("ȡ��ѡ����")]
    public class MaxSelector : SelectorNode
    {
        public override IAction Select(IAIContext context)
        {
            float score = float.MinValue;
            BinderSingleNode result = null;
            float value;
            var binders = GetAllOnPort<BinderNode>(nameof(binder));
            foreach (var binder in binders)
            {
                Step(binder,
                    (BinderSingleNode single) =>
                    {
                        value = single.Scorers.Scorer(context);
                        if (score < value)
                        {
                            score = value;
                            result = single;
                        }
                    }
                    );
            }
            return result.Action;
        }
    }
}