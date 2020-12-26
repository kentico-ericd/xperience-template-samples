To create a template for advanced routes based on the content tree:

1. Create a [controller](https://github.com/kentico-ericd/xperience-template-samples/blob/master/BlankCore/AdvancedTemplate/MyAdvancedController.cs) that returns `TemplateResult`
1. [Register](https://github.com/kentico-ericd/xperience-template-samples/blob/master/BlankCore/Registrations.cs#L37) the advanced route with your page type
1. Create a view (anywhere, any name). Normally they are located in the _~/Views_ directory, but I've sectioned these examples for better readability
1. Use [`@model ComponentViewModel`](https://github.com/kentico-ericd/xperience-template-samples/blob/master/BlankCore/AdvancedTemplate/_Template.cshtml#L9) to get data about the page in the view
1. __(Optional)__ Create page template [properties class](https://github.com/kentico-ericd/xperience-template-samples/blob/master/BlankCore/AdvancedTemplate/AdvancedTemplateProperties.cs) that inherits `IPageTemplateProperties` and change the model to `ComponentViewModel<YourPropertiesClass>`
1. __(Optional)__ Create a [filter class](https://github.com/kentico-ericd/xperience-template-samples/blob/master/BlankCore/AdvancedTemplate/AdvancedTemplateFilter.cs) which inherits `IPageTemplateFilter` and defines what templates are available for your page type and [register](https://github.com/kentico-ericd/xperience-template-samples/blob/master/BlankCore/Startup.cs#L61) it
1. [Register](https://github.com/kentico-ericd/xperience-template-samples/blob/master/BlankCore/Registrations.cs#L22) the template