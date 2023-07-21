using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

namespace UtilityAI
{
    [CreateAssetMenu(menuName = "Utility AI/�����󶨼�")]
    public class BinderGraph : AIBaseGraph
    {
        private BinderSetNode binderSet;
        public IEnumerable<BinderNode> Binders => BinderSet.Binders;
        public BinderSetNode BinderSet => GetUniqueNode(binderSet);
    }
}