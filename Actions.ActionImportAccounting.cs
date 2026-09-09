namespace ssConectaProveedores;

public partial class Actions {
public class lcvImportAccounting : VarsBag {
public ST_a158c76eb93396680623c04244f48b6cStructure inParami_File;
public long inParami_InvoiceId;
public string inParami_SupplierNumber;
public decimal inParami_TotalAmount;
public long inParami_InvoiceAccountingId;
public RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d resExcelToRecordList_outParamOut = new RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d();
public RL_375b9dd8c8b0d6d7bccf4d550f48644d queryResGetPaymentTermByDescr_outParamList = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
public long queryResGetPaymentTermByDescr_outParamCount = 0L;

public RL_bf188616de0f0f2f6ca06ba5dba27490 queryResGetTaxIndicatorsByExternalId2_outParamList = new RL_bf188616de0f0f2f6ca06ba5dba27490();
public long queryResGetTaxIndicatorsByExternalId2_outParamCount = 0L;

public RL_ec55ed22dae89075d036f3a863173164 queryResGetCeBe_outParamList = new RL_ec55ed22dae89075d036f3a863173164();
public long queryResGetCeBe_outParamCount = 0L;

public RL_0dcbcba642ca8b22e87f690d4de9d077 queryResGetPaymentMethodByExtId_outParamList = new RL_0dcbcba642ca8b22e87f690d4de9d077();
public long queryResGetPaymentMethodByExtId_outParamCount = 0L;

public RL_bf188616de0f0f2f6ca06ba5dba27490 queryResGetTaxIndicatorsByExternalId_outParamList = new RL_bf188616de0f0f2f6ca06ba5dba27490();
public long queryResGetTaxIndicatorsByExternalId_outParamCount = 0L;

public RL_ec55ed22dae89075d036f3a863173164 queryResGetCostCenter_outParamList = new RL_ec55ed22dae89075d036f3a863173164();
public long queryResGetCostCenter_outParamCount = 0L;

public lcvImportAccounting(ST_a158c76eb93396680623c04244f48b6cStructure inParami_File, long inParami_InvoiceId, string inParami_SupplierNumber, decimal inParami_TotalAmount, long inParami_InvoiceAccountingId) {
this.inParami_File = inParami_File;
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_SupplierNumber = inParami_SupplierNumber;
this.inParami_TotalAmount = inParami_TotalAmount;
this.inParami_InvoiceAccountingId = inParami_InvoiceAccountingId;
}
}
public class lcoImportAccounting : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord outParamo_InvoiceAccounting = new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();

public RL_0704e14bc1b3305d76f59d709913c287 outParamo_InvoiceAccountingEntries = new RL_0704e14bc1b3305d76f59d709913c287();

public RL_d55212981ba3c49c0fb66324f6a1411a outParamo_InvoiceAccountingServices = new RL_d55212981ba3c49c0fb66324f6a1411a();

public lcoImportAccounting() {
}
}
/// <summary>
/// Action <code>ImportAccounting</code> that represents the Service Studio action
///  <code>ImportAccounting</code> <p> Description: Action to make an Accounting importation.</p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord,RL_0704e14bc1b3305d76f59d709913c287,RL_d55212981ba3c49c0fb66324f6a1411a)> ActionImportAccounting(IRequestContext requestContext,ST_a158c76eb93396680623c04244f48b6cStructure inParami_File,long inParami_InvoiceId,string inParami_SupplierNumber,decimal inParami_TotalAmount,long inParami_InvoiceAccountingId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord outParamo_InvoiceAccounting = default;
RL_0704e14bc1b3305d76f59d709913c287 outParamo_InvoiceAccountingEntries = default;
RL_d55212981ba3c49c0fb66324f6a1411a outParamo_InvoiceAccountingServices = default;
lcoImportAccounting result = new lcoImportAccounting();
lcvImportAccounting localVars = new lcvImportAccounting(inParami_File, inParami_InvoiceId, inParami_SupplierNumber, inParami_TotalAmount, inParami_InvoiceAccountingId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ImportAccounting", "2ba363b1-6ca2-4174-b658-da40d1f7add6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ImportAccounting", "2ba363b1-6ca2-4174-b658-da40d1f7add6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ExcelToRecordList ExcelToRLImportAccountingExcelToRecordList
FuncActionImportAccounting.ExcelToRLImportAccountingExcelToRecordList(requestContext,localVars.inParami_File.ssBinaryData,"LAYOUT",out localVars.resExcelToRecordList_outParamOut);
// diff supplier?
if(((localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssCuentadeMayor!=localVars.inParami_SupplierNumber))) {
// RaiseError InvalidImport
throw new Ex_InvalidImportUserException (AppUtils.GetStringResource("bf6gi0TLukK7LpMaU5KGyA#Message.-1897038481.1", "Supplier number does not match with invoice."));

} else {
// diff amount?
if(((localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssImporteenmonedadeldocto!=localVars.inParami_TotalAmount))) {
// RaiseError InvalidImport
throw new Ex_InvalidImportUserException (AppUtils.GetStringResource("YtBTvyH97U68sCzWVdjfog#Message.2087948248.1", "Total Amount does not match with invoice."));

} else {
// Query datasetGetPaymentMethodByExtId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetPaymentMethodByExtId_maxRecords = 1;
if (datasetGetPaymentMethodByExtId_maxRecords < 1) datasetGetPaymentMethodByExtId_maxRecords = 1;
int datasetGetPaymentMethodByExtId_startIndex = 0;(localVars.queryResGetPaymentMethodByExtId_outParamList,localVars.queryResGetPaymentMethodByExtId_outParamCount) = await FuncActionImportAccounting.datasetGetPaymentMethodByExtId(requestContext,datasetGetPaymentMethodByExtId_maxRecords,datasetGetPaymentMethodByExtId_startIndex,IterationMultiplicity.Never,localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssV_pago,cancellationToken);

// Query datasetGetPaymentTermByDescr
cancellationToken.ThrowIfCancellationRequested();
int datasetGetPaymentTermByDescr_maxRecords = 1;
if (datasetGetPaymentTermByDescr_maxRecords < 1) datasetGetPaymentTermByDescr_maxRecords = 1;
int datasetGetPaymentTermByDescr_startIndex = 0;(localVars.queryResGetPaymentTermByDescr_outParamList,localVars.queryResGetPaymentTermByDescr_outParamCount) = await FuncActionImportAccounting.datasetGetPaymentTermByDescr(requestContext,datasetGetPaymentTermByDescr_maxRecords,datasetGetPaymentTermByDescr_startIndex,IterationMultiplicity.Never,localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssCondicionesdepago,cancellationToken);

// empty?
if(((localVars.queryResGetPaymentTermByDescr_outParamList.Empty||localVars.queryResGetPaymentMethodByExtId_outParamList.Empty))) {
// RaiseError InvalidImport
throw new Ex_InvalidImportUserException (AppUtils.GetStringResource("0BYY48+5a0qFUjUeL3KiNw#Message.1094738852.1", "Invalid data in the field Payment Terms."));

} else {
// Query datasetGetTaxIndicatorsByExternalId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTaxIndicatorsByExternalId_maxRecords = 1;
if (datasetGetTaxIndicatorsByExternalId_maxRecords < 1) datasetGetTaxIndicatorsByExternalId_maxRecords = 1;
int datasetGetTaxIndicatorsByExternalId_startIndex = 0;(localVars.queryResGetTaxIndicatorsByExternalId_outParamList,localVars.queryResGetTaxIndicatorsByExternalId_outParamCount) = await FuncActionImportAccounting.datasetGetTaxIndicatorsByExternalId(requestContext,datasetGetTaxIndicatorsByExternalId_maxRecords,datasetGetTaxIndicatorsByExternalId_startIndex,IterationMultiplicity.Never,localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssIVA,cancellationToken);

// iva error?
if(((localVars.queryResGetTaxIndicatorsByExternalId_outParamList.Empty&&(localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssIVA!="")))) {
// RaiseError InvalidImport
throw new Ex_InvalidImportUserException (AppUtils.GetStringResource("k3ZKrh69b0idJWHbT_uqeA#Message.-784830304.1", "Invalid data in the field IVA Indicator"));

} else {
// Accounting
// o_InvoiceAccounting.Id = i_InvoiceAccountingId
result.outParamo_InvoiceAccounting.ssId = localVars.inParami_InvoiceAccountingId;

// o_InvoiceAccounting.InvoiceId = i_InvoiceId
result.outParamo_InvoiceAccounting.ssInvoiceId = localVars.inParami_InvoiceId;

// o_InvoiceAccounting.SupplierNumber = ExcelToRecordList.Current.ImportAccountingExcelStruct.CuentadeMayor
result.outParamo_InvoiceAccounting.ssSupplierNumber = localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssCuentadeMayor;

// o_InvoiceAccounting.FreeText = ExcelToRecordList.Current.ImportAccountingExcelStruct.TextodeCabeceradeDocumento
result.outParamo_InvoiceAccounting.ssFreeText = localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssTextodeCabeceradeDocumento;

// o_InvoiceAccounting.Division = ExcelToRecordList.Current.ImportAccountingExcelStruct.Division
result.outParamo_InvoiceAccounting.ssDivision = localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssDivision;

// o_InvoiceAccounting.IvaAmount = GetTaxIndicatorsByExternalId.List.Current.TaxIndicator.Id
result.outParamo_InvoiceAccounting.ssIvaAmount = (((decimal)localVars.queryResGetTaxIndicatorsByExternalId_outParamList.CurrentRec.ssENTaxIndicator.ssId));

// o_InvoiceAccounting.TotalAmount = ExcelToRecordList.Current.ImportAccountingExcelStruct.Importeenmonedadeldocto
result.outParamo_InvoiceAccounting.ssTotalAmount = localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssImporteenmonedadeldocto;

// o_InvoiceAccounting.PaymentMethodId = GetPaymentMethodByExtId.List.Current.PaymentMethods.Id
result.outParamo_InvoiceAccounting.ssPaymentMethodId = localVars.queryResGetPaymentMethodByExtId_outParamList.CurrentRec.ssENPaymentMethods.ssId;

// o_InvoiceAccounting.PaymentTermsId = GetPaymentTermByDescr.List.Current.PaymentTerms.Id
result.outParamo_InvoiceAccounting.ssPaymentTermsId = localVars.queryResGetPaymentTermByDescr_outParamList.CurrentRec.ssENPaymentTerms.ssId;

// o_InvoiceAccounting.ICMEIndicator = ExcelToRecordList.Current.ImportAccountingExcelStruct.IndicadorICME
result.outParamo_InvoiceAccounting.ssICMEIndicator = localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssIndicadorICME;

// o_InvoiceAccounting.IvaIndicatorId = GetTaxIndicatorsByExternalId.List.Current.TaxIndicator.Id
result.outParamo_InvoiceAccounting.ssIvaIndicatorId = localVars.queryResGetTaxIndicatorsByExternalId_outParamList.CurrentRec.ssENTaxIndicator.ssId;
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamo_InvoiceAccountingEntries,(await RL_0704e14bc1b3305d76f59d709913c287.ConvertAsync(localVars.resExcelToRecordList_outParamOut, new RL_0704e14bc1b3305d76f59d709913c287(), async (RC_6c3703fd5f299efe93690e66a0547b14 source, EN_66fb76d3fab58a693a3c750c022bd4efEntityRecord target, CancellationToken cancellationToken) => {
target.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());
target.ssInvoiceId = localVars.inParami_InvoiceId;
target.ssControldedocumento = source.ssSTImportAccountingExcelStruct.ssControldedocumento;
target.ssFechadedocumento = BuiltInFunction.TextToDate (source.ssSTImportAccountingExcelStruct.ssFechadedocumento);
target.ssFechadecontabilizacion = BuiltInFunction.TextToDate (source.ssSTImportAccountingExcelStruct.ssFechadecontabilizacion);
target.ssClasededocumento = source.ssSTImportAccountingExcelStruct.ssClasededocumento;
target.ssSociedad = source.ssSTImportAccountingExcelStruct.ssSociedad;
target.ssMoneda = source.ssSTImportAccountingExcelStruct.ssMoneda;
target.ssTipodeCambio = source.ssSTImportAccountingExcelStruct.ssTipodeCambio;
target.ssFechadeConversion = BuiltInFunction.TextToDate (source.ssSTImportAccountingExcelStruct.ssFechadeConversion);
target.ssNumerodeDoc_DeReferencia = source.ssSTImportAccountingExcelStruct.ssNumerodeDoc_DeReferencia;
target.ssTextodeCabeceradeDocumento = source.ssSTImportAccountingExcelStruct.ssTextodeCabeceradeDocumento;
target.ssClaveContabilizacion = source.ssSTImportAccountingExcelStruct.ssClaveContabilizacion;
target.ssCuentadeMayor = source.ssSTImportAccountingExcelStruct.ssCuentadeMayor;
target.ssIndicadorICME = source.ssSTImportAccountingExcelStruct.ssIndicadorICME;
target.ssImporteenmonedadeldocto = source.ssSTImportAccountingExcelStruct.ssImporteenmonedadeldocto;
target.ssCalcularimpuestos = source.ssSTImportAccountingExcelStruct.ssCalcularimpuestos;
target.ssIndicadordeIVA = localVars.queryResGetTaxIndicatorsByExternalId_outParamList.CurrentRec.ssENTaxIndicator.ssExternalId;
target.ssDivision = source.ssSTImportAccountingExcelStruct.ssDivision;
target.ssCondicionesdepago = source.ssSTImportAccountingExcelStruct.ssCondicionesdepago;
target.ssFechabase = BuiltInFunction.TextToDate (source.ssSTImportAccountingExcelStruct.ssFechabase);
target.ssCentrodecostos = source.ssSTImportAccountingExcelStruct.ssCentrodecostos;
target.ssCentrodebeneficio = source.ssSTImportAccountingExcelStruct.ssCentrodebeneficio;
target.ssNumerodeasignacion = source.ssSTImportAccountingExcelStruct.ssNumerodeasignacion;
target.ssTexto = source.ssSTImportAccountingExcelStruct.ssTexto;
target.ssF_vencimiento = source.ssSTImportAccountingExcelStruct.ssF_vencimiento;
target.ssF_valor = source.ssSTImportAccountingExcelStruct.ssF_valor;
target.ssV_pago = source.ssSTImportAccountingExcelStruct.ssV_pago;
target.ssNombre = source.ssSTImportAccountingExcelStruct.ssNombre;
target.ssPoblacion = source.ssSTImportAccountingExcelStruct.ssPoblacion;
target.ssClavebanco = source.ssSTImportAccountingExcelStruct.ssClavebanco;
target.ssCta_bancaria = source.ssSTImportAccountingExcelStruct.ssCta_bancaria;
target.ssCuentaalternativa = source.ssSTImportAccountingExcelStruct.ssCuentaalternativa;
return target;
}, cancellationToken)),cancellationToken);

// Foreach ExcelToRecordList
localVars.resExcelToRecordList_outParamOut.StartIteration();
try {localVars.resExcelToRecordList_outParamOut.Advance(1);
while (!((localVars.resExcelToRecordList_outParamOut.Eof))) {
// CeCo and CeBe?
if((((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_TK88])))&&(localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssCentrodecostos!=""))&&(localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssCentrodebeneficio!="")))) {
// RaiseError InvalidImport
throw new Ex_InvalidImportUserException (AppUtils.GetStringResource("bm8LTa9zx0Gbyq4yFhAjgA#Message.538985870.1", "Cost Center and Benefit Center cannot be both filled."));

} else {
// Query datasetGetCostCenter
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCostCenter_maxRecords = 1;
if (datasetGetCostCenter_maxRecords < 1) datasetGetCostCenter_maxRecords = 1;
int datasetGetCostCenter_startIndex = 0;(localVars.queryResGetCostCenter_outParamList,localVars.queryResGetCostCenter_outParamCount) = await FuncActionImportAccounting.datasetGetCostCenter(requestContext,datasetGetCostCenter_maxRecords,datasetGetCostCenter_startIndex,IterationMultiplicity.Never,localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssCentrodecostos,cancellationToken);

// Query datasetGetCeBe
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCeBe_maxRecords = 1;
if (datasetGetCeBe_maxRecords < 1) datasetGetCeBe_maxRecords = 1;
int datasetGetCeBe_startIndex = 0;(localVars.queryResGetCeBe_outParamList,localVars.queryResGetCeBe_outParamCount) = await FuncActionImportAccounting.datasetGetCeBe(requestContext,datasetGetCeBe_maxRecords,datasetGetCeBe_startIndex,IterationMultiplicity.Never,localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssCentrodebeneficio,cancellationToken);

// Query datasetGetTaxIndicatorsByExternalId2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTaxIndicatorsByExternalId2_maxRecords = 1;
if (datasetGetTaxIndicatorsByExternalId2_maxRecords < 1) datasetGetTaxIndicatorsByExternalId2_maxRecords = 1;
int datasetGetTaxIndicatorsByExternalId2_startIndex = 0;(localVars.queryResGetTaxIndicatorsByExternalId2_outParamList,localVars.queryResGetTaxIndicatorsByExternalId2_outParamCount) = await FuncActionImportAccounting.datasetGetTaxIndicatorsByExternalId2(requestContext,datasetGetTaxIndicatorsByExternalId2_maxRecords,datasetGetTaxIndicatorsByExternalId2_startIndex,IterationMultiplicity.Never,localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssIVA,cancellationToken);

// unrecognized cc?
if(((localVars.queryResGetCostCenter_outParamList.Empty&&(localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssCentrodecostos!="")))) {
// RaiseError InvalidImport
throw new Ex_InvalidImportUserException (AppUtils.GetStringResource("_uP7LHvvj0OwsCcLtJ_hyg#Message.-1693009857.1", "Cost center does not exist in our catalog."));

} else {
// unrecognized cebe?
if(((localVars.queryResGetCeBe_outParamList.Empty&&(localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssCentrodebeneficio!="")))) {
// RaiseError InvalidImport
throw new Ex_InvalidImportUserException (AppUtils.GetStringResource("__oQieArXkqIHVvKN54Y5Q#Message.-2070927031.1", "Benefit center does not exist in our catalog."));

} else {
// unrecognized iva?
if(((localVars.queryResGetTaxIndicatorsByExternalId2_outParamList.Empty&&(localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssIVA!="")))) {
// RaiseError InvalidImport
throw new Ex_InvalidImportUserException (AppUtils.GetStringResource("hF46Cae67kCapqX0A0kTIw#Message.-205537805.1", "IVA does not exist in our catalog."));

} else {
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamo_InvoiceAccountingServices,new RC_3a3d5d4cc50f8572263073b452541424(){ ssENCeBeCostCenterSAP = localVars.queryResGetCeBe_outParamList.CurrentRec.ssENCostCenterSAP, ssENCostCenterSAP = localVars.queryResGetCostCenter_outParamList.CurrentRec.ssENCostCenterSAP, ssENInvoiceAccountingServices = new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceAccountingId = localVars.inParami_InvoiceAccountingId, ssAccount = localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssCuentadeMayor, ssCostCenterId = localVars.queryResGetCostCenter_outParamList.CurrentRec.ssENCostCenterSAP.ssId, ssCeBeCostCenterId = localVars.queryResGetCeBe_outParamList.CurrentRec.ssENCostCenterSAP.ssId, ssAmount = localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssImporteenmonedadeldocto, ssIVAIndicatorId = localVars.queryResGetTaxIndicatorsByExternalId2_outParamList.CurrentRec.ssENTaxIndicator.ssId, ssFreeText = localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssTextodeCabeceradeDocumento, ssDivision = localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssDivision, ssICME = localVars.resExcelToRecordList_outParamOut.CurrentRec.ssSTImportAccountingExcelStruct.ssIndicadorICME }, ssENTaxIndicator = localVars.queryResGetTaxIndicatorsByExternalId2_outParamList.CurrentRec.ssENTaxIndicator },cancellationToken);

}

}

}

}

localVars.resExcelToRecordList_outParamOut.Advance();
}

} finally {
localVars.resExcelToRecordList_outParamOut.EndIteration();
}

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

}

}

}

} //close CreateActionActivity using block
} // try

catch (Ex_InvalidImportUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = InvalidImport.ExceptionMessage
result.outParamo_Output.ssMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "File format is incorrect."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("YBLJsCaz1UilES4Cj1J8tw#Value.-364521094.1", "File format is incorrect.");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
outParamo_InvoiceAccounting = result.outParamo_InvoiceAccounting;
outParamo_InvoiceAccountingEntries = result.outParamo_InvoiceAccountingEntries;
outParamo_InvoiceAccountingServices = result.outParamo_InvoiceAccountingServices;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamo_InvoiceAccounting,outParamo_InvoiceAccountingEntries,outParamo_InvoiceAccountingServices);
}

public static class FuncActionImportAccounting {

// Query Function "GetPaymentTermByDescr" vuXJQbKclUOvIohjXvlB+A of Action "ImportAccounting"
public static async Task<(RL_375b9dd8c8b0d6d7bccf4d550f48644d,long)> datasetGetPaymentTermByDescr(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteEstructuraDescripcionPROP,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ImportAccounting.GetPaymentTermByDescr", "41c9e5be-9cb2-4395-af22-88635ef941f8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ImportAccounting.GetPaymentTermByDescr", "41c9e5be-9cb2-4395-af22-88635ef941f8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.sWOjK6JsdEG2WNpA0fet1g/NodesNotShownInESpaceTree.vuXJQbKclUOvIohjXvlB+A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentterms3\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {PaymentTerms} \"enpaymentterms3\"");
whereBuilder.Append(" WHERE (\"enpaymentterms3\".\"estructuradescripcionprop\" = @qpteEstructuraDescripcionPROP)");
sqlCmd.CreateParameterWithoutReplacements("@qpteEstructuraDescripcionPROP", DbType.String, qpteEstructuraDescripcionPROP);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_375b9dd8c8b0d6d7bccf4d550f48644d outParamList = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ImportAccounting.GetPaymentTermByDescr.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_375b9dd8c8b0d6d7bccf4d550f48644d _tmp = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ImportAccounting.GetPaymentTermByDescr.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_375b9dd8c8b0d6d7bccf4d550f48644d)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetTaxIndicatorsByExternalId2" 4JTViM0x8Uiw5ZpeA0ZGYw of Action "ImportAccounting"
public static async Task<(RL_bf188616de0f0f2f6ca06ba5dba27490,long)> datasetGetTaxIndicatorsByExternalId2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteExternalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ImportAccounting.GetTaxIndicatorsByExternalId2", "88d594e0-31cd-48f1-b0e5-9a5e03464663");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ImportAccounting.GetTaxIndicatorsByExternalId2", "88d594e0-31cd-48f1-b0e5-9a5e03464663", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.sWOjK6JsdEG2WNpA0fet1g/NodesNotShownInESpaceTree.4JTViM0x8Uiw5ZpeA0ZGYw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"entaxindicator1\".\"id\" o0, \"entaxindicator1\".\"description\" o1, \"entaxindicator1\".\"externalid\" o2, \"entaxindicator1\".\"createdon\" o3, \"entaxindicator1\".\"createdby\" o4, \"entaxindicator1\".\"updatedon\" o5, \"entaxindicator1\".\"updatedby\" o6");
fromBuilder.Append(" FROM {TaxIndicator} \"entaxindicator1\"");
whereBuilder.Append(" WHERE ((Upper(\"entaxindicator1\".\"externalid\")) = (Upper(@qpteExternalId)))");
sqlCmd.CreateParameterWithoutReplacements("@qpteExternalId", DbType.String, qpteExternalId);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_bf188616de0f0f2f6ca06ba5dba27490 outParamList = new RL_bf188616de0f0f2f6ca06ba5dba27490();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ImportAccounting.GetTaxIndicatorsByExternalId2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bf188616de0f0f2f6ca06ba5dba27490 _tmp = new RL_bf188616de0f0f2f6ca06ba5dba27490();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ImportAccounting.GetTaxIndicatorsByExternalId2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bf188616de0f0f2f6ca06ba5dba27490)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetCeBe" 0r8mkPXPVU2wt5ngSatUZg of Action "ImportAccounting"
public static async Task<(RL_ec55ed22dae89075d036f3a863173164,long)> datasetGetCeBe(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteCeBe,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ImportAccounting.GetCeBe", "9026bfd2-cff5-4d55-b0b7-99e049ab5466");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ImportAccounting.GetCeBe", "9026bfd2-cff5-4d55-b0b7-99e049ab5466", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.sWOjK6JsdEG2WNpA0fet1g/NodesNotShownInESpaceTree.0r8mkPXPVU2wt5ngSatUZg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encostcentersap1\".\"id\" o0, \"encostcentersap1\".\"regionid\" o1, \"encostcentersap1\".\"companyid\" o2, \"encostcentersap1\".\"soc_\" o3, \"encostcentersap1\".\"div_\" o4, \"encostcentersap1\".\"area\" o5, \"encostcentersap1\".\"ce_coste\" o6, \"encostcentersap1\".\"cebe\" o7, \"encostcentersap1\".\"denominacion\" o8, \"encostcentersap1\".\"descripcion\" o9, \"encostcentersap1\".\"responsable\" o10, \"encostcentersap1\".\"ceco\" o11, \"encostcentersap1\".\"costesprim_reales_ind_debloq\" o12, \"encostcentersap1\".\"costessecund_reales_ind_debl\" o13, \"encostcentersap1\".\"ingresosreales_ind_debloqueo\" o14, \"encostcentersap1\".\"actualiz_comprom__ind_debloq\" o15, \"encostcentersap1\".\"costesprimariosplan_ind_debl\" o16, \"encostcentersap1\".\"costessecund_plan_ind_debloq\" o17, \"encostcentersap1\".\"ingresosplan_ind_debloqueo_\" o18, \"encostcentersap1\".\"autor\" o19, \"encostcentersap1\".\"createdon\" o20, \"encostcentersap1\".\"createdby\" o21, \"encostcentersap1\".\"updatedon\" o22, \"encostcentersap1\".\"updatedby\" o23, \"encostcentersap1\".\"isactive\" o24");
fromBuilder.Append(" FROM {CostCenterSAP} \"encostcentersap1\"");
whereBuilder.Append(" WHERE ((Upper(\"encostcentersap1\".\"cebe\")) = (Upper(@qpteCeBe)))");
sqlCmd.CreateParameterWithoutReplacements("@qpteCeBe", DbType.String, qpteCeBe);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_ec55ed22dae89075d036f3a863173164 outParamList = new RL_ec55ed22dae89075d036f3a863173164();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ImportAccounting.GetCeBe.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ec55ed22dae89075d036f3a863173164 _tmp = new RL_ec55ed22dae89075d036f3a863173164();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ImportAccounting.GetCeBe.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ec55ed22dae89075d036f3a863173164)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetPaymentMethodByExtId" oDdPkCBJR0iidF3li90wOQ of Action "ImportAccounting"
public static async Task<(RL_0dcbcba642ca8b22e87f690d4de9d077,long)> datasetGetPaymentMethodByExtId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteExternalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ImportAccounting.GetPaymentMethodByExtId", "904f37a0-4920-4847-a274-5de58bdd3039");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ImportAccounting.GetPaymentMethodByExtId", "904f37a0-4920-4847-a274-5de58bdd3039", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.sWOjK6JsdEG2WNpA0fet1g/NodesNotShownInESpaceTree.oDdPkCBJR0iidF3li90wOQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentmethods2\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {PaymentMethods} \"enpaymentmethods2\"");
whereBuilder.Append(" WHERE (\"enpaymentmethods2\".\"externalid\" = @qpteExternalId)");
sqlCmd.CreateParameterWithoutReplacements("@qpteExternalId", DbType.String, qpteExternalId);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_0dcbcba642ca8b22e87f690d4de9d077 outParamList = new RL_0dcbcba642ca8b22e87f690d4de9d077();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ImportAccounting.GetPaymentMethodByExtId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0dcbcba642ca8b22e87f690d4de9d077 _tmp = new RL_0dcbcba642ca8b22e87f690d4de9d077();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ImportAccounting.GetPaymentMethodByExtId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0dcbcba642ca8b22e87f690d4de9d077)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetTaxIndicatorsByExternalId" ADz0mC+nSkusfBONke5zLg of Action "ImportAccounting"
public static async Task<(RL_bf188616de0f0f2f6ca06ba5dba27490,long)> datasetGetTaxIndicatorsByExternalId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteExternalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ImportAccounting.GetTaxIndicatorsByExternalId", "98f43c00-a72f-4b4a-ac7c-138d91ee732e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ImportAccounting.GetTaxIndicatorsByExternalId", "98f43c00-a72f-4b4a-ac7c-138d91ee732e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.sWOjK6JsdEG2WNpA0fet1g/NodesNotShownInESpaceTree.ADz0mC+nSkusfBONke5zLg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"entaxindicator2\".\"id\" o0, NULL o1, \"entaxindicator2\".\"externalid\" o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {TaxIndicator} \"entaxindicator2\"");
whereBuilder.Append(" WHERE ((Upper(\"entaxindicator2\".\"externalid\")) = (Upper(@qpteExternalId)))");
sqlCmd.CreateParameterWithoutReplacements("@qpteExternalId", DbType.String, qpteExternalId);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_bf188616de0f0f2f6ca06ba5dba27490 outParamList = new RL_bf188616de0f0f2f6ca06ba5dba27490();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ImportAccounting.GetTaxIndicatorsByExternalId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bf188616de0f0f2f6ca06ba5dba27490 _tmp = new RL_bf188616de0f0f2f6ca06ba5dba27490();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ImportAccounting.GetTaxIndicatorsByExternalId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bf188616de0f0f2f6ca06ba5dba27490)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetCostCenter" lOfc6xmdWUGE5jF7JGkFJw of Action "ImportAccounting"
public static async Task<(RL_ec55ed22dae89075d036f3a863173164,long)> datasetGetCostCenter(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteCe_coste,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ImportAccounting.GetCostCenter", "ebdce794-9d19-4159-84e6-317b24690527");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ImportAccounting.GetCostCenter", "ebdce794-9d19-4159-84e6-317b24690527", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.sWOjK6JsdEG2WNpA0fet1g/NodesNotShownInESpaceTree.lOfc6xmdWUGE5jF7JGkFJw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encostcentersap2\".\"id\" o0, \"encostcentersap2\".\"regionid\" o1, \"encostcentersap2\".\"companyid\" o2, \"encostcentersap2\".\"soc_\" o3, \"encostcentersap2\".\"div_\" o4, \"encostcentersap2\".\"area\" o5, \"encostcentersap2\".\"ce_coste\" o6, \"encostcentersap2\".\"cebe\" o7, \"encostcentersap2\".\"denominacion\" o8, \"encostcentersap2\".\"descripcion\" o9, \"encostcentersap2\".\"responsable\" o10, \"encostcentersap2\".\"ceco\" o11, \"encostcentersap2\".\"costesprim_reales_ind_debloq\" o12, \"encostcentersap2\".\"costessecund_reales_ind_debl\" o13, \"encostcentersap2\".\"ingresosreales_ind_debloqueo\" o14, \"encostcentersap2\".\"actualiz_comprom__ind_debloq\" o15, \"encostcentersap2\".\"costesprimariosplan_ind_debl\" o16, \"encostcentersap2\".\"costessecund_plan_ind_debloq\" o17, \"encostcentersap2\".\"ingresosplan_ind_debloqueo_\" o18, \"encostcentersap2\".\"autor\" o19, \"encostcentersap2\".\"createdon\" o20, \"encostcentersap2\".\"createdby\" o21, \"encostcentersap2\".\"updatedon\" o22, \"encostcentersap2\".\"updatedby\" o23, \"encostcentersap2\".\"isactive\" o24");
fromBuilder.Append(" FROM {CostCenterSAP} \"encostcentersap2\"");
whereBuilder.Append(" WHERE ((Upper(\"encostcentersap2\".\"ce_coste\")) = (Upper(@qpteCe_coste)))");
sqlCmd.CreateParameterWithoutReplacements("@qpteCe_coste", DbType.String, qpteCe_coste);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_ec55ed22dae89075d036f3a863173164 outParamList = new RL_ec55ed22dae89075d036f3a863173164();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ImportAccounting.GetCostCenter.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ec55ed22dae89075d036f3a863173164 _tmp = new RL_ec55ed22dae89075d036f3a863173164();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ImportAccounting.GetCostCenter.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ec55ed22dae89075d036f3a863173164)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}


/// <summary>
/// Excel To RecordList: ExcelToRLImportAccountingExcelToRecordList (KHNWXE9MNDU2766pMlTQUkw) of Action
///  "ImportAccounting"
/// </summary>
public static void ExcelToRLImportAccountingExcelToRecordList(IRequestContext requestContext,byte[] excelContent,string tableName,out RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d outParamOut) {

if(excelContent.GetLength(0) == 0) {
    throw InvalidExcelErrorsHelper.EmptyExcelFile();
}
var service = ServiceLocator.GetService<ISpreadsheetService>();
var reader = service.GetReader(
    excelContent, 
    tableName, 
    new Type[] {
        typeof(int), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(int), 
typeof(string), 
typeof(string), 
typeof(decimal), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string), 
typeof(string)
    },
    new string[] {
        "Controldedocumento", 
"Fechadedocumento", 
"Fechadecontabilizacion", 
"Clasededocumento", 
"Sociedad", 
"Moneda", 
"TipodeCambio", 
"FechadeConversion", 
"NumerodeDoc_DeReferencia", 
"TextodeCabeceradeDocumento", 
"ClaveContabilizacion", 
"CuentadeMayor", 
"IndicadorICME", 
"Importeenmonedadeldocto", 
"Calcularimpuestos", 
"IVA", 
"Division", 
"Condicionesdepago", 
"Fechabase", 
"Centrodecostos", 
"Centrodebeneficio", 
"Numerodeasignacion", 
"Texto", 
"F_vencimiento", 
"F_valor", 
"V_pago", 
"Nombre", 
"Poblacion", 
"Clavebanco", 
"Cta_bancaria", 
"Cuentaalternativa"
    },
    new string[] {
        "Control de documento", 
"Fecha de documento", 
"Fecha de contabilizacion", 
"Clase de documento", 
"Sociedad", 
"Moneda", 
"Tipo de Cambio", 
"Fecha de Conversion", 
"Numero de Doc De Referencia", 
"Texto de Cabecera de Documento", 
"Clave Contabilizacion", 
"Cuenta de Mayor", 
"Indicador ICME", 
"Importe en moneda del docto", 
"Calcular Impuestos", 
"IVA", 
"Division", 
"Condiciones de pago", 
"Fecha Base", 
"Centro de Costos", 
"Centro de Beneficio", 
"Numero de Asignacion", 
"Texto", 
"F. vencimiento", 
"F. valor", 
"V. pago", 
"Nombre", 
"Poblacion", 
"Clave Banco", 
"Cta Bancaria", 
"Cuenta Alternativa"
    },
    new string[] {
        "Controldedocumento", 
"Fechadedocumento", 
"Fechadecontabilizacion", 
"Clasededocumento", 
"Sociedad", 
"Moneda", 
"TipodeCambio", 
"FechadeConversion", 
"NumerodeDoc_DeReferencia", 
"TextodeCabeceradeDocumento", 
"ClaveContabilizacion", 
"CuentadeMayor", 
"IndicadorICME", 
"Importeenmonedadeldocto", 
"Calcularimpuestos", 
"IVA", 
"Division", 
"Condicionesdepago", 
"Fechabase", 
"Centrodecostos", 
"Centrodebeneficio", 
"Numerodeasignacion", 
"Texto", 
"F_vencimiento", 
"F_valor", 
"V_pago", 
"Nombre", 
"Poblacion", 
"Clavebanco", 
"Cta_bancaria", 
"Cuentaalternativa"
    },
    new string[] {
        "Control de documento", 
"Fecha de documento", 
"Fecha de contabilizacion", 
"Clase de documento", 
"Sociedad", 
"Moneda", 
"Tipo de Cambio", 
"Fecha de Conversion", 
"Numero de Doc De Referencia", 
"Texto de Cabecera de Documento", 
"Clave Contabilizacion", 
"Cuenta de Mayor", 
"Indicador ICME", 
"Importe en moneda del docto", 
"Calcular Impuestos", 
"IVA", 
"Division", 
"Condiciones de pago", 
"Fecha Base", 
"Centro de Costos", 
"Centro de Beneficio", 
"Numero de Asignacion", 
"Texto", 
"F. vencimiento", 
"F. valor", 
"V. pago", 
"Nombre", 
"Poblacion", 
"Clave Banco", 
"Cta Bancaria", 
"Cuenta Alternativa"
    });

RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d tmp = new();
tmp.Reader = reader;

outParamOut = (RL_74bdfb4be7d9e7d4cf37e3a8de1ad73d)tmp.Duplicate();
}


}


}
