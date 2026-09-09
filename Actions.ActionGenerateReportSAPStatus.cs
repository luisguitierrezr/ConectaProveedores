namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateReportSAPStatus : VarsBag {
public int inParami_OffsetUtc;
public long inParami_SupplierId;
public string inParami_InvoiceName;
public string inParami_FolioNumber;
public int inParami_InvoiceStatusId;
public string inParami_OrderMainNumber;
public string inParami_AssignedTo;
public string inParami_Project;
public string inParami_Period;
public int inParami_FrequencyId;
public string inParami_BusinessValueCategory;
public string inParami_BusinessValueSubCateg;
public DateTime inParami_PaidOn;
public decimal inParami_AmountFrom;
public decimal inParami_AmountTo;
public string inParami_CurrencyId;
public DateTime inParami_InvoiceCreatedOn;
public DateTime inParami_FolioCreatedOn;
public int inParami_SpecialApprovalId;
public int inParami_CFDITypeId;
public bool inParami_IsSelectAll;
public string inParami_SelectedIds;
/// <summary>
/// Variable <code>LinesReportSAPStatusList</code> that represents the Service Studio
///  ReportSAPStatus_ItemList <code>LinesReportSAPStatusList</code> <p>Description: </p>
/// </summary>
public RL_c94b937e248ffb05391a1f227e9d9277 varLcLinesReportSAPStatusList = new RL_c94b937e248ffb05391a1f227e9d9277();

public byte[] resRecordListToExcel1_outParamOut = new byte[] {};
public RL_d73c3b3bac950b4c134511806f4793ea queryResGetInvoicesSAP_outParamList = new RL_d73c3b3bac950b4c134511806f4793ea();
public long queryResGetInvoicesSAP_outParamCount = 0L;

public lcvGenerateReportSAPStatus(int inParami_OffsetUtc, long inParami_SupplierId, string inParami_InvoiceName, string inParami_FolioNumber, int inParami_InvoiceStatusId, string inParami_OrderMainNumber, string inParami_AssignedTo, string inParami_Project, string inParami_Period, int inParami_FrequencyId, string inParami_BusinessValueCategory, string inParami_BusinessValueSubCateg, DateTime inParami_PaidOn, decimal inParami_AmountFrom, decimal inParami_AmountTo, string inParami_CurrencyId, DateTime inParami_InvoiceCreatedOn, DateTime inParami_FolioCreatedOn, int inParami_SpecialApprovalId, int inParami_CFDITypeId, bool inParami_IsSelectAll, string inParami_SelectedIds) {
this.inParami_OffsetUtc = inParami_OffsetUtc;
this.inParami_SupplierId = inParami_SupplierId;
this.inParami_InvoiceName = inParami_InvoiceName;
this.inParami_FolioNumber = inParami_FolioNumber;
this.inParami_InvoiceStatusId = inParami_InvoiceStatusId;
this.inParami_OrderMainNumber = inParami_OrderMainNumber;
this.inParami_AssignedTo = inParami_AssignedTo;
this.inParami_Project = inParami_Project;
this.inParami_Period = inParami_Period;
this.inParami_FrequencyId = inParami_FrequencyId;
this.inParami_BusinessValueCategory = inParami_BusinessValueCategory;
this.inParami_BusinessValueSubCateg = inParami_BusinessValueSubCateg;
this.inParami_PaidOn = inParami_PaidOn;
this.inParami_AmountFrom = inParami_AmountFrom;
this.inParami_AmountTo = inParami_AmountTo;
this.inParami_CurrencyId = inParami_CurrencyId;
this.inParami_InvoiceCreatedOn = inParami_InvoiceCreatedOn;
this.inParami_FolioCreatedOn = inParami_FolioCreatedOn;
this.inParami_SpecialApprovalId = inParami_SpecialApprovalId;
this.inParami_CFDITypeId = inParami_CFDITypeId;
this.inParami_IsSelectAll = inParami_IsSelectAll;
this.inParami_SelectedIds = inParami_SelectedIds;
}
}
public class lcoGenerateReportSAPStatus : VarsBag {
public ST_a158c76eb93396680623c04244f48b6cStructure outParamFile = new ST_a158c76eb93396680623c04244f48b6cStructure();

public lcoGenerateReportSAPStatus() {
}
}
/// <summary>
/// Action <code>GenerateReportSAPStatus</code> that represents the Service Studio action
///  <code>GenerateReportSAPStatus</code> <p> Description: GenerateLinesReportSAPStatus</p>
/// </summary>
public static async Task<ST_a158c76eb93396680623c04244f48b6cStructure> ActionGenerateReportSAPStatus(IRequestContext requestContext,int inParami_OffsetUtc,long inParami_SupplierId,string inParami_InvoiceName,string inParami_FolioNumber,int inParami_InvoiceStatusId,string inParami_OrderMainNumber,string inParami_AssignedTo,string inParami_Project,string inParami_Period,int inParami_FrequencyId,string inParami_BusinessValueCategory,string inParami_BusinessValueSubCateg,DateTime inParami_PaidOn,decimal inParami_AmountFrom,decimal inParami_AmountTo,string inParami_CurrencyId,DateTime inParami_InvoiceCreatedOn,DateTime inParami_FolioCreatedOn,int inParami_SpecialApprovalId,int inParami_CFDITypeId,bool inParami_IsSelectAll,string inParami_SelectedIds,CancellationToken cancellationToken) {
ST_a158c76eb93396680623c04244f48b6cStructure outParamFile = default;
lcoGenerateReportSAPStatus result = new lcoGenerateReportSAPStatus();
lcvGenerateReportSAPStatus localVars = new lcvGenerateReportSAPStatus(inParami_OffsetUtc, inParami_SupplierId, inParami_InvoiceName, inParami_FolioNumber, inParami_InvoiceStatusId, inParami_OrderMainNumber, inParami_AssignedTo, inParami_Project, inParami_Period, inParami_FrequencyId, inParami_BusinessValueCategory, inParami_BusinessValueSubCateg, inParami_PaidOn, inParami_AmountFrom, inParami_AmountTo, inParami_CurrencyId, inParami_InvoiceCreatedOn, inParami_FolioCreatedOn, inParami_SpecialApprovalId, inParami_CFDITypeId, inParami_IsSelectAll, inParami_SelectedIds);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateReportSAPStatus", "6b29dd22-03dc-4883-a364-0fcabd8a74e4"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateReportSAPStatus", "6b29dd22-03dc-4883-a364-0fcabd8a74e4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoicesSAP
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesSAP_maxRecords = 999999999;
if (datasetGetInvoicesSAP_maxRecords < 1) datasetGetInvoicesSAP_maxRecords = 1;
int datasetGetInvoicesSAP_startIndex = 0;(localVars.queryResGetInvoicesSAP_outParamList,localVars.queryResGetInvoicesSAP_outParamCount) = await FuncActionGenerateReportSAPStatus.datasetGetInvoicesSAP(requestContext,datasetGetInvoicesSAP_maxRecords,datasetGetInvoicesSAP_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionGetIsCorporativo(requestContext,cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),localVars.inParami_AmountFrom,localVars.inParami_AmountTo,localVars.inParami_AssignedTo,localVars.inParami_BusinessValueCategory,localVars.inParami_BusinessValueSubCateg,localVars.inParami_CFDITypeId,localVars.inParami_CurrencyId,localVars.inParami_FolioCreatedOn,localVars.inParami_FolioNumber,localVars.inParami_FrequencyId,localVars.inParami_InvoiceCreatedOn,localVars.inParami_InvoiceName,localVars.inParami_InvoiceStatusId,localVars.inParami_IsSelectAll,localVars.inParami_OffsetUtc,localVars.inParami_OrderMainNumber,localVars.inParami_PaidOn,localVars.inParami_Period,localVars.inParami_Project,localVars.inParami_SelectedIds,localVars.inParami_SpecialApprovalId,localVars.inParami_SupplierId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcLinesReportSAPStatusList,(await RL_c94b937e248ffb05391a1f227e9d9277.ConvertAsync(localVars.queryResGetInvoicesSAP_outParamList, new RL_c94b937e248ffb05391a1f227e9d9277(), async (RC_2f34e41fc62b4f171d5257cbac94e819 source, ST_fc6debbee6469de53c667334dded1d22Structure target, CancellationToken cancellationToken) => {
target.ssSupplierName = source.ssENSupplier.ssName;
target.ssSupplierNumber = source.ssENSupplier.ssNumber;
target.ssInvoiceName = source.ssENInvoiceExtended.ssFolio;
target.ssFolioNumber = source.ssENFolio.ssFolioNumber;
target.ssInvoiceStatus = source.ssENInvoiceStatus.ssLabel;
target.ssOrderNumber = source.ssENOrderMain.ssOrderNumber;
target.ssAssignedTo = source.ssENInvoiceApprovalLevel.ssAssignedTo;
target.ssAssetServiceDescription = source.ssENProject_Asset_Service.ssDescription;
target.ssIssueDate = BuiltInFunction.FormatDateTime (BuiltInFunction.AddHours (source.ssENFolio.ssCreatedOn, localVars.inParami_OffsetUtc), "dd/MM/yyyy");
target.ssFrequency = source.ssENFrequency.ssLabel;
target.ssBusinessValueCategory = source.ssENBusinessValueCategory.ssDescription;
target.ssBusinessValueSubCategory = source.ssENBusinessValueSubcategory.ssDescription;
target.ssPaidOn = (((source.ssENInvoiceStatus.ssId==(ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("h+R+u64a50K6vJ2dkkiVXQ"))).ssId)) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.AddDays (BuiltInFunction.AddDays (BuiltInFunction.AddHours (source.ssENInvoice.ssCreatedOn, localVars.inParami_OffsetUtc), ((source.ssENPaymentTerms.ssIsSpecial) ? (source.ssENOrderAccConcepts.ssPaymentTermCustomDays) : (BuiltInFunction.TextToInteger (source.ssENPaymentTerms.ssCtd_dias)))), (await Functions.ActionGetNextMonday(requestContext,BuiltInFunction.TextToDateTime (BuiltInFunction.DateTimeToText(BuiltInFunction.AddDays (BuiltInFunction.AddHours (source.ssENInvoice.ssCreatedOn, localVars.inParami_OffsetUtc), ((source.ssENPaymentTerms.ssIsSpecial) ? (source.ssENOrderAccConcepts.ssPaymentTermCustomDays) : (BuiltInFunction.TextToInteger (source.ssENPaymentTerms.ssCtd_dias)))))),cancellationToken))), "dd/MM/yyyy")) : (""));
target.ssTotalAmount = source.ssENInvoice.ssTotalAmount;
target.ssInvoiceDate = BuiltInFunction.FormatDateTime (BuiltInFunction.AddHours (BuiltInFunction.TextToDateTime (source.ssENInvoiceExtended.ssFechaEmision), localVars.inParami_OffsetUtc), "dd/MM/yyyy");
target.ssCurrency = source.ssENInvoice.ssCurrency;
target.ssInvoiceCreatedOn = BuiltInFunction.FormatDateTime (BuiltInFunction.AddHours (source.ssENInvoice.ssCreatedOn, localVars.inParami_OffsetUtc), "dd/MM/yyyy");
target.ssSpecialApproval = localVars.queryResGetInvoicesSAP_outParamList.CurrentRec.ssENSpecialApproval.ssLabel;
target.ssTags = AppUtils.GetStringResource("IyjTHGjLuEmfp0Qrt7PhHQ.#SourceValue#Value.-1571065650.1", "Invoices with order");
target.ssTypeCFDI = localVars.queryResGetInvoicesSAP_outParamList.CurrentRec.ssENAccountingDataType.ssLabel;
return target;
}, cancellationToken)),cancellationToken);

// RecordListToExcel RLToExcelGenerateReportSAPStatusRecordListToExcel1
localVars.resRecordListToExcel1_outParamOut = await FuncActionGenerateReportSAPStatus.RLToExcelGenerateReportSAPStatusRecordListToExcel1(requestContext,localVars.varLcLinesReportSAPStatusList,cancellationToken);

// File.BinaryData = RecordListToExcel1
result.outParamFile.ssBinaryData = localVars.resRecordListToExcel1_outParamOut;

// File.Name = "FoliosContabilization" + FormatDateTime + ".xlsx"
result.outParamFile.ssName = ((AppUtils.GetStringResource("fT0ApOkadEa9KxV2XdiQqg#Value.424097412.1", "FoliosContabilization")+BuiltInFunction.FormatDateTime (BuiltInFunction.CurrDate (), "ddMMyyyy"))+".xlsx");
} //close CreateActionActivity using block
} // try

finally {
outParamFile = result.outParamFile;
} // inner-finally
RETURN_STATEMENT:
return outParamFile;
}

public static class FuncActionGenerateReportSAPStatus {

private static async Task<RC_2f34e41fc62b4f171d5257cbac94e819> datasetGetInvoicesSAPReadDbAsync(RC_2f34e41fc62b4f171d5257cbac94e819 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingDataType.Read( r, ref index);
rec.ssENBusinessValueCategory.Read( r, ref index);
rec.ssENBusinessValueSubcategory.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFrequency.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENOrderAccConcepts.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENSpecialApproval.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesSAP" 9hwJQ+rNqUi9WJN6chmCvw of Action "GenerateReportSAPStatus"
public static async Task<(RL_d73c3b3bac950b4c134511806f4793ea,long)> datasetGetInvoicesSAP(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboGetIsCorporativo,long qpreOrderMain_DivisionId,decimal qpdei_AmountFrom,decimal qpdei_AmountTo,string qptei_AssignedTo,string qptei_BusinessValueCategory,string qptei_BusinessValueSubCateg,int qpacOrderAccConcepts_AccountingDataTypeId,string qpcuCurrency_Code,DateTime qpdai_FolioCreatedOn,string qptei_FolioNumber,int qpfrFrequency_Id,DateTime qpdai_InvoiceCreatedOn,string qptei_InvoiceName,int qpinInvoiceStatus_Id,bool qpboi_IsSelectAll,int qpini_OffsetUtc,string qptei_OrderMainNumber,DateTime qpdai_PaidOn,string qptei_Period,string qptei_Project,string qptei_SelectedIds,int qpspSpecialApproval_Id,long qpsuSupplier_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateReportSAPStatus.GetInvoicesSAP", "43091cf6-cdea-48a9-bd58-937a721982bf");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateReportSAPStatus.GetInvoicesSAP", "43091cf6-cdea-48a9-bd58-937a721982bf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.It0pa9wDg0ijZA_KvYp05A/NodesNotShownInESpaceTree.9hwJQ+rNqUi9WJN6chmCvw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enaccountingdatatype2\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enbusinessvaluecategory\".\"description\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enbusinessvaluesubcategory\".\"description\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, \"enfolio20\".\"folionumber\" o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, \"enfolio20\".\"createdon\" o39, NULL o40, NULL o41, NULL o42, NULL o43, \"enfrequency2\".\"label\" o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, trim_scale(\"eninvoice28\".\"totalamount\"::numeric) o53, \"eninvoice28\".\"currency\" o54, NULL o55, NULL o56, NULL o57, \"eninvoice28\".\"createdon\" o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, \"eninvoiceapprovallevel13\".\"assignedto\" o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, \"eninvoiceextended8\".\"folio\" o108, NULL o109, \"eninvoiceextended8\".\"fechaemision\" o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, \"eninvoicestatus1\".\"id\" o125, \"eninvoicestatus1\".\"label\" o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, \"enorderaccconcepts3\".\"paymenttermcustomdays\" o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, \"enordermain30\".\"ordernumber\" o186, NULL o187, NULL o188, NULL o189, NULL o190, NULL o191, NULL o192, NULL o193, NULL o194, NULL o195, NULL o196, NULL o197, NULL o198, NULL o199, NULL o200, NULL o201, NULL o202, NULL o203, NULL o204, NULL o205, NULL o206, NULL o207, NULL o208, NULL o209, NULL o210, NULL o211, NULL o212, NULL o213, NULL o214, NULL o215, NULL o216, NULL o217, \"enpaymentterms6\".\"ctd_dias\" o218, NULL o219, \"enpaymentterms6\".\"isspecial\" o220, NULL o221, NULL o222, NULL o223, NULL o224, NULL o225, \"enproject_asset_service4\".\"description\" o226, NULL o227, NULL o228, NULL o229, NULL o230, NULL o231, NULL o232, \"enspecialapproval\".\"label\" o233, NULL o234, NULL o235, NULL o236, NULL o237, \"ensupplier20\".\"name\" o238, \"ensupplier20\".\"number\" o239, NULL o240, NULL o241, NULL o242, NULL o243, NULL o244, NULL o245, NULL o246, NULL o247, NULL o248, NULL o249, NULL o250, NULL o251, NULL o252, NULL o253, NULL o254, NULL o255, NULL o256, NULL o257, NULL o258, NULL o259, NULL o260, NULL o261, NULL o262, NULL o263, NULL o264, NULL o265, NULL o266, NULL o267, NULL o268");
fromBuilder.Append(" FROM (((((((((((((((((({Invoice} \"eninvoice28\" Left JOIN {InvoiceStatus} \"eninvoicestatus1\" ON (\"eninvoice28\".\"invoicestatusid\" = \"eninvoicestatus1\".\"id\"))  Left JOIN {Folio} \"enfolio20\" ON (\"eninvoice28\".\"folioid\" = \"enfolio20\".\"id\"))  Left JOIN {Supplier} \"ensupplier20\" ON (\"enfolio20\".\"supplierid\" = \"ensupplier20\".\"id\"))  Inner JOIN {OrderMain} \"enordermain30\" ON (\"enfolio20\".\"orderid\" = \"enordermain30\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail4\" ON (\"enordermain30\".\"id\" = \"enorderdetail4\".\"orderid\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service4\" ON (\"enorderdetail4\".\"projectassetserviceid\" = \"enproject_asset_service4\".\"id\"))  Left JOIN {Frequency} \"enfrequency2\" ON (\"enorderdetail4\".\"frequency\" = \"enfrequency2\".\"id\"))  Left JOIN {InvoiceExtended} \"eninvoiceextended8\" ON (\"eninvoice28\".\"id\" = \"eninvoiceextended8\".\"id\"))  Left JOIN {BusinessValueCategory} \"enbusinessvaluecategory\" ON (\"enorderdetail4\".\"businessvaluecategoryid\" = \"enbusinessvaluecategory\".\"id\"))  Left JOIN {BusinessValueSubcategory} \"enbusinessvaluesubcategory\" ON (\"enorderdetail4\".\"businessvaluesubcategoryid\" = \"enbusinessvaluesubcategory\".\"id\"))  Left JOIN {InvoiceApproval} \"eninvoiceapproval12\" ON (\"eninvoice28\".\"id\" = \"eninvoiceapproval12\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel13\" ON ((\"eninvoiceapproval12\".\"id\" = \"eninvoiceapprovallevel13\".\"invoiceapprovalid\") AND (\"eninvoiceapprovallevel13\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
fromBuilder.Append(")))  Left JOIN {User} \"enuser71\" ON (\"eninvoiceapprovallevel13\".\"assignedto\" = \"enuser71\".\"id\"))  Left JOIN {Currency} \"encurrency1\" ON (\"enfolio20\".\"currencyid\" = \"encurrency1\".\"code\"))  Left JOIN {SpecialApproval} \"enspecialapproval\" ON (\"enorderdetail4\".\"specialapprovalid\" = \"enspecialapproval\".\"id\"))  Left JOIN {OrderAccConcepts} \"enorderaccconcepts3\" ON (\"eninvoice28\".\"orderaccconceptsid\" = \"enorderaccconcepts3\".\"id\"))  Left JOIN {AccountingDataType} \"enaccountingdatatype2\" ON (\"enorderaccconcepts3\".\"accountingdatatypeid\" = \"enaccountingdatatype2\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms6\" ON (\"enorderaccconcepts3\".\"paymenttermid\" = \"enpaymentterms6\".\"id\")) ");
whereBuilder.Append(" WHERE ((CASE WHEN (@qpboGetIsCorporativo = 1) THEN 1 ELSE (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
if (qpreOrderMain_DivisionId != 0) {
whereBuilder.Append("((\"enordermain30\".\"divisionid\" = @qpreOrderMain_DivisionId) AND (\"enordermain30\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
} else {
whereBuilder.Append("(\"enordermain30\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) END) = 1) AND ((((\"eninvoicestatus1\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("CJKmpdl1bUqOtDMY59Vg9Q"))).ssId);
whereBuilder.Append(") OR (\"eninvoicestatus1\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("h+R+u64a50K6vJ2dkkiVXQ"))).ssId);
whereBuilder.Append(")) OR (\"eninvoicestatus1\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Tfj332sYfU6orP6hWpZ2sg"))).ssId);
whereBuilder.Append(")) OR (\"eninvoicestatus1\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("J4p4BoSeP06EZmvoJ_ofhg"))).ssId);
whereBuilder.Append(")) AND ");
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier20\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier20\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier20\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qptei_InvoiceName != "" && qptei_InvoiceName != "") {
whereBuilder.Append("(caseaccent_normalize(\"eninvoice28\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qptei_InvoiceName) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptei_InvoiceName", DbType.String, qptei_InvoiceName);
}
if (qptei_FolioNumber != "" && qptei_FolioNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enfolio20\".\"folionumber\" collate \"default\") like caseaccent_normalize((('%' || @qptei_FolioNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptei_FolioNumber", DbType.String, qptei_FolioNumber);
}
if (qpinInvoiceStatus_Id != BuiltInFunction.NullIdentifier()) {
if (qpinInvoiceStatus_Id != 0) {
whereBuilder.Append("((\"eninvoicestatus1\".\"id\" = @qpinInvoiceStatus_Id) AND (\"eninvoicestatus1\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceStatus_Id", DbType.Int32, qpinInvoiceStatus_Id);
} else {
whereBuilder.Append("(\"eninvoicestatus1\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qptei_OrderMainNumber != "" && qptei_OrderMainNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain30\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qptei_OrderMainNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptei_OrderMainNumber", DbType.String, qptei_OrderMainNumber);
}
if (qptei_AssignedTo != "" && qptei_AssignedTo != "") {
whereBuilder.Append("(caseaccent_normalize(\"enuser71\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qptei_AssignedTo) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptei_AssignedTo", DbType.String, qptei_AssignedTo);
}
if (qptei_Project != "" && qptei_Project != "") {
whereBuilder.Append("(caseaccent_normalize(\"enproject_asset_service4\".\"description\" collate \"default\") like caseaccent_normalize((('%' || @qptei_Project) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptei_Project", DbType.String, qptei_Project);
}
if (qptei_Period != "" && qptei_Period != "") {
whereBuilder.Append("(caseaccent_normalize(\"enorderdetail4\".\"period\" collate \"default\") like caseaccent_normalize((('%' || @qptei_Period) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptei_Period", DbType.String, qptei_Period);
}
if (qpfrFrequency_Id != BuiltInFunction.NullIdentifier()) {
if (qpfrFrequency_Id != 0) {
whereBuilder.Append("((\"enfrequency2\".\"id\" = @qpfrFrequency_Id) AND (\"enfrequency2\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfrFrequency_Id", DbType.Int32, qpfrFrequency_Id);
} else {
whereBuilder.Append("(\"enfrequency2\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qptei_BusinessValueCategory != "" && qptei_BusinessValueCategory != "") {
whereBuilder.Append("(caseaccent_normalize(\"enbusinessvaluecategory\".\"description\" collate \"default\") like caseaccent_normalize((('%' || @qptei_BusinessValueCategory) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptei_BusinessValueCategory", DbType.String, qptei_BusinessValueCategory);
}
if (qptei_BusinessValueSubCateg != "" && qptei_BusinessValueSubCateg != "") {
whereBuilder.Append("(caseaccent_normalize(\"enbusinessvaluesubcategory\".\"description\" collate \"default\") like caseaccent_normalize((('%' || @qptei_BusinessValueSubCateg) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptei_BusinessValueSubCateg", DbType.String, qptei_BusinessValueSubCateg);
}
if (qpdai_PaidOn != BuiltInFunction.NullDate()) {
whereBuilder.Append("((\"eninvoice28\".\"updatedon\" >= (((cast(@qpdai_PaidOn as date)::timestamptz)::timestamptz + ((cast(@qpini_OffsetUtc as integer)) * interval '1 hour')))) AND (\"eninvoice28\".\"updatedon\" < (((((cast(@qpdai_PaidOn as date)::timestamptz)::timestamptz + ((cast(1 as integer)) * interval '1 day')))::timestamptz + ((cast(@qpini_OffsetUtc as integer)) * interval '1 hour'))))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdai_PaidOn", DbType.DateTime, qpdai_PaidOn);
sqlCmd.CreateParameterWithoutReplacements("@qpini_OffsetUtc", DbType.Int32, qpini_OffsetUtc);
}
if (qpdei_AmountFrom != (((decimal)0))) {
whereBuilder.Append("(\"eninvoice28\".\"totalamount\" >= @qpdei_AmountFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdei_AmountFrom", DbType.Decimal, qpdei_AmountFrom);
}
if (qpdei_AmountTo != (((decimal)0))) {
whereBuilder.Append("(\"eninvoice28\".\"totalamount\" <= @qpdei_AmountTo) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdei_AmountTo", DbType.Decimal, qpdei_AmountTo);
}
if (qpcuCurrency_Code != BuiltInFunction.NullTextIdentifier()) {
if ((qpcuCurrency_Code.Trim()!="")) {
whereBuilder.Append("((\"encurrency1\".\"code\" = @qpcuCurrency_Code) AND (\"encurrency1\".\"code\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcuCurrency_Code", DbType.String, qpcuCurrency_Code);
} else {
whereBuilder.Append("(\"encurrency1\".\"code\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdai_InvoiceCreatedOn != BuiltInFunction.NullDate()) {
whereBuilder.Append("((\"eninvoice28\".\"createdon\" >= (((cast(@qpdai_InvoiceCreatedOn as date)::timestamptz)::timestamptz + ((cast(@qpini_OffsetUtc as integer)) * interval '1 hour')))) AND (\"eninvoice28\".\"createdon\" < (((((cast(@qpdai_InvoiceCreatedOn as date)::timestamptz)::timestamptz + ((cast(1 as integer)) * interval '1 day')))::timestamptz + ((cast(@qpini_OffsetUtc as integer)) * interval '1 hour'))))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdai_InvoiceCreatedOn", DbType.DateTime, qpdai_InvoiceCreatedOn);
sqlCmd.CreateParameterWithoutReplacements("@qpini_OffsetUtc", DbType.Int32, qpini_OffsetUtc);
}
if (qpdai_FolioCreatedOn != BuiltInFunction.NullDate()) {
whereBuilder.Append("((\"enfolio20\".\"createdon\" >= (((cast(@qpdai_FolioCreatedOn as date)::timestamptz)::timestamptz + ((cast(@qpini_OffsetUtc as integer)) * interval '1 hour')))) AND (\"enfolio20\".\"createdon\" < (((((cast(@qpdai_FolioCreatedOn as date)::timestamptz)::timestamptz + ((cast(1 as integer)) * interval '1 day')))::timestamptz + ((cast(@qpini_OffsetUtc as integer)) * interval '1 hour'))))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpdai_FolioCreatedOn", DbType.DateTime, qpdai_FolioCreatedOn);
sqlCmd.CreateParameterWithoutReplacements("@qpini_OffsetUtc", DbType.Int32, qpini_OffsetUtc);
}
if (qpspSpecialApproval_Id != BuiltInFunction.NullIdentifier()) {
if (qpspSpecialApproval_Id != 0) {
whereBuilder.Append("((\"enspecialapproval\".\"id\" = @qpspSpecialApproval_Id) AND (\"enspecialapproval\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpspSpecialApproval_Id", DbType.Int32, qpspSpecialApproval_Id);
} else {
whereBuilder.Append("(\"enspecialapproval\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpacOrderAccConcepts_AccountingDataTypeId != BuiltInFunction.NullIdentifier()) {
if (qpacOrderAccConcepts_AccountingDataTypeId != 0) {
whereBuilder.Append("((\"enorderaccconcepts3\".\"accountingdatatypeid\" = @qpacOrderAccConcepts_AccountingDataTypeId) AND (\"enorderaccconcepts3\".\"accountingdatatypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpacOrderAccConcepts_AccountingDataTypeId", DbType.Int32, qpacOrderAccConcepts_AccountingDataTypeId);
} else {
whereBuilder.Append("(\"enorderaccconcepts3\".\"accountingdatatypeid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qptei_SelectedIds != "") {
whereBuilder.Append("((@qpboi_IsSelectAll = 1) OR (((CASE WHEN char_length(caseaccent_normalize(('#' || cast(\"enfolio20\".\"id\" as text)) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(('#' || cast(\"enfolio20\".\"id\" as text)) collate \"default\") in caseaccent_normalize(@qptei_SelectedIds collate \"default\"))-1) END)) <> (-1)))");
sqlCmd.CreateParameterWithoutReplacements("@qpboi_IsSelectAll", DbType.Boolean, qpboi_IsSelectAll);
sqlCmd.CreateParameterWithoutReplacements("@qptei_SelectedIds", DbType.String, qptei_SelectedIds);
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
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
RL_d73c3b3bac950b4c134511806f4793ea outParamList = new RL_d73c3b3bac950b4c134511806f4793ea();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesSAPReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[19];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, false, false, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {false, false, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, false, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[10] = new BitArray(new bool[] {true, false, true, true});
opt[11] = new BitArray(new bool[] {true, true, false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[12] = new BitArray(new bool[] {true, false, true, true, true});
opt[13] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[14] = new BitArray(new bool[] {true, false, true, true});
opt[15] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[16] = new BitArray(new bool[] {true, true, true, true, false, true, false, true, true, true, true});
opt[17] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[18] = new BitArray(new bool[] {true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateReportSAPStatus.GetInvoicesSAP.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d73c3b3bac950b4c134511806f4793ea _tmp = new RL_d73c3b3bac950b4c134511806f4793ea();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesSAPReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateReportSAPStatus.GetInvoicesSAP.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d73c3b3bac950b4c134511806f4793ea)_tmp;
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
/// RecordList To Excel: RLToExcelGenerateReportSAPStatusRecordListToExcel1 (Kr6S_OyoihEWbgQdKqHg1iw)
///  of Action "GenerateReportSAPStatus"
/// </summary>
public static async Task<byte[]> RLToExcelGenerateReportSAPStatusRecordListToExcel1(IRequestContext requestContext,RL_c94b937e248ffb05391a1f227e9d9277 ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(19, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Proveedor");
excel.CreateCell("Número de Proveedor");
excel.CreateCell("Número de Factura");
excel.CreateCell("Número de folio");
excel.CreateCell("Estado de la factura");
excel.CreateCell("Número de Pedido");
excel.CreateCell("Proyecto/Bien/Servicio");
excel.CreateCell("Fecha de emisión");
excel.CreateCell("Frecuencia");
excel.CreateCell("Categoría del Valor al Negocio");
excel.CreateCell("Subcategoría de valor del negocio");
excel.CreateCell("Fecha de Pago");
excel.CreateCell("Monto Total");
excel.CreateCell("Factura creada en");
excel.CreateCell("Moneda");
excel.CreateCell("Fecha de entrada al almacén");
excel.CreateCell("Aprobación especial");
excel.CreateCell("Etiquetas");
excel.CreateCell("Tipo de Pago");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssSupplierName);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceName);
excel.CreateCell(ssRecordList.CurrentRec.ssFolioNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssOrderNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssAssetServiceDescription);
excel.CreateCell(ssRecordList.CurrentRec.ssIssueDate);
excel.CreateCell(ssRecordList.CurrentRec.ssFrequency);
excel.CreateCell(ssRecordList.CurrentRec.ssBusinessValueCategory);
excel.CreateCell(ssRecordList.CurrentRec.ssBusinessValueSubCategory);
excel.CreateCell(ssRecordList.CurrentRec.ssPaidOn);
excel.CreateCell(ssRecordList.CurrentRec.ssTotalAmount);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceDate);
excel.CreateCell(ssRecordList.CurrentRec.ssCurrency);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceCreatedOn);
excel.CreateCell(ssRecordList.CurrentRec.ssSpecialApproval);
excel.CreateCell(ssRecordList.CurrentRec.ssTags);
excel.CreateCell(ssRecordList.CurrentRec.ssTypeCFDI);

            ssRecordList.Advance(); 
		}
	} finally {
		ssRecordList.EndIteration();
	}
}

return await excel.SaveAsync(cancellationToken);
}


}


}
