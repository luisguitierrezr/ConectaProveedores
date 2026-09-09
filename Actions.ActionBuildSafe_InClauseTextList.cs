namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionBuildSafe_InClauseTextList</code> that represents the Service Studio reference
///  action <code>BuildSafe_InClauseTextList</code> <p> Description: Returns a comma-delimited tex
/// t value with the encoded version of all the text values provided as input. The returned value can
///  be safely used in a SQL IN clause.</p>
/// </summary>
public static async Task<string> ActionBuildSafe_InClauseTextList(IRequestContext requestContext,RLTextLiteralRecordList inParamValueList,CancellationToken cancellationToken) {
string outParamOutput = default;
outParamOutput = await RssExtensionSanitization.MssBuildSafe_InClauseTextList(requestContext,inParamValueList,cancellationToken);
return outParamOutput;
}

}
