namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioCancelFromEntry : VarsBag {
public long inParami_FolioId;
public string inParamEntryDoc;
public Actions.lcoCancelFolioSAEC resCancelFolioSAEC =  new Actions.lcoCancelFolioSAEC();
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public lcvFolioCancelFromEntry(long inParami_FolioId, string inParamEntryDoc) {
this.inParami_FolioId = inParami_FolioId;
this.inParamEntryDoc = inParamEntryDoc;
}
}
public class lcoFolioCancelFromEntry : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoFolioCancelFromEntry() {
}
}
/// <summary>
/// Action <code>FolioCancelFromEntry</code> that represents the Service Studio action
///  <code>FolioCancelFromEntry</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionFolioCancelFromEntry(IRequestContext requestContext,long inParami_FolioId,string inParamEntryDoc,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoFolioCancelFromEntry result = new lcoFolioCancelFromEntry();
lcvFolioCancelFromEntry localVars = new lcvFolioCancelFromEntry(inParami_FolioId, inParamEntryDoc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioCancelFromEntry", "4c6eace6-1632-4ee0-8c35-b3f4aa99ce73"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioCancelFromEntry", "4c6eace6-1632-4ee0-8c35-b3f4aa99ce73", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if(((localVars.inParami_FolioId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// LogMessage
await ExtendedActions.LogMessage(requestContext,"Trying to cancel a folio with a nullidentifier from Entry","Cancel Folio",cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
// CancelFolioSAEC
localVars.resCancelFolioSAEC.outParamo_FolioNumber = await Actions.ActionCancelFolioSAEC(requestContext,localVars.inParami_FolioId,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = (((((((((AppUtils.GetStringResource("jD4VpzxG3ESQvknDvOPzHA#Value.68060425.1", "Folio")+" ")+localVars.resCancelFolioSAEC.outParamo_FolioNumber)+" ")+AppUtils.GetStringResource("jD4VpzxG3ESQvknDvOPzHA#Value.-177824843.1", "cancelado por registro manual fuera de portal Conecta"))+".")+"\r\n")+"( ")+localVars.inParamEntryDoc)+" )"), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = true, ssIsForSupplier = true },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// SendEmailApprovers_FolioCancel
await Actions.ActionSendEmailApprovers_FolioCancel(requestContext,localVars.inParami_FolioId,AppUtils.GetStringResource("qHGygFWLrE26_cly2rFopg#Value.1945962297.1", "Cancelado por registro manual fuera de portal Conecta."),"",cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionFolioCancelFromEntry {



}


}
