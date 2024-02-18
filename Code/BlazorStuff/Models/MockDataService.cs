namespace KodbokenBlazor
{

    public class MockdataService
    {
        private static List<Member> InitializeMockMember()
        {

           List<Member> members = new List<Member>();

            Member member = new Member
            (
                1,
                "User123",
                "ExampleEmail@gmail.com",
                "123",
                true,
                true,
                UserTypes.SuperUser,
                Gender.Male,
                ProgrammingLang.Scratch

            );

            members.Add( member );
            return members;
        }
    }
}
