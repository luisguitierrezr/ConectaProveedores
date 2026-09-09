namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioCancelFromAPI : VarsBag {
public long inParami_FolioId;
public string inParami_CancelationMotive;
public string inParami_GeneralCancelationMotive;
public Actions.lcoCancelFolioSAEC resCancelFolioSAEC =  new Actions.lcoCancelFolioSAEC();
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public lcvFolioCancelFromAPI(long inParami_FolioId, string inParami_CancelationMotive, string inParami_GeneralCancelationMotive) {
this.inParami_FolioId = inParami_FolioId;
this.inParami_CancelationMotive = inParami_CancelationMotive;
this.inParami_GeneralCancelationMotive = inParami_GeneralCancelationMotive;
}
}
public class lcoFolioCancelFromAPI : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoFolioCancelFromAPI() {
}
}
/// <summary>
/// Action <code>FolioCancelFromAPI</code> that represents the Service Studio action
///  <code>FolioCancelFromAPI</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionFolioCancelFromAPI(IRequestContext requestContext,long inParami_FolioId,string inParami_CancelationMotive,string inParami_GeneralCancelationMotive,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoFolioCancelFromAPI result = new lcoFolioCancelFromAPI();
lcvFolioCancelFromAPI localVars = new lcvFolioCancelFromAPI(inParami_FolioId, inParami_CancelationMotive, inParami_GeneralCancelationMotive);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioCancelFromAPI", "ea0014f7-73be-4163-a507-a204ba8283f1"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioCancelFromAPI", "ea0014f7-73be-4163-a507-a204ba8283f1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if(((localVars.inParami_FolioId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// LogMessage
await ExtendedActions.LogMessage(requestContext,"Trying to cancel a folio with a nullidentifier from API","Cancel Folio",cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
// CancelFolioSAEC
localVars.resCancelFolioSAEC.outParamo_FolioNumber = await Actions.ActionCancelFolioSAEC(requestContext,localVars.inParami_FolioId,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_FolioId, ssMessage = ((((((((AppUtils.GetStringResource("FV_ihgkrUEqv2NOO_uWJUA#Value.2195684.1", "Form")+" ")+localVars.resCancelFolioSAEC.outParamo_FolioNumber)+" ")+AppUtils.GetStringResource("FV_ihgkrUEqv2NOO_uWJUA#Value.-212506368.1", "canceled due to order modification"))+".")+localVars.inParami_GeneralCancelationMotive)+(((localVars.inParami_GeneralCancelationMotive!="")) ? (". ") : ("")))+localVars.inParami_CancelationMotive), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = true, ssIsForSupplier = true },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// SendEmailApprovers_FolioCancel
await Actions.ActionSendEmailApprovers_FolioCancel(requestContext,localVars.inParami_FolioId,localVars.inParami_CancelationMotive,localVars.inParami_GeneralCancelationMotive,cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionFolioCancelFromAPI {



}


}
