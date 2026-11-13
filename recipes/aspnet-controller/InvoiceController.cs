using Microsoft.AspNetCore.Mvc;
using Paperwork;                 // NewDocument / FromConfig extensions
using Paperwork.Generation;      // IPaperworkFactory

public class InvoiceController : Controller
{
    private readonly IPaperworkFactory _paperwork;
    private readonly IWebHostEnvironment _env;

    public InvoiceController(IPaperworkFactory paperwork, IWebHostEnvironment env)
    {
        _paperwork = paperwork;
        _env = env;
    }

    // GET /invoice/summary?company=Acme&month=3
    [HttpGet]
    public async Task<IActionResult> Summary(string company, int month, CancellationToken cancel)
    {
        if (!TryValidate(company, month, out var error))
            return BadRequest(error);

        var model = await LoadInvoiceDataAsync(company, month, cancel);
        if (model is null)
            return NotFound($"No invoices for {company} in month {month}.");

        var templatePath = Path.Combine(_env.ContentRootPath, "Templates", "InvoiceAcme.config");
        await using var template = System.IO.File.OpenRead(templatePath);

        var pdf = await _paperwork.FromConfig(template)
            .WithData("model", model)              // the name the template binds to
            .WithField("name", company)
            .WithField("companyCode", model.CompanyCode)
            .WithField("invoiceMonth", month.ToString())
            .BuildBytesAsync();

        return File(pdf, "application/pdf", $"{company}-{month:00}.pdf");
    }

    private static bool TryValidate(string company, int month, out string error)
    {
        if (string.IsNullOrWhiteSpace(company)) { error = "A company is required."; return false; }
        if (month < 1 || month > 12)            { error = "Month must be 1 to 12."; return false; }
        error = string.Empty;
        return true;
    }

    private Task<InvoiceModel?> LoadInvoiceDataAsync(string company, int month, CancellationToken cancel)
    {
        // your repository or API call - anything serialisable
        throw new NotImplementedException();
    }
}
