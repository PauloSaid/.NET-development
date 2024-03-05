# Upload Image: Guide.

This guide will teach you how to upload images in your .net application.

### Model

In your model.cs, we're incrementing a field IFormFile, that will be used to upload your file.
It's important to remember that this field must not be mapped into your database.
**OBS.: The code for everything it's inside the folders of this repository.**

### Controllers

Inside our controller we have to create a Task so we can upload the files. Posteriorly, checking the model state in the task create.

### View

To avoid our image of being nullable on display, inside the view code you have to add
enctype attribute at the form. Also, add one small script on create.cshtml of your controller.
