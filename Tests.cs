using System;
using Xunit;

namespace greeting_kata_csharp
{
    public class Tests
    { 
        [Fact]
        public void have_to_greet()
        {
            Assert.Equal("Hello, Bob.", Greeting.greet("Bob"));
        }

        [Fact]
        public void have_to_greet_my_friend()
        {
            Assert.Equal("Hello, my friend.", Greeting.greet(null));
        }

        [Fact]
        public void have_to_greet_my_friend_shouting()
        {
            Assert.Equal("HELLO BOB!", Greeting.greet("BOB"));
        }

        [Fact]
        public void have_to_greets_two_names()
        {
            string[] names = new string[] { "Jill", "Jane" };

            Assert.Equal("Hello, Jill and Jane.", Greeting.greet(names));
        }

        [Fact]
        public void have_to_greets_random_names()
        {
            string[] names = new string[] { "Amy", "Brian", "Charlotte" };

            Assert.Equal("Hello, Amy, Brian, and Charlotte.", Greeting.greet(names));
        }

        [Fact]
        public void have_to_greets_two_names_shouting ()
        {
            string[] names = new string[] { "BOB", "BRIAN" };

            Assert.Equal("HELLO, BOB AND BRIAN!", Greeting.greet(names));
        }
        
        [Fact]
        public void have_to_greets_random_names_shouting ()
        {
            string[] names = new string[] { "BOB", "BRIAN", "CARLOTA" };

            Assert.Equal("HELLO, BOB, BRIAN, AND CARLOTA!", Greeting.greet(names));
        }

        [Fact]
        public void have_to_greets_mixed_types_of_greetings ()
        {
            string[] names = new string[] { "Amy", "BRIAN", "Charlotte" };

            Assert.Equal("Hello, Amy and Charlotte. AND HELLO BRIAN!", Greeting.greet(names));
        }
        
    }
}