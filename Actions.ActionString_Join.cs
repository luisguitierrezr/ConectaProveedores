namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionString_Join</code> that represents the Service Studio reference action
///  <code>String_Join</code> <p> Description: Concatenates all the strings in a list into a singl
/// e string. In the resulting string, the individual elements are separated by the defined
///  separator.</p>
/// </summary>
public static async Task<string> ActionString_Join(IRequestContext requestContext,RLTextRecordList inParamList,string inParamSeparator,CancellationToken cancellationToken) {
string outParamText = default;
outParamText = await RssExtensionText.MssString_Join(requestContext,inParamList,inParamSeparator,cancellationToken);
return outParamText;
}

}
