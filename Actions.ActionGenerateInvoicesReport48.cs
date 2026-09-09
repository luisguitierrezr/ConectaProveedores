namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateInvoicesReport48 : VarsBag {
public ST_4301e782f48f03168dfeb78159c19548Structure inParamFilters;
public int inParami_OffsetUtc;
/// <summary>
/// Variable <code>InvoicesReport48</code> that represents the Service Studio InvoicesReport48List
///  <code>InvoicesReport48</code> <p>Description: </p>
/// </summary>
public RL_36f497358824531a4d0365a750b33706 varLcInvoicesReport48 = new RL_36f497358824531a4d0365a750b33706();

public Actions.lcoGenerateInvoicesReport48_Invoices resGenerateInvoicesReport48_Invoices =  new Actions.lcoGenerateInvoicesReport48_Invoices();
public byte[] resRecordListToExcel1_outParamOut = new byte[] {};
public RL_ec7fd70758abaa586e4d3f90d8e7ea59 queryResGetRequisitionsBySupplierUserId_outParamList = new RL_ec7fd70758abaa586e4d3f90d8e7ea59();
public long queryResGetRequisitionsBySupplierUserId_outParamCount = 0L;

public byte[] resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary = new byte[] {};

public lcvGenerateInvoicesReport48(ST_4301e782f48f03168dfeb78159c19548Structure inParamFilters, int inParami_OffsetUtc) {
this.inParamFilters = inParamFilters;
this.inParami_OffsetUtc = inParami_OffsetUtc;
}
}
public class lcoGenerateInvoicesReport48 : VarsBag {
public ST_a158c76eb93396680623c04244f48b6cStructure outParamFile = new ST_a158c76eb93396680623c04244f48b6cStructure();

public lcoGenerateInvoicesReport48() {
}
}
/// <summary>
/// Action <code>GenerateInvoicesReport48</code> that represents the Service Studio action
///  <code>GenerateInvoicesReport48</code> <p> Description: GenerateInvoiceReport48</p>
/// </summary>
public static async Task<ST_a158c76eb93396680623c04244f48b6cStructure> ActionGenerateInvoicesReport48(IRequestContext requestContext,ST_4301e782f48f03168dfeb78159c19548Structure inParamFilters,int inParami_OffsetUtc,CancellationToken cancellationToken) {
ST_a158c76eb93396680623c04244f48b6cStructure outParamFile = default;
lcoGenerateInvoicesReport48 result = new lcoGenerateInvoicesReport48();
lcvGenerateInvoicesReport48 localVars = new lcvGenerateInvoicesReport48(inParamFilters, inParami_OffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateInvoicesReport48", "4b8676da-3228-4c3a-9a93-8d2e9af75c4c"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateInvoicesReport48", "4b8676da-3228-4c3a-9a93-8d2e9af75c4c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionsBySupplierUserId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionsBySupplierUserId_maxRecords = 0;
int datasetGetRequisitionsBySupplierUserId_startIndex = 0;(localVars.queryResGetRequisitionsBySupplierUserId_outParamList,localVars.queryResGetRequisitionsBySupplierUserId_outParamCount) = await FuncActionGenerateInvoicesReport48.datasetGetRequisitionsBySupplierUserId(requestContext,datasetGetRequisitionsBySupplierUserId_maxRecords,datasetGetRequisitionsBySupplierUserId_startIndex,IterationMultiplicity.Single,localVars.inParamFilters.ssSupplierId,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_AllRegionsSuppliersInvoicesReport]))),cancellationToken);

// Foreach GetRequisitionsBySupplierUserId.List
localVars.queryResGetRequisitionsBySupplierUserId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionsBySupplierUserId_outParamList.Eof))) {
// GenerateInvoicesReport48_Invoices
localVars.resGenerateInvoicesReport48_Invoices.outParamo_InvoicesReport48List = await Actions.ActionGenerateInvoicesReport48_Invoices(requestContext,localVars.queryResGetRequisitionsBySupplierUserId_outParamList.CurrentRec.ssENRequisition.ssId,localVars.queryResGetRequisitionsBySupplierUserId_outParamList.CurrentRec.ssENFrequency.ssLabel,"",localVars.queryResGetRequisitionsBySupplierUserId_outParamList.CurrentRec.ssENProject_Asset_Service.ssDescription,localVars.queryResGetRequisitionsBySupplierUserId_outParamList.CurrentRec.ssENRegion.ssDivisionFI,localVars.queryResGetRequisitionsBySupplierUserId_outParamList.CurrentRec.ssENRequisition.ssName,localVars.queryResGetRequisitionsBySupplierUserId_outParamList.CurrentRec.ssENRequisition.ssCreatedOn,localVars.queryResGetRequisitionsBySupplierUserId_outParamList.CurrentRec.ssENCostCenterSAP.ssCeBe,localVars.queryResGetRequisitionsBySupplierUserId_outParamList.CurrentRec.ssENCostCenterSAP.ssCeCo,localVars.queryResGetRequisitionsBySupplierUserId_outParamList.CurrentRec.ssENSupplier,localVars.inParamFilters,localVars.inParami_OffsetUtc,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcInvoicesReport48,localVars.resGenerateInvoicesReport48_Invoices.outParamo_InvoicesReport48List,cancellationToken);

localVars.queryResGetRequisitionsBySupplierUserId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionsBySupplierUserId_outParamList.EndIteration();
}

// RecordListToExcel RLToExcelGenerateInvoicesReport48RecordListToExcel1
localVars.resRecordListToExcel1_outParamOut = await FuncActionGenerateInvoicesReport48.RLToExcelGenerateInvoicesReport48RecordListToExcel1(requestContext,localVars.varLcInvoicesReport48,cancellationToken);

// ConvertExcelBinaryToCsvBinary
localVars.resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary = await Actions.ActionConvertExcelBinaryToCsvBinary(requestContext,localVars.resRecordListToExcel1_outParamOut,cancellationToken);

// File.BinaryData = ConvertExcelBinaryToCsvBinary.ConvertExcelBinaryToCsvBinary
result.outParamFile.ssBinaryData = localVars.resConvertExcelBinaryToCsvBinary_outParamConvertExcelBinaryToCsvBinary;

// File.Name = "SuppliersWithoutOrderReport" + ".csv"
result.outParamFile.ssName = (AppUtils.GetStringResource("1p9y4pXHOkedUeDna0iVeg#Value.1228814497.1", "SuppliersWithoutOrderReport")+".csv");
} //close CreateActionActivity using block
} // try

finally {
outParamFile = result.outParamFile;
} // inner-finally
RETURN_STATEMENT:
return outParamFile;
}

public static class FuncActionGenerateInvoicesReport48 {

private static async Task<RC_8b7c923e868586b85592884287e2136d> datasetGetRequisitionsBySupplierUserIdReadDbAsync(RC_8b7c923e868586b85592884287e2136d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCostCenterSAP.Read( r, ref index);
rec.ssENFrequency.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionsBySupplierUserId" QiIL7ofgW0yJr1tAhbBElw of Action "GenerateInvoicesReport48"
public static async Task<(RL_ec7fd70758abaa586e4d3f90d8e7ea59,long)> datasetGetRequisitionsBySupplierUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplier_Id,long qpreRequisition_RegionId,bool qpboIsActiveDEV_AllRegionsSuppliersInvoicesReport,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateInvoicesReport48.GetRequisitionsBySupplierUserId", "ee0b2242-e087-4c5b-89af-5b4085b04497");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateInvoicesReport48.GetRequisitionsBySupplierUserId", "ee0b2242-e087-4c5b-89af-5b4085b04497", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /UserActions.2naGSygyOkyak40umvdcTA/NodesNotShownInESpaceTree.QiIL7ofgW0yJr1tAhbBElw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"encostcentersap3\".\"cebe\" o7, NULL o8, NULL o9, NULL o10, \"encostcentersap3\".\"ceco\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, \"enfrequency1\".\"label\" o26, NULL o27, NULL o28, NULL o29, \"enproject_asset_service2\".\"description\" o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, \"enregion16\".\"divisionfi\" o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, \"enrequisition25\".\"id\" o49, \"enrequisition25\".\"name\" o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, \"enrequisition25\".\"createdon\" o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, \"ensupplier12\".\"id\" o107, \"ensupplier12\".\"tratamiento\" o108, \"ensupplier12\".\"name\" o109, \"ensupplier12\".\"number\" o110, \"ensupplier12\".\"conceptobusq_1_2\" o111, \"ensupplier12\".\"calle_numero\" o112, \"ensupplier12\".\"distrito\" o113, \"ensupplier12\".\"codigopostal_pobl_\" o114, \"ensupplier12\".\"pais\" o115, \"ensupplier12\".\"region_\" o116, \"ensupplier12\".\"idioma\" o117, \"ensupplier12\".\"telefono\" o118, \"ensupplier12\".\"extension\" o119, \"ensupplier12\".\"fax\" o120, \"ensupplier12\".\"cliente\" o121, \"ensupplier12\".\"soc_glasociada\" o122, \"ensupplier12\".\"clavedegrupo\" o123, \"ensupplier12\".\"n_ident_fis_1\" o124, \"ensupplier12\".\"personafisica\" o125, \"ensupplier12\".\"ramo\" o126, \"ensupplier12\".\"grupodeporte\" o127, \"ensupplier12\".\"email\" o128, \"ensupplier12\".\"isactive\" o129, \"ensupplier12\".\"createdon\" o130, \"ensupplier12\".\"createdby\" o131, \"ensupplier12\".\"updatedon\" o132, \"ensupplier12\".\"updatedby\" o133, \"ensupplier12\".\"regionid\" o134");
fromBuilder.Append(" FROM ((((({Requisition} \"enrequisition25\" Left JOIN {Supplier} \"ensupplier12\" ON (\"enrequisition25\".\"supplierid\" = \"ensupplier12\".\"id\"))  Left JOIN {Frequency} \"enfrequency1\" ON (\"enrequisition25\".\"frequencyid\" = \"enfrequency1\".\"id\"))  Left JOIN {Region} \"enregion16\" ON (\"enrequisition25\".\"regionid\" = \"enregion16\".\"id\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service2\" ON (\"enrequisition25\".\"projectassetserviceid\" = \"enproject_asset_service2\".\"id\"))  Left JOIN {CostCenterSAP} \"encostcentersap3\" ON (\"enrequisition25\".\"costcenterid\" = \"encostcentersap3\".\"id\")) ");
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier()) || qpreRequisition_RegionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
whereBuilder.Append(" WHERE ");
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier12\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier12\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier12\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpreRequisition_RegionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
whereBuilder.Append("((@qpboIsActiveDEV_AllRegionsSuppliersInvoicesReport = 1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsActiveDEV_AllRegionsSuppliersInvoicesReport", DbType.Boolean, qpboIsActiveDEV_AllRegionsSuppliersInvoicesReport);
if (qpreRequisition_RegionId != 0) {
whereBuilder.Append("((\"enrequisition25\".\"regionid\" = @qpreRequisition_RegionId) AND (\"enrequisition25\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
} else {
whereBuilder.Append("(\"enrequisition25\".\"regionid\" IS NULL)");
}
whereBuilder.Append(")");
}
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
RL_ec7fd70758abaa586e4d3f90d8e7ea59 outParamList = new RL_ec7fd70758abaa586e4d3f90d8e7ea59();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionsBySupplierUserIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, false, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoicesReport48.GetRequisitionsBySupplierUserId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ec7fd70758abaa586e4d3f90d8e7ea59 _tmp = new RL_ec7fd70758abaa586e4d3f90d8e7ea59();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionsBySupplierUserIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoicesReport48.GetRequisitionsBySupplierUserId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ec7fd70758abaa586e4d3f90d8e7ea59)_tmp;
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
/// RecordList To Excel: RLToExcelGenerateInvoicesReport48RecordListToExcel1 (KhrBLzJZ23Ui2Qo_c_8id4w)
///  of Action "GenerateInvoicesReport48"
/// </summary>
public static async Task<byte[]> RLToExcelGenerateInvoicesReport48RecordListToExcel1(IRequestContext requestContext,RL_36f497358824531a4d0365a750b33706 ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(42, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("Región");
excel.CreateCell("No. de Proveedor");
excel.CreateCell("Proveedor");
excel.CreateCell("RFC");
excel.CreateCell("N° de Requisición");
excel.CreateCell("Fecha de Creación de Requisición");
excel.CreateCell("Serie Factura");
excel.CreateCell("Factura");
excel.CreateCell("Fecha de la Factura");
excel.CreateCell("Subtotal");
excel.CreateCell("IVA");
excel.CreateCell("IVA Retención");
excel.CreateCell("ISR Retención");
excel.CreateCell("Erogaciones");
excel.CreateCell("Total Factura");
excel.CreateCell("Moneda");
excel.CreateCell("Estatus");
excel.CreateCell("Usuario Asignado");
excel.CreateCell("Fecha de Carga");
excel.CreateCell("Fecha de Vencimiento");
excel.CreateCell("Fecha de Pago");
excel.CreateCell("Descripción");
excel.CreateCell("Centro de Atención");
excel.CreateCell("Calle");
excel.CreateCell("Num Exterior");
excel.CreateCell("Código Postal");
excel.CreateCell("Importe del Traslado");
excel.CreateCell("Nombre PDF");
excel.CreateCell("Nombre XML");
excel.CreateCell("UUID");
excel.CreateCell("N°DEL CECO");
excel.CreateCell("Centros de Costos");
excel.CreateCell("N°DEL CEBE");
excel.CreateCell("Usuarios Aprobadores");
excel.CreateCell("Fecha de llegada a CxP/Egresos");
excel.CreateCell("Periodo Proyecto");
excel.CreateCell("Proyecto");
excel.CreateCell("Periodicidad");
excel.CreateCell("Póliza SAP");
excel.CreateCell("Fecha de Registro Contable Factura en SAP");
excel.CreateCell("Departamento de quien realiza el registro de la factura");
excel.CreateCell("Analista de CxP/Egresos");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssRegion);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplier);
excel.CreateCell(ssRecordList.CurrentRec.ssSupplierRFC);
excel.CreateCell(ssRecordList.CurrentRec.ssRequisitonName);
excel.CreateCell(ssRecordList.CurrentRec.ssRequisitionCreatedOn);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceSerie);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceEmissionDate);
excel.CreateCell(ssRecordList.CurrentRec.ssSubtotal);
excel.CreateCell(ssRecordList.CurrentRec.ssIVA);
excel.CreateCell(ssRecordList.CurrentRec.ssRetentionIVA);
excel.CreateCell(ssRecordList.CurrentRec.ssISRRetention);
excel.CreateCell(ssRecordList.CurrentRec.ssExpenditures);
excel.CreateCell(ssRecordList.CurrentRec.ssTotalAmount);
excel.CreateCell(ssRecordList.CurrentRec.ssCurrency);
excel.CreateCell(ssRecordList.CurrentRec.ssStatus);
excel.CreateCell(ssRecordList.CurrentRec.ssAssignedUser);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceCreationDate);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceExpirationDate);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoicePaymentDate);
excel.CreateCell(ssRecordList.CurrentRec.ssDescription);
excel.CreateCell(ssRecordList.CurrentRec.ssCentrodeAtencion);
excel.CreateCell(ssRecordList.CurrentRec.ssStreet);
excel.CreateCell(ssRecordList.CurrentRec.ssDoorNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssPostalCode);
excel.CreateCell(ssRecordList.CurrentRec.ssImportTraslado);
excel.CreateCell(ssRecordList.CurrentRec.ssPdfName);
excel.CreateCell(ssRecordList.CurrentRec.ssXmlName);
excel.CreateCell(ssRecordList.CurrentRec.ssUUID);
excel.CreateCell(ssRecordList.CurrentRec.ssIDCeCo);
excel.CreateCell(ssRecordList.CurrentRec.ssCostCenters);
excel.CreateCell(ssRecordList.CurrentRec.ssIDCeBe);
excel.CreateCell(ssRecordList.CurrentRec.ssApprovingUsers);
excel.CreateCell(ssRecordList.CurrentRec.ssInvoiceApprovalDate);
excel.CreateCell(ssRecordList.CurrentRec.ssProjectPeriod);
excel.CreateCell(ssRecordList.CurrentRec.ssProject);
excel.CreateCell(ssRecordList.CurrentRec.ssFrequency);
excel.CreateCell(ssRecordList.CurrentRec.ssSAPNumber);
excel.CreateCell(ssRecordList.CurrentRec.ssSAPRegisterDate);
excel.CreateCell(ssRecordList.CurrentRec.ssApprovalArea);
excel.CreateCell(ssRecordList.CurrentRec.ssAccountingUser);

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
