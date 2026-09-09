namespace ssConectaProveedores;

public partial class Actions {
public class lcvReadOrderNotes : VarsBag {
public string inParamOrderNumber;
public ST_cc99e347274d861473c4d7d08b6332b6Structure resCall_Z01_READ_TEXT_outParamResponse = new ST_cc99e347274d861473c4d7d08b6332b6Structure();

public lcvReadOrderNotes(string inParamOrderNumber) {
this.inParamOrderNumber = inParamOrderNumber;
}
}
public class lcoReadOrderNotes : VarsBag {
public string outParamNotes = "";

public lcoReadOrderNotes() {
}
}
/// <summary>
/// Action <code>ReadOrderNotes</code> that represents the Service Studio action
///  <code>ReadOrderNotes</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionReadOrderNotes(IRequestContext requestContext,string inParamOrderNumber,CancellationToken cancellationToken) {
string outParamNotes = default;
lcoReadOrderNotes result = new lcoReadOrderNotes();
lcvReadOrderNotes localVars = new lcvReadOrderNotes(inParamOrderNumber);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ReadOrderNotes", "2fa5bd91-8287-4c6d-ac48-c294d7a7b390"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ReadOrderNotes", "2fa5bd91-8287-4c6d-ac48-c294d7a7b390", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Call_Z01_READ_TEXT
localVars.resCall_Z01_READ_TEXT_outParamResponse = await ServiceAPIs.ServiceAPICall_Z01_READ_TEXT(requestContext,new ST_c4a97e6963b2cd0d749b56dde8d26a02Structure(){ ssID = "F01", ssNAME = localVars.inParamOrderNumber, ssOBJECT = "EKPO" },cancellationToken);

// Foreach Call_Z01_READ_TEXT.Response.LINES
localVars.resCall_Z01_READ_TEXT_outParamResponse.ssLINES.StartIteration();
try {while (!((localVars.resCall_Z01_READ_TEXT_outParamResponse.ssLINES.Eof))) {
// Notes = Notes + Call_Z01_READ_TEXT.Response.LINES.Current.TDLINE
result.outParamNotes=(result.outParamNotes+localVars.resCall_Z01_READ_TEXT_outParamResponse.ssLINES.CurrentRec.ssTDLINE);
localVars.resCall_Z01_READ_TEXT_outParamResponse.ssLINES.Advance();
}

} finally {
localVars.resCall_Z01_READ_TEXT_outParamResponse.ssLINES.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamNotes = result.outParamNotes;
} // inner-finally
RETURN_STATEMENT:
return outParamNotes;
}

public static class FuncActionReadOrderNotes {



}


}
