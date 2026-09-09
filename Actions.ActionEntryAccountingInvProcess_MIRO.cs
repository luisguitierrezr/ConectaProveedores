namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntryAccountingInvProcess_MIRO : VarsBag {
public long inParamInvoiceAccountingProcessId;
public decimal inParamExchangeRate;
/// <summary>
/// Variable <code>ConceptPayTermDays</code> that represents the Service Studio Integer
///  <code>ConceptPayTermDays</code> <p>Description: </p>
/// </summary>
public int varLcConceptPayTermDays = 0;

public Actions.lcoInvoiceGetIVACodeByTax resInvoiceGetIVACodeByTax =  new Actions.lcoInvoiceGetIVACodeByTax();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate6 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoGetPaymentTermSpecial resGetPaymentTermSpecial =  new Actions.lcoGetPaymentTermSpecial();
public RL_72bc9c8db8dc80bec32b40b958e9af79 queryResGetInvoiceById_outParamList = new RL_72bc9c8db8dc80bec32b40b958e9af79();
public long queryResGetInvoiceById_outParamCount = 0L;

public Actions.lcoEntryAccounting_CallInvoiceCount resEntryAccounting_CallInvoiceCount =  new Actions.lcoEntryAccounting_CallInvoiceCount();
public RL_9404dc36b913809894c7e4e44e8e1dd8 queryResGetTaxToAdd_outParamList = new RL_9404dc36b913809894c7e4e44e8e1dd8();
public long queryResGetTaxToAdd_outParamCount = 0L;

public RL_cc70186cbf781c90043dce30d28664ab queryResGetOrderAccConceptById_outParamList = new RL_cc70186cbf781c90043dce30d28664ab();
public long queryResGetOrderAccConceptById_outParamCount = 0L;

public RL_4e909af3a15d1687c03c789af38db7ae queryResGetInvoiceAccountingProcessById_outParamList = new RL_4e909af3a15d1687c03c789af38db7ae();
public long queryResGetInvoiceAccountingProcessById_outParamCount = 0L;

public RL_af9a0ce202ec088a3c6de60c469b7bc6 queryResGetFolioItemsByOrderMainId_outParamList = new RL_af9a0ce202ec088a3c6de60c469b7bc6();
public long queryResGetFolioItemsByOrderMainId_outParamCount = 0L;

public Actions.lcoGetOrderK012 resGetOrderK012 =  new Actions.lcoGetOrderK012();
public lcvEntryAccountingInvProcess_MIRO(long inParamInvoiceAccountingProcessId, decimal inParamExchangeRate) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
this.inParamExchangeRate = inParamExchangeRate;
}
}
public class lcoEntryAccountingInvProcess_MIRO : VarsBag {
public bool outParamIsSuccess = true;

public string outParamMessage = "";

public lcoEntryAccountingInvProcess_MIRO() {
}
}
/// <summary>
/// Action <code>EntryAccountingInvProcess_MIRO</code> that represents the Service Studio action
///  <code>EntryAccountingInvProcess_MIRO</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,string)> ActionEntryAccountingInvProcess_MIRO(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,decimal inParamExchangeRate,CancellationToken cancellationToken) {
bool outParamIsSuccess = default;
string outParamMessage = default;
lcoEntryAccountingInvProcess_MIRO result = new lcoEntryAccountingInvProcess_MIRO();
lcvEntryAccountingInvProcess_MIRO localVars = new lcvEntryAccountingInvProcess_MIRO(inParamInvoiceAccountingProcessId, inParamExchangeRate);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EntryAccountingInvProcess_MIRO", "5c8330fe-55af-4520-ad23-41c333fdb080"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EntryAccountingInvProcess_MIRO", "5c8330fe-55af-4520-ad23-41c333fdb080", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceAccountingProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcessById_maxRecords = 1;
if (datasetGetInvoiceAccountingProcessById_maxRecords < 1) datasetGetInvoiceAccountingProcessById_maxRecords = 1;
int datasetGetInvoiceAccountingProcessById_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcessById_outParamList,localVars.queryResGetInvoiceAccountingProcessById_outParamCount) = await FuncActionEntryAccountingInvProcess_MIRO.datasetGetInvoiceAccountingProcessById(requestContext,datasetGetInvoiceAccountingProcessById_maxRecords,datasetGetInvoiceAccountingProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionEntryAccountingInvProcess_MIRO.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceId,cancellationToken);

// Query datasetGetOrderAccConceptById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderAccConceptById_maxRecords = 1;
if (datasetGetOrderAccConceptById_maxRecords < 1) datasetGetOrderAccConceptById_maxRecords = 1;
int datasetGetOrderAccConceptById_startIndex = 0;(localVars.queryResGetOrderAccConceptById_outParamList,localVars.queryResGetOrderAccConceptById_outParamCount) = await FuncActionEntryAccountingInvProcess_MIRO.datasetGetOrderAccConceptById(requestContext,datasetGetOrderAccConceptById_maxRecords,datasetGetOrderAccConceptById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssOrderAccConceptsID,cancellationToken);

// GetPaymentTermSpecial
localVars.resGetPaymentTermSpecial.outParamId = await Actions.ActionGetPaymentTermSpecial(requestContext,cancellationToken);

// ConceptPayTermDays = If
localVars.varLcConceptPayTermDays=(((localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssPaymentTermId!=localVars.resGetPaymentTermSpecial.outParamId)) ? (BuiltInFunction.TextToInteger (localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENPaymentTerms.ssCtd_dias)) : (localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssPaymentTermCustomDays));
// Query datasetGetFolioItemsByOrderMainId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioItemsByOrderMainId_maxRecords = 0;
int datasetGetFolioItemsByOrderMainId_startIndex = 0;(localVars.queryResGetFolioItemsByOrderMainId_outParamList,localVars.queryResGetFolioItemsByOrderMainId_outParamCount) = await FuncActionEntryAccountingInvProcess_MIRO.datasetGetFolioItemsByOrderMainId(requestContext,datasetGetFolioItemsByOrderMainId_maxRecords,datasetGetFolioItemsByOrderMainId_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssFolioId,cancellationToken);

// Query datasetGetTaxToAdd
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTaxToAdd_maxRecords = 1;
if (datasetGetTaxToAdd_maxRecords < 1) datasetGetTaxToAdd_maxRecords = 1;
int datasetGetTaxToAdd_startIndex = 0;(localVars.queryResGetTaxToAdd_outParamList,localVars.queryResGetTaxToAdd_outParamCount) = await FuncActionEntryAccountingInvProcess_MIRO.datasetGetTaxToAdd(requestContext,datasetGetTaxToAdd_maxRecords,datasetGetTaxToAdd_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceId,cancellationToken);

// GetOrderK012
(localVars.resGetOrderK012.outParamPaymentTermsDesc,localVars.resGetOrderK012.outParamPaymentTermDays) = await Actions.ActionGetOrderK012(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssId,cancellationToken);

// LogsAccountingCreate6
localVars.resLogsAccountingCreate6.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call_ZMXFFIMF_CONTA_FACTURAS", ssDescription = Convert.ToString(BuiltInFunction.NullIdentifier ()), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("q6_YoL3bg0GiY7Qo3Po32Q"))).ssId },cancellationToken);

// InvoiceGetIVACodeByTax
(localVars.resInvoiceGetIVACodeByTax.outParamTaxIndicatorId,localVars.resInvoiceGetIVACodeByTax.outParamCode) = await Actions.ActionInvoiceGetIVACodeByTax(requestContext,localVars.queryResGetTaxToAdd_outParamList.CurrentRec.ssENInvoiceExtendedTax,(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplier.ssPais=="MX"),localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplier.ssNumber,cancellationToken);

// EntryAccounting_CallInvoiceCount
localVars.resEntryAccounting_CallInvoiceCount.outParamo_Output = await Actions.ActionEntryAccounting_CallInvoiceCount(requestContext,localVars.queryResGetFolioItemsByOrderMainId_outParamList,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssId,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber,localVars.queryResGetInvoiceById_outParamList.CurrentRec,localVars.queryResGetTaxToAdd_outParamList.CurrentRec.ssENInvoiceExtendedTax.ssImporte,localVars.resInvoiceGetIVACodeByTax.outParamCode,localVars.inParamExchangeRate,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENPaymentMethods.ssExternalId,(((localVars.resGetOrderK012.outParamPaymentTermsDesc!="")) ? (localVars.resGetOrderK012.outParamPaymentTermsDesc) : (localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENPaymentTerms.ssEstructuraDescripcionPROP)),(((localVars.resGetOrderK012.outParamPaymentTermsDesc!="")) ? (localVars.resGetOrderK012.outParamPaymentTermDays) : (localVars.varLcConceptPayTermDays)),localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssOffsetUtc,localVars.queryResGetTaxToAdd_outParamList.CurrentRec.ssENInvoiceExtendedTax.ssTasaOCuota,cancellationToken);

// IsSuccess = EntryAccounting_CallInvoiceCount.o_Output.IsSuccess
result.outParamIsSuccess=localVars.resEntryAccounting_CallInvoiceCount.outParamo_Output.ssIsSuccess;

// Message = EntryAccounting_CallInvoiceCount.o_Output.Message
result.outParamMessage=localVars.resEntryAccounting_CallInvoiceCount.outParamo_Output.ssMessage;
} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// IsSuccess = False
result.outParamIsSuccess=false;

// Message = "Error in SAP services. Please contact an administrator."
result.outParamMessage=AppUtils.GetStringResource("K6nTBETsQkWDcGvWTzokxQ#Value.1410737295.1", "Error in SAP services. Please contact an administrator.");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamIsSuccess = result.outParamIsSuccess;
outParamMessage = result.outParamMessage;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamIsSuccess,outParamMessage);
}

public static class FuncActionEntryAccountingInvProcess_MIRO {

private static async Task<RC_bd42fd4399da47c92c88d912cd87df67> datasetGetInvoiceByIdReadDbAsync(RC_bd42fd4399da47c92c88d912cd87df67 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENOrderAccounting.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENPaymentMethods.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" SzFfYHCRWUaHfsEmv_fUng of Action "EntryAccountingInvProcess_MIRO"
public static async Task<(RL_72bc9c8db8dc80bec32b40b958e9af79,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccountingInvProcess_MIRO.GetInvoiceById", "605f314b-9170-4659-877e-c126bff7d49e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccountingInvProcess_MIRO.GetInvoiceById", "605f314b-9170-4659-877e-c126bff7d49e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions._jCDXK9VIEWtI0HDM_2wgA/NodesNotShownInESpaceTree.SzFfYHCRWUaHfsEmv_fUng, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany4\".\"id\" o0, \"encompany4\".\"externalid\" o1, \"encompany4\".\"description\" o2, \"encompany4\".\"rfc\" o3, \"encompany4\".\"postalcode\" o4, \"encompany4\".\"cyaimport\" o5, \"encompany4\".\"fspuse\" o6, \"encompany4\".\"createdon\" o7, \"encompany4\".\"createdby\" o8, \"encompany4\".\"updatedon\" o9, \"encompany4\".\"updatedby\" o10, \"eninvoice20\".\"id\" o11, \"eninvoice20\".\"name\" o12, \"eninvoice20\".\"requisitionid\" o13, \"eninvoice20\".\"folioid\" o14, \"eninvoice20\".\"ordermainid\" o15, \"eninvoice20\".\"cfditypeid\" o16, trim_scale(\"eninvoice20\".\"totalamount\"::numeric) o17, \"eninvoice20\".\"currency\" o18, \"eninvoice20\".\"invoicestatusid\" o19, \"eninvoice20\".\"accountingdatetime\" o20, \"eninvoice20\".\"paymentdatetime\" o21, \"eninvoice20\".\"createdon\" o22, \"eninvoice20\".\"createdby\" o23, \"eninvoice20\".\"updatedon\" o24, \"eninvoice20\".\"updatedby\" o25, \"eninvoice20\".\"submittedon\" o26, \"eninvoice20\".\"isnewversion\" o27, \"eninvoice20\".\"id_poliza\" o28, \"eninvoice20\".\"id_poliza_sap\" o29, \"eninvoice20\".\"doc51\" o30, \"eninvoice20\".\"accountingerror\" o31, \"eninvoice20\".\"orderaccconceptsid\" o32, trim_scale(\"eninvoice20\".\"amortization\"::numeric) o33, \"eninvoice20\".\"creditnoteinvoiceid\" o34, \"eninvoiceextended7\".\"id\" o35, \"eninvoiceextended7\".\"version\" o36, \"eninvoiceextended7\".\"folio\" o37, \"eninvoiceextended7\".\"serie\" o38, \"eninvoiceextended7\".\"fechaemision\" o39, \"eninvoiceextended7\".\"formapago\" o40, \"eninvoiceextended7\".\"metodopago\" o41, \"eninvoiceextended7\".\"lugarexpedicion\" o42, trim_scale(\"eninvoiceextended7\".\"subtotal\"::numeric) o43, trim_scale(\"eninvoiceextended7\".\"descuento\"::numeric) o44, trim_scale(\"eninvoiceextended7\".\"totaliva\"::numeric) o45, trim_scale(\"eninvoiceextended7\".\"retenciones\"::numeric) o46, trim_scale(\"eninvoiceextended7\".\"total\"::numeric) o47, \"eninvoiceextended7\".\"tipocomprobante\" o48, \"eninvoiceextended7\".\"moneda\" o49, trim_scale(\"eninvoiceextended7\".\"tipocambio\"::numeric) o50, \"eninvoiceextended7\".\"usocfdi\" o51, \"eninvoiceextended7\".\"exportacion\" o52, \"eninvoiceextended7\".\"uuid\" o53, \"enorderaccounting1\".\"id\" o54, \"enorderaccounting1\".\"orderid\" o55, \"enorderaccounting1\".\"hasestim_equal_agrepaym_depr\" o56, \"enorderaccounting1\".\"hassettlement_depr\" o57, \"enorderaccounting1\".\"hascreditnote_depr\" o58, \"enorderaccounting1\".\"hasvoucher_depr\" o59, \"enorderaccounting1\".\"hasspecialpostdeliveryauth\" o60, \"enorderaccounting1\".\"specialpostdeliveryauthid\" o61, trim_scale(\"enorderaccounting1\".\"amount_deprec\"::numeric) o62, \"enorderaccounting1\".\"currencyid_deprec\" o63, \"enorderaccounting1\".\"paymentmethodid_deprec\" o64, \"enorderaccounting1\".\"paymenttermid_deprec\" o65, trim_scale(\"enorderaccounting1\".\"negociatedexchangerateacc\"::numeric) o66, \"enorderaccounting1\".\"exchangeratecomment\" o67, \"enorderaccounting1\".\"evidencefileid\" o68, \"enorderaccounting1\".\"hascontract\" o69, \"enorderaccounting1\".\"hasrepse\" o70, \"enorderaccounting1\".\"haspaymentsupplement\" o71, \"enorderaccounting1\".\"hasnoticeofpaymentsuspension\" o72, \"enorderdetail3\".\"orderid\" o73, \"enorderdetail3\".\"isapprovalfromuserarea\" o74, \"enorderdetail3\".\"projectassetserviceid\" o75, \"enorderdetail3\".\"projectassetservice\" o76, \"enorderdetail3\".\"projectdescription\" o77, \"enorderdetail3\".\"businessvaluecategoryid\" o78, \"enorderdetail3\".\"businessvaluesubcategoryid\" o79, \"enorderdetail3\".\"paymenttermsid\" o80, \"enorderdetail3\".\"paymentmethodid\" o81, trim_scale(\"enorderdetail3\".\"negotiatedexchangerate\"::numeric) o82, \"enorderdetail3\".\"contractstatus\" o83, \"enorderdetail3\".\"dateofcommitment\" o84, \"enorderdetail3\".\"hasdeposit\" o85, \"enorderdetail3\".\"hasinsurance\" o86, \"enorderdetail3\".\"distributionid\" o87, \"enorderdetail3\".\"hasadvancepayment\" o88, trim_scale(\"enorderdetail3\".\"retentionrate\"::numeric) o89, \"enorderdetail3\".\"hasbasedate\" o90, \"enorderdetail3\".\"startbasedate\" o91, \"enorderdetail3\".\"endbasedate\" o92, \"enorderdetail3\".\"contractnumber\" o93, \"enorderdetail3\".\"isretentionapplied\" o94, \"enorderdetail3\".\"frequency\" o95, \"enorderdetail3\".\"period\" o96, \"enorderdetail3\".\"orderretentiontypeid\" o97, \"enorderdetail3\".\"paymentoptionsid\" o98, \"enorderdetail3\".\"paymentwaysid\" o99, \"enorderdetail3\".\"orderscontract\" o100, trim_scale(\"enorderdetail3\".\"contractamount\"::numeric) o101, trim_scale(\"enorderdetail3\".\"contracttarif\"::numeric) o102, \"enorderdetail3\".\"contractsupplier\" o103, \"enorderdetail3\".\"isdependentfromfolios\" o104, \"enorderdetail3\".\"specialapprovalid\" o105, \"enorderdetail3\".\"createdby\" o106, \"enorderdetail3\".\"createdon\" o107, \"enorderdetail3\".\"updatedby\" o108, \"enorderdetail3\".\"updatedon\" o109, \"enorderdetail3\".\"allcontactfilesvalidated\" o110, \"enorderdetail3\".\"hasntrequestdocuments\" o111, \"enordermain27\".\"id\" o112, \"enordermain27\".\"ordernumber\" o113, \"enordermain27\".\"orderdate\" o114, \"enordermain27\".\"orderstatusid\" o115, \"enordermain27\".\"previousorderstatusid\" o116, \"enordermain27\".\"assignmentcode\" o117, \"enordermain27\".\"supplierid\" o118, \"enordermain27\".\"companyid\" o119, \"enordermain27\".\"documenttypeid\" o120, \"enordermain27\".\"currencyid\" o121, \"enordermain27\".\"telceldirectionid\" o122, \"enordermain27\".\"procurementgroup\" o123, \"enordermain27\".\"creatorsapnumber\" o124, \"enordermain27\".\"creatorsapname\" o125, \"enordermain27\".\"country\" o126, \"enordermain27\".\"isdeleted\" o127, \"enordermain27\".\"isreleased\" o128, trim_scale(\"enordermain27\".\"exchangerate\"::numeric) o129, \"enordermain27\".\"sustainabilitycategory\" o130, \"enordermain27\".\"sustainabilitysubcategory\" o131, trim_scale(\"enordermain27\".\"totalamount\"::numeric) o132, \"enordermain27\".\"fromcosmoz\" o133, \"enordermain27\".\"regionid\" o134, \"enordermain27\".\"divisionid\" o135, \"enordermain27\".\"applicant\" o136, \"enordermain27\".\"createdby\" o137, \"enordermain27\".\"createdon\" o138, \"enordermain27\".\"updatedby\" o139, \"enordermain27\".\"updatedon\" o140, \"enpaymentmethods3\".\"id\" o141, \"enpaymentmethods3\".\"description\" o142, \"enpaymentmethods3\".\"externalid\" o143, \"enpaymentmethods3\".\"isfcp\" o144, \"enpaymentmethods3\".\"createdon\" o145, \"enpaymentmethods3\".\"createdby\" o146, \"enpaymentmethods3\".\"updatedon\" o147, \"enpaymentmethods3\".\"updatedby\" o148, \"enpaymentmethods3\".\"isactive\" o149, \"enproject_asset_service3\".\"id\" o150, \"enproject_asset_service3\".\"description\" o151, \"enproject_asset_service3\".\"isothers\" o152, \"enproject_asset_service3\".\"createdon\" o153, \"enproject_asset_service3\".\"createdby\" o154, \"enproject_asset_service3\".\"updatedon\" o155, \"enproject_asset_service3\".\"updatedby\" o156, \"enregion20\".\"id\" o157, \"enregion20\".\"code\" o158, \"enregion20\".\"name\" o159, \"enregion20\".\"divisionfi\" o160, \"enregion20\".\"centrortp\" o161, \"enregion20\".\"commissionregion\" o162, \"enregion20\".\"isactive\" o163, \"enregion20\".\"createdon\" o164, \"enregion20\".\"createdby\" o165, \"enregion20\".\"updatedon\" o166, \"enregion20\".\"updatedby\" o167, \"enregion20\".\"isfsp\" o168, \"enregion20\".\"isfcp\" o169, \"ensupplier17\".\"id\" o170, \"ensupplier17\".\"tratamiento\" o171, \"ensupplier17\".\"name\" o172, \"ensupplier17\".\"number\" o173, \"ensupplier17\".\"conceptobusq_1_2\" o174, \"ensupplier17\".\"calle_numero\" o175, \"ensupplier17\".\"distrito\" o176, \"ensupplier17\".\"codigopostal_pobl_\" o177, \"ensupplier17\".\"pais\" o178, \"ensupplier17\".\"region_\" o179, \"ensupplier17\".\"idioma\" o180, \"ensupplier17\".\"telefono\" o181, \"ensupplier17\".\"extension\" o182, \"ensupplier17\".\"fax\" o183, \"ensupplier17\".\"cliente\" o184, \"ensupplier17\".\"soc_glasociada\" o185, \"ensupplier17\".\"clavedegrupo\" o186, \"ensupplier17\".\"n_ident_fis_1\" o187, \"ensupplier17\".\"personafisica\" o188, \"ensupplier17\".\"ramo\" o189, \"ensupplier17\".\"grupodeporte\" o190, \"ensupplier17\".\"email\" o191, \"ensupplier17\".\"isactive\" o192, \"ensupplier17\".\"createdon\" o193, \"ensupplier17\".\"createdby\" o194, \"ensupplier17\".\"updatedon\" o195, \"ensupplier17\".\"updatedby\" o196, \"ensupplier17\".\"regionid\" o197");
fromBuilder.Append(" FROM ((((((((({Invoice} \"eninvoice20\" Left JOIN {InvoiceExtended} \"eninvoiceextended7\" ON (\"eninvoice20\".\"id\" = \"eninvoiceextended7\".\"id\"))  Left JOIN {OrderMain} \"enordermain27\" ON (\"eninvoice20\".\"ordermainid\" = \"enordermain27\".\"id\"))  Left JOIN {Company} \"encompany4\" ON (\"enordermain27\".\"companyid\" = \"encompany4\".\"id\"))  Left JOIN {Supplier} \"ensupplier17\" ON (\"enordermain27\".\"supplierid\" = \"ensupplier17\".\"id\"))  Left JOIN {Region} \"enregion20\" ON (\"enordermain27\".\"regionid\" = \"enregion20\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail3\" ON (\"enordermain27\".\"id\" = \"enorderdetail3\".\"orderid\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service3\" ON (\"enorderdetail3\".\"projectassetserviceid\" = \"enproject_asset_service3\".\"id\"))  Left JOIN {OrderAccounting} \"enorderaccounting1\" ON (\"enordermain27\".\"id\" = \"enorderaccounting1\".\"orderid\"))  Left JOIN {PaymentMethods} \"enpaymentmethods3\" ON (\"enorderdetail3\".\"paymentmethodid\" = \"enpaymentmethods3\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice20\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice20\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice20\".\"id\" IS NULL)");
}
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
RL_72bc9c8db8dc80bec32b40b958e9af79 outParamList = new RL_72bc9c8db8dc80bec32b40b958e9af79();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[10];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false});
opt[6] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[7] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[8] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
opt[9] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccountingInvProcess_MIRO.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_72bc9c8db8dc80bec32b40b958e9af79 _tmp = new RL_72bc9c8db8dc80bec32b40b958e9af79();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccountingInvProcess_MIRO.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_72bc9c8db8dc80bec32b40b958e9af79)_tmp;
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

// Query Function "GetTaxToAdd" AuINgo5+nkmi6O5WfWLy8A of Action "EntryAccountingInvProcess_MIRO"
public static async Task<(RL_9404dc36b913809894c7e4e44e8e1dd8,long)> datasetGetTaxToAdd(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccountingInvProcess_MIRO.GetTaxToAdd", "820de202-7e8e-499e-a2e8-ee567d62f2f0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccountingInvProcess_MIRO.GetTaxToAdd", "820de202-7e8e-499e-a2e8-ee567d62f2f0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions._jCDXK9VIEWtI0HDM_2wgA/NodesNotShownInESpaceTree.AuINgo5+nkmi6O5WfWLy8A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendedtax5\".\"id\" o0, \"eninvoiceextendedtax5\".\"invoiceid\" o1, \"eninvoiceextendedtax5\".\"invoicetaxtypeid\" o2, \"eninvoiceextendedtax5\".\"impuesto\" o3, trim_scale(\"eninvoiceextendedtax5\".\"base\"::numeric) o4, trim_scale(\"eninvoiceextendedtax5\".\"tasaocuota\"::numeric) o5, trim_scale(\"eninvoiceextendedtax5\".\"importe\"::numeric) o6, \"eninvoiceextendedtax5\".\"tipofactor\" o7");
fromBuilder.Append(" FROM {InvoiceExtendedTax} \"eninvoiceextendedtax5\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedtax5\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedtax5\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedtax5\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextendedtax5\".\"impuesto\" = '002') AND (\"eninvoiceextendedtax5\".\"invoicetaxtypeid\" = ");
whereBuilder.Append((ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("jP_W+pSpRESLV3Fw0NPgPQ"))).ssId);
whereBuilder.Append(") AND (\"eninvoiceextendedtax5\".\"tipofactor\" = 'Tasa')");
orderByBuilder.Append(" ORDER BY \"eninvoiceextendedtax5\".\"importe\" DESC ");
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
RL_9404dc36b913809894c7e4e44e8e1dd8 outParamList = new RL_9404dc36b913809894c7e4e44e8e1dd8();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccountingInvProcess_MIRO.GetTaxToAdd.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9404dc36b913809894c7e4e44e8e1dd8 _tmp = new RL_9404dc36b913809894c7e4e44e8e1dd8();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccountingInvProcess_MIRO.GetTaxToAdd.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9404dc36b913809894c7e4e44e8e1dd8)_tmp;
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

private static async Task<RC_a10c541c5bb512cec4a0951b15921126> datasetGetOrderAccConceptByIdReadDbAsync(RC_a10c541c5bb512cec4a0951b15921126 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderAccConcepts.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
return rec;
}
// Query Function "GetOrderAccConceptById" Yez4lOCbIkO_rcImtG8EUQ of Action "EntryAccountingInvProcess_MIRO"
public static async Task<(RL_cc70186cbf781c90043dce30d28664ab,long)> datasetGetOrderAccConceptById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConcepts_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccountingInvProcess_MIRO.GetOrderAccConceptById", "94f8ec61-9be0-4322-bfad-c226b46f0451");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccountingInvProcess_MIRO.GetOrderAccConceptById", "94f8ec61-9be0-4322-bfad-c226b46f0451", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions._jCDXK9VIEWtI0HDM_2wgA/NodesNotShownInESpaceTree.Yez4lOCbIkO_rcImtG8EUQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enorderaccconcepts2\".\"paymenttermid\" o8, \"enorderaccconcepts2\".\"paymenttermcustomdays\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enpaymentterms5\".\"ctd_dias\" o18, \"enpaymentterms5\".\"estructuradescripcionprop\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM ({OrderAccConcepts} \"enorderaccconcepts2\" Left JOIN {PaymentTerms} \"enpaymentterms5\" ON (\"enorderaccconcepts2\".\"paymenttermid\" = \"enpaymentterms5\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderAccConcepts_Id != 0) {
whereBuilder.Append("((\"enorderaccconcepts2\".\"id\" = @qporOrderAccConcepts_Id) AND (\"enorderaccconcepts2\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConcepts_Id", DbType.Int64, qporOrderAccConcepts_Id);
} else {
whereBuilder.Append("(\"enorderaccconcepts2\".\"id\" IS NULL)");
}
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
RL_cc70186cbf781c90043dce30d28664ab outParamList = new RL_cc70186cbf781c90043dce30d28664ab();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderAccConceptByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, false, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccountingInvProcess_MIRO.GetOrderAccConceptById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_cc70186cbf781c90043dce30d28664ab _tmp = new RL_cc70186cbf781c90043dce30d28664ab();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderAccConceptByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccountingInvProcess_MIRO.GetOrderAccConceptById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_cc70186cbf781c90043dce30d28664ab)_tmp;
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

// Query Function "GetInvoiceAccountingProcessById" 7t4Wquoc5UCcKGLGzgdEbQ of Action "EntryAccountingInvProcess_MIRO"
public static async Task<(RL_4e909af3a15d1687c03c789af38db7ae,long)> datasetGetInvoiceAccountingProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccountingInvProcess_MIRO.GetInvoiceAccountingProcessById", "aa16deee-1cea-40e5-9c28-62c6ce07446d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccountingInvProcess_MIRO.GetInvoiceAccountingProcessById", "aa16deee-1cea-40e5-9c28-62c6ce07446d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions._jCDXK9VIEWtI0HDM_2wgA/NodesNotShownInESpaceTree.7t4Wquoc5UCcKGLGzgdEbQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoiceaccountingprocess1\".\"invoiceid\" o1, NULL o2, \"eninvoiceaccountingprocess1\".\"offsetutc\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {InvoiceAccountingProcess} \"eninvoiceaccountingprocess1\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess1\".\"id\" = @qpinId) AND (\"eninvoiceaccountingprocess1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess1\".\"id\" IS NULL)");
}
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
RL_4e909af3a15d1687c03c789af38db7ae outParamList = new RL_4e909af3a15d1687c03c789af38db7ae();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccountingInvProcess_MIRO.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4e909af3a15d1687c03c789af38db7ae _tmp = new RL_4e909af3a15d1687c03c789af38db7ae();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccountingInvProcess_MIRO.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4e909af3a15d1687c03c789af38db7ae)_tmp;
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

private static async Task<RC_82af454f3893e60efc22cc7344fd4176> datasetGetFolioItemsByOrderMainIdReadDbAsync(RC_82af454f3893e60efc22cc7344fd4176 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioItems.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
return rec;
}
// Query Function "GetFolioItemsByOrderMainId" 88OK0C5ymESyqAQFomqdQQ of Action "EntryAccountingInvProcess_MIRO"
public static async Task<(RL_af9a0ce202ec088a3c6de60c469b7bc6,long)> datasetGetFolioItemsByOrderMainId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioItems_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccountingInvProcess_MIRO.GetFolioItemsByOrderMainId", "d08ac3f3-722e-4498-b2a8-0405a26a9d41");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccountingInvProcess_MIRO.GetFolioItemsByOrderMainId", "d08ac3f3-722e-4498-b2a8-0405a26a9d41", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions._jCDXK9VIEWtI0HDM_2wgA/NodesNotShownInESpaceTree.88OK0C5ymESyqAQFomqdQQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolioitems3\".\"id\" o0, \"enfolioitems3\".\"folioid\" o1, \"enfolioitems3\".\"ordermainitemid\" o2, \"enfolioitems3\".\"ordernumber\" o3, \"enfolioitems3\".\"articlenumber\" o4, \"enfolioitems3\".\"description\" o5, \"enfolioitems3\".\"inputationcode\" o6, \"enfolioitems3\".\"deliverydate\" o7, trim_scale(\"enfolioitems3\".\"invoiceqtt\"::numeric) o8, trim_scale(\"enfolioitems3\".\"remainingqtt\"::numeric) o9, trim_scale(\"enfolioitems3\".\"unitprice\"::numeric) o10, trim_scale(\"enfolioitems3\".\"totalprice\"::numeric) o11, trim_scale(\"enfolioitems3\".\"quantity\"::numeric) o12, \"enfolioitems3\".\"deliveryqtt\" o13, \"enfolioitems3\".\"importdelivery\" o14, \"enfolioitems3\".\"pep\" o15, \"enfolioitems3\".\"placeid\" o16, \"enfolioitems3\".\"placename\" o17, \"enordermainitem5\".\"id\" o18, \"enordermainitem5\".\"ordermainid\" o19, \"enordermainitem5\".\"position\" o20, \"enordermainitem5\".\"materialcode\" o21, \"enordermainitem5\".\"materialdescription\" o22, \"enordermainitem5\".\"assigmnentcode\" o23, \"enordermainitem5\".\"documentclassid\" o24, \"enordermainitem5\".\"deliverydate\" o25, trim_scale(\"enordermainitem5\".\"quantity\"::numeric) o26, \"enordermainitem5\".\"unittype\" o27, trim_scale(\"enordermainitem5\".\"unitprice\"::numeric) o28, \"enordermainitem5\".\"basequantity\" o29, \"enordermainitem5\".\"isdeleted\" o30, \"enordermainitem5\".\"isblocked\" o31, \"enordermainitem5\".\"isfinaldelivery\" o32, \"enordermainitem5\".\"glaccountid\" o33, \"enordermainitem5\".\"costcenterid\" o34, \"enordermainitem5\".\"fundscenter\" o35, \"enordermainitem5\".\"fund\" o36, \"enordermainitem5\".\"commitmentitem\" o37, \"enordermainitem5\".\"vatindicator\" o38, \"enordermainitem5\".\"vatprocedure\" o39, trim_scale(\"enordermainitem5\".\"vatrate\"::numeric) o40, \"enordermainitem5\".\"purchaserequisitionnumber\" o41, \"enordermainitem5\".\"purchaserequisitionitemnr\" o42, \"enordermainitem5\".\"regionid\" o43, \"enordermainitem5\".\"center\" o44, \"enordermainitem5\".\"pepelement\" o45, trim_scale(\"enordermainitem5\".\"quantitydelivered\"::numeric) o46, \"enordermainitem5\".\"orderunitofmeasure\" o47, \"enordermainitem5\".\"applicant\" o48, \"enordermainitem5\".\"direction\" o49, \"enordermainitem5\".\"contractnumber\" o50, \"enordermainitem5\".\"contractposition\" o51, \"enordermainitem5\".\"contractstartdate\" o52, \"enordermainitem5\".\"contractenddate\" o53, trim_scale(\"enordermainitem5\".\"contractplannedvalue\"::numeric) o54, \"enordermainitem5\".\"positiontype\" o55, \"enordermainitem5\".\"serialnumberprofile\" o56, \"enordermainitem5\".\"batchmanaged\" o57, \"enordermainitem5\".\"materialtype\" o58, \"enordermainitem5\".\"itemgroup\" o59, \"enordermainitem5\".\"orderrequestcreatorsapnumber\" o60, \"enordermainitem5\".\"ismultipleimputation\" o61, \"enordermainitem5\".\"invoiceusageid\" o62, \"enordermainitem5\".\"ordermainitemstatusid\" o63, \"enordermainitem5\".\"divisionid\" o64, \"enordermainitem5\".\"createdby\" o65, \"enordermainitem5\".\"createdon\" o66, \"enordermainitem5\".\"updatedby\" o67, \"enordermainitem5\".\"updatedon\" o68, \"enregion21\".\"id\" o69, \"enregion21\".\"code\" o70, \"enregion21\".\"name\" o71, \"enregion21\".\"divisionfi\" o72, \"enregion21\".\"centrortp\" o73, \"enregion21\".\"commissionregion\" o74, \"enregion21\".\"isactive\" o75, \"enregion21\".\"createdon\" o76, \"enregion21\".\"createdby\" o77, \"enregion21\".\"updatedon\" o78, \"enregion21\".\"updatedby\" o79, \"enregion21\".\"isfsp\" o80, \"enregion21\".\"isfcp\" o81");
fromBuilder.Append(" FROM (({FolioItems} \"enfolioitems3\" Left JOIN {OrderMainItem} \"enordermainitem5\" ON (\"enfolioitems3\".\"ordermainitemid\" = \"enordermainitem5\".\"id\"))  Left JOIN {Region} \"enregion21\" ON (\"enordermainitem5\".\"divisionid\" = \"enregion21\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioItems_FolioId != 0) {
whereBuilder.Append("((\"enfolioitems3\".\"folioid\" = @qpfoFolioItems_FolioId) AND (\"enfolioitems3\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioItems_FolioId", DbType.Int64, qpfoFolioItems_FolioId);
} else {
whereBuilder.Append("(\"enfolioitems3\".\"folioid\" IS NULL)");
}
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
RL_af9a0ce202ec088a3c6de60c469b7bc6 outParamList = new RL_af9a0ce202ec088a3c6de60c469b7bc6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioItemsByOrderMainIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccountingInvProcess_MIRO.GetFolioItemsByOrderMainId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_af9a0ce202ec088a3c6de60c469b7bc6 _tmp = new RL_af9a0ce202ec088a3c6de60c469b7bc6();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioItemsByOrderMainIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccountingInvProcess_MIRO.GetFolioItemsByOrderMainId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_af9a0ce202ec088a3c6de60c469b7bc6)_tmp;
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



}


}
