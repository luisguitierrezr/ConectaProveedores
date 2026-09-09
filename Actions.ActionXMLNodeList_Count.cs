namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionXMLNodeList_Count</code> that represents the Service Studio reference action
///  <code>XMLNodeList_Count</code> <p> Description: Gets the number of nodes in the XML node list.</p>
/// </summary>
public static async Task<int> ActionXMLNodeList_Count(IRequestContext requestContext,object inParamXMLNodeList,CancellationToken cancellationToken) {
int outParamCount = default;
outParamCount = await RssExtensionXml.MssXMLNodeList_Count(requestContext,inParamXMLNodeList,cancellationToken);
return outParamCount;
}

}
