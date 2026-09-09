namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionXMLDocument_Load</code> that represents the Service Studio reference action
///  <code>XMLDocument_Load</code> <p> Description: Loads a XML content into a DOM object.</p>
/// </summary>
public static async Task<(object,bool,RLXmlErrorRecordList)> ActionXMLDocument_Load(IRequestContext requestContext,string inParamXML,string inParamXSD,CancellationToken cancellationToken) {
object outParamXMLDocument = default;
bool outParamIsValid = default;
RLXmlErrorRecordList outParamErrors = default;
OutSystems.Application.Extensibility.DataTypes.IRecordList proxy_Errors;
(outParamXMLDocument,outParamIsValid,proxy_Errors) = await RssExtensionXml.MssXMLDocument_Load<RLXmlErrorRecordList>(requestContext,inParamXML,inParamXSD,cancellationToken);
outParamErrors = (RLXmlErrorRecordList) proxy_Errors;
return (outParamXMLDocument,outParamIsValid,outParamErrors);
}

}
