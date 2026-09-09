namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionRegex_Replace</code> that represents the Service Studio reference action
///  <code>Regex_Replace</code> <p> Description: Replaces all occurrences of a specified regula
/// r expression pattern with a new string.</p>
/// </summary>
public static async Task<string> ActionRegex_Replace(IRequestContext requestContext,string inParamText,string inParamRegexPattern,string inParamNewString,bool inParamIgnoreCase,bool inParamMultiLine,bool inParamSingleLine,CancellationToken cancellationToken) {
string outParamResult = default;
outParamResult = await RssExtensionText.MssRegex_Replace(requestContext,inParamText,inParamRegexPattern,inParamNewString,inParamIgnoreCase,inParamMultiLine,inParamSingleLine,cancellationToken);
return outParamResult;
}

}
