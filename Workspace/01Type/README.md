# Type

Type Casting, Type Conversion
<br/>

## Type Casting(형 변환)

> 형 변환은 변수나 표현식의 데이터 형을 다른 데이터 형으로 변환하는 것을 의미
> <br/>
> C#에서 형 변환은 두 가지 유형으로 나뉨
> <br/>

1. implicit casting(암시적 형 변환)

   > 작은 데이터 형에서 큰 데이터 형으로 변환되는 것
   > <br/>

   ```cs
   int tmp1 = 10;
   long longTmp = tmp1; // 암시적 형 변환 (implicit casting)
   Console.WriteLine(longTmp); // 10
   ```

   <br/>

2. explicit casting(명시적 형 변환)

   > 큰 데이터 형에서 작은 데이터 형으로의 변환 또는 서로 다른 데이터 형 간의 변환 시 사용
   > <br/>

   ```cs
   int tmp2 = (int)7.7; // 명시적 형 변환 (explicit casting)
   Console.WriteLine(tmp2); // 7
   ```

   <br/>

## Type Conversion(형식 변환)

> 형식 변환은 데이터의 표현 방식을 변경하거나 다른 형식으로 변환
> <br/>

```cs
// 형식 변환 (Type Conversion)
Console.WriteLine(Convert.ToString(num)); // 65
Console.WriteLine(Convert.ToBoolean(num)); // True
Console.WriteLine(Convert.ToChar(num)); // A
```

<br/>

cf. ToBoolean
<br/>

**Convert.ToBoolean** 메서드는 다양한 data type을 bool으로 변환하는 데 사용
<br/>

일반적으로 0이 아닌 정수값은 true로 변환
<br/>

**Convert.ToBoolean**은 0이 아닌 모든 정수값을 true로 변환하고, 0은 false로 변환
<br/>

## 참고

[C# learn 문서 - conversion](https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/language-specification/conversions#102-implicit-conversions)
<br/>

[블로그 참조](https://to-be-great-organizer.tistory.com/148)
