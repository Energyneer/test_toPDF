using PdfSharpCore.Pdf;
using DocumentFormat.OpenXml.Packaging;

namespace Core
{
    public class ConvertService : IConvertService
    {
        public Stream ConvertToStream(Stream docxStream)
        {
            using WordprocessingDocument document = WordprocessingDocument.Open(docxStream, false);

            return ConvertToStream(document);
        }

        public Stream ConvertToStream(WordprocessingDocument docxDocument)
        {
            var stream = new MemoryStream();
            var pdfDocument = Convert(docxDocument);
            
            pdfDocument.Save(stream);

            return stream;
        }

        public PdfDocument Convert(WordprocessingDocument docxDocument)
        {
            var generic = new GenerateService(docxDocument);

            return generic.Generate();
        }
    }
}
