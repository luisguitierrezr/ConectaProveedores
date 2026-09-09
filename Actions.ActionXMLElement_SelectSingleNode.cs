namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionXMLElement_SelectSingleNode</code> that represents the Service Studio reference
///  action <code>XMLElement_SelectSingleNode</code> <p> Description: Returns a XML element or a XM
/// L attribute as described by the XPath string.</p>
/// </summary>
public static async Task<object> ActionXMLElement_SelectSingleNode(IRequestContext requestContext,object inParamXMLElement,string inParamXPathString,CancellationToken cancellationToken) {
object outParamXMLNode = default;
outParamXMLNode = await RssExtensionXml.MssXMLElement_SelectSingleNode(requestContext,inParamXMLElement,inParamXPathString,cancellationToken);
return outParamXMLNode;
}

}
