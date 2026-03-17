using System;
using System.Collections.Generic;
using System.Text;

class Item : IEquatable<Item>
{
    public string Name;
    public int Id;
    // 생성자로 값 할당
    public Item(string name, int id)
    {
        Name = name;
        Id = id;
    }
    // IEquatable<Item>의 구현
    public bool Equals(Item other)
    {
        if (other == null)
        {
            return false;
        }
        // Item other와 현재 개체의 아이디가 같거나 
        return Id == other.Id && Name == other.Name;
    }
    // 오버라이드 구현
    public override bool Equals(object obj)
    {
        return Equals(obj as Item);
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name);
    }
}
