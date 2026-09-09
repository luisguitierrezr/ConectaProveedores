namespace ssConectaProveedores;

public partial class Actions {
public class lcvSaveOrderAccConcepts : VarsBag {
public long inParami_OrderId;
public RC_dd1ef552e394be88b7a9660ce51d9447 inParami_OrderAccConcept_EstimEqualAg;
public RC_dd1ef552e394be88b7a9660ce51d9447 inParami_OrderAccConcept_CreditNote;
public RC_dd1ef552e394be88b7a9660ce51d9447 inParami_OrderAccConcept_Voucher;
public RC_dd1ef552e394be88b7a9660ce51d9447 inParami_OrderAccConcept_Finiquito;
public RC_dd1ef552e394be88b7a9660ce51d9447 inParami_OrderAccConcept_Anticipo;
public Actions.lcoOrderAccConceptsCreateOrUpdate resOrderAccConceptsCreateOrUpdate5 =  new Actions.lcoOrderAccConceptsCreateOrUpdate();
public Actions.lcoOrderAccConceptsCreateOrUpdate resOrderAccConceptsCreateOrUpdate6 =  new Actions.lcoOrderAccConceptsCreateOrUpdate();
public Actions.lcoOrderAccConceptsCreateOrUpdate resOrderAccConceptsCreateOrUpdate4 =  new Actions.lcoOrderAccConceptsCreateOrUpdate();
public Actions.lcoOrderAccConceptsCreateOrUpdate resOrderAccConceptsCreateOrUpdateVoucher =  new Actions.lcoOrderAccConceptsCreateOrUpdate();
public Actions.lcoOrderAccConceptsCreateOrUpdate resOrderAccConceptsCreateOrUpdate =  new Actions.lcoOrderAccConceptsCreateOrUpdate();
public Actions.lcoOrderAccConceptsCreateOrUpdate resOrderAccConceptsCreateOrUpdateFiniquito =  new Actions.lcoOrderAccConceptsCreateOrUpdate();
public Actions.lcoOrderAccConceptsCreateOrUpdate resOrderAccConceptsCreateOrUpdate2 =  new Actions.lcoOrderAccConceptsCreateOrUpdate();
public Actions.lcoOrderAccConceptsCreateOrUpdate resOrderAccConceptsCreateOrUpdateAnticipo =  new Actions.lcoOrderAccConceptsCreateOrUpdate();
public Actions.lcoOrderAccConceptsCreateOrUpdate resOrderAccConceptsCreateOrUpdate7 =  new Actions.lcoOrderAccConceptsCreateOrUpdate();
public Actions.lcoOrderAccConceptsCreateOrUpdate resOrderAccConceptsCreateOrUpdateCreditNote =  new Actions.lcoOrderAccConceptsCreateOrUpdate();
public lcvSaveOrderAccConcepts(long inParami_OrderId, RC_dd1ef552e394be88b7a9660ce51d9447 inParami_OrderAccConcept_EstimEqualAg, RC_dd1ef552e394be88b7a9660ce51d9447 inParami_OrderAccConcept_CreditNote, RC_dd1ef552e394be88b7a9660ce51d9447 inParami_OrderAccConcept_Voucher, RC_dd1ef552e394be88b7a9660ce51d9447 inParami_OrderAccConcept_Finiquito, RC_dd1ef552e394be88b7a9660ce51d9447 inParami_OrderAccConcept_Anticipo) {
this.inParami_OrderId = inParami_OrderId;
this.inParami_OrderAccConcept_EstimEqualAg = inParami_OrderAccConcept_EstimEqualAg;
this.inParami_OrderAccConcept_CreditNote = inParami_OrderAccConcept_CreditNote;
this.inParami_OrderAccConcept_Voucher = inParami_OrderAccConcept_Voucher;
this.inParami_OrderAccConcept_Finiquito = inParami_OrderAccConcept_Finiquito;
this.inParami_OrderAccConcept_Anticipo = inParami_OrderAccConcept_Anticipo;
}
}
public class lcoSaveOrderAccConcepts : VarsBag {
public string outParamErrorMsg = "";

public bool outParamWithError = true;

public bool outParamIsEstimEqualAgEmpty = true;

public bool outParamIsFiniquitoEmpty = true;

public lcoSaveOrderAccConcepts() {
}
}
/// <summary>
/// Action <code>SaveOrderAccConcepts</code> that represents the Service Studio action
///  <code>SaveOrderAccConcepts</code> <p> Description: Save Order AccConcepts</p>
/// </summary>
public static async Task<(string,bool,bool,bool)> ActionSaveOrderAccConcepts(IRequestContext requestContext,long inParami_OrderId,RC_dd1ef552e394be88b7a9660ce51d9447 inParami_OrderAccConcept_EstimEqualAg,RC_dd1ef552e394be88b7a9660ce51d9447 inParami_OrderAccConcept_CreditNote,RC_dd1ef552e394be88b7a9660ce51d9447 inParami_OrderAccConcept_Voucher,RC_dd1ef552e394be88b7a9660ce51d9447 inParami_OrderAccConcept_Finiquito,RC_dd1ef552e394be88b7a9660ce51d9447 inParami_OrderAccConcept_Anticipo,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
bool outParamWithError = default;
bool outParamIsEstimEqualAgEmpty = default;
bool outParamIsFiniquitoEmpty = default;
lcoSaveOrderAccConcepts result = new lcoSaveOrderAccConcepts();
lcvSaveOrderAccConcepts localVars = new lcvSaveOrderAccConcepts(inParami_OrderId, inParami_OrderAccConcept_EstimEqualAg, inParami_OrderAccConcept_CreditNote, inParami_OrderAccConcept_Voucher, inParami_OrderAccConcept_Finiquito, inParami_OrderAccConcept_Anticipo);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SaveOrderAccConcepts", "83a6805e-e9e3-4a26-b238-1db973079c9d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SaveOrderAccConcepts", "83a6805e-e9e3-4a26-b238-1db973079c9d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// OrderAccConceptsCreateOrUpdate
localVars.resOrderAccConceptsCreateOrUpdate.outParamId = await Actions.ActionOrderAccConceptsCreateOrUpdate(requestContext,localVars.inParami_OrderAccConcept_EstimEqualAg.ssENMainAccConcepts,cancellationToken);

// OrderAccConceptsCreateOrUpdateCreditNote
localVars.resOrderAccConceptsCreateOrUpdateCreditNote.outParamId = await Actions.ActionOrderAccConceptsCreateOrUpdate(requestContext,localVars.inParami_OrderAccConcept_CreditNote.ssENMainAccConcepts,cancellationToken);

// OrderAccConceptsCreateOrUpdateVoucher
localVars.resOrderAccConceptsCreateOrUpdateVoucher.outParamId = await Actions.ActionOrderAccConceptsCreateOrUpdate(requestContext,localVars.inParami_OrderAccConcept_Voucher.ssENMainAccConcepts,cancellationToken);

// OrderAccConceptsCreateOrUpdateFiniquito
localVars.resOrderAccConceptsCreateOrUpdateFiniquito.outParamId = await Actions.ActionOrderAccConceptsCreateOrUpdate(requestContext,localVars.inParami_OrderAccConcept_Finiquito.ssENMainAccConcepts,cancellationToken);

// OrderAccConceptsCreateOrUpdateAnticipo
localVars.resOrderAccConceptsCreateOrUpdateAnticipo.outParamId = await Actions.ActionOrderAccConceptsCreateOrUpdate(requestContext,localVars.inParami_OrderAccConcept_Anticipo.ssENMainAccConcepts,cancellationToken);

if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipPagosComplemento]))))) {
// Set Error False
// WithError = False
result.outParamWithError=false;
} else {
if((localVars.inParami_OrderAccConcept_EstimEqualAg.ssENMainAccConcepts.ssIsActive)) {
// Foreach i_OrderAccConcept_EstimEqualAg.SubAccConcepts
localVars.inParami_OrderAccConcept_EstimEqualAg.ssRLSubAccConcepts.StartIteration();
try {while (!((localVars.inParami_OrderAccConcept_EstimEqualAg.ssRLSubAccConcepts.Eof))) {
// i_OrderAccConcept_EstimEqualAg.SubAccConcepts.Current.OrderAccountingId = i_OrderAccConcept_EstimEqualAg.MainAccConcepts.OrderAccountingId
localVars.inParami_OrderAccConcept_EstimEqualAg.ssRLSubAccConcepts.CurrentRec.ssOrderAccountingId = localVars.inParami_OrderAccConcept_EstimEqualAg.ssENMainAccConcepts.ssOrderAccountingId;

// i_OrderAccConcept_EstimEqualAg.SubAccConcepts.Current.OrderAccConceptsId = i_OrderAccConcept_EstimEqualAg.MainAccConcepts.Id
localVars.inParami_OrderAccConcept_EstimEqualAg.ssRLSubAccConcepts.CurrentRec.ssOrderAccConceptsId = localVars.inParami_OrderAccConcept_EstimEqualAg.ssENMainAccConcepts.ssId;

// i_OrderAccConcept_EstimEqualAg.SubAccConcepts.Current.IsActive = True
localVars.inParami_OrderAccConcept_EstimEqualAg.ssRLSubAccConcepts.CurrentRec.ssIsActive = true;
// Set Error False
// WithError = False
result.outParamWithError=false;

// IsEstimEqualAgEmpty = False
result.outParamIsEstimEqualAgEmpty=false;
// OrderAccConceptsCreateOrUpdate2
localVars.resOrderAccConceptsCreateOrUpdate2.outParamId = await Actions.ActionOrderAccConceptsCreateOrUpdate(requestContext,localVars.inParami_OrderAccConcept_EstimEqualAg.ssRLSubAccConcepts.CurrentRec,cancellationToken);

localVars.inParami_OrderAccConcept_EstimEqualAg.ssRLSubAccConcepts.Advance();
}

} finally {
localVars.inParami_OrderAccConcept_EstimEqualAg.ssRLSubAccConcepts.EndIteration();
}

// IsEstimEqualAgEmpty = If
result.outParamIsEstimEqualAgEmpty=(((result.outParamIsEstimEqualAgEmpty==false)) ? (false) : (true));
}

if((localVars.inParami_OrderAccConcept_CreditNote.ssENMainAccConcepts.ssIsActive)) {
// Foreach i_OrderAccConcept_CreditNote.SubAccConcepts
localVars.inParami_OrderAccConcept_CreditNote.ssRLSubAccConcepts.StartIteration();
try {while (!((localVars.inParami_OrderAccConcept_CreditNote.ssRLSubAccConcepts.Eof))) {
// i_OrderAccConcept_CreditNote.SubAccConcepts.Current.OrderAccountingId = i_OrderAccConcept_CreditNote.MainAccConcepts.OrderAccountingId
localVars.inParami_OrderAccConcept_CreditNote.ssRLSubAccConcepts.CurrentRec.ssOrderAccountingId = localVars.inParami_OrderAccConcept_CreditNote.ssENMainAccConcepts.ssOrderAccountingId;

// i_OrderAccConcept_CreditNote.SubAccConcepts.Current.OrderAccConceptsId = OrderAccConceptsCreateOrUpdateCreditNote.Id
localVars.inParami_OrderAccConcept_CreditNote.ssRLSubAccConcepts.CurrentRec.ssOrderAccConceptsId = localVars.resOrderAccConceptsCreateOrUpdateCreditNote.outParamId;

// i_OrderAccConcept_CreditNote.SubAccConcepts.Current.IsActive = True
localVars.inParami_OrderAccConcept_CreditNote.ssRLSubAccConcepts.CurrentRec.ssIsActive = true;
// Set Error False
// WithError = False
result.outParamWithError=false;
// OrderAccConceptsCreateOrUpdate4
localVars.resOrderAccConceptsCreateOrUpdate4.outParamId = await Actions.ActionOrderAccConceptsCreateOrUpdate(requestContext,localVars.inParami_OrderAccConcept_CreditNote.ssRLSubAccConcepts.CurrentRec,cancellationToken);

localVars.inParami_OrderAccConcept_CreditNote.ssRLSubAccConcepts.Advance();
}

} finally {
localVars.inParami_OrderAccConcept_CreditNote.ssRLSubAccConcepts.EndIteration();
}

}

if((localVars.inParami_OrderAccConcept_Voucher.ssENMainAccConcepts.ssIsActive)) {
// Foreach i_OrderAccConcept_Voucher.SubAccConcepts
localVars.inParami_OrderAccConcept_Voucher.ssRLSubAccConcepts.StartIteration();
try {while (!((localVars.inParami_OrderAccConcept_Voucher.ssRLSubAccConcepts.Eof))) {
// i_OrderAccConcept_Voucher.SubAccConcepts.Current.OrderAccountingId = i_OrderAccConcept_Voucher.MainAccConcepts.OrderAccountingId
localVars.inParami_OrderAccConcept_Voucher.ssRLSubAccConcepts.CurrentRec.ssOrderAccountingId = localVars.inParami_OrderAccConcept_Voucher.ssENMainAccConcepts.ssOrderAccountingId;

// i_OrderAccConcept_Voucher.SubAccConcepts.Current.OrderAccConceptsId = OrderAccConceptsCreateOrUpdateVoucher.Id
localVars.inParami_OrderAccConcept_Voucher.ssRLSubAccConcepts.CurrentRec.ssOrderAccConceptsId = localVars.resOrderAccConceptsCreateOrUpdateVoucher.outParamId;

// i_OrderAccConcept_Voucher.SubAccConcepts.Current.IsActive = True
localVars.inParami_OrderAccConcept_Voucher.ssRLSubAccConcepts.CurrentRec.ssIsActive = true;
// Set Error False
// WithError = False
result.outParamWithError=false;
// OrderAccConceptsCreateOrUpdate5
localVars.resOrderAccConceptsCreateOrUpdate5.outParamId = await Actions.ActionOrderAccConceptsCreateOrUpdate(requestContext,localVars.inParami_OrderAccConcept_Voucher.ssRLSubAccConcepts.CurrentRec,cancellationToken);

localVars.inParami_OrderAccConcept_Voucher.ssRLSubAccConcepts.Advance();
}

} finally {
localVars.inParami_OrderAccConcept_Voucher.ssRLSubAccConcepts.EndIteration();
}

}

if((localVars.inParami_OrderAccConcept_Finiquito.ssENMainAccConcepts.ssIsActive)) {
// Foreach i_OrderAccConcept_Finiquito.SubAccConcepts
localVars.inParami_OrderAccConcept_Finiquito.ssRLSubAccConcepts.StartIteration();
try {while (!((localVars.inParami_OrderAccConcept_Finiquito.ssRLSubAccConcepts.Eof))) {
// i_OrderAccConcept_Finiquito.SubAccConcepts.Current.OrderAccountingId = i_OrderAccConcept_Finiquito.MainAccConcepts.OrderAccountingId
localVars.inParami_OrderAccConcept_Finiquito.ssRLSubAccConcepts.CurrentRec.ssOrderAccountingId = localVars.inParami_OrderAccConcept_Finiquito.ssENMainAccConcepts.ssOrderAccountingId;

// i_OrderAccConcept_Finiquito.SubAccConcepts.Current.OrderAccConceptsId = OrderAccConceptsCreateOrUpdateFiniquito.Id
localVars.inParami_OrderAccConcept_Finiquito.ssRLSubAccConcepts.CurrentRec.ssOrderAccConceptsId = localVars.resOrderAccConceptsCreateOrUpdateFiniquito.outParamId;

// i_OrderAccConcept_Finiquito.SubAccConcepts.Current.IsActive = True
localVars.inParami_OrderAccConcept_Finiquito.ssRLSubAccConcepts.CurrentRec.ssIsActive = true;
// Set Error False
// WithError = False
result.outParamWithError=false;

// IsFiniquitoEmpty = False
result.outParamIsFiniquitoEmpty=false;
// OrderAccConceptsCreateOrUpdate6
localVars.resOrderAccConceptsCreateOrUpdate6.outParamId = await Actions.ActionOrderAccConceptsCreateOrUpdate(requestContext,localVars.inParami_OrderAccConcept_Finiquito.ssRLSubAccConcepts.CurrentRec,cancellationToken);

localVars.inParami_OrderAccConcept_Finiquito.ssRLSubAccConcepts.Advance();
}

} finally {
localVars.inParami_OrderAccConcept_Finiquito.ssRLSubAccConcepts.EndIteration();
}

// IsFiniquitoEmpty = If
result.outParamIsFiniquitoEmpty=(((result.outParamIsFiniquitoEmpty==false)) ? (false) : (true));
}

if((localVars.inParami_OrderAccConcept_Anticipo.ssENMainAccConcepts.ssIsActive)) {
// Foreach i_OrderAccConcept_Anticipo.SubAccConcepts
localVars.inParami_OrderAccConcept_Anticipo.ssRLSubAccConcepts.StartIteration();
try {while (!((localVars.inParami_OrderAccConcept_Anticipo.ssRLSubAccConcepts.Eof))) {
// i_OrderAccConcept_Anticipo.SubAccConcepts.Current.OrderAccountingId = i_OrderAccConcept_Anticipo.MainAccConcepts.OrderAccountingId
localVars.inParami_OrderAccConcept_Anticipo.ssRLSubAccConcepts.CurrentRec.ssOrderAccountingId = localVars.inParami_OrderAccConcept_Anticipo.ssENMainAccConcepts.ssOrderAccountingId;

// i_OrderAccConcept_Anticipo.SubAccConcepts.Current.OrderAccConceptsId = OrderAccConceptsCreateOrUpdateAnticipo.Id
localVars.inParami_OrderAccConcept_Anticipo.ssRLSubAccConcepts.CurrentRec.ssOrderAccConceptsId = localVars.resOrderAccConceptsCreateOrUpdateAnticipo.outParamId;

// i_OrderAccConcept_Anticipo.SubAccConcepts.Current.IsActive = True
localVars.inParami_OrderAccConcept_Anticipo.ssRLSubAccConcepts.CurrentRec.ssIsActive = true;
// Set Error False
// WithError = False
result.outParamWithError=false;
// OrderAccConceptsCreateOrUpdate7
localVars.resOrderAccConceptsCreateOrUpdate7.outParamId = await Actions.ActionOrderAccConceptsCreateOrUpdate(requestContext,localVars.inParami_OrderAccConcept_Anticipo.ssRLSubAccConcepts.CurrentRec,cancellationToken);

localVars.inParami_OrderAccConcept_Anticipo.ssRLSubAccConcepts.Advance();
}

} finally {
localVars.inParami_OrderAccConcept_Anticipo.ssRLSubAccConcepts.EndIteration();
}

}

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// ErrorMsg = AllExceptions.ExceptionMessage
result.outParamErrorMsg=ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamErrorMsg = result.outParamErrorMsg;
outParamWithError = result.outParamWithError;
outParamIsEstimEqualAgEmpty = result.outParamIsEstimEqualAgEmpty;
outParamIsFiniquitoEmpty = result.outParamIsFiniquitoEmpty;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamErrorMsg,outParamWithError,outParamIsEstimEqualAgEmpty,outParamIsFiniquitoEmpty);
}

public static class FuncActionSaveOrderAccConcepts {



}


}
