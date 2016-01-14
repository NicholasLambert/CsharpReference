/*
 * This program creates a stack object called myStack
 * The stack is then given two new objects
 * The objects are then printed back out, in the reverse order of what they were added
 */
using System;
using System.Collections;

namespace Stacks
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Create Stack object
			Stack myStack = new Stack();

			//add some objects into my stack
			myStack.Push("Hello");
			myStack.Push ("World");

			//Write some things to the console about the stack
			Console.WriteLine("Stack Demo");
			Console.WriteLine ("Stack Count: {0}", myStack.Count);

			//function to print the stack by passing the stack into it
			PrintStack (myStack);

		}

		public static void PrintStack(IEnumerable myCollection) {
			foreach (Object obj in myCollection) {
				Console.WriteLine(obj);
			}
		}
	}
}
