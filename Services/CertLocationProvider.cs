//This service returns the location of the certificate file
using System.IO;
using System.Reflection;
public interface ICertLocationProvider
{
  string GetCertLocation();
}

public class CertLocationProvider : ICertLocationProvider
{
  public string GetCertLocation()
  {
    //HINT: The certificate file is located in the certs folder
    var certFileName = "ValidCertificate.cert";

    // Get the base directory for the project
    var baseDirectory = AppContext.BaseDirectory;

    // Combine the base directory with the Certs folder and the certificate file name
    var certFolder = Path.Combine(baseDirectory, "Certs");
    var certFilePath = Path.Combine(certFolder, certFileName);

    return certFilePath;
  }
}
