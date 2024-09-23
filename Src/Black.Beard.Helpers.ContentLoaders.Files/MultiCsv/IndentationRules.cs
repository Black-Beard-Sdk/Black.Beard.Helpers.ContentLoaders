using System;
using System.Collections.Generic;

namespace Bb.MultiCsv
{

    /// <summary>
    /// List of rules
    /// </summary>
    public class IndentationRules
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="IndentationRules"/> class.
        /// </summary>
        /// <param name="payload"></param>
        public IndentationRules(string payload)
        {

            this._rules = new Dictionary<string, IndentationRule>();

            var rules = payload
                .Trim()
                .Split(';', StringSplitOptions.RemoveEmptyEntries);

            foreach (var rulePayload in rules)
            {
                var rule = new IndentationRule(rulePayload);
                if (this._rules.TryGetValue(rule.Key, out IndentationRule r))
                    r.Merge(rule);
                else
                    this._rules.Add(rule.Key.Trim(), rule);
            }

            _isNotEmpty = this._rules.Count > 0;

        }

        /// <summary>
        /// contains rules
        /// </summary>
        public bool HasRule => _isNotEmpty;

        /// <summary>
        /// Return true if the child is embedded in the parent otherwise false if the items have same parent.
        /// </summary>
        /// <param name="parent">parent</param>
        /// <param name="child">item that is maybe a child</param>
        /// <returns></returns>
        internal bool EvaluateIfEmbeddedInParent(Block parent, Block child)
        {

            if (_isNotEmpty && this._rules.TryGetValue(parent.Name, out IndentationRule r))
                return r.Children.Contains(child.Name);

            return false;

        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is IndentationRules rules
                && _isNotEmpty == rules._isNotEmpty;
        }

        private readonly Dictionary<string, IndentationRule> _rules;
        private readonly bool _isNotEmpty;

    }

}
