namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionString_Split</code> that represents the Service Studio reference action
///  <code>String_Split</code> <p> Description: Splits a string into individual elements delimited b
/// y any of the characters specified.</p>
/// </summary>
public static async Task<RLTextRecordList> ActionString_Split(IRequestContext requestContext,string inParamText,string inParamDelimiters,CancellationToken cancellationToken) {
RLTextRecordList outParamList = default;
OutSystems.Application.Extensibility.DataTypes.IRecordList proxy_List;
proxy_List = await RssExtensionText.MssString_Split<RLTextRecordList>(requestContext,inParamText,inParamDelimiters,cancellationToken);
outParamList = (RLTextRecordList) proxy_List;
return outParamList;
}

}
