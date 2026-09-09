namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersImport_OrderCreate : VarsBag {
public ST_9c87dd52bd762501ef8a064794927f08Structure inParamOrdersRequest;
public long inParamCompanyId;
public long inParamDocumentTypeId;
public long inParamSupplierId;
public long inParamRegionId;
/// <summary>
/// Variable <code>TotalAmount</code> that represents the Service Studio Currency
///  <code>TotalAmount</code> <p>Description: </p>
/// </summary>
public decimal varLcTotalAmount = 0.0M;

/// <summary>
/// Variable <code>OrderMain</code> that represents the Service Studio OrderMain <code>OrderMain</code>
///  <p>Description: </p>
/// </summary>
public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord varLcOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();

/// <summary>
/// Variable <code>OrderMainItems</code> that represents the Service Studio OrderMainItemList
///  <code>OrderMainItems</code> <p>Description: </p>
/// </summary>
public RL_36053b0a011ac5d2d2fe088489de85e6 varLcOrderMainItems = new RL_36053b0a011ac5d2d2fe088489de85e6();

/// <summary>
/// Variable <code>ErrorsList</code> that represents the Service Studio TextRecordList
///  <code>ErrorsList</code> <p>Description: </p>
/// </summary>
public RL_df53376d76478ddd40257fed0b6f76e8 varLcErrorsList = new RL_df53376d76478ddd40257fed0b6f76e8();

public RL_1fd700228cc5fdbb5577ed3fdc4f16ac queryResGetIdentifiers_outParamList = new RL_1fd700228cc5fdbb5577ed3fdc4f16ac();
public long queryResGetIdentifiers_outParamCount = 0L;

public Actions.lcoOrderMainItemCreateOrUpdate resOrderMainItemCreateOrUpdate =  new Actions.lcoOrderMainItemCreateOrUpdate();
public string resString_Join_outParamText = "";

public string resString_Join3_outParamText = "";

public Actions.lcoOrderMainCreateOrUpdate resOrderMainCreateOrUpdate =  new Actions.lcoOrderMainCreateOrUpdate();
public string resString_Join2_outParamText = "";

public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public lcvOrdersImport_OrderCreate(ST_9c87dd52bd762501ef8a064794927f08Structure inParamOrdersRequest, long inParamCompanyId, long inParamDocumentTypeId, long inParamSupplierId, long inParamRegionId) {
this.inParamOrdersRequest = inParamOrdersRequest;
this.inParamCompanyId = inParamCompanyId;
this.inParamDocumentTypeId = inParamDocumentTypeId;
this.inParamSupplierId = inParamSupplierId;
this.inParamRegionId = inParamRegionId;
}
}
public class lcoOrdersImport_OrderCreate : VarsBag {
public ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = new ST_9f3831cec6ebd34416b59b8df7a27893Structure();

public lcoOrdersImport_OrderCreate() {
}
}
/// <summary>
/// Action <code>OrdersImport_OrderCreate</code> that represents the Service Studio action
///  <code>OrdersImport_OrderCreate</code> <p> Description: </p>
/// </summary>
public static async Task<ST_9f3831cec6ebd34416b59b8df7a27893Structure> ActionOrdersImport_OrderCreate(IRequestContext requestContext,ST_9c87dd52bd762501ef8a064794927f08Structure inParamOrdersRequest,long inParamCompanyId,long inParamDocumentTypeId,long inParamSupplierId,long inParamRegionId,CancellationToken cancellationToken) {
ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = default;
lcoOrdersImport_OrderCreate result = new lcoOrdersImport_OrderCreate();
lcvOrdersImport_OrderCreate localVars = new lcvOrdersImport_OrderCreate(inParamOrdersRequest, inParamCompanyId, inParamDocumentTypeId, inParamSupplierId, inParamRegionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersImport_OrderCreate", "d721c95d-3415-4aed-9bfd-d3cfa1e139da"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersImport_OrderCreate", "d721c95d-3415-4aed-9bfd-d3cfa1e139da", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach OrdersRequest.OrderItems
localVars.inParamOrdersRequest.ssOrderItems.StartIteration();
try {while (!((localVars.inParamOrdersRequest.ssOrderItems.Eof))) {
// Query QueryGetIdentifiers
cancellationToken.ThrowIfCancellationRequested();
int QueryGetIdentifiers_maxRecords = 0;
int QueryGetIdentifiers_startIndex = 0;(localVars.queryResGetIdentifiers_outParamList,localVars.queryResGetIdentifiers_outParamCount) = await FuncActionOrdersImport_OrderCreate.QueryGetIdentifiers(requestContext,QueryGetIdentifiers_maxRecords,QueryGetIdentifiers_startIndex,IterationMultiplicity.Multiple,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssDocumentClass,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssCostCenter,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssCenter,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssGLAccountNumber,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssBusinessArea,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssDirection,cancellationToken);

// ControledLogMessage
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),(((((((((((((((((((((("RowNumber "+BuiltInFunction.IntegerToText (localVars.inParamOrdersRequest.ssOrderItems.CurrentRowNumber))+" | ")+"DocumentClass: ")+localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssDocumentClass)+" (")+BuiltInFunction.LongIntegerToText (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTDocumentClassId.ssValue))+") | ")+"CostCenter: ")+localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssCostCenter)+" (")+BuiltInFunction.LongIntegerToText (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTCostCenterId.ssValue))+") | ")+"Center: ")+localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssCenter)+" (")+BuiltInFunction.LongIntegerToText (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTRegionId.ssValue))+") | ")+"GLAccountNumber: ")+localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssGLAccountNumber)+" (")+BuiltInFunction.LongIntegerToText (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTServiceTypeId.ssValue))+")"),"OrdersImport_OrderCreate",cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcOrderMainItems,new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderMainId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssPosition = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssPosition, ssMaterialCode = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssArticleNr, ssMaterialDescription = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssArticleDescription, ssAssigmnentCode = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssImputationCode, ssDocumentClassId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTDocumentClassId.ssValue), ssDeliveryDate = (await Functions.ActionDateValidate(requestContext,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssDeliveryDate,((((string)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportDefaultDateFormat]))),false,cancellationToken)).ssDate, ssQuantity = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssQuantity, ssUnitType = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssUnitType, ssUnitPrice = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssUnitPrice, ssBaseQuantity = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssBaseQuantity, ssIsDeleted = (localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssChangeIndicator=="L"), ssIsBlocked = (localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssChangeIndicator=="S"), ssIsFinalDelivery = (localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssFinalDelivery=="X"), ssGLAccountId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTServiceTypeId.ssValue), ssCostCenterId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTCostCenterId.ssValue), ssFundsCenter = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssFundsCenter, ssFund = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssFund, ssCommitmentItem = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssCommitmentItem, ssVATIndicator = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssVATIndicator, ssVATProcedure = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssVATProcedure, ssVATRate = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssVATRate, ssPurchaseRequisitionNumber = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssPurchaseRequisitionNumber, ssPurchaseRequisitionItemNr = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssPurchaseRequisitionItemNumber, ssRegionId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTRegionId.ssValue), ssCenter = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssCenter, ssPEPElement = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssPEPElement, ssQuantityDelivered = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssDeliveredQuantity, ssOrderUnitOfMeasure = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssUMP, ssApplicant = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssApplicant, ssDirection = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssDirection, ssContractNumber = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssContractNumber, ssContractPosition = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssContractPosition, ssContractStartDate = (await Functions.ActionDateValidate(requestContext,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssContractStartDate,((((string)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportDefaultDateFormat]))),false,cancellationToken)).ssDate, ssContractEndDate = (await Functions.ActionDateValidate(requestContext,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssContractEndDate,((((string)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportDefaultDateFormat]))),false,cancellationToken)).ssDate, ssContractPlannedValue = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssContractPlannedValue, ssPositionType = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssPositionType, ssSerialNumberProfile = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssSerialNumberProfile, ssBatchManaged = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssBatchManaged, ssMaterialType = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssMaterialType, ssItemGroup = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssItemGroup, ssOrderRequestCreatorSAPNumber = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssCreatingUser, ssIsMultipleImputation = (BuiltInFunction.Trim (localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssCostCenter)=="IMPUT-MULT"), ssInvoiceUsageId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTInvoiceUsageId.ssValue), ssOrderMainItemStatusId = (ENOrderMainItemStatusEntity.GetRecordByKey(ObjectKey.Parse("Ca+WgIpOj0CuJbhSpYSjFw"))).ssId, ssDivisionId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTDivisionId.ssValue) },cancellationToken);

// OrderMain.DivisionId = If
localVars.varLcOrderMain.ssDivisionId = ((localVars.varLcOrderMainItems.Empty) ? (localVars.varLcOrderMain.ssDivisionId) : (localVars.varLcOrderMainItems[0].ssDivisionId));

// OrderMain.TelcelDirectionId = If
localVars.varLcOrderMain.ssTelcelDirectionId = (((localVars.varLcOrderMain.ssTelcelDirectionId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList[0].ssSTDirectionId.ssValue)) : (localVars.varLcOrderMain.ssTelcelDirectionId));

// OrderMain.Applicant = If
localVars.varLcOrderMain.ssApplicant = ((localVars.varLcOrderMainItems.Empty) ? (localVars.varLcOrderMain.ssApplicant) : (localVars.varLcOrderMainItems[0].ssApplicant));

// TotalAmount = TotalAmount + If
localVars.varLcTotalAmount=(localVars.varLcTotalAmount+((((localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssChangeIndicator=="L")||(localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssChangeIndicator=="S"))) ? ((((decimal)0))) : ((localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssQuantity*((decimal)localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssUnitPrice/
(decimal)(((decimal)localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssBaseQuantity)))))));

// OrderMain.AssignmentCode = If
localVars.varLcOrderMain.ssAssignmentCode = ((localVars.varLcOrderMainItems.Empty) ? (localVars.varLcOrderMain.ssAssignmentCode) : (localVars.varLcOrderMainItems[0].ssAssigmnentCode));
localVars.inParamOrdersRequest.ssOrderItems.Advance();
}

} finally {
localVars.inParamOrdersRequest.ssOrderItems.EndIteration();
}

// OrderMain
// OrderMain.Id = NullIdentifier
localVars.varLcOrderMain.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// OrderMain.OrderNumber = Trim
localVars.varLcOrderMain.ssOrderNumber = BuiltInFunction.Trim (localVars.inParamOrdersRequest.ssOrderNumber);

// OrderMain.OrderDate = DateValidate(OrdersRequest.OrderDate, OrdersImportDefaultDateFormat, True).Date
localVars.varLcOrderMain.ssOrderDate = (await Functions.ActionDateValidate(requestContext,localVars.inParamOrdersRequest.ssOrderDate,((((string)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportDefaultDateFormat]))),true,cancellationToken)).ssDate;

// OrderMain.OrderStatusId = ToComplement
localVars.varLcOrderMain.ssOrderStatusId = (ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("BHvVtSdSlUixsh+41KTCZg"))).ssId;

// OrderMain.SupplierId = SupplierId
localVars.varLcOrderMain.ssSupplierId = localVars.inParamSupplierId;

// OrderMain.ProcurementGroup = OrdersRequest.ProcurementGroup
localVars.varLcOrderMain.ssProcurementGroup = localVars.inParamOrdersRequest.ssProcurementGroup;

// OrderMain.CreatorSAPNumber = OrdersRequest.CreatedBy
localVars.varLcOrderMain.ssCreatorSAPNumber = localVars.inParamOrdersRequest.ssCreatedBy;

// OrderMain.CreatorSAPName = OrdersRequest.CreatedByName
localVars.varLcOrderMain.ssCreatorSAPName = localVars.inParamOrdersRequest.ssCreatedByName;

// OrderMain.CompanyId = CompanyId
localVars.varLcOrderMain.ssCompanyId = localVars.inParamCompanyId;

// OrderMain.Country = OrdersRequest.CountryCode
localVars.varLcOrderMain.ssCountry = localVars.inParamOrdersRequest.ssCountryCode;

// OrderMain.IsDeleted = OrdersRequest.DeletedIndicator = "C"
localVars.varLcOrderMain.ssIsDeleted = (localVars.inParamOrdersRequest.ssDeletedIndicator=="C");

// OrderMain.IsReleased = OrdersRequest.Released = "S" or Trim = ""
localVars.varLcOrderMain.ssIsReleased = ((localVars.inParamOrdersRequest.ssReleased=="S")||(BuiltInFunction.Trim (localVars.inParamOrdersRequest.ssReleased)==""));

// OrderMain.ExchangeRate = OrdersRequest.ExchangeRate
localVars.varLcOrderMain.ssExchangeRate = localVars.inParamOrdersRequest.ssExchangeRate;

// OrderMain.SustainabilityCategory = OrdersRequest.SustainabilityCategory
localVars.varLcOrderMain.ssSustainabilityCategory = localVars.inParamOrdersRequest.ssSustainabilityCategory;

// OrderMain.SustainabilitySubcategory = OrdersRequest.SustainabilitySubcategory
localVars.varLcOrderMain.ssSustainabilitySubcategory = localVars.inParamOrdersRequest.ssSustainabilitySubcategory;

// OrderMain.TotalAmount = TextToDecimal
localVars.varLcOrderMain.ssTotalAmount = BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal (localVars.varLcTotalAmount, 2, ".", ""));

// OrderMain.DocumentTypeId = DocumentTypeId
localVars.varLcOrderMain.ssDocumentTypeId = localVars.inParamDocumentTypeId;

// OrderMain.CurrencyId = TextToIdentifier
localVars.varLcOrderMain.ssCurrencyId = BuiltInFunction.TextToIdentifier (localVars.inParamOrdersRequest.ssCurrencyCode);

// OrderMain.RegionId = RegionId
localVars.varLcOrderMain.ssRegionId = localVars.inParamRegionId;
// OrderMainCreateOrUpdate
(localVars.resOrderMainCreateOrUpdate.outParamId,localVars.resOrderMainCreateOrUpdate.outParamHasSuccess,localVars.resOrderMainCreateOrUpdate.outParamErrorMessage,localVars.resOrderMainCreateOrUpdate.outParamSource_Out) = await Actions.ActionOrderMainCreateOrUpdate(requestContext,localVars.varLcOrderMain,cancellationToken);

// error?
if(((!localVars.resOrderMainCreateOrUpdate.outParamHasSuccess))) {
// ListAppend2
await ExtendedActions.ListAppend(requestContext,localVars.varLcErrorsList,new RC_ca61515b5f1b81a3f63a72f69693ae36(){ ssText = localVars.resOrderMainCreateOrUpdate.outParamErrorMessage },cancellationToken);

// String_Join
localVars.resString_Join_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.varLcErrorsList, new RLTextRecordList(), async (RC_ca61515b5f1b81a3f63a72f69693ae36 source, RCTextRecord target, CancellationToken cancellationToken) => {
target.ssSTText2.ssValue = source.ssText;
return target;
}, cancellationToken)),";",cancellationToken);

// Result
// Result.Identifier = OrderMain.Id
result.outParamResult.ssIdentifier = localVars.varLcOrderMain.ssId;

// Result.HasSuccess = False
result.outParamResult.ssHasSuccess = false;

// Result.ErrorMessage = String_Join.Text
result.outParamResult.ssErrorMessage = localVars.resString_Join_outParamText;
} else {
// OrderMain.Id = OrderMainCreateOrUpdate.Id
localVars.varLcOrderMain.ssId = localVars.resOrderMainCreateOrUpdate.outParamId;
// Foreach OrderMainItems
localVars.varLcOrderMainItems.StartIteration();
try {while (!((localVars.varLcOrderMainItems.Eof))) {
// order id
// OrderMainItems.Current.OrderMainId = OrderMain.Id
localVars.varLcOrderMainItems.CurrentRec.ssOrderMainId = localVars.varLcOrderMain.ssId;
// OrderMainItemCreateOrUpdate
(localVars.resOrderMainItemCreateOrUpdate.outParamId,localVars.resOrderMainItemCreateOrUpdate.outParamHasSuccess,localVars.resOrderMainItemCreateOrUpdate.outParamErrorMessage) = await Actions.ActionOrderMainItemCreateOrUpdate(requestContext,localVars.varLcOrderMainItems.CurrentRec,cancellationToken);

// error?
if(((!localVars.resOrderMainItemCreateOrUpdate.outParamHasSuccess))) {
// ListAppend3
await ExtendedActions.ListAppend(requestContext,localVars.varLcErrorsList,new RC_ca61515b5f1b81a3f63a72f69693ae36(){ ssText = localVars.resOrderMainItemCreateOrUpdate.outParamErrorMessage },cancellationToken);

}

localVars.varLcOrderMainItems.Advance();
}

} finally {
localVars.varLcOrderMainItems.EndIteration();
}

// error?
if(((!localVars.varLcErrorsList.Empty))) {
// String_Join3
localVars.resString_Join3_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.varLcErrorsList, new RLTextRecordList(), async (RC_ca61515b5f1b81a3f63a72f69693ae36 source, RCTextRecord target, CancellationToken cancellationToken) => {
target.ssSTText2.ssValue = source.ssText;
return target;
}, cancellationToken)),";",cancellationToken);

// Result
// Result.Identifier = OrderMain.Id
result.outParamResult.ssIdentifier = localVars.varLcOrderMain.ssId;

// Result.HasSuccess = False
result.outParamResult.ssHasSuccess = false;

// Result.ErrorMessage = String_Join3.Text
result.outParamResult.ssErrorMessage = localVars.resString_Join3_outParamText;
} else {
// InitializeOrderAccounting
await Actions.ActionInitializeOrderAccounting(requestContext,localVars.resOrderMainCreateOrUpdate.outParamId,cancellationToken);

// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.resOrderMainCreateOrUpdate.outParamId, ssCreatedBy = localVars.varLcOrderMain.ssCreatedBy, ssCreatedOn = localVars.varLcOrderMain.ssCreatedOn, ssMessage = AppUtils.GetStringResource("kytK38vfYUiOZN2uHSSz6w#Value.1708013806.1", "This order has been created") },cancellationToken);

// Result
// Result.Identifier = OrderMain.Id
result.outParamResult.ssIdentifier = localVars.varLcOrderMain.ssId;

// Result.HasSuccess = True
result.outParamResult.ssHasSuccess = true;

// Result.ErrorMessage = ""
result.outParamResult.ssErrorMessage = "";
}

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// ListAppend4
await ExtendedActions.ListAppend(requestContext,localVars.varLcErrorsList,new RC_ca61515b5f1b81a3f63a72f69693ae36(){ ssText = ex.Message },cancellationToken);

// String_Join2
localVars.resString_Join2_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.varLcErrorsList, new RLTextRecordList(), async (RC_ca61515b5f1b81a3f63a72f69693ae36 source, RCTextRecord target, CancellationToken cancellationToken) => {
target.ssSTText2.ssValue = source.ssText;
return target;
}, cancellationToken)),";",cancellationToken);

// Result
// Result.Identifier = OrderMain.Id
result.outParamResult.ssIdentifier = localVars.varLcOrderMain.ssId;

// Result.HasSuccess = False
result.outParamResult.ssHasSuccess = false;

// Result.ErrorMessage = String_Join2.Text
result.outParamResult.ssErrorMessage = localVars.resString_Join2_outParamText;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamResult = result.outParamResult;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamResult;
}

public static class FuncActionOrdersImport_OrderCreate {

private static async Task<RC_b8337e876917ffb03ca766882c5f94fb> QueryGetIdentifiersReadDbAsync(RC_b8337e876917ffb03ca766882c5f94fb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssSTDocumentClassId.Read(r, ref index);
rec.ssSTCostCenterId.Read(r, ref index);
rec.ssSTRegionId.Read(r, ref index);
rec.ssSTDivisionId.Read(r, ref index);
rec.ssSTServiceTypeId.Read(r, ref index);
rec.ssSTInvoiceUsageId.Read(r, ref index);
rec.ssSTDirectionId.Read(r, ref index);
return rec;
}
// Query Function "GetIdentifiers" 9AovCVLi5k6SR4BfQXDDWA of Action "OrdersImport_OrderCreate"
public static async Task<(RL_1fd700228cc5fdbb5577ed3fdc4f16ac,long)> QueryGetIdentifiers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteDocumentClasse,string qpteCostCenter,string qpteCenter,string qpteGLAccount,string qpteDivision,string qpteDireccion,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("OrdersImport_OrderCreate.GetIdentifiers", "092f0af4-e252-4ee6-9247-805f4170c358");
using var queryActivity = activitySource.CreateSqlQueryActivity("OrdersImport_OrderCreate.GetIdentifiers", "092f0af4-e252-4ee6-9247-805f4170c358", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityDocumentType = AppUtils.Instance.RuntimeEntityReplace("DocumentType");
string entityCostCenterSAP = AppUtils.Instance.RuntimeEntityReplace("CostCenterSAP");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityAccountingAccounts_ServiceType = AppUtils.Instance.RuntimeEntityReplace("AccountingAccounts_ServiceType");
string entityInvoicesUsageAccounts = AppUtils.Instance.RuntimeEntityReplace("InvoicesUsageAccounts");
string entityTelcelDirection = AppUtils.Instance.RuntimeEntityReplace("TelcelDirection");
sqlCmd.CreateParameter("@qpteDocumentClasse", DbType.String, qpteDocumentClasse);
sqlCmd.CreateParameter("@qpteCostCenter", DbType.String, qpteCostCenter);
sqlCmd.CreateParameter("@qpteCenter", DbType.String, qpteCenter);
sqlCmd.CreateParameter("@qpteDivision", DbType.String, qpteDivision);
sqlCmd.CreateParameter("@qpteGLAccount", DbType.String, qpteGLAccount);
sqlCmd.CreateParameter("@qpteDireccion", DbType.String, qpteDireccion);
string sql = "";
string advSql = "SELECT  \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityDocumentType,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityDocumentType,"") + " WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityDocumentType,".\"classe\"") + " = @qpteDocumentClasse) LIMIT 1) \"documentclassid\", \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + " WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"ce_coste\"") + " = @qpteCostCenter) LIMIT 1) \"costcenterid\", \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"centrortp\"") + " = @qpteCenter) LIMIT 1) \"regionid\", \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"divisionfi\"") + " = @qpteDivision) LIMIT 1) \"divisionid\", \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityAccountingAccounts_ServiceType,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityAccountingAccounts_ServiceType,"") + " WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityAccountingAccounts_ServiceType,".\"cc\"") + " = @qpteGLAccount) LIMIT 1) \"servicetypeid\", \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoicesUsageAccounts,".\"invoiceusageid\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoicesUsageAccounts,"") + " WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoicesUsageAccounts,".\"accountingaccount\"") + " = @qpteGLAccount) LIMIT 1) \"invoiceusageid\", \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,"") + " WHERE  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"name\"") + " = @qpteDireccion) LIMIT 1) \"directionid\"";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_1fd700228cc5fdbb5577ed3fdc4f16ac outParamList = new RL_1fd700228cc5fdbb5577ed3fdc4f16ac();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = QueryGetIdentifiersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {false});
opt[1] = new BitArray(new bool[] {false});
opt[2] = new BitArray(new bool[] {false});
opt[3] = new BitArray(new bool[] {false});
opt[4] = new BitArray(new bool[] {false});
opt[5] = new BitArray(new bool[] {false});
opt[6] = new BitArray(new bool[] {false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersImport_OrderCreate.GetIdentifiers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1fd700228cc5fdbb5577ed3fdc4f16ac _tmp = new RL_1fd700228cc5fdbb5577ed3fdc4f16ac();
_tmp.AlternateReadDbMethodAsync = QueryGetIdentifiersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersImport_OrderCreate.GetIdentifiers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1fd700228cc5fdbb5577ed3fdc4f16ac)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetIdentifiers in OrdersImport_OrderCreate in ConectaProveedores (SELECT       ((SELECT {DocumentType}.[Id] FROM {DocumentType} WHERE {DocumentType}.[Classe] = @DocumentClasse) LIMIT 1) [DocumentClassId],      ((SELECT {CostCenterSAP}.[Id] FROM {CostCenterSAP} WHERE {CostCenterSAP}.[Ce_coste] = @CostCenter) LIMIT 1) [CostCenterId],      ((SELECT {Region}.[Id] FROM {Region} WHERE {Region}.[CentroRTP] = @Center) LIMIT 1) [RegionId],      ((SELECT {Region}.[Id] FROM {Region} WHERE {Region}.[DivisionFI] = @Division) LIMIT 1) [DivisionId],      ((SELECT {AccountingAccounts_ServiceType}.[Id] FROM {AccountingAccounts_ServiceType} WHERE {AccountingAccounts_ServiceType}.[CC] = @GLAccount) LIMIT 1) [ServiceTypeId],      ((SELECT {InvoicesUsageAccounts}.[InvoiceUsageId] FROM {InvoicesUsageAccounts} WHERE {InvoicesUsageAccounts}.[AccountingAccount] = @GLAccount) LIMIT 1) [InvoiceUsageId],      ((SELECT {TelcelDirection}.[Id] FROM {TelcelDirection} WHERE {TelcelDirection}.[Name] = @Direccion) LIMIT 1) [DirectionId]): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetIdentifiers in OrdersImport_OrderCreate in ConectaProveedores (SELECT       ((SELECT {DocumentType}.[Id] FROM {DocumentType} WHERE {DocumentType}.[Classe] = @DocumentClasse) LIMIT 1) [DocumentClassId],      ((SELECT {CostCenterSAP}.[Id] FROM {CostCenterSAP} WHERE {CostCenterSAP}.[Ce_coste] = @CostCenter) LIMIT 1) [CostCenterId],      ((SELECT {Region}.[Id] FROM {Region} WHERE {Region}.[CentroRTP] = @Center) LIMIT 1) [RegionId],      ((SELECT {Region}.[Id] FROM {Region} WHERE {Region}.[DivisionFI] = @Division) LIMIT 1) [DivisionId],      ((SELECT {AccountingAccounts_ServiceType}.[Id] FROM {AccountingAccounts_ServiceType} WHERE {AccountingAccounts_ServiceType}.[CC] = @GLAccount) LIMIT 1) [ServiceTypeId],      ((SELECT {InvoicesUsageAccounts}.[InvoiceUsageId] FROM {InvoicesUsageAccounts} WHERE {InvoicesUsageAccounts}.[AccountingAccount] = @GLAccount) LIMIT 1) [InvoiceUsageId],      ((SELECT {TelcelDirection}.[Id] FROM {TelcelDirection} WHERE {TelcelDirection}.[Name] = @Direccion) LIMIT 1) [DirectionId]): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetIdentifiers in OrdersImport_OrderCreate in ConectaProveedores (SELECT       ((SELECT {DocumentType}.[Id] FROM {DocumentType} WHERE {DocumentType}.[Classe] = @DocumentClasse) LIMIT 1) [DocumentClassId],      ((SELECT {CostCenterSAP}.[Id] FROM {CostCenterSAP} WHERE {CostCenterSAP}.[Ce_coste] = @CostCenter) LIMIT 1) [CostCenterId],      ((SELECT {Region}.[Id] FROM {Region} WHERE {Region}.[CentroRTP] = @Center) LIMIT 1) [RegionId],      ((SELECT {Region}.[Id] FROM {Region} WHERE {Region}.[DivisionFI] = @Division) LIMIT 1) [DivisionId],      ((SELECT {AccountingAccounts_ServiceType}.[Id] FROM {AccountingAccounts_ServiceType} WHERE {AccountingAccounts_ServiceType}.[CC] = @GLAccount) LIMIT 1) [ServiceTypeId],      ((SELECT {InvoicesUsageAccounts}.[InvoiceUsageId] FROM {InvoicesUsageAccounts} WHERE {InvoicesUsageAccounts}.[AccountingAccount] = @GLAccount) LIMIT 1) [InvoiceUsageId],      ((SELECT {TelcelDirection}.[Id] FROM {TelcelDirection} WHERE {TelcelDirection}.[Name] = @Direccion) LIMIT 1) [DirectionId]): " + aqExcep.Message));
}
}
}



}


}
