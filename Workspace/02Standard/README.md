# stdin, stdout(표준 입출력)

stdin(표준 입력): Console.Read(), Console.ReadLine()
<br/>

stdout(표준 출력): Console.Write(), Console.WriteLine()
<br/>

## stdin(표준 입력)

- Console.Read()

  > 표준 입력에서 한 문자를 읽음, 반환값은 int32형이고 ASCII 값으로 반환
  > <br/>

  ```cs
  // Console.Read()
  int inputVar = Console.Read();
  Console.WriteLine(inputVar); // ASCII 값

  char charInputVar = (char)inputVar; // ASCII 값을 문자로 변환
  Console.WriteLine(charInputVar);
  ```

- Console.ReadLine()

  > 표준 입력에서 한 줄을 읽음, 반환값은 문자열
  > <br/>

  ```cs
  // Console.ReadLine()
  string inputStr = Console.ReadLine();
  Console.WriteLine("출력" + inputStr);
  ```

<br/>

## stdout(표준 입출력)

- Console.Write()

  > 인자로 주어진 값을 표준 출력에 출력
  > <br/>
  > 개행문자 없이 그대로 출력
  > <br/>

  ```cs
  int age = 25;
  Console.Write("I am " + age + " years old.");
  ```

- Console.WriteLine()

  > Console.Write()와 같이 출력이지만 출력 후에 자동으로 줄 바꿈이 추가
  > <br/>

  ```cs
  Console.WriteLine(7 < 5); // False
  Console.WriteLine(3.14); // 3.14

  string ageInput = Console.ReadLine();
  age = Convert.ToInt32(ageInput); // 입력이 문자열 이므로

  Console.WriteLine("I am " + age + " years old.");
  ```
