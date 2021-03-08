# Problem

In the example, we are trying to create a series of page indexing links depending on the page model supplied into the home page.

```html
<div class="btn-group pull-right m-1">
    <a class="btn-outline-dark btn" href="/Page1">1</a>
    <a class="btn-primary btn" href="/Page2">2</a>
</div>
```

# Solution

Make a tag helper class, inside the `index.cshtml`, use this tag helper.

## Creating Tag Helper class

Creating the tag helper class

```c#
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        //...
    }
```

Any tag helper must inherit the Tag Helper base class.

The attributes specifies the element to which the tag helper can be applied, and the attributes specify its name in the tag as an pseudo html tag.

## Constructor

The tag helper constructor can take an argument for `IUrlHelperFactory`, which will be used later to generate an URL.

I don't see any where this class being constructed, so I assume this is an other case of dependency injection, where the framework injects a `UrlHelperFactory` class when it can.



