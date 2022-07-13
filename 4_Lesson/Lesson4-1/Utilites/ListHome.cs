using System.Collections;

namespace _4_Lesson;

//Создаем связанный список /свой свобственный/
public class ListHome<T> : IEnumerable<T>
    //------------------------------------------------------------------------------------------------------------------------------------------
{
    //Вложенный класс. Класс узла
    public class Node
    {
     //------------------------------------------------------------------------------------------------------------------------------------------
     //ПОЛЯ ЭЛЕМЕНТА
        internal ListHome<T> List { get; set; }
        public T? Value { get; set; }
        public Node? Prev { get; internal set; }
        public Node? Next { get; internal set; }
        internal Node(ListHome<T> List, T value)
        {
            Value = value;
            this.List = List;
        }

    }
    //------------------------------------------------------------------------------------------------------------------------------------------
    //ПОЛЯ СПИСКА
    public int _Count;
    public Node? First { get; set; }
    public Node? Last { get; set; }

    //------------------------------------------------------------------------------------------------------------------------------------------
    //МЕТОДЫ СПИСКА
    //Добавление первого элемента списка
    public Node AddFirst(T value)
    {

        var node = new Node(this, value);                         

        _Count++;
        //Список пуст создаем первый элемент
        if (First is null)
        {
            First = node;            
            Last = node;

            return node;
        }
        //Список не пуст. Двигаем первый элемент, вставляем на место первого, новый элемент.
        node.Next = First;
        First.Prev = node;
        First = node;
        return node;

    }
   
    //Добавление последнего элемента
    public Node AddLast(T value)
    {

        var node = new Node(this, value);

        _Count++;
        //Список пуст создаем первый элемент
        if (Last is null)
        {
            Last = node;
            First = node;

            return node;
        }
        //Список не пуст. Двигаем первый элемент вставляем, на место него новый элемент.
        node.Prev = Last;
        Last.Next = node;
        Last = node;
        return node;

    }

    //Добавление элемента в ДО указанного
    public Node AddBefore(Node Position, T value)
    {
        if (!ReferenceEquals(Position.List, this))
            throw new InvalidOperationException("Нельзя добавить узел после указанного узла. Указанный узел принадлежит другому списку.");

        if (ReferenceEquals(Position, First))
            return AddFirst(value);

        var node = new Node(this, value)
        {

            Next = Position,
            Prev = Position.Prev,

        };
       
        _Count++;

        Position.Prev = node;
        node.Prev!.Next = node;

        return node;

    }

    //Добавление элемента ПОСЛЕ указанного
    public Node AddAfter(Node Position, T value)
    {
        if (!ReferenceEquals(Position.List, this))
            throw new InvalidOperationException("Нельзя добавить узел после указанного узла. Указанный узел принадлежит другому списку.");

        if (ReferenceEquals(Position, Last))
            return AddLast(value);

        var node = new Node(this, value)
        {

            Prev = Position,
            Next = Position.Next,

        };

        _Count++;

        Position.Next = node;
        node.Next!.Prev = node;

        return node;
        
    }

    //Удаление элемента из текущего списка
    public T Remove(Node node)
    {

    //Проверка на наличие в списке только одного узла
        if (ReferenceEquals(First, Last))
        {

            First = null;
            Last = null;

            _Count = 0;

            return node.Value!;

        }

    //Проверка на первый узел
        if (ReferenceEquals(node, First))
        {

            First = node.Next;
            First!.Prev = null;

            _Count--;

            return node.Value!;

        }

    //Проверка на последний узел
        if(ReferenceEquals(node, Last))
        {

            Last = node.Prev;
            Last!.Next = null;
            
            _Count--;

            return node.Value!;

        }
    
    //Удаление ноды
        node.Prev!.Next = node.Next;
        node.Next!.Prev = node.Prev;

        node.Next = null;
        node.Prev = null;

        _Count--;

        return node.Value!;
        
    }

    //Метод очистки списка
    public void Clear()
    {

        var node = First;
        while(node is not null)
        {
            node.Prev = null;
            var temp = node;
            node = node.Next;
            temp.Next = null;
        }

        _Count = 0;
        First = Last = null;

    }
    //------------------------------------------------------------------------------------------------------------------------------------------
    //ИНТЕРФЕЙС
    public IEnumerator<T> GetEnumerator()
    {
        var node = First;
        while (node is not null)
        {
            yield return node.Value!;
            node = node.Next;
        }
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    //Переопределяем ToString
    public override string ToString() => string.Join(", ", this);
   
}
   