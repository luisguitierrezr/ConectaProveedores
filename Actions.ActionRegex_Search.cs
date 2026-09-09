namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionRegex_Search</code> that represents the Service Studio reference action
///  <code>Regex_Search</code> <p> Description: Searches the input string for an occurrence of a regula
/// r expression pattern.</p>
/// </summary>
public static async Task<(bool,string,int)> ActionRegex_Search(IRequestContext requestContext,string inParamText,string inParamRegexPattern,bool inParamIgnoreCase,bool inParamMultiLine,bool inParamSingleLine,CancellationToken cancellationToken) {
bool outParamFound = default;
string outParamPatternResult = default;
int outParamFirstIndex = default;
(outParamFound,outParamPatternResult,outParamFirstIndex) = await RssExtensionText.MssRegex_Search(requestContext,inParamText,inParamRegexPattern,inParamIgnoreCase,inParamMultiLine,inParamSingleLine,cancellationToken);
return (outParamFound,outParamPatternResult,outParamFirstIndex);
}

}
