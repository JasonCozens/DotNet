# DotNet

This file explains how things were developed.

## To Do List

The object of this exercise was to incrementally build a console based to do list.
The first version would have the folowing functionality:

* Create a new to do list.
* Open a file containing a to do list.
* Add to do items.
* Delete to do items.
* Save the changes.
* Close the file.

The implementation shuld be fully tested and to enable this prig is being used to stub system assemblies.

## Wednesday 18th May 2016

Having used prig to test the Open method I moved onto the Add item method but testing this was difficult because of the need to open a file.
It became evident that the to do list editor was doing two things it was handling the to do list persistence and the editing of the to do list.
A new class was created based on the IToDoListPersistence interface that could be injected into the editor.

Model - To Do List
Controller/ Application - Editor
IO - Persistence

## Thursday 19th May 2016

A much simpler model is needed. Start by considering a very simple task list that is a queue.
It has the following interface:

```csharp
public interface IToDoList
{
    void Add(string description);
	string Get();
	void Del();
}
```

And Test.

```csharp
[TestMethod]
public void Add_Test()
{
    IToDoList toDoList = new <Implementation>();
}
```

At this point it is difficult to see how to test the implementation as it is not very observable.
