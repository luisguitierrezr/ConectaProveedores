namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionXMLNodeList_Item</code> that represents the Service Studio reference action
///  <code>XMLNodeList_Item</code> <p> Description: Retrieves a node at the given index.</p>
/// </summary>
public static async Task<object> ActionXMLNodeList_Item(IRequestContext requestContext,object inParamXMLNodeList,int inParamIndex,CancellationToken cancellationToken) {
object outParamXMLNode = default;
outParamXMLNode = await RssExtensionXml.MssXMLNodeList_Item(requestContext,inParamXMLNodeList,inParamIndex,cancellationToken);
return outParamXMLNode;
}

}
