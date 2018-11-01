using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Remutable
{
    internal class ProcessContext<TSource>
    {
        public TSource Source { get; set; }
        public object Target { get; set; }
        public ParameterExpression SourceParameterExpression { get; set; }
        public ParameterExpression IndexParameterExpression { get; set; }
        public Expression InstanceExpression { get; set; }
        public List<int> IndexParameterValues { get; set; }
        public List<string> AffectedProperties { get; set; }
        public bool IsLastProcessedIndex { get; set; }

        public ProcessContext()
        {
            AffectedProperties = new List<string>();
            IndexParameterValues = new List<int>();
        }
    }
}