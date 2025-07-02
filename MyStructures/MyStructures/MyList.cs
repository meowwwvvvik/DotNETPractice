namespace MyStructures
{
  /// <summary>
  /// Список
  /// </summary>
  public class MyList
  {
    private int[] _array;
    private int _cursor;
    /// <summary>
    /// Конструктор
    /// </summary>
    public MyList()
    {
      _array = new int[2];
      _cursor = 0;
    }

    /// <summary>
    /// Добавляет элемент в конец списка
    /// </summary>
    /// <param name="item">Элемент</param>
    public void Add(int item)
    {
      _array[_cursor] = item;
      _cursor += 1;

      if (CapacityIsFull())
      {
        CreateBiggerArray();
      }
    }

    /// <summary>
    /// Добавляет множество элементов в список
    /// </summary>
    /// <param name="items">Элементы для добавления</param>
    public void AddRange(int[] items)
    {
      foreach (var i in items)
      {
        Add(i);
      }
    }

    /// <summary>
    /// Проверяет, существует ли элемент item в списке
    /// </summary>
    /// <param name="item">Элемент</param>
    /// <returns>true - если существует, false - если не существует</returns>
    public bool Exist(int item)
    {
      return (_array.Contains(item));
    }

    /// <summary>
    /// Возвращает диапазон из списка в виде MyList
    /// </summary>
    /// <param name="startIndex">Индекс начала</param>
    /// <param name="endIndex">Индекс конца</param>
    /// <returns>Список - диапазон</returns>
    public MyList? GetRange(int startIndex, int endIndex)
    {
      var _rangeArray = new MyList();

      if (startIndex < 0 || startIndex >= _array.Length || endIndex < 0 || endIndex >= _array.Length)
      {
        Console.WriteLine("Index out of range.");
        return null;
      }
      for (int i = startIndex; i <= endIndex; i++)
      {
        _rangeArray.Add(_array[i]);
      }
      return _rangeArray;
    }
    

    /// <summary>
    /// Получение элемента из списка по индексу
    /// </summary>
    /// <param name="index">Индекс</param>
    /// <returns>Элемент</returns>
    public int Get(int index)
    {
      return _array[index];
    }

    /// <summary>
    /// Очистка списка
    /// </summary>
    public void Clear()
    {
      _array = new int[2];
      _cursor = 0;
    }

    private void CreateBiggerArray()
    {
      var biggerArray = new int[_array.Length * 2];

      for (var i = 0; i < _array.Length; i++)
      {
        biggerArray[i] = _array[i];
      }

      _array = biggerArray;
    }
    private bool CapacityIsFull()
    {
      return _cursor == _array.Length;
    }
  }
}
