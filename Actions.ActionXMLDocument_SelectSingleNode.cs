namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionXMLDocument_SelectSingleNode</code> that represents the Service Studio reference
///  action <code>XMLDocument_SelectSingleNode</code> <p> Description: Returns a XML element or a XM
/// L attribute as described by the XPath string.</p>
/// </summary>
public static async Task<object> ActionXMLDocument_SelectSingleNode(IRequestContext requestContext,object inParamXMLDocument,string inParamXPathString,CancellationToken cancellationToken) {
object outParamXMLNode = default;
outParamXMLNode = await RssExtensionXml.MssXMLDocument_SelectSingleNode(requestContext,inParamXMLDocument,inParamXPathString,cancellationToken);
return outParamXMLNode;
}

}
