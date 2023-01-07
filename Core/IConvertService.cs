using DocumentFormat.OpenXml.Packaging;
using PdfSharpCore.Pdf;

namespace Core;

public interface IConvertService
{
    public Stream ConvertToStream(Stream docxStream);
    public Stream ConvertToStream(WordprocessingDocument docxDocument);
    public PdfDocument Convert(WordprocessingDocument docxDocument);
}
