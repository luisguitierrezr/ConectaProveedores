namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionExtractTextOrOcr</code> that represents the Service Studio reference action
///  <code>ExtractTextOrOcr</code> <p> Description: </p>
/// </summary>
public static async Task<ST_ce06f43cf108d98e4f79c0106fcfd0acStructure> ActionExtractTextOrOcr(IRequestContext requestContext,byte[] inParampdfBytes,string inParamlanguages,int inParamdpi,CancellationToken cancellationToken) {
ST_ce06f43cf108d98e4f79c0106fcfd0acStructure outParamExtractTextOrOcr = default;
OutSystems.Application.Extensibility.DataTypes.IRecord proxy_ExtractTextOrOcr;
proxy_ExtractTextOrOcr = await RssExternalLibraryPdfOcrLibrary.MssExtractTextOrOcr<ST_ce06f43cf108d98e4f79c0106fcfd0acStructure>(requestContext,inParampdfBytes,inParamlanguages,inParamdpi,cancellationToken);
outParamExtractTextOrOcr = (ST_ce06f43cf108d98e4f79c0106fcfd0acStructure) proxy_ExtractTextOrOcr;
return outParamExtractTextOrOcr;
}

}
