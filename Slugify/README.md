- [Meaning](#slugify)
- [Importance](#importance)
- [How to make it works?](#code)

# Slugify

Slugify is a process of converting a string into a URL-friendly format, often used in web development when creating URLs for web pages, blog posts, or other resources. The purpose of slugifying a string is to make it more readable for humans and search engines, as well as ensuring that it contains only URL-safe characters.

## Importance

The importance of slugifying strings lies in improving the usability and SEO (Search Engine Optimization) of a website. By converting titles or other text into slugs, you create URLs that are easier to read and understand, which can lead to better user experience. Additionally, search engines tend to prefer URLs that are descriptive and readable, which can positively impact the website's SEO ranking.

## How to make it works?

First of all, we are going to create a folder called Extensions, inside of it we'll create our .cs file called RouteSlugifyParameterTransformer.cs:

## Code

/Extensions/RouteSlugifyParameterTransformer.cs
```csharp
using System.Text.RegularExpressions;

namespace mvc.Extensions;

public class RouteSlugifyParameterTransformer : IOutboundParameterTransformer //that implements the IOutboundParameterTransformer interface.
{
    public string? TransformOutbound(object? value)
    /*
    This defines a method called TransformOutbound that takes an object as input and returns a nullable string (string?). 
    The method signature indicates that it can return null.
    */
    {
        if(value is null)
        {
            return null;
        }

        return Regex.Replace(
            value.ToString()!,
                "([a-z])([A-Z])",
                "$1-$2",
                RegexOptions.CultureInvariant,
                TimeSpan.FromMilliseconds(100))
                    .ToLowerInvariant();
        /*
        This Regex converts the value parameter to a string,
        then uses a regular expression to replace occurrences of
        a lowercase letter followed by an uppercase letter with the lowercase letter,
        a hyphen, and the uppercase letter. The ToLowerInvariant() method is then called to convert the result to lowercase   
        before returning it.
        */
        
    }
}
```

After creating this extension, we now are incrementing this code on our program.cs

```c#
builder.Services.AddRouting(options =>
    options.ConstraintMap["slugify"] = typeof(RouteSlugifyParameterTransformer)
);
```
This code configures the routing system to use a custom parameter transformer for the "slugify" constraint.
