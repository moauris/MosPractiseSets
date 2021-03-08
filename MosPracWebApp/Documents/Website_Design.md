# Mo's Practice Sets Web Application Design

A simple basic Practice set application with basic design of the MVC model and other features of the Asp.Net Core.

On the left column would be a series of categories, such as ASP.Net, Language, PowerShell, Azure, etc. In the main view would be an uncategorized view of all the tests. By clicking the main category navigation you get a filtered view of all the test items of that category.

Once you click on the practice set, you view a detail page of that practice, with a few buttons for going back, start test, and some configurations of the test, such as timed versus untimed, difficulty settings, etc.

Once you enter a test, depending on the configuration, the test starts with an overhead for the question item position. Below will be the question statement, followed by a selection of answers.

# What qualifies as a question page

The question page must have a statement, where a question is being asked, expecting the user to respond.

Some common types are single/multiple options, drag & drop (diagram matching), calculation, etc.

A question page should also supply explanation to the user as to why options are wrong.

# What qualifies as an effective question

An effective question should have the below characteristics:

1. User cannot easily infer from the statement the correct answer, counter example would be a screenshot showing a page of "Cosmos DB" and then ask the user what this page is showing with one of the options being "Cosmos DB"

2. The wrong options should not be obviously wrong, counter example would be 3 questions with wrong idea framed differently

# Database ViewModel versus Single supply page design idea

A **Database ViewModel** is when we first create a page, and then supply a Database backing it up.

```html
<h3>
    <vc:question_statement/>
</h3>
<form>
    <h3>
        <vc:question_answers/>
    </h3>
</form>
```

Then we code the framework to fetch the data from the database.

<span style="background-color:green;border-radius:5px;padding:2px 10px;color:white">Advantage</span>  

- Uniform in style across questions, which also means we only need to design a few times for each template, and then populate them with data.
- Centralized styling management, no need to make changes across every page

<span style="background-color:red;border-radius:5px;padding:2px 10px;color:white">Disadvantage</span>  

- Lack flexibility
- If a new structure of answer is needed, need to design a new template.

A **single supply page** supplies a single question and answer page. It might have some sort of Database backend, but there are no standardized model behind it. 

<span style="background-color:green;border-radius:5px;padding:2px 10px;color:white">Advantage</span>  

- Highly customizable

<span style="background-color:red;border-radius:5px;padding:2px 10px;color:white">Disadvantage</span>  

- If a style need to be implemented, need to do it for all unique pages.

## Conclusion

There need to be some sort of common ground if this project grows in size, currently favoring the single page design.

If the question pages are less than 50, implementing each design is bearable. If it becomes unbearable, we'll see if a more structure database view model can be implemented.

# Asp.Net and Practice Set modeling

At the end of the day, the Asp.Net Core engine supplies a webpage, which is essentially an html stream, to the requesting web browser.

Most of its core functionalities revolves around the idea of how are requests handled, and how to supply the corresponding.

There are several ways we can supply a html as part of the markup:

## Tag Helper

The tag helper class in asp.net is used to create pseudo html tags that actually invoke the C# class.

Tag Helpers literally help generate html tags in a logical order.

### How-to

First we need to design a tag helper class.

Use the `[HtmlTargetElement(string tagname, Attributes = string attributename)]` to mark a class inheriting `TagHelper` class so that in the razor page, it can be used inside a specific tag element, with the name specified as attribute name.

The inheritance carries a method called `Process(TagHelperContext context, TagHelperOutput output)` 

### Additional Note

At current stage it's really difficult for me to see what a tag helper is needed in the example.

To me they could've just generate the snippet using Razor syntax. or even components.

But maybe for this demonstration they just want to have every possible feature being used to demonstrate, sure you can use razor, you can use components, but hey, here is another option called tag helper, it's really complicated, but I think you should learn it, too.

