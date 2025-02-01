// using에는 using statement와 using directive라는 두 가지 용도가 있다.

/* Using Directive (네임스페이스 포함)
 * using directive는 특정 네임스페이스를 코드에 포함시켜,
 * 그 네임스페이스 안의 클래스를 전체 코드에서 사용할 수 있게 만든다.
 * 파일의 맨 위에서 선언하여, 해당 파일 내에서 여러 번 사용할 수 있는 클래스들을 쉽게 접근할 수 있게 한다.
 */

using EntityFrameworkCoreExample;
using Microsoft.EntityFrameworkCore.Metadata;

/* Using Statement (리소스 관리)
 * using statement는 리소스 관리와 관련이 있다. 
 * IDisposable 인터페이스를 구현하는 객체를 사용할 때, 
 * 객체가 더 이상 필요하지 않으면 자동으로 리소스를 해제하기 위해 사용된다.
 * using statement는 객체의 생애 주기를 관리하며, 
 * 블록이 종료되면 해당 객체의 Dispose() 메서드가 자동으로 호출되어 리소스가 해제된다.
 * IDisposable 인터페이스는 C#에서 리소스를 안전하게 해제하기 위해 사용하는 도구입니다.
 * 리소스는 예를 들어, 파일, 네트워크 연결, 데이터베이스 연결 같은 메모리 외의 자원을 말합니다. 
 * 이런 리소스들은 프로그램이 더 이상 필요하지 않을 때 반드시 수동으로 해제해야 합니다. 
 * IDisposable은 그런 작업을 자동으로 도와주는 방법을 제공합니다.
 * IDisposable 인터페이스는 **Dispose()**라는 메서드 하나를 가지고 있습니다. 
 * 이 메서드는 객체가 더 이상 필요하지 않거나, 객체가 사용하는 리소스를 해제할 때 호출됩니다.
 */

using StudentContext dbContext = new();

// Add With EF Core (C)
Student s = new()
{
    FullName = "Danbi K",
    EmailAddress = "DanbiK@gmail.com",
    DateOfBirth = new DateTime(2018, 2, 27)
};

Student s2 = new()
{
    FullName = "Cheonsa K",
    EmailAddress = "CheonsaK@gmail.com",
    DateOfBirth = new DateTime(2018, 2, 27)
};

dbContext.Students.Add(s); // Prepares the Student insert statement
dbContext.SaveChanges(); // Execute pending insert (pending insert 외에 아직 실행되지 않은 업데이트나 삭제도 실행)
// add 다음에 꼭 saveChanges 해줘야댐

dbContext.Students.Add(s2); 
dbContext.SaveChanges();

// Retrieve Student from DB (R)
List<Student> allStudents = dbContext.Students.ToList(); // Method syntax 다른 예시는 Query syntax 인데 길고 복잡하다

foreach (Student stu in allStudents) 
{ 
    Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
}

/* CRUD functionality 전체 예시는 밑에 사이트 참조
 * https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=visual-studio
 */