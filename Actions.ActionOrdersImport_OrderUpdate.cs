namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersImport_OrderUpdate : VarsBag {
public ST_9c87dd52bd762501ef8a064794927f08Structure inParamOrdersRequest;
public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamOrderMain;
/// <summary>
/// Variable <code>ErrorsList</code> that represents the Service Studio TextRecordList
///  <code>ErrorsList</code> <p>Description: </p>
/// </summary>
public RL_df53376d76478ddd40257fed0b6f76e8 varLcErrorsList = new RL_df53376d76478ddd40257fed0b6f76e8();

/// <summary>
/// Variable <code>TotalAmount</code> that represents the Service Studio Currency
///  <code>TotalAmount</code> <p>Description: </p>
/// </summary>
public decimal varLcTotalAmount = 0.0M;

/// <summary>
/// Variable <code>l_CancelationMotive</code> that represents the Service Studio Text
///  <code>l_CancelationMotive</code> <p>Description: CancelationMotive</p>
/// </summary>
public string varLcl_CancelationMotive = "";

public Actions.lcoOrderMainItemCreateOrUpdate resOrderMainItemCreateOrUpdate =  new Actions.lcoOrderMainItemCreateOrUpdate();
public Actions.lcoOrderMainCreateOrUpdate resOrderMainCreateOrUpdate =  new Actions.lcoOrderMainCreateOrUpdate();
public string resString_Join2_outParamText = "";

public Actions.lcoOrderNotes_Append resOrderNotes_Append =  new Actions.lcoOrderNotes_Append();
public RL_1fd700228cc5fdbb5577ed3fdc4f16ac queryResGetIdentifiers_outParamList = new RL_1fd700228cc5fdbb5577ed3fdc4f16ac();
public long queryResGetIdentifiers_outParamCount = 0L;

public RL_5a5dc4e5843197429d3408a507236d6a resListFilter_outParamFilteredList = new RL_5a5dc4e5843197429d3408a507236d6a();

public RL_361bfb1983e170050cb9d371d001b386 queryResGetOrderMainItemsByOrderMainId_outParamList = new RL_361bfb1983e170050cb9d371d001b386();
public long queryResGetOrderMainItemsByOrderMainId_outParamCount = 0L;

public RL_361bfb1983e170050cb9d371d001b386 resFilterByPosition_outParamFilteredList = new RL_361bfb1983e170050cb9d371d001b386();

public Actions.lcoOrderMainItemCreateOrUpdate resOrderMainItemCreateOrUpdate2 =  new Actions.lcoOrderMainItemCreateOrUpdate();
public Actions.lcoOrderApproval_Restart resOrderApproval_Restart =  new Actions.lcoOrderApproval_Restart();
public Actions.lcoOrdersImport_OrderUpdateCompare resOrdersImport_OrderUpdateCompare =  new Actions.lcoOrdersImport_OrderUpdateCompare();
public string resJSONSerialize1_outParamJSON = "";
public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public lcvOrdersImport_OrderUpdate(ST_9c87dd52bd762501ef8a064794927f08Structure inParamOrdersRequest, EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamOrderMain) {
this.inParamOrdersRequest = inParamOrdersRequest;
this.inParamOrderMain = inParamOrderMain;
}
}
public class lcoOrdersImport_OrderUpdate : VarsBag {
public ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = new ST_9f3831cec6ebd34416b59b8df7a27893Structure();

public lcoOrdersImport_OrderUpdate() {
}
}
/// <summary>
/// Action <code>OrdersImport_OrderUpdate</code> that represents the Service Studio action
///  <code>OrdersImport_OrderUpdate</code> <p> Description: </p>
/// </summary>
public static async Task<ST_9f3831cec6ebd34416b59b8df7a27893Structure> ActionOrdersImport_OrderUpdate(IRequestContext requestContext,ST_9c87dd52bd762501ef8a064794927f08Structure inParamOrdersRequest,EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamOrderMain,CancellationToken cancellationToken) {
ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = default;
lcoOrdersImport_OrderUpdate result = new lcoOrdersImport_OrderUpdate();
lcvOrdersImport_OrderUpdate localVars = new lcvOrdersImport_OrderUpdate(inParamOrdersRequest, inParamOrderMain);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersImport_OrderUpdate", "f271ca53-9d6a-4a37-8fb6-31c9ee24a37e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersImport_OrderUpdate", "f271ca53-9d6a-4a37-8fb6-31c9ee24a37e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// OrdersImport_OrderUpdateCompare
(localVars.resOrdersImport_OrderUpdateCompare.outParamIsReturnToOrderComplement,localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios,localVars.resOrdersImport_OrderUpdateCompare.outParamIsCancelAllFolios,localVars.resOrdersImport_OrderUpdateCompare.outParamGeneralCancelReason) = await Actions.ActionOrdersImport_OrderUpdateCompare(requestContext,localVars.inParamOrderMain.ssId,localVars.inParamOrdersRequest,cancellationToken);

// LogMessage
await ExtendedActions.LogMessage(requestContext,((((((("OrderNumber: "+localVars.inParamOrderMain.ssOrderNumber)+" | ")+"IsReturnToOrderComplement: ")+(localVars.resOrdersImport_OrderUpdateCompare.outParamIsReturnToOrderComplement ? "True" : "False"))+" | ")+"IsCancelAssociatedFolios: ")+((localVars.resOrdersImport_OrderUpdateCompare.outParamIsCancelAllFolios||(!localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.Empty)) ? "True" : "False")),"Order Update",cancellationToken);

// OrderNotes_Append
localVars.resOrderNotes_Append.outParamNotes = await Actions.ActionOrderNotes_Append(requestContext,localVars.inParamOrderMain.ssOrderNumber,cancellationToken);

// Query datasetGetOrderMainItemsByOrderMainId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainItemsByOrderMainId_maxRecords = 0;
int datasetGetOrderMainItemsByOrderMainId_startIndex = 0;(localVars.queryResGetOrderMainItemsByOrderMainId_outParamList,localVars.queryResGetOrderMainItemsByOrderMainId_outParamCount) = await FuncActionOrdersImport_OrderUpdate.datasetGetOrderMainItemsByOrderMainId(requestContext,datasetGetOrderMainItemsByOrderMainId_maxRecords,datasetGetOrderMainItemsByOrderMainId_startIndex,IterationMultiplicity.Multiple,localVars.inParamOrderMain.ssId,cancellationToken);

// Foreach GetOrderMainItemsByOrderMainId.List
localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.StartIteration();
try {while (!((localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.Eof))) {
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_5a5dc4e5843197429d3408a507236d6a)await  localVars.inParamOrdersRequest.ssOrderItems.FilterAsync(async (p, cancellationToken) => (p.ssPosition==localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssPosition), cancellationToken)));

if((localVars.resListFilter_outParamFilteredList.Empty)) {
// TotalAmount = TotalAmount + If
localVars.varLcTotalAmount=(localVars.varLcTotalAmount+((localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssIsDeleted) ? ((((decimal)0))) : ((localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssQuantity*((decimal)localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssUnitPrice/
(decimal)(((decimal)localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssBaseQuantity)))))));
} else {
// GetOrderMainItemsByOrderMainId.List.Current.OrderMainItem.Quantity = ListFilter.FilteredList.Current.Quantity
localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssQuantity = localVars.resListFilter_outParamFilteredList.CurrentRec.ssQuantity;

// GetOrderMainItemsByOrderMainId.List.Current.OrderMainItem.UnitPrice = ListFilter.FilteredList.Current.UnitPrice
localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssUnitPrice = localVars.resListFilter_outParamFilteredList.CurrentRec.ssUnitPrice;

// GetOrderMainItemsByOrderMainId.List.Current.OrderMainItem.IsDeleted = ListFilter.FilteredList.Current.ChangeIndicator = "L"
localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssIsDeleted = (localVars.resListFilter_outParamFilteredList.CurrentRec.ssChangeIndicator=="L");

// GetOrderMainItemsByOrderMainId.List.Current.OrderMainItem.IsBlocked = ListFilter.FilteredList.Current.ChangeIndicator = "S"
localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssIsBlocked = (localVars.resListFilter_outParamFilteredList.CurrentRec.ssChangeIndicator=="S");

// GetOrderMainItemsByOrderMainId.List.Current.OrderMainItem.AssigmnentCode = ListFilter.FilteredList.Current.ImputationCode
localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssAssigmnentCode = localVars.resListFilter_outParamFilteredList.CurrentRec.ssImputationCode;

// GetOrderMainItemsByOrderMainId.List.Current.OrderMainItem.BaseQuantity = ListFilter.FilteredList.Current.BaseQuantity
localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssBaseQuantity = localVars.resListFilter_outParamFilteredList.CurrentRec.ssBaseQuantity;

// GetOrderMainItemsByOrderMainId.List.Current.OrderMainItem.IsFinalDelivery = ListFilter.FilteredList.Current.FinalDelivery = "X"
localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssIsFinalDelivery = (localVars.resListFilter_outParamFilteredList.CurrentRec.ssFinalDelivery=="X");

// TotalAmount = TotalAmount + If
localVars.varLcTotalAmount=(localVars.varLcTotalAmount+(((localVars.resListFilter_outParamFilteredList.CurrentRec.ssChangeIndicator=="L")) ? ((((decimal)0))) : ((localVars.resListFilter_outParamFilteredList.CurrentRec.ssQuantity*((decimal)localVars.resListFilter_outParamFilteredList.CurrentRec.ssUnitPrice/
(decimal)(((decimal)localVars.resListFilter_outParamFilteredList.CurrentRec.ssBaseQuantity)))))));
// OrderMainItemCreateOrUpdate
(localVars.resOrderMainItemCreateOrUpdate.outParamId,localVars.resOrderMainItemCreateOrUpdate.outParamHasSuccess,localVars.resOrderMainItemCreateOrUpdate.outParamErrorMessage) = await Actions.ActionOrderMainItemCreateOrUpdate(requestContext,localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem,cancellationToken);

}

localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.Advance();
}

} finally {
localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.EndIteration();
}

// Foreach OrdersRequest.OrderItems
localVars.inParamOrdersRequest.ssOrderItems.StartIteration();
try {while (!((localVars.inParamOrdersRequest.ssOrderItems.Eof))) {
// FilterByPosition
localVars.resFilterByPosition_outParamFilteredList = (((RL_361bfb1983e170050cb9d371d001b386)await  localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENOrderMainItem.ssPosition==localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssPosition), cancellationToken)));

// Position Exists?
if((!((!localVars.resFilterByPosition_outParamFilteredList.Empty)))) {
// Query QueryGetIdentifiers
cancellationToken.ThrowIfCancellationRequested();
int QueryGetIdentifiers_maxRecords = 0;
int QueryGetIdentifiers_startIndex = 0;(localVars.queryResGetIdentifiers_outParamList,localVars.queryResGetIdentifiers_outParamCount) = await FuncActionOrdersImport_OrderUpdate.QueryGetIdentifiers(requestContext,QueryGetIdentifiers_maxRecords,QueryGetIdentifiers_startIndex,IterationMultiplicity.Never,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssDocumentClass,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssCostCenter,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssCenter,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssGLAccountNumber,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssBusinessArea,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssDirection,cancellationToken);

// OrderMainItemCreateOrUpdate2
(localVars.resOrderMainItemCreateOrUpdate2.outParamId,localVars.resOrderMainItemCreateOrUpdate2.outParamHasSuccess,localVars.resOrderMainItemCreateOrUpdate2.outParamErrorMessage) = await Actions.ActionOrderMainItemCreateOrUpdate(requestContext,new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderMainId = localVars.inParamOrderMain.ssId, ssPosition = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssPosition, ssMaterialCode = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssArticleNr, ssMaterialDescription = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssArticleDescription, ssAssigmnentCode = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssImputationCode, ssDocumentClassId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTDocumentClassId.ssValue), ssDeliveryDate = (await Functions.ActionDateValidate(requestContext,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssDeliveryDate,((((string)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportDefaultDateFormat]))),false,cancellationToken)).ssDate, ssQuantity = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssQuantity, ssUnitType = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssUnitType, ssUnitPrice = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssUnitPrice, ssBaseQuantity = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssBaseQuantity, ssIsDeleted = (localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssChangeIndicator=="L"), ssIsBlocked = (localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssChangeIndicator=="S"), ssIsFinalDelivery = (localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssFinalDelivery=="X"), ssGLAccountId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTServiceTypeId.ssValue), ssCostCenterId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTCostCenterId.ssValue), ssFundsCenter = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssFundsCenter, ssFund = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssFund, ssCommitmentItem = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssCommitmentItem, ssVATIndicator = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssVATIndicator, ssVATProcedure = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssVATProcedure, ssVATRate = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssVATRate, ssPurchaseRequisitionNumber = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssPurchaseRequisitionNumber, ssPurchaseRequisitionItemNr = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssPurchaseRequisitionItemNumber, ssRegionId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTRegionId.ssValue), ssCenter = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssCenter, ssPEPElement = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssPEPElement, ssQuantityDelivered = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssDeliveredQuantity, ssOrderUnitOfMeasure = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssUMP, ssApplicant = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssApplicant, ssDirection = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssDirection, ssContractNumber = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssContractNumber, ssContractPosition = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssContractPosition, ssContractStartDate = (await Functions.ActionDateValidate(requestContext,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssContractStartDate,((((string)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportDefaultDateFormat]))),false,cancellationToken)).ssDate, ssContractEndDate = (await Functions.ActionDateValidate(requestContext,localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssContractEndDate,((((string)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportDefaultDateFormat]))),false,cancellationToken)).ssDate, ssContractPlannedValue = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssContractPlannedValue, ssPositionType = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssPositionType, ssSerialNumberProfile = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssSerialNumberProfile, ssBatchManaged = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssBatchManaged, ssMaterialType = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssMaterialType, ssItemGroup = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssItemGroup, ssOrderRequestCreatorSAPNumber = localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssCreatingUser, ssInvoiceUsageId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTInvoiceUsageId.ssValue), ssOrderMainItemStatusId = (ENOrderMainItemStatusEntity.GetRecordByKey(ObjectKey.Parse("Ca+WgIpOj0CuJbhSpYSjFw"))).ssId, ssDivisionId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetIdentifiers_outParamList.CurrentRec.ssSTDivisionId.ssValue) },cancellationToken);

// TotalAmount = TotalAmount + If
localVars.varLcTotalAmount=(localVars.varLcTotalAmount+(((localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssChangeIndicator=="L")) ? ((((decimal)0))) : ((localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssQuantity*((decimal)localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssUnitPrice/
(decimal)(((decimal)localVars.inParamOrdersRequest.ssOrderItems.CurrentRec.ssBaseQuantity)))))));
}

localVars.inParamOrdersRequest.ssOrderItems.Advance();
}

} finally {
localVars.inParamOrdersRequest.ssOrderItems.EndIteration();
}

// OrdersImport_OrderUpdateCompare.IsReturnToOrderComplement = If
localVars.resOrdersImport_OrderUpdateCompare.outParamIsReturnToOrderComplement = ((localVars.resOrdersImport_OrderUpdateCompare.outParamIsReturnToOrderComplement) ? (true) : ((localVars.inParamOrderMain.ssTotalAmount!=localVars.varLcTotalAmount)));

// OrdersImport_OrderUpdateCompare.IsCancelAllFolios = If
localVars.resOrdersImport_OrderUpdateCompare.outParamIsCancelAllFolios = ((localVars.resOrdersImport_OrderUpdateCompare.outParamIsCancelAllFolios) ? (true) : ((localVars.inParamOrderMain.ssTotalAmount!=localVars.varLcTotalAmount)));

// OrdersImport_OrderUpdateCompare.GeneralCancelReason = If + If
localVars.resOrdersImport_OrderUpdateCompare.outParamGeneralCancelReason = ((((localVars.inParamOrderMain.ssIsReleased!=(localVars.inParamOrdersRequest.ssReleased=="S"))) ? (((((localVars.inParamOrdersRequest.ssReleased=="S")) ? (AppUtils.GetStringResource("7r_szDnNpEqM0LL72TOa8Q#Value.-486654627.1", "Released")) : (AppUtils.GetStringResource("7r_szDnNpEqM0LL72TOa8Q#Value.-1326572810.1", "Unreleased")))+". ")) : (""))+(((localVars.inParamOrderMain.ssTotalAmount!=localVars.varLcTotalAmount)) ? ((AppUtils.GetStringResource("7r_szDnNpEqM0LL72TOa8Q#Value.-662427935.1", "Total price changed")+". ")) : ("")));
// Pedido desliberado?
if((((localVars.inParamOrderMain.ssIsReleased!=(localVars.inParamOrdersRequest.ssReleased=="S"))&&(localVars.inParamOrdersRequest.ssReleased!="S")))) {
// OrderMain.PreviousOrderStatusId = OrderMain.OrderStatusId
localVars.inParamOrderMain.ssPreviousOrderStatusId = localVars.inParamOrderMain.ssOrderStatusId;

// OrderMain.OrderStatusId = Unreleased
localVars.inParamOrderMain.ssOrderStatusId = (ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("rQ22nid450ur93GrTIUjww"))).ssId;
} else {
// Pedido liberado?
if((((localVars.inParamOrderMain.ssIsReleased!=(localVars.inParamOrdersRequest.ssReleased=="S"))&&(localVars.inParamOrdersRequest.ssReleased=="S")))) {
// OrderMain.OrderStatusId = If
localVars.inParamOrderMain.ssOrderStatusId = (((((((localVars.inParamOrderMain.ssPreviousOrderStatusId==(ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("BHvVtSdSlUixsh+41KTCZg"))).ssId)||(localVars.inParamOrderMain.ssPreviousOrderStatusId==(ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("M7Q91hYooUaA8nlePjiPnQ"))).ssId))||(localVars.inParamOrderMain.ssPreviousOrderStatusId==(ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("bRJk2wDqy0yRFZotyjWZ5Q"))).ssId))||(localVars.inParamOrderMain.ssPreviousOrderStatusId==(ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("7Z08Vke3o0m5iptrgiGvaA"))).ssId))||(localVars.inParamOrderMain.ssPreviousOrderStatusId==(ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("XJxoo8RXb0K2bc9xcMC4lg"))).ssId))) ? (localVars.inParamOrderMain.ssPreviousOrderStatusId) : (localVars.inParamOrderMain.ssOrderStatusId));
}

}

// Assign OrderMain
// OrderMain.IsReleased = OrdersRequest.Released = "S"
localVars.inParamOrderMain.ssIsReleased = (localVars.inParamOrdersRequest.ssReleased=="S");

// OrderMain.TotalAmount = TextToDecimal
localVars.inParamOrderMain.ssTotalAmount = BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal (localVars.varLcTotalAmount, 2, ".", ""));
// Foreach OrdersImport_OrderUpdateCompare.ListOfPositionsToCancelFolios
localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.StartIteration();
try {while (!((localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.Eof))) {
// l_CancelationMotive = If
localVars.varLcl_CancelationMotive=(((localVars.varLcl_CancelationMotive=="")) ? (((((localVars.varLcl_CancelationMotive+"Pos ")+Convert.ToString(localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.CurrentRec.ssPosition))+": ")+localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.CurrentRec.ssUpdate)) : (((((localVars.varLcl_CancelationMotive+" | Pos ")+Convert.ToString(localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.CurrentRec.ssPosition))+": ")+localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.CurrentRec.ssUpdate)));
localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.Advance();
}

} finally {
localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.EndIteration();
}

if((localVars.resOrdersImport_OrderUpdateCompare.outParamIsReturnToOrderComplement)) {
// OrderApproval_Restart
localVars.resOrderApproval_Restart.outParamo_NoApprovalFound = await Actions.ActionOrderApproval_Restart(requestContext,localVars.inParamOrderMain.ssId,cancellationToken);

// OrderMain.OrderStatusId = If
localVars.inParamOrderMain.ssOrderStatusId = ((localVars.resOrderApproval_Restart.outParamo_NoApprovalFound) ? (localVars.inParamOrderMain.ssOrderStatusId) : ((((localVars.inParamOrderMain.ssOrderStatusId==(ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("rQ22nid450ur93GrTIUjww"))).ssId)) ? ((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("rQ22nid450ur93GrTIUjww"))).ssId) : ((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("M7Q91hYooUaA8nlePjiPnQ"))).ssId))));
// NotifyOrderRelatedUsers
await Actions.ActionNotifyOrderRelatedUsers(requestContext,localVars.inParamOrderMain.ssId,((((AppUtils.GetStringResource("qy7PT1W8gkiK6pwd7GpHZA#Value.1636541774.1", "Order modification")+":  ")+localVars.resOrdersImport_OrderUpdateCompare.outParamGeneralCancelReason)+" ")+localVars.varLcl_CancelationMotive),cancellationToken);

}

// JSON Serialize JsonSerializeOrdersImport_OrderUpdateJSONSerialize1
FuncActionOrdersImport_OrderUpdate.JsonSerializeOrdersImport_OrderUpdateJSONSerialize1(localVars.inParamOrderMain, out localVars.resJSONSerialize1_outParamJSON);
// ControledLogMessage2
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),("OrdersImport_OrderUpdate » Order Main update "+localVars.resJSONSerialize1_outParamJSON),"OrdersImport_OrderUpdate",cancellationToken);

// OrderMainCreateOrUpdate
(localVars.resOrderMainCreateOrUpdate.outParamId,localVars.resOrderMainCreateOrUpdate.outParamHasSuccess,localVars.resOrderMainCreateOrUpdate.outParamErrorMessage,localVars.resOrderMainCreateOrUpdate.outParamSource_Out) = await Actions.ActionOrderMainCreateOrUpdate(requestContext,localVars.inParamOrderMain,cancellationToken);

// Result.Identifier = OrderMain.Id
result.outParamResult.ssIdentifier = localVars.inParamOrderMain.ssId;

// Result.HasSuccess = True
result.outParamResult.ssHasSuccess = true;

// Result.ErrorMessage = ""
result.outParamResult.ssErrorMessage = "";
// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.resOrderMainCreateOrUpdate.outParamId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((AppUtils.GetStringResource("i8AjINvabEaGXT84UNP6oA#Value.445029057.1", "This order has been updated")+". ")+localVars.resOrdersImport_OrderUpdateCompare.outParamGeneralCancelReason)+" ")+localVars.varLcl_CancelationMotive) },cancellationToken);

// IsCancelAllFolios?
if((localVars.resOrdersImport_OrderUpdateCompare.outParamIsCancelAllFolios)) {
// CancelSAECAndNotify
await Actions.ActionCancelSAECAndNotify(requestContext,localVars.inParamOrderMain.ssId,0,localVars.varLcl_CancelationMotive,((AppUtils.GetStringResource("nw9eUceQoE+A0HkqNWKfBA#Value.1636541774.1", "Order modification")+":  ")+localVars.resOrdersImport_OrderUpdateCompare.outParamGeneralCancelReason),cancellationToken);

} else {
// Foreach OrdersImport_OrderUpdateCompare.ListOfPositionsToCancelFolios
localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.StartIteration();
try {while (!((localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.Eof))) {
// CancelSAECAndNotify2
await Actions.ActionCancelSAECAndNotify(requestContext,localVars.inParamOrderMain.ssId,localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.CurrentRec.ssPosition,((((((AppUtils.GetStringResource("0h0GSxMGP0ihwl2W_N16mg#Value.812449097.1", "Position")+" ")+Convert.ToString(localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.CurrentRec.ssPosition))+" ")+AppUtils.GetStringResource("0h0GSxMGP0ihwl2W_N16mg#Value.-615513399.1", "modified"))+": ")+localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.CurrentRec.ssUpdate),((AppUtils.GetStringResource("NC7YnwItuk69D+wAvFmHJA#Value.1636541774.1", "Order modification")+":  ")+localVars.resOrdersImport_OrderUpdateCompare.outParamGeneralCancelReason),cancellationToken);

localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.Advance();
}

} finally {
localVars.resOrdersImport_OrderUpdateCompare.outParamListOfPositionsToCancelFolios.EndIteration();
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
result.outParamResult.ssIdentifier = localVars.inParamOrderMain.ssId;

// Result.HasSuccess = False
result.outParamResult.ssHasSuccess = false;

// Result.ErrorMessage = AllExceptions.ExceptionMessage
result.outParamResult.ssErrorMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamResult = result.outParamResult;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamResult;
}

public static class FuncActionOrdersImport_OrderUpdate {

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
// Query Function "GetIdentifiers" ewZwPNZX+Ue704RpOYrQ5w of Action "OrdersImport_OrderUpdate"
public static async Task<(RL_1fd700228cc5fdbb5577ed3fdc4f16ac,long)> QueryGetIdentifiers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteDocumentClasse,string qpteCostCenter,string qpteCenter,string qpteGLAccount,string qpteDivision,string qpteDireccion,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("OrdersImport_OrderUpdate.GetIdentifiers", "3c70067b-57d6-47f9-bbd3-8469398ad0e7");
using var queryActivity = activitySource.CreateSqlQueryActivity("OrdersImport_OrderUpdate.GetIdentifiers", "3c70067b-57d6-47f9-bbd3-8469398ad0e7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersImport_OrderUpdate.GetIdentifiers.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersImport_OrderUpdate.GetIdentifiers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1fd700228cc5fdbb5577ed3fdc4f16ac)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetIdentifiers in OrdersImport_OrderUpdate in ConectaProveedores (SELECT       ((SELECT {DocumentType}.[Id] FROM {DocumentType} WHERE {DocumentType}.[Classe] = @DocumentClasse) LIMIT 1) [DocumentClassId],      ((SELECT {CostCenterSAP}.[Id] FROM {CostCenterSAP} WHERE {CostCenterSAP}.[Ce_coste] = @CostCenter) LIMIT 1) [CostCenterId],      ((SELECT {Region}.[Id] FROM {Region} WHERE {Region}.[CentroRTP] = @Center) LIMIT 1) [RegionId],      ((SELECT {Region}.[Id] FROM {Region} WHERE {Region}.[DivisionFI] = @Division) LIMIT 1) [DivisionId],      ((SELECT {AccountingAccounts_ServiceType}.[Id] FROM {AccountingAccounts_ServiceType} WHERE {AccountingAccounts_ServiceType}.[CC] = @GLAccount) LIMIT 1) [ServiceTypeId],      ((SELECT {InvoicesUsageAccounts}.[InvoiceUsageId] FROM {InvoicesUsageAccounts} WHERE {InvoicesUsageAccounts}.[AccountingAccount] = @GLAccount) LIMIT 1) [InvoiceUsageId],      ((SELECT {TelcelDirection}.[Id] FROM {TelcelDirection} WHERE {TelcelDirection}.[Name] = @Direccion) LIMIT 1) [DirectionId]): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetIdentifiers in OrdersImport_OrderUpdate in ConectaProveedores (SELECT       ((SELECT {DocumentType}.[Id] FROM {DocumentType} WHERE {DocumentType}.[Classe] = @DocumentClasse) LIMIT 1) [DocumentClassId],      ((SELECT {CostCenterSAP}.[Id] FROM {CostCenterSAP} WHERE {CostCenterSAP}.[Ce_coste] = @CostCenter) LIMIT 1) [CostCenterId],      ((SELECT {Region}.[Id] FROM {Region} WHERE {Region}.[CentroRTP] = @Center) LIMIT 1) [RegionId],      ((SELECT {Region}.[Id] FROM {Region} WHERE {Region}.[DivisionFI] = @Division) LIMIT 1) [DivisionId],      ((SELECT {AccountingAccounts_ServiceType}.[Id] FROM {AccountingAccounts_ServiceType} WHERE {AccountingAccounts_ServiceType}.[CC] = @GLAccount) LIMIT 1) [ServiceTypeId],      ((SELECT {InvoicesUsageAccounts}.[InvoiceUsageId] FROM {InvoicesUsageAccounts} WHERE {InvoicesUsageAccounts}.[AccountingAccount] = @GLAccount) LIMIT 1) [InvoiceUsageId],      ((SELECT {TelcelDirection}.[Id] FROM {TelcelDirection} WHERE {TelcelDirection}.[Name] = @Direccion) LIMIT 1) [DirectionId]): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetIdentifiers in OrdersImport_OrderUpdate in ConectaProveedores (SELECT       ((SELECT {DocumentType}.[Id] FROM {DocumentType} WHERE {DocumentType}.[Classe] = @DocumentClasse) LIMIT 1) [DocumentClassId],      ((SELECT {CostCenterSAP}.[Id] FROM {CostCenterSAP} WHERE {CostCenterSAP}.[Ce_coste] = @CostCenter) LIMIT 1) [CostCenterId],      ((SELECT {Region}.[Id] FROM {Region} WHERE {Region}.[CentroRTP] = @Center) LIMIT 1) [RegionId],      ((SELECT {Region}.[Id] FROM {Region} WHERE {Region}.[DivisionFI] = @Division) LIMIT 1) [DivisionId],      ((SELECT {AccountingAccounts_ServiceType}.[Id] FROM {AccountingAccounts_ServiceType} WHERE {AccountingAccounts_ServiceType}.[CC] = @GLAccount) LIMIT 1) [ServiceTypeId],      ((SELECT {InvoicesUsageAccounts}.[InvoiceUsageId] FROM {InvoicesUsageAccounts} WHERE {InvoicesUsageAccounts}.[AccountingAccount] = @GLAccount) LIMIT 1) [InvoiceUsageId],      ((SELECT {TelcelDirection}.[Id] FROM {TelcelDirection} WHERE {TelcelDirection}.[Name] = @Direccion) LIMIT 1) [DirectionId]): " + aqExcep.Message));
}
}
}

// Query Function "GetOrderMainItemsByOrderMainId" KTYMQ68oM0WGPstqe1VlGg of Action "OrdersImport_OrderUpdate"
public static async Task<(RL_361bfb1983e170050cb9d371d001b386,long)> datasetGetOrderMainItemsByOrderMainId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrdersImport_OrderUpdate.GetOrderMainItemsByOrderMainId", "430c3629-28af-4533-863e-cb6a7b55651a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrdersImport_OrderUpdate.GetOrderMainItemsByOrderMainId", "430c3629-28af-4533-863e-cb6a7b55651a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.U8px8mqdN0qPtjHJ7iSjfg/NodesNotShownInESpaceTree.KTYMQ68oM0WGPstqe1VlGg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordermainitem14\".\"id\" o0, \"enordermainitem14\".\"ordermainid\" o1, \"enordermainitem14\".\"position\" o2, \"enordermainitem14\".\"materialcode\" o3, \"enordermainitem14\".\"materialdescription\" o4, \"enordermainitem14\".\"assigmnentcode\" o5, \"enordermainitem14\".\"documentclassid\" o6, \"enordermainitem14\".\"deliverydate\" o7, trim_scale(\"enordermainitem14\".\"quantity\"::numeric) o8, \"enordermainitem14\".\"unittype\" o9, trim_scale(\"enordermainitem14\".\"unitprice\"::numeric) o10, \"enordermainitem14\".\"basequantity\" o11, \"enordermainitem14\".\"isdeleted\" o12, \"enordermainitem14\".\"isblocked\" o13, \"enordermainitem14\".\"isfinaldelivery\" o14, \"enordermainitem14\".\"glaccountid\" o15, \"enordermainitem14\".\"costcenterid\" o16, \"enordermainitem14\".\"fundscenter\" o17, \"enordermainitem14\".\"fund\" o18, \"enordermainitem14\".\"commitmentitem\" o19, \"enordermainitem14\".\"vatindicator\" o20, \"enordermainitem14\".\"vatprocedure\" o21, trim_scale(\"enordermainitem14\".\"vatrate\"::numeric) o22, \"enordermainitem14\".\"purchaserequisitionnumber\" o23, \"enordermainitem14\".\"purchaserequisitionitemnr\" o24, \"enordermainitem14\".\"regionid\" o25, \"enordermainitem14\".\"center\" o26, \"enordermainitem14\".\"pepelement\" o27, trim_scale(\"enordermainitem14\".\"quantitydelivered\"::numeric) o28, \"enordermainitem14\".\"orderunitofmeasure\" o29, \"enordermainitem14\".\"applicant\" o30, \"enordermainitem14\".\"direction\" o31, \"enordermainitem14\".\"contractnumber\" o32, \"enordermainitem14\".\"contractposition\" o33, \"enordermainitem14\".\"contractstartdate\" o34, \"enordermainitem14\".\"contractenddate\" o35, trim_scale(\"enordermainitem14\".\"contractplannedvalue\"::numeric) o36, \"enordermainitem14\".\"positiontype\" o37, \"enordermainitem14\".\"serialnumberprofile\" o38, \"enordermainitem14\".\"batchmanaged\" o39, \"enordermainitem14\".\"materialtype\" o40, \"enordermainitem14\".\"itemgroup\" o41, \"enordermainitem14\".\"orderrequestcreatorsapnumber\" o42, \"enordermainitem14\".\"ismultipleimputation\" o43, \"enordermainitem14\".\"invoiceusageid\" o44, \"enordermainitem14\".\"ordermainitemstatusid\" o45, \"enordermainitem14\".\"divisionid\" o46, \"enordermainitem14\".\"createdby\" o47, \"enordermainitem14\".\"createdon\" o48, \"enordermainitem14\".\"updatedby\" o49, \"enordermainitem14\".\"updatedon\" o50");
fromBuilder.Append(" FROM {OrderMainItem} \"enordermainitem14\"");
whereBuilder.Append(" WHERE ");
if (qporOrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem14\".\"ordermainid\" = @qporOrderMainId) AND (\"enordermainitem14\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainId", DbType.Int64, qporOrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem14\".\"ordermainid\" IS NULL)");
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
RL_361bfb1983e170050cb9d371d001b386 outParamList = new RL_361bfb1983e170050cb9d371d001b386();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersImport_OrderUpdate.GetOrderMainItemsByOrderMainId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_361bfb1983e170050cb9d371d001b386 _tmp = new RL_361bfb1983e170050cb9d371d001b386();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersImport_OrderUpdate.GetOrderMainItemsByOrderMainId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_361bfb1983e170050cb9d371d001b386)_tmp;
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
/// JSONSerialize: JsonSerializeOrdersImport_OrderUpdateJSONSerialize1 (KzQ9gmf3yDkW4dkIl8nQexg)  of
///  Action "OrdersImport_OrderUpdate"
/// </summary>
public static void JsonSerializeOrdersImport_OrderUpdateJSONSerialize1 (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

}


}
