using System.Collections;

namespace HomeWorks;

public class MyList<MyType> : IEnumerable<MyType> where MyType : new()
{
    private MyType?[] _data;
    private int _count;
    private int _size;

    public MyList()
    {
        _data = new MyType?[1];
        _count = 0;
        _size = 1;
    }

    public void Add(MyType? item)
    {
        if (_count < _size)
        {
            _data[_count] = item;
            _count++;
        }
        else
        {
            _size += 1;
            MyType[] tmp = new MyType[_size];
            _data.CopyTo(tmp, 0);
            _data = new MyType[_size];
            tmp.CopyTo(_data, 0);
            _data[_count] = item;
            _count++;
        }
    }

    public bool Remove(MyType item)
    {
        int indexToRemove = Array.IndexOf(_data, item);
        if (indexToRemove == -1)
        {
            return false;
        }

        _size--;
        _count--;
        MyType[] newData = new MyType[_size];
        for (int i = 0; i < indexToRemove; i++)
        {
            newData[i] = _data[i]!;
        }

        for (int i = indexToRemove; i < newData.Length; i++)
        {
            newData[i] = _data[i + 1]!;
        }

        _data = new MyType[_size];
        newData.CopyTo(_data, 0);

        return true;
    }

    public MyType? this[int index]
    {
        get
        {
            if (index >= 0 && index < _count)
            {
                return _data[index];
            }
            throw new IndexOutOfRangeException("Index is out of range.");
        }
        set
        {
            if (index >= 0 && index < _count)
            {
                _data[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
        }
    }

    public int Find(MyType item)
    {
        return Array.IndexOf(_data, item);
    }

    public static MyList<MyType> operator +(MyList<MyType> list, MyType item)
    {
        list.Add(item);
        return list;
    }

    public static MyList<MyType> operator -(MyList<MyType> list, MyType item)
    {
        list.Remove(item);
        return list;
    }


    public IEnumerator<MyType?> GetEnumerator()
    {
        return _data.AsEnumerable().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}