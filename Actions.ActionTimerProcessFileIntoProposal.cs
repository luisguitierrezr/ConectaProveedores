namespace ssConectaProveedores;

public partial class Actions {
public class lcvTimerProcessFileIntoProposal : VarsBag {
/// <summary>
/// Variable <code>l_FileExtendedId</code> that represents the Service Studio FileExtendedIdentifier
///  <code>l_FileExtendedId</code> <p>Description: File_Extended Identifier</p>
/// </summary>
public long varLcl_FileExtendedId = 0L;

/// <summary>
/// Variable <code>l_LinesValid</code> that represents the Service Studio Boolean
///  <code>l_LinesValid</code> <p>Description: LinesValid</p>
/// </summary>
public bool varLcl_LinesValid = false;

/// <summary>
/// Variable <code>l_ProposalId</code> that represents the Service Studio ProposalIdentifier
///  <code>l_ProposalId</code> <p>Description: Proposal Identifier</p>
/// </summary>
public long varLcl_ProposalId = 0L;

/// <summary>
/// Variable <code>l_RegionId</code> that represents the Service Studio RegionIdentifier
///  <code>l_RegionId</code> <p>Description: Region of the file</p>
/// </summary>
public long varLcl_RegionId = 0L;

/// <summary>
/// Variable <code>l_ErrorList</code> that represents the Service Studio ErroImportList
///  <code>l_ErrorList</code> <p>Description: Error Import List</p>
/// </summary>
public RL_21421685308149cb9c93dd790730a8ac varLcl_ErrorList = new RL_21421685308149cb9c93dd790730a8ac();

public Actions.lcoProposalStatusHistoryCreateOrUpdate resProposalStatusHistoryCreateOrUpdate =  new Actions.lcoProposalStatusHistoryCreateOrUpdate();
public Actions.lcoProposalLogAdd resProposalLogDocumentAdd2 =  new Actions.lcoProposalLogAdd();
public Actions.lcoProposalLogAdd resProposalLogAdd5 =  new Actions.lcoProposalLogAdd();
public Actions.lcoProposalCreate resProposalCreate =  new Actions.lcoProposalCreate();
public Actions.lcoProposalFileExtendedCreateOrUpdate resProposalFileExtendedCreateOrUpdate =  new Actions.lcoProposalFileExtendedCreateOrUpdate();
public Actions.lcoProposalCreateOrUpdate resProposalCreateOrUpdate =  new Actions.lcoProposalCreateOrUpdate();
public Actions.lcoProposalCreateOrUpdate resProposalCreateOrUpdate2 =  new Actions.lcoProposalCreateOrUpdate();
public Actions.lcoVerifyAndValidateFilename resVerifyAndValidateFilename =  new Actions.lcoVerifyAndValidateFilename();
public RL_6de96902c907b264dc4c48e378eca40b queryResGetFileExtendeds_outParamList = new RL_6de96902c907b264dc4c48e378eca40b();
public long queryResGetFileExtendeds_outParamCount = 0L;

public Actions.lcoProposalLogAdd resProposalLogDocumentAdd =  new Actions.lcoProposalLogAdd();
public RC_91adc4f46f8a0f51cacc4bc718d2ea35 resGetProposal_outParamRecord = new RC_91adc4f46f8a0f51cacc4bc718d2ea35();

public long resCreateProposalLine_outParamId = 0L;

public Actions.lcoProposalLogAdd resProposalLogAdd =  new Actions.lcoProposalLogAdd();
public Actions.lcoProposalLogAdd resProposalLogAdd3 =  new Actions.lcoProposalLogAdd();
public RC_6e3ea28d2c552bc2cc129f42297e5982 resGetFileExtended_outParamRecord = new RC_6e3ea28d2c552bc2cc129f42297e5982();

public Actions.lcoProposalStatusHistoryCreateOrUpdate resProposalStatusHistoryCreateOrUpdate2 =  new Actions.lcoProposalStatusHistoryCreateOrUpdate();
public Actions.lcoInitializeProposalWorkflow resInitializeProposalWorkflow =  new Actions.lcoInitializeProposalWorkflow();
public RC_91adc4f46f8a0f51cacc4bc718d2ea35 resGetProposal2_outParamRecord = new RC_91adc4f46f8a0f51cacc4bc718d2ea35();

public RL_d5c1b2482ff109e80580d8b5fb920193 queryResGetSupplierByNumber_outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
public long queryResGetSupplierByNumber_outParamCount = 0L;

public RC_91adc4f46f8a0f51cacc4bc718d2ea35 resGetProposal3_outParamRecord = new RC_91adc4f46f8a0f51cacc4bc718d2ea35();

public RL_060f887b4f32b5cdb78b49175875565c queryResGetCompanyByRFC_outParamList = new RL_060f887b4f32b5cdb78b49175875565c();
public long queryResGetCompanyByRFC_outParamCount = 0L;

public RL_08f794aa2125354ca78c75fb19e7e496 queryResGetFileById_outParamList = new RL_08f794aa2125354ca78c75fb19e7e496();
public long queryResGetFileById_outParamCount = 0L;

public RC_6e3ea28d2c552bc2cc129f42297e5982 resGetFileExtended2_outParamRecord = new RC_6e3ea28d2c552bc2cc129f42297e5982();

public Actions.lcoProposalLogAdd resProposalLogAdd6 =  new Actions.lcoProposalLogAdd();
public Actions.lcoValidateProposalLine resValidateProposalLine =  new Actions.lcoValidateProposalLine();
public Actions.lcoProposalStatusHistoryCreateOrUpdate resProposalStatusHistoryCreateOrUpdate3 =  new Actions.lcoProposalStatusHistoryCreateOrUpdate();
public Actions.lcoProposalFileExtendedCreateOrUpdate resProposalFileExtendedCreateOrUpdate2 =  new Actions.lcoProposalFileExtendedCreateOrUpdate();
public RL_060f887b4f32b5cdb78b49175875565c queryResGetCompanies_outParamList = new RL_060f887b4f32b5cdb78b49175875565c();
public long queryResGetCompanies_outParamCount = 0L;

public Actions.lcoProposalLogAdd resProposalLogAdd2 =  new Actions.lcoProposalLogAdd();
public Actions.lcoProposalLogAdd resProposalLogAdd4 =  new Actions.lcoProposalLogAdd();
public lcvTimerProcessFileIntoProposal() {
}
}
/// <summary>
/// Action <code>TimerProcessFileIntoProposal</code> that represents the Service Studio action
///  <code>TimerProcessFileIntoProposal</code> <p> Description: Action to process files into proposa
/// l records</p>
/// </summary>
public static async Task ActionTimerProcessFileIntoProposal(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvTimerProcessFileIntoProposal localVars = new lcvTimerProcessFileIntoProposal();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("TimerProcessFileIntoProposal", "97109e99-8f5d-423e-8418-cee1b31e2c4f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("TimerProcessFileIntoProposal", "97109e99-8f5d-423e-8418-cee1b31e2c4f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query datasetGetFileExtendeds
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFileExtendeds_maxRecords = 0;
int datasetGetFileExtendeds_startIndex = 0;(localVars.queryResGetFileExtendeds_outParamList,localVars.queryResGetFileExtendeds_outParamCount) = await FuncActionTimerProcessFileIntoProposal.datasetGetFileExtendeds(requestContext,datasetGetFileExtendeds_maxRecords,datasetGetFileExtendeds_startIndex,IterationMultiplicity.Single,cancellationToken);

// Foreach GetFileExtendeds.List
localVars.queryResGetFileExtendeds_outParamList.StartIteration();
try {while (!((localVars.queryResGetFileExtendeds_outParamList.Eof))) {
// l_FileExtendedId = GetFileExtendeds.List.Current.FileExtended.Id
localVars.varLcl_FileExtendedId=localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssId;
// Reset Valid lines
// l_LinesValid = True
localVars.varLcl_LinesValid=true;
// Query datasetGetFileById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFileById_maxRecords = 1;
if (datasetGetFileById_maxRecords < 1) datasetGetFileById_maxRecords = 1;
int datasetGetFileById_startIndex = 0;(localVars.queryResGetFileById_outParamList,localVars.queryResGetFileById_outParamCount) = await FuncActionTimerProcessFileIntoProposal.datasetGetFileById(requestContext,datasetGetFileById_maxRecords,datasetGetFileById_startIndex,IterationMultiplicity.Never,localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssId,cancellationToken);

// VerifyAndValidateFilename
(localVars.resVerifyAndValidateFilename.outParamo_Output,localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData) = await Actions.ActionVerifyAndValidateFilename(requestContext,localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssFilename,false,true,localVars.queryResGetFileById_outParamList.CurrentRec.ssENFile3.ssBinary,cancellationToken);

// l_RegionId = VerifyAndValidateFilename.o_ProposalTempData.RegionId
localVars.varLcl_RegionId=localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssRegionId;
// ProposalCreate
localVars.resProposalCreate.outParamId = await Actions.ActionProposalCreate(requestContext,new EN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssName = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssName, ssPaymentDate = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssPaymentDate, ssProposalDate = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssProposalDate, ssProposalTypeId = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssProposalTypeId, ssBankId = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssBankId, ssProposalStatusId = ((localVars.resVerifyAndValidateFilename.outParamo_Output.ssIsSuccess) ? ((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("7agdijeyhUC3qdG5GpOcAg"))).ssId) : ((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId)), ssFileId = localVars.queryResGetFileById_outParamList.CurrentRec.ssENFile3.ssId, ssTotalProposalLines = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssTotalProposalLines, ssTotalValueML = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssTotalValueML, ssTotalValueMD = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssTotalValueMD, ssCurrencyId = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCurrencyId, ssRegionId = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssRegionId, ssCreatedBy = localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssUploadedBy, ssCreatedOn = localVars.queryResGetFileById_outParamList.CurrentRec.ssENFile3.ssCreatedOn },cancellationToken);

// l_ProposalId = ProposalCreate.Id
localVars.varLcl_ProposalId=localVars.resProposalCreate.outParamId;
// ProposalLogAdd
localVars.resProposalLogAdd.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.varLcl_ProposalId,0L,localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssUploadedBy,(((("Propuesta cargada"+" ")+localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssFilename)+" ")+(((localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssUploadedBy==BuiltInFunction.NullTextIdentifier ())) ? (AppUtils.GetStringResource("Xm680H7dZUegk4n3ix7GbQ#Value.1208795410.1", "(Auto)")) : (AppUtils.GetStringResource("Xm680H7dZUegk4n3ix7GbQ#Value.-801526821.1", "(Manual)")))),false,cancellationToken);

if((localVars.resVerifyAndValidateFilename.outParamo_Output.ssIsSuccess)) {
// Query datasetGetCompanies
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCompanies_maxRecords = 0;
int datasetGetCompanies_startIndex = 0;(localVars.queryResGetCompanies_outParamList,localVars.queryResGetCompanies_outParamCount) = await FuncActionTimerProcessFileIntoProposal.datasetGetCompanies(requestContext,datasetGetCompanies_maxRecords,datasetGetCompanies_startIndex,IterationMultiplicity.Multiple,cancellationToken);

// ListClear
await ExtendedActions.ListClear(requestContext,localVars.varLcl_ErrorList,cancellationToken);

// Lines
// Foreach VerifyAndValidateFilename.o_ProposalTempData.CommissionsAndLeasesFileStructList
localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.StartIteration();
try {while (!((localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.Eof))) {
// ValidateProposalLine
localVars.resValidateProposalLine.outParamo_Output = await Actions.ActionValidateProposalLine(requestContext,localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec,(await RL_c137814ac517b1e8679b0756ef62a588.ConvertAsync(localVars.queryResGetCompanies_outParamList, new RL_c137814ac517b1e8679b0756ef62a588(), async (RC_99a1fa6df481ec5b1908e770c81b73b1 source, EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssDivisionFI,cancellationToken);

// l_LinesValid = If
localVars.varLcl_LinesValid=(((localVars.varLcl_LinesValid==false)) ? (false) : (localVars.resValidateProposalLine.outParamo_Output.ssIsSuccess));
// Query datasetGetCompanyByRFC
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCompanyByRFC_maxRecords = 1;
if (datasetGetCompanyByRFC_maxRecords < 1) datasetGetCompanyByRFC_maxRecords = 1;
int datasetGetCompanyByRFC_startIndex = 0;(localVars.queryResGetCompanyByRFC_outParamList,localVars.queryResGetCompanyByRFC_outParamCount) = await FuncActionTimerProcessFileIntoProposal.datasetGetCompanyByRFC(requestContext,datasetGetCompanyByRFC_maxRecords,datasetGetCompanyByRFC_startIndex,IterationMultiplicity.Never,localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssSoc,cancellationToken);

// Query datasetGetSupplierByNumber
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplierByNumber_maxRecords = 1;
if (datasetGetSupplierByNumber_maxRecords < 1) datasetGetSupplierByNumber_maxRecords = 1;
int datasetGetSupplierByNumber_startIndex = 0;(localVars.queryResGetSupplierByNumber_outParamList,localVars.queryResGetSupplierByNumber_outParamCount) = await FuncActionTimerProcessFileIntoProposal.datasetGetSupplierByNumber(requestContext,datasetGetSupplierByNumber_maxRecords,datasetGetSupplierByNumber_startIndex,IterationMultiplicity.Never,localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssCuenta,cancellationToken);

// CreateProposalLine
localVars.resCreateProposalLine_outParamId = await ExtendedActions.CreateProposalLine(requestContext,new RC_cbff39127609a0f830b2d34948d1c019(){ ssENProposalLine = new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord(){ ssProposalId = localVars.resProposalCreate.outParamId, ssApprovalStatusId = ((localVars.resValidateProposalLine.outParamo_Output.ssIsSuccess) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("I4VnodzG6ke+WTu4gjHzUQ"))).ssId)), ssCompanyId = localVars.queryResGetCompanyByRFC_outParamList.CurrentRec.ssENCompany.ssId, ssSupplierId = localVars.queryResGetSupplierByNumber_outParamList.CurrentRec.ssENSupplier.ssId, ssFe_contab_ = BuiltInFunction.TextToDate (localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssFeContab), ssEj__mes = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssEjMes, ssCuenta = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssCuenta, ssReferencia = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssReferencia, ssNombre1 = ((localVars.queryResGetSupplierByNumber_outParamList.Empty) ? (localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssNombre1) : (localVars.queryResGetSupplierByNumber_outParamList.CurrentRec.ssENSupplier.ssName)), ssNombre2 = "", ssN_doc_ = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssNDoc, ssN_DocType = ((((localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssProposalTypeId==(ENProposalTypeEntity.GetRecordByKey(ObjectKey.Parse("GVjPmq9Y3UikKDjYWKOleg"))).ssId)) ? ("COM") : ("ARR"))+localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssNDoc), ssImporteenML = BuiltInFunction.TextToDecimal (localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssImporteEnML), ssML = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssML, ssImporteenMD = BuiltInFunction.TextToDecimal (localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssImporteEnMD), ssMon_ = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssMon, ssSoc_ = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssSoc, ssDiv_ = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssDiv, ssLib_mayor = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssLibMayor, ssTextocab_documento = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssTextoCabDocumento, ssDoc_comp_ = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssDocComp, ssHasErrors = (!localVars.resValidateProposalLine.outParamo_Output.ssIsSuccess), ssErrorMessage = localVars.resValidateProposalLine.outParamo_Output.ssMessage } },cancellationToken);

if(((!localVars.resValidateProposalLine.outParamo_Output.ssIsSuccess))) {
// ProposalLogDocumentAdd2
localVars.resProposalLogDocumentAdd2.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.varLcl_ProposalId,localVars.resCreateProposalLine_outParamId,BuiltInFunction.NullTextIdentifier (),((((("Archivo"+" ")+(((localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssProposalTypeId==(ENProposalTypeEntity.GetRecordByKey(ObjectKey.Parse("GVjPmq9Y3UikKDjYWKOleg"))).ssId)) ? ("COM") : ("ARR")))+localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssNDoc)+" ")+"creado con error."),true,cancellationToken);

// ListAppendErrors
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_ErrorList,new ST_37eba272293c59d7cf1400fbd0fb4b40Structure(){ ssDocument = ((((localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssProposalTypeId==(ENProposalTypeEntity.GetRecordByKey(ObjectKey.Parse("GVjPmq9Y3UikKDjYWKOleg"))).ssId)) ? ("COM") : ("ARR"))+localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssNDoc), ssError = localVars.resValidateProposalLine.outParamo_Output.ssMessage },cancellationToken);

} else {
// ProposalLogDocumentAdd
localVars.resProposalLogDocumentAdd.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.varLcl_ProposalId,localVars.resCreateProposalLine_outParamId,BuiltInFunction.NullTextIdentifier (),((((("Archivo"+" ")+(((localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssProposalTypeId==(ENProposalTypeEntity.GetRecordByKey(ObjectKey.Parse("GVjPmq9Y3UikKDjYWKOleg"))).ssId)) ? ("COM") : ("ARR")))+localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.CurrentRec.ssNDoc)+" ")+"creado."),false,cancellationToken);

}

localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.Advance();
}

} finally {
localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssCommissionsAndLeasesFileStructList.EndIteration();
}

// GetProposal
localVars.resGetProposal_outParamRecord = await ExtendedActions.GetProposal(requestContext,localVars.resProposalCreate.outParamId,cancellationToken);

// GetProposal.Record.Proposal.TotalValueML = VerifyAndValidateFilename.o_ProposalTempData.TotalValueML
localVars.resGetProposal_outParamRecord.ssENProposal.ssTotalValueML = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssTotalValueML;

// GetProposal.Record.Proposal.TotalValueMD = VerifyAndValidateFilename.o_ProposalTempData.TotalValueMD
localVars.resGetProposal_outParamRecord.ssENProposal.ssTotalValueMD = localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssTotalValueMD;

// GetProposal.Record.Proposal.ProposalStatusId = If
localVars.resGetProposal_outParamRecord.ssENProposal.ssProposalStatusId = ((localVars.varLcl_LinesValid) ? ((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("7agdijeyhUC3qdG5GpOcAg"))).ssId) : ((ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId));
// GetFileExtendeds.List.Current.FileExtended.IsProcessed = True
localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssIsProcessed = true;

// GetFileExtendeds.List.Current.FileExtended.HasError = notl_LinesValid
localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssHasError = (!localVars.varLcl_LinesValid);

// GetFileExtendeds.List.Current.FileExtended.ErrorMessage = If
localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssErrorMessage = ((localVars.varLcl_LinesValid) ? ("") : ("Errores encontrados en los pagos de propuestas."));
if((!(localVars.varLcl_LinesValid))) {
// ProposalLogAdd2
localVars.resProposalLogAdd2.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.varLcl_ProposalId,0L,localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssUploadedBy,"Errores encontrados en los pagos de propuestas.",true,cancellationToken);

}

if(((localVars.resGetProposal_outParamRecord.ssENProposal.ssProposalStatusId!=(ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId))) {
// InitializeProposalWorkflow
localVars.resInitializeProposalWorkflow.outParamo_Output = await Actions.ActionInitializeProposalWorkflow(requestContext,(((localVars.resVerifyAndValidateFilename.outParamo_ProposalTempData.ssProposalTypeId==(ENProposalTypeEntity.GetRecordByKey(ObjectKey.Parse("GVjPmq9Y3UikKDjYWKOleg"))).ssId)) ? ("COM") : ("ARR")),localVars.varLcl_ProposalId,cancellationToken);

if((localVars.resInitializeProposalWorkflow.outParamo_Output.ssIsSuccess)) {
// ProposalLogAdd5
localVars.resProposalLogAdd5.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.resProposalCreate.outParamId,0L,localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssUploadedBy,"Esta propuesta ha pasado con éxito la verificación del sistema.",false,cancellationToken);

} else {
// GetProposal.Record.Proposal.ProposalStatusId = ErrorAPI
localVars.resGetProposal_outParamRecord.ssENProposal.ssProposalStatusId = (ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId;

// GetFileExtendeds.List.Current.FileExtended.HasError = True
localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssHasError = true;

// GetFileExtendeds.List.Current.FileExtended.ErrorMessage = InitializeProposalWorkflow.o_Output.Message
localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssErrorMessage = localVars.resInitializeProposalWorkflow.outParamo_Output.ssMessage;
// ProposalLogAdd4
localVars.resProposalLogAdd4.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.resProposalCreate.outParamId,0L,localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssUploadedBy,"Esta propuesta tuvo un error durante el flujo de trabajo de la API. Por favor, verifíquela.",true,cancellationToken);

}

}

// UpdateFileExtended
await ExtendedActions.UpdateFileExtended(requestContext,localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ChangedAttributes,localVars.queryResGetFileExtendeds_outParamList.CurrentRec,cancellationToken);

// UpdateProposal
await ExtendedActions.UpdateProposal(requestContext,localVars.resGetProposal_outParamRecord.ChangedAttributes,localVars.resGetProposal_outParamRecord,cancellationToken);

// ProposalStatusHistoryCreateOrUpdate2
localVars.resProposalStatusHistoryCreateOrUpdate2.outParamId = await Actions.ActionProposalStatusHistoryCreateOrUpdate(requestContext,new EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssProposalId = localVars.resGetProposal_outParamRecord.ssENProposal.ssId, ssProposalStatusId = localVars.resGetProposal_outParamRecord.ssENProposal.ssProposalStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

if((!(localVars.varLcl_LinesValid))) {
// SendErrorAPI2
await Actions.ActionSendErrorAPI(requestContext,localVars.queryResGetFileExtendeds_outParamList.CurrentRec.ssENFileExtended.ssFilename,localVars.varLcl_ErrorList,cancellationToken);

}

} else {
// RaiseError IncorrectFilename
throw new Ex_IncorrectFilenameUserException (((AppUtils.GetStringResource("Bf8yWF_lU0KWhBIetNrQZA#Message.1011958934.1", "Hay un problema con el nombre del archivo:")+" ")+localVars.resVerifyAndValidateFilename.outParamo_Output.ssMessage));

}

localVars.queryResGetFileExtendeds_outParamList.Advance();
}

} finally {
localVars.queryResGetFileExtendeds_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

catch (Ex_SendingEmailUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler

// GetFileExtended2
localVars.resGetFileExtended2_outParamRecord = await ExtendedActions.GetFileExtended(requestContext,localVars.varLcl_FileExtendedId,cancellationToken);

// GetProposal3
localVars.resGetProposal3_outParamRecord = await ExtendedActions.GetProposal(requestContext,localVars.varLcl_ProposalId,cancellationToken);

// GetFileExtended2.Record.FileExtended.IsProcessed = True
localVars.resGetFileExtended2_outParamRecord.ssENFileExtended.ssIsProcessed = true;

// GetFileExtended2.Record.FileExtended.HasError = True
localVars.resGetFileExtended2_outParamRecord.ssENFileExtended.ssHasError = true;

// GetFileExtended2.Record.FileExtended.ErrorMessage = "Propuesta procesada correctamente, pero error al enviar la notificación."
localVars.resGetFileExtended2_outParamRecord.ssENFileExtended.ssErrorMessage = "Propuesta procesada correctamente, pero error al enviar la notificación.";

// GetProposal3.Record.Proposal.ProposalStatusId = ErrorAPI
localVars.resGetProposal3_outParamRecord.ssENProposal.ssProposalStatusId = (ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId;
// ProposalFileExtendedCreateOrUpdate2
localVars.resProposalFileExtendedCreateOrUpdate2.outParamId = await Actions.ActionProposalFileExtendedCreateOrUpdate(requestContext,localVars.resGetFileExtended2_outParamRecord.ssENFileExtended,cancellationToken);

// ProposalCreateOrUpdate2
localVars.resProposalCreateOrUpdate2.outParamId = await Actions.ActionProposalCreateOrUpdate(requestContext,localVars.resGetProposal3_outParamRecord.ssENProposal,cancellationToken);

// ProposalStatusHistoryCreateOrUpdate3
localVars.resProposalStatusHistoryCreateOrUpdate3.outParamId = await Actions.ActionProposalStatusHistoryCreateOrUpdate(requestContext,new EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssProposalId = localVars.resGetProposal3_outParamRecord.ssENProposal.ssId, ssProposalStatusId = localVars.resGetProposal3_outParamRecord.ssENProposal.ssProposalStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// ProposalLogAdd6
localVars.resProposalLogAdd6.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.resProposalCreateOrUpdate2.outParamId,0L,localVars.resGetFileExtended2_outParamRecord.ssENFileExtended.ssUploadedBy,AppUtils.GetStringResource("YstQU36moUqYxsI8YvPgcA#Value.1210352581.1", "Algo salió mal con esta propuesta. Por favor, verifíquela."),true,cancellationToken);

goto RETURN_STATEMENT;

} // Catch
catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler

// GetFileExtended
localVars.resGetFileExtended_outParamRecord = await ExtendedActions.GetFileExtended(requestContext,localVars.varLcl_FileExtendedId,cancellationToken);

// GetProposal2
localVars.resGetProposal2_outParamRecord = await ExtendedActions.GetProposal(requestContext,localVars.varLcl_ProposalId,cancellationToken);

// GetFileExtended.Record.FileExtended.IsProcessed = True
localVars.resGetFileExtended_outParamRecord.ssENFileExtended.ssIsProcessed = true;

// GetFileExtended.Record.FileExtended.HasError = True
localVars.resGetFileExtended_outParamRecord.ssENFileExtended.ssHasError = true;

// GetFileExtended.Record.FileExtended.ErrorMessage = AllExceptions.ExceptionMessage
localVars.resGetFileExtended_outParamRecord.ssENFileExtended.ssErrorMessage = ex.Message;

// GetProposal2.Record.Proposal.ProposalStatusId = ErrorAPI
localVars.resGetProposal2_outParamRecord.ssENProposal.ssProposalStatusId = (ENProposalStatusEntity.GetRecordByKey(ObjectKey.Parse("OSpEADv8F0q4Sge4sU9mWA"))).ssId;
// ProposalFileExtendedCreateOrUpdate
localVars.resProposalFileExtendedCreateOrUpdate.outParamId = await Actions.ActionProposalFileExtendedCreateOrUpdate(requestContext,localVars.resGetFileExtended_outParamRecord.ssENFileExtended,cancellationToken);

// ProposalCreateOrUpdate
localVars.resProposalCreateOrUpdate.outParamId = await Actions.ActionProposalCreateOrUpdate(requestContext,localVars.resGetProposal2_outParamRecord.ssENProposal,cancellationToken);

// ProposalStatusHistoryCreateOrUpdate
localVars.resProposalStatusHistoryCreateOrUpdate.outParamId = await Actions.ActionProposalStatusHistoryCreateOrUpdate(requestContext,new EN_f6d34ae04169ae9164103e8797ea11d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssProposalId = localVars.resGetProposal2_outParamRecord.ssENProposal.ssId, ssProposalStatusId = localVars.resGetProposal2_outParamRecord.ssENProposal.ssProposalStatusId, ssTimeStamp = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// ProposalLogAdd3
localVars.resProposalLogAdd3.outParamo_ProposalLogId = await Actions.ActionProposalLogAdd(requestContext,localVars.resProposalCreateOrUpdate.outParamId,0L,localVars.resGetFileExtended_outParamRecord.ssENFileExtended.ssUploadedBy,AppUtils.GetStringResource("4OmZScWJ9k21D4gKqRaZ9g#Value.1210352581.1", "Algo salió mal con esta propuesta. Por favor, verifíquela."),true,cancellationToken);

// SendErrorAPI
await Actions.ActionSendErrorAPI(requestContext,localVars.resGetFileExtended_outParamRecord.ssENFileExtended.ssFilename,localVars.varLcl_ErrorList,cancellationToken);

goto RETURN_STATEMENT;

} // Catch
finally {
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionTimerProcessFileIntoProposal {

// Query Function "GetFileExtendeds" uipDVpxHBEOzZ9PuynAjrA of Action "TimerProcessFileIntoProposal"
public static async Task<(RL_6de96902c907b264dc4c48e378eca40b,long)> datasetGetFileExtendeds(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("TimerProcessFileIntoProposal.GetFileExtendeds", "56432aba-479c-4304-b367-d3eeca7023ac");
using var queryActivity = activitySource.CreateAggregateQueryActivity("TimerProcessFileIntoProposal.GetFileExtendeds", "56432aba-479c-4304-b367-d3eeca7023ac", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.mZ4Ql12PPkKEGM7hsx4sTw/NodesNotShownInESpaceTree.uipDVpxHBEOzZ9PuynAjrA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfileextended1\".\"id\" o0, \"enfileextended1\".\"filename\" o1, \"enfileextended1\".\"isprocessed\" o2, \"enfileextended1\".\"haserror\" o3, \"enfileextended1\".\"errormessage\" o4, \"enfileextended1\".\"uploadedby\" o5, NULL o6");
fromBuilder.Append(" FROM {FileExtended} \"enfileextended1\"");
whereBuilder.Append(" WHERE (\"enfileextended1\".\"isprocessed\" = 0)");
orderByBuilder.Append(" ORDER BY \"enfileextended1\".\"id\" DESC ");
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
RL_6de96902c907b264dc4c48e378eca40b outParamList = new RL_6de96902c907b264dc4c48e378eca40b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TimerProcessFileIntoProposal.GetFileExtendeds.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6de96902c907b264dc4c48e378eca40b _tmp = new RL_6de96902c907b264dc4c48e378eca40b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TimerProcessFileIntoProposal.GetFileExtendeds.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6de96902c907b264dc4c48e378eca40b)_tmp;
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

// Query Function "GetSupplierByNumber" liGQrwFpfEKxHZ02JPeBEA of Action "TimerProcessFileIntoProposal"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSupplierByNumber(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("TimerProcessFileIntoProposal.GetSupplierByNumber", "af902196-6901-427c-b11d-9d3624f78110");
using var queryActivity = activitySource.CreateAggregateQueryActivity("TimerProcessFileIntoProposal.GetSupplierByNumber", "af902196-6901-427c-b11d-9d3624f78110", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.mZ4Ql12PPkKEGM7hsx4sTw/NodesNotShownInESpaceTree.liGQrwFpfEKxHZ02JPeBEA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"ensupplier25\".\"id\" o0, NULL o1, \"ensupplier25\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier25\"");
whereBuilder.Append(" WHERE (caseaccent_normalize(\"ensupplier25\".\"number\" collate \"default\") like caseaccent_normalize(@qpteNumber collate \"default\"))");
sqlCmd.CreateParameterWithoutReplacements("@qpteNumber", DbType.String, qpteNumber);
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
RL_d5c1b2482ff109e80580d8b5fb920193 outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TimerProcessFileIntoProposal.GetSupplierByNumber.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d5c1b2482ff109e80580d8b5fb920193 _tmp = new RL_d5c1b2482ff109e80580d8b5fb920193();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TimerProcessFileIntoProposal.GetSupplierByNumber.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d5c1b2482ff109e80580d8b5fb920193)_tmp;
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

// Query Function "GetCompanyByRFC" r6Kcx2oZ4k65bAE9VwAIuA of Action "TimerProcessFileIntoProposal"
public static async Task<(RL_060f887b4f32b5cdb78b49175875565c,long)> datasetGetCompanyByRFC(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteRFC,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("TimerProcessFileIntoProposal.GetCompanyByRFC", "c79ca2af-196a-4ee2-b96c-013d570008b8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("TimerProcessFileIntoProposal.GetCompanyByRFC", "c79ca2af-196a-4ee2-b96c-013d570008b8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.mZ4Ql12PPkKEGM7hsx4sTw/NodesNotShownInESpaceTree.r6Kcx2oZ4k65bAE9VwAIuA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany6\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {Company} \"encompany6\"");
whereBuilder.Append(" WHERE (caseaccent_normalize(\"encompany6\".\"rfc\" collate \"default\") like caseaccent_normalize(@qpteRFC collate \"default\"))");
orderByBuilder.Append(" ORDER BY \"encompany6\".\"description\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpteRFC", DbType.String, qpteRFC);
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
RL_060f887b4f32b5cdb78b49175875565c outParamList = new RL_060f887b4f32b5cdb78b49175875565c();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TimerProcessFileIntoProposal.GetCompanyByRFC.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_060f887b4f32b5cdb78b49175875565c _tmp = new RL_060f887b4f32b5cdb78b49175875565c();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TimerProcessFileIntoProposal.GetCompanyByRFC.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_060f887b4f32b5cdb78b49175875565c)_tmp;
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

// Query Function "GetFileById" 3JTGzuCFfkuCm_4HFgerpA of Action "TimerProcessFileIntoProposal"
public static async Task<(RL_08f794aa2125354ca78c75fb19e7e496,long)> datasetGetFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfiId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("TimerProcessFileIntoProposal.GetFileById", "cec694dc-85e0-4b7e-829b-fe071607aba4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("TimerProcessFileIntoProposal.GetFileById", "cec694dc-85e0-4b7e-829b-fe071607aba4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.mZ4Ql12PPkKEGM7hsx4sTw/NodesNotShownInESpaceTree.3JTGzuCFfkuCm_4HFgerpA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfile31\".\"id\" o0, \"enfile31\".\"binary\" o1, NULL o2, \"enfile31\".\"createdon\" o3");
fromBuilder.Append(" FROM {File3} \"enfile31\"");
whereBuilder.Append(" WHERE ");
if (qpfiId != 0) {
whereBuilder.Append("((\"enfile31\".\"id\" = @qpfiId) AND (\"enfile31\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfiId", DbType.Int64, qpfiId);
} else {
whereBuilder.Append("(\"enfile31\".\"id\" IS NULL)");
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
RL_08f794aa2125354ca78c75fb19e7e496 outParamList = new RL_08f794aa2125354ca78c75fb19e7e496();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TimerProcessFileIntoProposal.GetFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_08f794aa2125354ca78c75fb19e7e496 _tmp = new RL_08f794aa2125354ca78c75fb19e7e496();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TimerProcessFileIntoProposal.GetFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_08f794aa2125354ca78c75fb19e7e496)_tmp;
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

// Query Function "GetCompanies" wJIA7V3gR0OA+bjGToMlgA of Action "TimerProcessFileIntoProposal"
public static async Task<(RL_060f887b4f32b5cdb78b49175875565c,long)> datasetGetCompanies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("TimerProcessFileIntoProposal.GetCompanies", "ed0092c0-e05d-4347-80f9-b8c64e832580");
using var queryActivity = activitySource.CreateAggregateQueryActivity("TimerProcessFileIntoProposal.GetCompanies", "ed0092c0-e05d-4347-80f9-b8c64e832580", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.mZ4Ql12PPkKEGM7hsx4sTw/NodesNotShownInESpaceTree.wJIA7V3gR0OA+bjGToMlgA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany7\".\"id\" o0, \"encompany7\".\"externalid\" o1, \"encompany7\".\"description\" o2, \"encompany7\".\"rfc\" o3, \"encompany7\".\"postalcode\" o4, \"encompany7\".\"cyaimport\" o5, \"encompany7\".\"fspuse\" o6, \"encompany7\".\"createdon\" o7, \"encompany7\".\"createdby\" o8, \"encompany7\".\"updatedon\" o9, \"encompany7\".\"updatedby\" o10");
fromBuilder.Append(" FROM {Company} \"encompany7\"");
whereBuilder.Append(" WHERE (\"encompany7\".\"cyaimport\" = 1)");
orderByBuilder.Append(" ORDER BY \"encompany7\".\"externalid\" ASC ");
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
RL_060f887b4f32b5cdb78b49175875565c outParamList = new RL_060f887b4f32b5cdb78b49175875565c();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query TimerProcessFileIntoProposal.GetCompanies.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_060f887b4f32b5cdb78b49175875565c _tmp = new RL_060f887b4f32b5cdb78b49175875565c();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query TimerProcessFileIntoProposal.GetCompanies.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_060f887b4f32b5cdb78b49175875565c)_tmp;
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
