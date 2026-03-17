using System;
using System.Collections.Generic;
using System.Drawing;
using static System.Console;



// 1 

string s1 = "hello";
string s2 = "hello";
string s3 = new string("hello".ToCharArray());
// 문자열은 == 연산자가 값비교를 수행함 (특이 케이스)
WriteLine(s1 == s2);
WriteLine(s1 == s3);

// 참조 동등성 확인
WriteLine(object.ReferenceEquals(s1, s2));
WriteLine(object.ReferenceEquals(s1, s3));

WriteLine();

// 2
Player p1 = new("one", 10);
Player p2 = new("one", 10);
Player p3 = p1;

WriteLine($"p1 == p2: {p1 == p2}");
WriteLine($"p1 == p3: {p1 == p3}");
WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");
WriteLine($"p1.Eqauls: {p1.Equals(p3)}");

WriteLine();

// 3
Point pt1 = new Point(10, 20);
Point pt2 = new(10, 20);
Point pt3 = new Point(30, 40);

WriteLine($"pt1.Equals(pt2)) : {pt1.Equals(pt2)}");
WriteLine($"pt1.Equals(pt3)) : {pt1.Equals(pt3)}");

WriteLine();

// 4
Item item1 = new("Sword", 1);
Item item2 = new("Sword", 1);
Item item3 = new("Shield", 2);
// 구현한 Equals 메서드 호출
WriteLine($"item1.Equals(item2): {item1.Equals(item2)}");
WriteLine($"item1.Equals(item3): {item1.Equals(item3)}");

HashSet<Item> inventory = new HashSet<Item>();
inventory.Add(item1);
WriteLine($"inventory.Contains(item2): {inventory.Contains(item2)}");

WriteLine();

// 5
BadItem b1 = new BadItem("potion");
BadItem b2 = new BadItem("potion");
WriteLine($"b1.Equals(b2): {b1.Equals(b2)}");

Dictionary<BadItem, int> Stock = new();
Stock[b1] = 10;
WriteLine($"Stock.ContainsKey(b2) : {Stock.ContainsKey(b2)}");

WriteLine();

// 6
List<Monster> monsters = new()
{
    new Monster("Goblin",30),
    new Monster("Dragon", 100),
    new Monster("Slime", 10),
    new Monster("Orc", 50)
};
WriteLine("정렬 전:");
foreach (Monster m in monsters)
{
    WriteLine($"{m.Name}(전투력: {m.Power})");
}

monsters.Sort();

WriteLine("정렬 후:");
foreach (Monster m in monsters)
{
    WriteLine($"{m.Name}(전투력: {m.Power})");
}

WriteLine();

// 7
