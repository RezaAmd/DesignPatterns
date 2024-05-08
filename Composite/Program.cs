using Composite.Composites;
using Composite.Models;

Console.WriteLine("Composite design pattern:\n");

CompositeNode root = new CompositeNode();
root.Add(new Leaf("src"));

CompositeNode src = new CompositeNode();
src.Add(new Leaf("Application"));

CompositeNode application = new CompositeNode();
application.Add(new Leaf("Common"));
application.Add(new Leaf("CQRS"));
src.Add(application);

src.Add(new Leaf("Domain"));
src.Add(new Leaf("Infrastructure"));
root.Add(src);
root.Add(new Leaf("tests"));

root.Display(1);