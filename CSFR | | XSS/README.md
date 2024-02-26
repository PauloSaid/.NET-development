# Understanding CSRF and XSS: A Comprehensive Guide.

### ⚠️CSRF (Cross-Site Request Forgery)
CSRF is a type of attack where an attacker tricks a user into unintentionally executing actions on a web application in which they are authenticated.
The attacker can exploit the trust that a site has in a user's browser by sending a malicious request from a different site, which is automatically included with the user's credentials,
allowing the attacker to perform actions on behalf of the user without their consent.

![image](https://github.com/PauloSaid/.NET-development/assets/103071726/f863b384-9d77-4ecb-9b8e-872e1a9c5ec3)

### ⚠️XSS (Cross-Site Scripting):
XSS is a vulnerability that allows attackers to inject malicious scripts into web pages viewed by other users. These scripts can steal sensitive information, hijack user sessions, or deface websites.

![image](https://github.com/PauloSaid/.NET-development/assets/103071726/a5ae7cec-a98a-4efd-b1c0-dc8110890df0)

### ‍💻In development‍💻:
CSRF and XSS attacks are critical to prevent in .NET development to protect user data and ensure the security of web applications. Failure to prevent these attacks can lead to unauthorized access, data theft, and other security breaches.
Implementing proper security measures in .NET applications, such as input validation, output encoding, and using secure coding practices, is essential to mitigate these risks.

### 🛑How to prevent CSRF🛑:
ASP.NET provides an ValidateAntiForgeryToken attribute that can be applied to controller actions to validate that the request is not a result of a CSRF attack. Anyway, instead of adding this attribute to every controller, let's incremeating this on your Program.cs file:
```c#
builder.Services.AddControllersWithViews(options =>
    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute())
);
```

By following this step, you can help prevent CSRF attacks in your .NET applications by ensuring that requests originate from your site and are not forged by malicious third parties.

### 🛑How to prevent XSS🛑:

You can use request validations, AntiXSS libraries or content enconding, but don't worry. ASP.NET provides built-in protection against XSS.
