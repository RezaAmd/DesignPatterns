using Builder.Builders;
using Builder.Models;

// + Easy to use.
// - Need more time to develop and change.

Console.WriteLine("Builder design pattern:");

// Its difficult to detect Class cunstructor parameters.
// User abbas = new("Abbas", "abbas@example.com", "090000000000", 32, 179, 83);

// But you can use builder design pattern.
User abbas = new UserBuilder("Abbas", "abbas@example.com") // Requires params.
                                                           //.WithPhoneNumber("099999999999") // Optional
    .WithAge(32)
    .WithHeight(179)
    .WithWeight(83)
    .Build();
;

Console.WriteLine($"Hi im {abbas.Name} my weight is {abbas.Weight}, i was made by builder!");