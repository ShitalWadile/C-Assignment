using System;
using Sytsem.Collections.Generic;
using System.Linq;
using System.Text;
namespace My_Stack{
	class MyStack{
		
	static void Main(String[] args){
		 
		stack MyStack = new stack();
		Mystack.push("punam");
		Mystack.Push("Shital");
		Mystack.push("Pranjal");
		Mystack.push("Anjali");
		Mystack.push("Radha");
		
	}
		foreach(var stackItem in Mystack){
			Console.WriteLine(StackItem);
			
		}
		Console.WriteLine("Count Stack"+Mystack.Count);
		Console.WriteLine("Peek Element"+Mystack.peek());
		Console.WriteLine("Pop Element"+Mystack.pop());
		Console.WriteLine("After peek Element"+Mystack.peek());
		Console.Readkey();
	}
	if (Mystack.Count<=0|| Mystack.Count<=5){
		Console.WriteLine("There is Exception in stack");
		Console.ReadLine();
		
	}
	
	
}

