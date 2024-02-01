using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace Bb.MultiCsv
{

    public class JsonVisitor : IVisitor<JsonNode>
    {

        public JsonVisitor()
        {
            this._hash = new HashSet<Block>();
        }

        public JsonNode Visit(Block block)
        {

            Dictionary<string, JsonNode> dic = new Dictionary<string, JsonNode>();

            foreach (Block subList in block.Subs)
            {

                if (!dic.TryGetValue(subList.Name, out var list))
                    dic.Add(subList.Name, list = new JsonArray());

                if (this._hash.Add(subList))
                    (list as JsonArray).Add(subList.Accept(this));

                else
                {

                }

            }

            foreach (var property in block)
                if (!IgnoreEmptyProperties || !string.IsNullOrEmpty(property.Value))
                    dic.Add(property.Key, JsonValue.Create(property.Value));

            var result = new JsonObject();

            foreach (var kv in dic)
                result.Add(new KeyValuePair<string, JsonNode>(kv.Key, kv.Value));

            return result;

        }

        public bool IgnoreEmptyProperties { get; set; }

        private readonly HashSet<Block> _hash;

    }
}
