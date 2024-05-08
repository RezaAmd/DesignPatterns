// https://www.perplexity.ai/search/write-me-a-oQznyLLeTguSe795JStfSA#2
using Decorator.Components;
using Decorator.Contracts;
using Decorator.Decorators;

Console.WriteLine("Decorator design pattern:\n");
// Create a Concrete Component
IOperationComponent component = new ConcreteComponent();

// Wrap the Concrete Component with a Concrete Decorator
DecoratorObj decorator = new ConcreteDecorator(component);

// Call operation on the Decorator
decorator.Operation();

Console.ReadLine();
