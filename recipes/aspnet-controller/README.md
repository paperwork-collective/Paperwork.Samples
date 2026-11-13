# Return a PDF from an ASP.NET controller

A controller action that takes a company and a month on a request, loads your own data, and returns the invoice as a PDF made with Paperwork.Core.

This is the code for the [Return a PDF from an ASP.NET controller](https://paperwork.help/recipes/aspnet-controller.html) recipe in the Paperwork help.

## Files

- `Program.cs`: registers Paperwork at startup. This is the lines to add to your own `Program.cs`, not a whole program.
- `InvoiceController.cs`: the controller action that validates the request, loads the data and returns the PDF.
- `InvoiceModel.cs`: your data type. Replace it with your own.

## Use it

1. Add the `Paperwork.Core` package to a .NET web application.
2. Export your template from [Paperwork.Design](https://paperwork.design) (open it and choose **Export**), and put the `.config` file in a `Templates` folder. The controller reads `Templates/InvoiceAcme.config`, so rename it or change the path.
3. Add the three files to your project, and fill in `LoadInvoiceDataAsync` to load your own data.
4. Open `/invoice/summary?company=Acme&month=3`. The browser downloads the PDF.

## Learn more

The full walk-through is on the help site: [Return a PDF from an ASP.NET controller](https://paperwork.help/recipes/aspnet-controller.html).
