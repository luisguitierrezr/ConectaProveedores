namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionXMLElement_GetAttributeValue</code> that represents the Service Studio reference
///  action <code>XMLElement_GetAttributeValue</code> <p> Description: Returns the value of an XM
/// L Attribute with a given name.</p>
/// </summary>
public static async Task<string> ActionXMLElement_GetAttributeValue(IRequestContext requestContext,object inParamXMLElement,string inParamAttributeName,CancellationToken cancellationToken) {
string outParamAttributeValue = default;
outParamAttributeValue = await RssExtensionXml.MssXMLElement_GetAttributeValue(requestContext,inParamXMLElement,inParamAttributeName,cancellationToken);
return outParamAttributeValue;
}

}
