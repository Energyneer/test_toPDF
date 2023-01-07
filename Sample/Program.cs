using Core;

namespace Sample;

public class Program
{
    public static void Main()
    {
        var fileStream = new FileStream(@"C:\Users\enner\Downloads\GenericTwoSideContractTguOnly.docx", FileMode.Open);

        IConvertService service = new ConvertService();
        var result = service.ConvertToStream(fileStream);
        
        var file = File.Create(@"C:\Users\enner\Downloads\GenericTwoSideContractTguOnly.pdf");
        result.Seek(0, SeekOrigin.Begin);
        result.CopyTo(file);
        fileStream.Close();
    }
}
