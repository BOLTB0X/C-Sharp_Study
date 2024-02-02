# Hello

C#은 OOP
<br/>

```cs
namespace HelloCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#");
        }
    }
}
```

## 동작 과정

**namespace -> class -> method**
<br/>

> namespace 키워드는 관련 개체 집합을 포함하는 범위를 선언하는 데 사용
> <br/>
> 네임스페이스를 사용하여 코드 요소를 구성하고 전역적으로 고유한 형식을 만듬
> <br/>
> class는 객체, 객체를 형성하는 method, 변수를 명시하고 담아두는 틀 같은 것
> <br/>

<br/>

즉 위 코드 'Hello C#'을 출력하기 위해 출력문, 메소드, 클래스 등을 이건 Hello용으로 묶는 것이 **namespace**
<br/>

- 서로 다른 목적을 가진 코드를 namespace로 분리하여 유지보수성을 향상
  <br/>
- 한 namespace 안에 다른 namespace를 중첩하여 사용할 수 있음
  <br/>
- C#에서 모든 코드는 class 안에서 작성(객체지향)
  <br/>

## 참고

[C# learn 문서 - namespace](https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/namespace)
<br/>

[블로그 참조](https://to-be-great-organizer.tistory.com/148)
