# Auto(Var)

> Implicit typed local variable (암시적 타입 지역변수)

user에 의해 로컬변수의 타입이 정해지는 것이 아니라 컴파일러에 의해서 타입이 정해지는 것

## Var

1. var 로 변수 선언시 -> 초기화까지 한 번에 해줘야함

2. 함수 정의시 사용 불가

3. single variable만 정의 가능, ex) `var i, j, k` : X


```cs
static void Main(string[] args)
{
    var a; // 컴파일러 에러
}
```

암시적으로 형식화된 로컬변수는 초기화가 필요

```cs
static void Main(string[] args)
{
    var a = 10; // int형 10으로 초기화

    a = "Hi" // 컴파일러 에러
}
```

대입되는 값의 타입에 따라 변수의 타입은 암시적으로 정해짐

이후에 그 변수는 다른 타입의 값을 대입하게된다면 오류가 발생

#### **cf. 변수의 타입이 궁금하다면**

```cs
var fullName = name + " lee"; // C++의 Auto와 같은 용도


// GetType()를 사용하여 객체의 타입 정보를 출력
Console.WriteLine(fullName.GetType()); // System.String

var number = 100; // 초기화도 같이 해줘야함
Console.WriteLine(number.GetType()); // System.Int32
```

GetType메소드 이용

## for, foreach

```cs
// for, foreach를 쓸 때 유용
for(var i = 1; i <= 10; i++)
{
    Console.WriteLine(i); // 1, 2, 3.... ,9, 10
}

string[] arr = { "Alpha", "Beta", "Gamma" };

foreach(var i in arr)
{
    Console.WriteLine(i);
}
```
