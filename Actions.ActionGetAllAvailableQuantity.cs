namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetAllAvailableQuantity : VarsBag {
public RL_a968cf9f63475dc9358672149b11245a inParamGetFolioItemsByFolioId_List;
public long inParamFolioIdToExclude;
public Actions.lcoGetFolioItemAvailableQuantity resGetFolioItemAvailableQuantity =  new Actions.lcoGetFolioItemAvailableQuantity();
public lcvGetAllAvailableQuantity(RL_a968cf9f63475dc9358672149b11245a inParamGetFolioItemsByFolioId_List, long inParamFolioIdToExclude) {
this.inParamGetFolioItemsByFolioId_List = inParamGetFolioItemsByFolioId_List;
this.inParamFolioIdToExclude = inParamFolioIdToExclude;
}
}
public class lcoGetAllAvailableQuantity : VarsBag {
public RL_123aa03224ec08dab8cbe26021987012 outParamLocalSelectedLines = new RL_123aa03224ec08dab8cbe26021987012();

public lcoGetAllAvailableQuantity() {
}
}
/// <summary>
/// Action <code>GetAllAvailableQuantity</code> that represents the Service Studio action
///  <code>GetAllAvailableQuantity</code> <p> Description: </p>
/// </summary>
public static async Task<RL_123aa03224ec08dab8cbe26021987012> ActionGetAllAvailableQuantity(IRequestContext requestContext,RL_a968cf9f63475dc9358672149b11245a inParamGetFolioItemsByFolioId_List,long inParamFolioIdToExclude,CancellationToken cancellationToken) {
RL_123aa03224ec08dab8cbe26021987012 outParamLocalSelectedLines = default;
lcoGetAllAvailableQuantity result = new lcoGetAllAvailableQuantity();
lcvGetAllAvailableQuantity localVars = new lcvGetAllAvailableQuantity(inParamGetFolioItemsByFolioId_List, inParamFolioIdToExclude);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetAllAvailableQuantity", "d8134071-3fee-4b2e-ab4d-7578c106805a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetAllAvailableQuantity", "d8134071-3fee-4b2e-ab4d-7578c106805a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach GetFolioItemsByFolioId_List
localVars.inParamGetFolioItemsByFolioId_List.StartIteration();
try {while (!((localVars.inParamGetFolioItemsByFolioId_List.Eof))) {
// GetFolioItemAvailableQuantity
localVars.resGetFolioItemAvailableQuantity.outParamDeliveryQtt = await Actions.ActionGetFolioItemAvailableQuantity(requestContext,localVars.inParamGetFolioItemsByFolioId_List.CurrentRec.ssENOrderMainItem.ssId,localVars.inParamFolioIdToExclude,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamLocalSelectedLines,(await RecordUtils.ConvertAsync(localVars.inParamGetFolioItemsByFolioId_List.CurrentRec, new ST_aa3e6001f162e602247a2e2cc13e2cf8Structure(), async (RC_95110bc97f34f4c1561c8cbf2b5015b2 source, ST_aa3e6001f162e602247a2e2cc13e2cf8Structure target, CancellationToken cancellationToken) => {
target.ssOrderMainId = source.ssENOrderMainItem.ssId;
target.ssPosition = Convert.ToString(source.ssENOrderMainItem.ssPosition);
target.ssOrderNumber = source.ssENFolioItems.ssOrderNumber;
target.ssArticleNumber = source.ssENFolioItems.ssArticleNumber;
target.ssDescription = source.ssENFolioItems.ssDescription;
target.ssInputationCode = source.ssENFolioItems.ssInputationCode;
target.ssDeliveryDate = source.ssENFolioItems.ssDeliveryDate;
target.ssInvoiceQtt = source.ssENFolioItems.ssInvoiceQtt;
target.ssRemainingQtt = ((source.ssENOrderMainItem.ssQuantity-localVars.resGetFolioItemAvailableQuantity.outParamDeliveryQtt)-source.ssENFolioItems.ssInvoiceQtt);
target.ssRemainingQttTotal = (source.ssENOrderMainItem.ssQuantity-localVars.resGetFolioItemAvailableQuantity.outParamDeliveryQtt);
target.ssUnitPrice = source.ssENOrderMainItem.ssUnitPrice;
target.ssTotalPrice = source.ssENFolioItems.ssTotalPrice;
target.ssQuantity = source.ssENOrderMainItem.ssQuantity;
target.ssDeliveryQtt = source.ssENFolioItems.ssDeliveryQtt;
target.ssImportdelivery = (source.ssENFolioItems.ssInvoiceQtt*source.ssENFolioItems.ssUnitPrice);
target.ssIsInvoiceError = false;
target.ssIsDateError = false;
target.ssPEP = source.ssENFolioItems.ssPEP;
target.ssPlaceId = source.ssENFolioItems.ssPlaceId;
target.ssPlaceName = source.ssENFolioItems.ssPlaceName;
target.ssBaseQuantity = source.ssENOrderMainItem.ssBaseQuantity;
target.ssIsMultipleImputation = source.ssENOrderMainItem.ssIsMultipleImputation;
return target;
}, cancellationToken)),cancellationToken);

localVars.inParamGetFolioItemsByFolioId_List.Advance();
}

} finally {
localVars.inParamGetFolioItemsByFolioId_List.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamLocalSelectedLines = result.outParamLocalSelectedLines;
} // inner-finally
RETURN_STATEMENT:
return outParamLocalSelectedLines;
}

public static class FuncActionGetAllAvailableQuantity {



}


}
