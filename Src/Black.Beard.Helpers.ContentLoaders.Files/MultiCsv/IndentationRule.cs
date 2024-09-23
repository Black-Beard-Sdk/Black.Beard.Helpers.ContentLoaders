using System;
using System.Collections.Generic;

namespace Bb.MultiCsv
{

    /// <summary>
    /// Indentation rule
    /// </summary>
    public class IndentationRule
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="IndentationRule"/> class.
        /// </summary>
        /// <param name="rule"></param>
        public IndentationRule(string rule)
        {
            var items = rule.Trim().Split(':');
            this.Key = items[0].Trim();
            this.Children = new HashSet<string>();
            var i = items[1].Trim().Split('|', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in i)
                this.Children.Add(item.Trim());
        
        }

        /// <summary>
        /// Key of the rule
        /// </summary>
        public string Key { get; }

        /// <summary>
        /// Items of the rule
        /// </summary>
        public HashSet<string> Children { get; }

        internal void Merge(IndentationRule rule)
        {
            foreach (var item in rule.Children)
                this.Children.Add(item);
        }

    }

}
