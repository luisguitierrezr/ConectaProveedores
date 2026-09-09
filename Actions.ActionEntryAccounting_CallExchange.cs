namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntryAccounting_CallExchange : VarsBag {
public string inParamCurrency;
public DateTime inParamDate;
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate4 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate3 =  new Actions.lcoLogsAccountingCreate();
public ST_72813e0dac5e52c872182de62adb7f2bStructure resCall_ZMXFFIMF_OBT_TIP_CAM_outParamResponse = new ST_72813e0dac5e52c872182de62adb7f2bStructure();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate5 =  new Actions.lcoLogsAccountingCreate();
public lcvEntryAccounting_CallExchange(string inParamCurrency, DateTime inParamDate) {
this.inParamCurrency = inParamCurrency;
this.inParamDate = inParamDate;
}
}
public class lcoEntryAccounting_CallExchange : VarsBag {
public decimal outParamExchangeValue = 0.0M;

public lcoEntryAccounting_CallExchange() {
}
}
/// <summary>
/// Action <code>EntryAccounting_CallExchange</code> that represents the Service Studio action
///  <code>EntryAccounting_CallExchange</code> <p> Description: </p>
/// </summary>
public static async Task<decimal> ActionEntryAccounting_CallExchange(IRequestContext requestContext,string inParamCurrency,DateTime inParamDate,CancellationToken cancellationToken) {
decimal outParamExchangeValue = default;
lcoEntryAccounting_CallExchange result = new lcoEntryAccounting_CallExchange();
lcvEntryAccounting_CallExchange localVars = new lcvEntryAccounting_CallExchange(inParamCurrency, inParamDate);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EntryAccounting_CallExchange", "7828ed40-2d07-487a-86e6-e6343c40ad16"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EntryAccounting_CallExchange", "7828ed40-2d07-487a-86e6-e6343c40ad16", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// LogsAccountingCreate3
localVars.resLogsAccountingCreate3.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call Tipo Cambio", ssDescription = ((((((("PI_KURST "+"M")+" // PI_FCURR ")+localVars.inParamCurrency)+" // PI_TCURR ")+"MXN")+" // PI_GDATU ")+BuiltInFunction.FormatDateTime (BuiltInFunction.CurrDate (), "dd.MM.yyyy")), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DfEszJhTpUmVCxUNPRuFWg"))).ssId },cancellationToken);

// Call_ZMXFFIMF_OBT_TIP_CAM
localVars.resCall_ZMXFFIMF_OBT_TIP_CAM_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXFFIMF_OBT_TIP_CAM(requestContext,new ST_694abc44952847f050feca404fbee9c5Structure(){ ssPI_FCURR = localVars.inParamCurrency, ssPI_GDATU = BuiltInFunction.FormatDateTime (localVars.inParamDate, "ddMMyyyy"), ssPI_KURST = "M", ssPI_TCURR = "MXN" },cancellationToken);

// ExchangeValue = Call_ZMXFFIMF_OBT_TIP_CAM.Response.PE_UKURS
result.outParamExchangeValue=localVars.resCall_ZMXFFIMF_OBT_TIP_CAM_outParamResponse.ssPE_UKURS;
// LogsAccountingCreate4
localVars.resLogsAccountingCreate4.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Resposta Tipo Cambio", ssDescription = ((("PI_UKURS "+BuiltInFunction.DecimalToText(localVars.resCall_ZMXFFIMF_OBT_TIP_CAM_outParamResponse.ssPE_UKURS))+" // PE_MSG ")+localVars.resCall_ZMXFFIMF_OBT_TIP_CAM_outParamResponse.ssPE_MSG), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DfEszJhTpUmVCxUNPRuFWg"))).ssId },cancellationToken);

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// LogsAccountingCreate5
localVars.resLogsAccountingCreate5.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error Tipo Cambio", ssDescription = "", ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("DfEszJhTpUmVCxUNPRuFWg"))).ssId },cancellationToken);

goto RETURN_STATEMENT;

} // Catch
finally {
outParamExchangeValue = result.outParamExchangeValue;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamExchangeValue;
}

public static class FuncActionEntryAccounting_CallExchange {



}


}
