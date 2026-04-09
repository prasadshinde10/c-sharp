// ============================================
// Program #196 — CommandPattern
// Category  : 20_Design_Patterns
// Difficulty: [Intermediate]
// Description: Command pattern with undo and redo for text editor
// ============================================

using System;
using System.Collections.Generic;

namespace CSharp30Programs.Design_Patterns
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }

    class TextEditor
    {
        public string Content { get; private set; } = string.Empty;

        public void Append(string text) => Content += text;

        public void RemoveLast(int count)
        {
            if (count <= 0 || Content.Length == 0) return;
            int length = System.Math.Max(0, Content.Length - count);
            Content = Content.Substring(0, length);
        }
    }

    class AppendTextCommand : ICommand
    {
        private readonly TextEditor _editor;
        private readonly string _text;

        public AppendTextCommand(TextEditor editor, string text)
        {
            _editor = editor;
            _text = text;
        }

        public void Execute() => _editor.Append(_text);

        public void Undo() => _editor.RemoveLast(_text.Length);
    }

    class CommandManager
    {
        private readonly Stack<ICommand> _undoStack = new Stack<ICommand>();
        private readonly Stack<ICommand> _redoStack = new Stack<ICommand>();

        public void Execute(ICommand command)
        {
            command.Execute();
            _undoStack.Push(command);
            _redoStack.Clear();
        }

        public void Undo()
        {
            if (_undoStack.Count == 0) return;
            var command = _undoStack.Pop();
            command.Undo();
            _redoStack.Push(command);
        }

        public void Redo()
        {
            if (_redoStack.Count == 0) return;
            var command = _redoStack.Pop();
            command.Execute();
            _undoStack.Push(command);
        }
    }

    class Program_196_CommandPattern
    {
        static void Main(string[] args)
        {
            var editor = new TextEditor();
            var manager = new CommandManager();

            manager.Execute(new AppendTextCommand(editor, "Hello"));
            manager.Execute(new AppendTextCommand(editor, " World"));
            Console.WriteLine("After typing : " + editor.Content);

            manager.Undo();
            Console.WriteLine("After undo   : " + editor.Content);

            manager.Redo();
            Console.WriteLine("After redo   : " + editor.Content);
        }
    }
}
