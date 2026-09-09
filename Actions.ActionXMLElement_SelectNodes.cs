namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionXMLElement_SelectNodes</code> that represents the Service Studio reference
///  action <code>XMLElement_SelectNodes</code> <p> Description: Returns a list of XML elements or XM
/// L attributes as described by the XPath string.</p>
/// </summary>
public static async Task<object> ActionXMLElement_SelectNodes(IRequestContext requestContext,object inParamXMLElement,string inParamXPathString,CancellationToken cancellationToken) {
object outParamXMLNodeList = default;
outParamXMLNodeList = await RssExtensionXml.MssXMLElement_SelectNodes(requestContext,inParamXMLElement,inParamXPathString,cancellationToken);
return outParamXMLNodeList;
}

}
