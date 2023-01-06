using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using PdfSharpCore.Pdf;

namespace Core;

public interface IConvertService
{
    public Stream ConvertToStream(Stream docxStream);
    public Stream ConvertToStream(WordprocessingDocument docxDocument);
    public PdfDocument Convert(WordprocessingDocument docxDocument);
}
