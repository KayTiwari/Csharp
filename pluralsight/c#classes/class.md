classes allow of abstraction and encapsulation

class <Keyword> {
    class encapsulation
}

Every class should be inside of a namespace, otherwise you are in the global namespace

class Book(name, pages, genre){
    this.name = name;
    this.pages = pages;
    this.genre = genre;

}

--One class per file

classes are blueprints for objects
objects are instances of classes


Constructor methods-
must have same name as class



Access modifiers:
public - code outside of this class can have access to this method
private - code not available outside of class
protected - accessible with an identifier


this keyword - implicit variable always available in methods and constructors

static keyword - static members are not associated with objects and can be called with <Class>.<Method>
instance member - methods or attributes available in object instances <Object>.<Method>

