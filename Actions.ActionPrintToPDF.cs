namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionPrintToPDF</code> that represents the Service Studio reference action
///  <code>PrintToPDF</code> <p> Description: Generates a PDF from a given URL, using the paper size an
/// d margin size from the print stylesheet.</p>
/// </summary>
public static async Task<byte[]> ActionPrintToPDF(IRequestContext requestContext,string inParamURL,ST_201dce7bb255178c132fec4d547942aeStructure inParamEnvironment,CancellationToken cancellationToken) {
byte[] outParamPDF = default;
outParamPDF = await RsseSpaceUltimatePDF.MssPrintToPDF(requestContext,inParamURL,inParamEnvironment,cancellationToken);
return outParamPDF;
}

}
