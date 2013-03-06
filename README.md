tdd-csharp-tutorial
===================

This tutioral walksthrough the process of creating an MVC.NET application using the principles of Test-Driven-Development.


Inital Setup
------------

* Create New ASP.NET MVC 4 empty project with unit test project
* Using NuGet add the folowing projects to the unit test project
	* Selenium.Webdriver
	* Selenium.Support
* Create base class for functional tests
* Create base class for pages for tests

Hello World
-----------

<dl>
	<dt><strong>User Story:</strong></dt>
	<dd>As a visitor to the site, I expect to see a greeting on the index page</dd>
</dl>

This would translate into a functional test script as follows:

1. Navigate to index page of application
2. Locate "Hello, World!" on the web page

#### Steps

1. Create functional test
2. Run tests (it will fail)
3. Create unit test for controller 
   (this will require stub implementation)
4. Run Tests (it will fail)
5. Implement controller
6. Run Tests (functional test will still fail)
7. Implement view
8. Run Tests (all pass)

 **Congratulations you have completed your user story.**

Addition
--------

<dl>
	<dt><strong>User Story:</strong></dt>
	<dd>As a visitor, I want to be able to add 2 numbers and see the result</dd>
</dl>

This would translate into a functional test script as follows:

1. Navigate to addition page of application
2. Enter 1 into the first box
3. Enter 1 into the second box
4. Click "=" button
5. Verify the result is 2

	**Note:** This test should be repeated with various combinations of numbers.

#### Steps

1. Create data driven functional test, including page
2. Run tests (it will fail)
3. Create data driven unit test for controller 
   (this will require stub implementation)
4. Run Tests (it will fail)
5. Implement controller
6. Run Tests (functional test will still fail)
7. Implement view
8. Run Tests (all pass)

 **Congratulations you have completed your user story.**
