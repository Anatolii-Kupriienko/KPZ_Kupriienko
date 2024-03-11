## Overview

Brief overview of the project.

## Programming Principles

### DRY (Don't Repeat Yourself)

In this project, we adhere to the DRY principle by avoiding duplication of code. For example:
- Method `ValidateString` in `Product.cs` is used for validating strings and is reused in various methods ([Product.cs:25](./ShopWarehouse/Implementations/Product.cs#L25)), ([Product.cs:32](./ShopWarehouse/Implementations/Product.cs#L32)).
- The `ValidateFraction` method in the `Money.cs` class is used for validating fractions, eliminating duplicate code ([Money.cs:28](./ShopWarehouse/Implementations//Money.cs#L28)), ([Money.cs:39](./ShopWarehouse/Implementations//Money.cs#L39))

### KISS (Keep It Simple, Stupid) and YAGNI (You Aren't Gonna Need It)

We follow the KISS and YAGNI principle by keeping our code simple and easy to understand.
And we achieve that by adding only the most important and always useful functionality to the classes and interfaces.
Without any premature optimization or too many abstractions.
And not trying to predict the future by creating unneccesary methods, fields, classes or whatever else *may* be needed in the future, because in the end we will fail at that.

### SOLID

#### Single Responsibility Principle (SRP)

We follow SRP by ensuring that each class and class memeber has a single responsibility. So that if I want to change how I am validating the products I receive in the warehouse, I change the `ValidateReceive` method at [[Warehouse.cs:26](./ShopWarehouse/Implementations/Warehouse.cs#L26)], instead of changing something inside my [[ReceiveNewShipment](./ShopWarehouse/Implementations/Warehouse.cs#L24)] method. `ReceiveNewShipment` method is changed only if I want to change the login of how I process the received shipment. Same idea is persistent with all of the other methods in all the classes.

#### Open/Closed Principle (OCP)

We adhere to the OCP by designing our classes to be open for extension but closed for modification. For example:
- The `Product` class can be extended to include additional functionalities or information without modifying the existing code ([Product.cs](./ShopWarehouse/Implementations/Product.cs))

#### Liskov Substitution Principle (LSP)

This is not really applicable here, since there is no inheritance, but the existing interfaces are set up so that in future development, with correct usage of existing interfaces and designing of new ones, this can be achieved.

#### Interface Segregation Principle (ISP)

We adhere to ISP by segregating interfaces to ensure that clients only depend on the methods they use. For example:
- The [[IExporter](./ShopWarehouse/Interfaces/IExporter.cs)] and [[IImporter](./ShopWarehouse/Interfaces/IImporter.cs)] interfaces along with [[IProduct](./ShopWarehouse/Interfaces/IProduct.cs)] and [[IReportable](./ShopWarehouse/Interfaces/IReportable.cs)], they all contains only methods and fields related to what their names imply they should do, avoiding unnecessary dependencies.

### Fail Fast

We implement the Fail Fast principle by detecting and reporting errors as soon as they occur. For example:
- The `ValidateString` method in `Product.cs` throws an exception if the input string is null or empty, ensuring that invalid data is detected early ([Product.cs:58](./ShopWarehouse/Implementations/Product.cs#L58))
- The `ValidateFraction` method in `Money.cs` throws an exception if the fraction value is invalid, preventing further processing with invalid data ([Money.cs:86](./ShopWarehouse/Implementations/Money.cs#L86)).


#### Some closing remarks
- You might object to my adherence to the DRY principle with repeating fields in `IProduct` and `IReportable`. But they are 2 different entities and can be used separately, and inheriting one from another is not the correct choice in this case to remove this repetition. Even if you try to create a third interface to inherit in these 2, that would be disgusting in my opinion. So basically my argument is that, yes *technincally* this is not 100% DRY right there, but in this case it is ok, since they both need these fields but can be used separately. 
- And another point is am I using `Money` class instead of `IMoney` interface in the `Product` class and `IProduct` interface. And to I can say that I noticed it too late, but I think that it is fine since, it doesn't actually use any of the functionality of the `IMoney` interface. But I realise that this could be a problem in the future or in another scenario with a different class/interface.
- And lastly there is no UML diagram, I know and I am not going to do anything about it. It is not really something that I want to do and not worth it for the grade.