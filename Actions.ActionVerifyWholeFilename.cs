namespace ssConectaProveedores;

public partial class Actions {
public class lcvVerifyWholeFilename : VarsBag {
public string inParami_Filename;
public bool inParami_IsCommission;
public bool inParami_IsComissionUnknown;
/// <summary>
/// Variable <code>l_FormattedDateText</code> that represents the Service Studio Text
///  <code>l_FormattedDateText</code> <p>Description: FormattedDateText</p>
/// </summary>
public string varLcl_FormattedDateText = "";

/// <summary>
/// Variable <code>l_Regex</code> that represents the Service Studio Text <code>l_Regex</code>
///  <p>Description: </p>
/// </summary>
public string varLcl_Regex = "";

public bool resRegex_SearchFullFilename_outParamFound = false;
public string resRegex_SearchFullFilename_outParamPatternResult = "";
public int resRegex_SearchFullFilename_outParamFirstIndex = 0;

public bool resRegex_SearchDatePart_outParamFound = false;
public string resRegex_SearchDatePart_outParamPatternResult = "";
public int resRegex_SearchDatePart_outParamFirstIndex = 0;

public lcvVerifyWholeFilename(string inParami_Filename, bool inParami_IsCommission, bool inParami_IsComissionUnknown) {
this.inParami_Filename = inParami_Filename;
this.inParami_IsCommission = inParami_IsCommission;
this.inParami_IsComissionUnknown = inParami_IsComissionUnknown;
}
}
public class lcoVerifyWholeFilename : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoVerifyWholeFilename() {
}
}
/// <summary>
/// Action <code>VerifyWholeFilename</code> that represents the Service Studio action
///  <code>VerifyWholeFilename</code> <p> Description: Action to validate imported filename</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionVerifyWholeFilename(IRequestContext requestContext,string inParami_Filename,bool inParami_IsCommission,bool inParami_IsComissionUnknown,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoVerifyWholeFilename result = new lcoVerifyWholeFilename();
lcvVerifyWholeFilename localVars = new lcvVerifyWholeFilename(inParami_Filename, inParami_IsCommission, inParami_IsComissionUnknown);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("VerifyWholeFilename", "2c5193d5-e3dd-4f82-909d-00b5230f891a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("VerifyWholeFilename", "2c5193d5-e3dd-4f82-909d-00b5230f891a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// i_IsCommission = Index <> -1
localVars.inParami_IsCommission=(BuiltInFunction.IndexSC (localVars.inParami_Filename, "COMISIONES", 0, false, false)!=(-1));

// i_IsComissionUnknown = False
localVars.inParami_IsComissionUnknown=false;

// l_Regex = "^TELCEL_" + If + "_R(\d+)_(BBVA|INBURSA|Inbursa)_B" + If + "(\d+)_(\d{8})\.xlsx$"
localVars.varLcl_Regex=(((("^TELCEL_"+((localVars.inParami_IsComissionUnknown) ? ("(COMISIONES|ARRENDAMIENTOS)") : (((localVars.inParami_IsCommission) ? ("COMISIONES") : ("ARRENDAMIENTOS")))))+"_R(\\d+)_(BBVA|INBURSA|Inbursa)_B")+((localVars.inParami_IsComissionUnknown) ? ("(C|A)") : (((localVars.inParami_IsCommission) ? ("C") : ("A")))))+"(\\d+)_(\\d{8})\\.xlsx$");
// Regex_SearchFullFilename
(localVars.resRegex_SearchFullFilename_outParamFound,localVars.resRegex_SearchFullFilename_outParamPatternResult,localVars.resRegex_SearchFullFilename_outParamFirstIndex) = await Actions.ActionRegex_Search(requestContext,localVars.inParami_Filename,localVars.varLcl_Regex,false,false,false,cancellationToken);

if(((localVars.resRegex_SearchFullFilename_outParamPatternResult==localVars.inParami_Filename))) {
// Regex_SearchDatePart
(localVars.resRegex_SearchDatePart_outParamFound,localVars.resRegex_SearchDatePart_outParamPatternResult,localVars.resRegex_SearchDatePart_outParamFirstIndex) = await Actions.ActionRegex_Search(requestContext,localVars.inParami_Filename,"(\\d{8})",true,false,false,cancellationToken);

// l_FormattedDateText = Substr + "-" + Substr + "-" + Substr
localVars.varLcl_FormattedDateText=((((BuiltInFunction.SubstrSC (localVars.resRegex_SearchDatePart_outParamPatternResult, 0, 4)+"-")+BuiltInFunction.SubstrSC (localVars.resRegex_SearchDatePart_outParamPatternResult, 4, 2))+"-")+BuiltInFunction.SubstrSC (localVars.resRegex_SearchDatePart_outParamPatternResult, 6, 2));
// o_Output
// o_Output.IsSuccess = TextToDateTime <> NullDate
result.outParamo_Output.ssIsSuccess = (BuiltInFunction.TextToDateTime (localVars.varLcl_FormattedDateText)!=BuiltInFunction.NullDate ());

// o_Output.Message = "The filename contains an invalid date."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("Kch4JeD5BECbrM00_1u25A#Value.384041307.1", "The filename contains an invalid date.");
} else {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "The filename is not according to the expected pattern."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("4PLU_5JV80yC5DOhDvv3aw#Value.-779523095.1", "The filename is not according to the expected pattern.");
}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Error verifying filename."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("FamyTUL3fEmARjxwyq9S+Q#Value.1737238072.1", "Error verifying filename.");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionVerifyWholeFilename {



}


}
