# Globalization and localization in ASP.NET Core

A multilingual website allows a website to reach a wider audience. ASP.NET Core provides services and middleware for localizing into different languages and cultures. That's really important, mainly when thinking about the visibility and acessibility of our projects.

### Terms

* Globalization (G11N): The process of making an app support different languages and regions. The abbreviation comes from the first and last letters and the number of letters between them.

* Localization (L10N): The process of customizing a globalized app for specific languages and regions.

* Internationalization (I18N): Both globalization and localization.

* Culture: A language and, optionally, a region.

* Neutral culture: A culture that has a specified language, but not a region (for example "en", "es").

* Specific culture: A culture that has a specified language and region (for example, "en-US", "en-GB", "es-CL").

* Parent culture: The neutral culture that contains a specific culture (for example, "en" is the parent culture of "en-US" and "en-GB").

* Locale: A locale is the same as a culture.

### CODE

Besides the code shared in this repository, we must have to increment some configurations on our Program.cs.

Let's start adding this on our mvc configuration

```csharp
	builder.Services
			.AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                	.AddDataAnnotationsLocalization();
```

After that, we just got to call our function on app.

```csharp
	app.UseGlobalizationConfig();
```

That's all the setup. As a result we can increment the _Layout page.
```html
@*                <div class="text-end">
                Language: @System.Globalization.CultureInfo.CurrentCulture.Name
                </div>*@
                <div class="text-end">
                    <partial name="_SelectLanguagePartial" />
                </div>
```
