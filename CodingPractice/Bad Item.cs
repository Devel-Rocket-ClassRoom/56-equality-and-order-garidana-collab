using System;
using System.Collections.Generic;
using System.Text;

class BadItem
{
    public string Name;

    public BadItem(string name)
    {
        Name = name;
    }

    public override bool Equals(object obj)
    {
        // obj를 BadItem으로 변환을 시도하고
        BadItem other = obj as BadItem;
        // 변환이 실패할시에는 other는 null이됨
        if (other == null)
        {
            return false;
        }
        // 변환에 성공할 시 other는 BadItemㅇ로 변환이된 obj가 됨
        return Name == other.Name;

        // as 는 안전한 형변환 연산자
    }

}