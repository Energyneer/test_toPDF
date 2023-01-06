using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

namespace Core;

public class GenerateService
{
    private readonly WordprocessingDocument _document;

    public GenerateService(WordprocessingDocument document)
    {
        _document = document;
    }

    public PdfDocument Generate()
    {
        var document = new PdfDocument();
        var page = document.AddPage();

        var gfx = XGraphics.FromPdfPage(page);
        var font = new XFont("Arial", 20, XFontStyle.Bold);

        var textColor = XBrushes.Black;
        var layout = new XRect(20, 20, page.Width, page.Height);
        var format = XStringFormats.Center;


        gfx.DrawString("Hello World!", font, textColor, layout, format);

        return document;
    }
}