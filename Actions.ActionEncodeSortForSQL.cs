namespace ssConectaProveedores;

public partial class Actions {
public class lcvEncodeSortForSQL : VarsBag {
public string inParamSortForAggregate;
public string resRegex_Replace_outParamResult = "";

public lcvEncodeSortForSQL(string inParamSortForAggregate) {
this.inParamSortForAggregate = inParamSortForAggregate;
}
}
public class lcoEncodeSortForSQL : VarsBag {
public string outParamSortForSQL = "";

public lcoEncodeSortForSQL() {
}
}
/// <summary>
/// Action <code>EncodeSortForSQL</code> that represents the Service Studio action
///  <code>EncodeSortForSQL</code> <p> Description: Encode Sort For SQL.</p>
/// </summary>
public static async Task<string> ActionEncodeSortForSQL(IRequestContext requestContext,string inParamSortForAggregate,CancellationToken cancellationToken) {
string outParamSortForSQL = default;
lcoEncodeSortForSQL result = new lcoEncodeSortForSQL();
lcvEncodeSortForSQL localVars = new lcvEncodeSortForSQL(inParamSortForAggregate);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EncodeSortForSQL", "1e198d3d-a487-4ae6-8f98-94f22de31cbe"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EncodeSortForSQL", "1e198d3d-a487-4ae6-8f98-94f22de31cbe", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Regex_Replace
localVars.resRegex_Replace_outParamResult = await Actions.ActionRegex_Replace(requestContext,localVars.inParamSortForAggregate,"[^\\w. ]"," ",true,false,false,cancellationToken);

// Entity and Atribute?
if(((BuiltInFunction.IndexSC (localVars.inParamSortForAggregate, ".", 0, false, false)!=(-1)))) {
// SortForSQL = "{" + Replace + "]"
result.outParamSortForSQL=(("{"+BuiltInFunction.Replace (localVars.resRegex_Replace_outParamResult, ".", "}.["))+"]");

// SortForSQL = Replace
result.outParamSortForSQL=BuiltInFunction.Replace (BuiltInFunction.ToUpper (result.outParamSortForSQL), " DESC]", "] DESC");
} else {
// SortForSQL = "[" + Regex_Replace.Result + "]"
result.outParamSortForSQL=(("["+localVars.resRegex_Replace_outParamResult)+"]");

// SortForSQL = Replace
result.outParamSortForSQL=BuiltInFunction.Replace (BuiltInFunction.ToUpper (result.outParamSortForSQL), " DESC]", "] DESC");
}

// SortForSQL = Replace
result.outParamSortForSQL=BuiltInFunction.Replace (BuiltInFunction.ToUpper (result.outParamSortForSQL), " DESC]", "] DESC");

// SortForSQL = Replace
result.outParamSortForSQL=BuiltInFunction.Replace (BuiltInFunction.ToUpper (result.outParamSortForSQL), " ASC]", "] ASC");
} //close CreateActionActivity using block
} // try

finally {
outParamSortForSQL = result.outParamSortForSQL;
} // inner-finally
RETURN_STATEMENT:
return outParamSortForSQL;
}

public static class FuncActionEncodeSortForSQL {



}


}
