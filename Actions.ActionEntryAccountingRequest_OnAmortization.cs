namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntryAccountingRequest_OnAmortization : VarsBag {
public EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoice;
public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamFolio;
public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamOrderMain;
public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate2 =  new Actions.lcoFolioCreateOrUpdate();
public lcvEntryAccountingRequest_OnAmortization(EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoice, EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamFolio, EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamOrderMain) {
this.inParamInvoice = inParamInvoice;
this.inParamFolio = inParamFolio;
this.inParamOrderMain = inParamOrderMain;
}
}
/// <summary>
/// Action <code>EntryAccountingRequest_OnAmortization</code> that represents the Service Studio action
///  <code>EntryAccountingRequest_OnAmortization</code> <p> Description: </p>
/// </summary>
public static async Task ActionEntryAccountingRequest_OnAmortization(IRequestContext requestContext,EN_d1d0320db36efbb094ad0082361435a0EntityRecord inParamInvoice,EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParamFolio,EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamOrderMain,CancellationToken cancellationToken) {
lcvEntryAccountingRequest_OnAmortization localVars = new lcvEntryAccountingRequest_OnAmortization(inParamInvoice, inParamFolio, inParamOrderMain);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EntryAccountingRequest_OnAmortization", "4964d9fd-5f9e-4424-9b7f-684f1e5f34c9"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EntryAccountingRequest_OnAmortization", "4964d9fd-5f9e-4424-9b7f-684f1e5f34c9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Set Manual Accounting
// Invoice.InvoiceStatusId = ManualAccounting
localVars.inParamInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("q0tYi3ZiTEKjRg2gCsYIDA"))).ssId;

// Folio.FolioStatusId = Approved
localVars.inParamFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("sjaNMehoxESZWJutqvvRYA"))).ssId;
// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.inParamInvoice,false,cancellationToken);

// has folio?
if(((localVars.inParamInvoice.ssFolioId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// FolioCreateOrUpdate2
localVars.resFolioCreateOrUpdate2.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.inParamFolio,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.resFolioCreateOrUpdate2.outParamId, ssMessage = ((((AppUtils.GetStringResource("lTmGalaB4Uq1cRq_NGi3JA#Value.-670115059.1", "Invoice")+" ")+localVars.inParamInvoice.ssName)+" ")+AppUtils.GetStringResource("lTmGalaB4Uq1cRq_NGi3JA#Value.-1260013650.1", "has passed to manual accounting due to amortization due.")), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = false, ssIsForSupplier = true },cancellationToken);

} else {
// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.inParamOrderMain.ssId, ssCreatedBy = BuiltInFunction.NullTextIdentifier (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("8Jmub_oH9EOfQ8GYfvOSJw#Value.701269683.1", "Invoice ")+" ")+localVars.inParamInvoice.ssName)+" ")+AppUtils.GetStringResource("8Jmub_oH9EOfQ8GYfvOSJw#Value.-1260013650.1", "has passed to manual accounting due to amortization due.")), ssIsError = true },cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionEntryAccountingRequest_OnAmortization {



}


}
