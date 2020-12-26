To create a basic template with content tree routing:

1. Ensure [page routing](https://github.com/kentico-ericd/xperience-template-samples/blob/master/BlankCore/Startup.cs#L37) is enabled
1. Create a view (anywhere, any name). Normally they are located in the _~/Views_ directory, but I've sectioned these examples for better readability
1. Use [`@model ComponentViewModel`](https://github.com/kentico-ericd/xperience-template-samples/blob/master/BlankCore/BasicTemplate/_AltTemplate.cshtml#L9) to get data about the page in the view
1. __(Optional)__ Create page template [properties class](https://github.com/kentico-ericd/xperience-template-samples/blob/master/BlankCore/BasicTemplate/BasicTemplateProperties.cs) that inherits `IPageTemplateProperties` and change the model to `ComponentViewModel<YourPropertiesClass>`
1. Register the template: [with properties](https://github.com/kentico-ericd/xperience-template-samples/blob/master/BlankCore/Registrations.cs#L6) or [without](https://github.com/kentico-ericd/xperience-template-samples/blob/master/BlankCore/Registrations.cs#L11)