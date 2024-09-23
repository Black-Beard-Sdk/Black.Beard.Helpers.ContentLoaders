using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bb.MultiCsv
{

    /// <summary>
    /// File reader
    /// </summary>
    public class FileReader
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FileReader"/> class.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="rulePayload"></param>
        /// <param name="initializer"></param>
        /// <returns></returns>
        public static FileReader FileReadFile(string filePath, string rulePayload, Action<FileReader>? initializer)
        {

            var reader = new FileReader(filePath, rulePayload);
            if (initializer != null)
                initializer(reader);
            reader.Read();
            return reader;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileReader"/> class.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="rulePayload"></param>
        /// <param name="initializer"></param>
        /// <returns></returns>
        public static FileReader FileReadFile(string filePath, IndentationRules rulePayload, Action<FileReader>? initializer)
        {

            var reader = new FileReader(filePath, rulePayload);
            if (initializer != null)
                initializer(reader);
            reader.Read();
            return reader;

        }

        private FileReader(string filePath, string rulePayload)
        {
            this._filePath = filePath;
            stack = new Stack<Block>();
            this._items = new List<Block>();
            _rule = new IndentationRules(rulePayload);
        }

        private FileReader(string filePath, IndentationRules rulePayload)
        {
            this._filePath = filePath;
            stack = new Stack<Block>();
            this._items = new List<Block>();
            _rule = rulePayload ?? new IndentationRules(string.Empty);
        }

        private void Read()
        {

            Encoding encoding = Encoding.UTF8;
            Block _nextToSee = null;

            using (var lexer = new Lexer(this._filePath, encoding))
            {

                var token = lexer.MoveNext();
                stack.Push(lexer.Current);

                while (While(lexer))
                {

                    var parent = stack.Peek();
                    var current = lexer.Current;

                    if (this._rule.EvaluateIfEmbeddedInParent(parent, current))
                    {
                        parent.Add(current);
                        stack.Push(current);
                    }
                    else
                    {

                        parent = stack.Pop();

                        while (stack.Count > 0 && (!this._rule.EvaluateIfEmbeddedInParent(parent, current)))
                            parent = stack.Pop();

                        if (!string.IsNullOrEmpty(_see) && current.Name == _see)
                        {
                            if (_nextToSee != null && _nextToSee != current)
                            {
                                var add = _filter(_nextToSee);
                                if (!add)
                                    parent.Remove(_nextToSee);
                            }
                            _nextToSee = current;
                        }

                        parent.Add(current);
                        stack.Push(parent);
                        stack.Push(current);

                    }

                }

                while (stack.Count > 0)
                {
                    var current = stack.Pop();
                    if (stack.Count == 0 || !stack.Peek().Subs.Contains(current))
                        this._items.Add(current);
                }

                this.FileInformations = lexer.FileInformations;

            }

        }

        /// <summary>
        /// Intercepts the block to see.
        /// </summary>
        /// <param name="see"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public FileReader See(string see, Func<Block, bool> filter)
        {

            if (string.IsNullOrEmpty(see))
                throw new ArgumentNullException(nameof(see));

            if (filter == null)
                throw new ArgumentNullException(nameof(filter));

            _see = see;
            _filter = filter;

            return this;

        }

        public FileReader WithVisitor(JsonVisitor visitor)
        {
            this._visitor = visitor;
            return this;
        }

        private bool While(Lexer lexer)
        {

            if (lexer.Token == Token.EOF)
                return false;

            var token = lexer.MoveNext();

            return token != Token.EOF;

        }

        private string _see = null;
        private Func<Block, bool> _filter;

        private readonly string _filePath;
        private Stack<Block> stack;
        private readonly List<Block> _items;
        private readonly IndentationRules _rule;

        internal JsonVisitor _visitor;

        /// <summary>
        /// File informations
        /// </summary>
        public FileInformations FileInformations { get; private set; }

        public IEnumerable<Block> Items { get => _items; }

    }

}
