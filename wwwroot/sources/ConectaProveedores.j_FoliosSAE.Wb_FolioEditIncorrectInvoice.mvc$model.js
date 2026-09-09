import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { RC_131b941598d8581e5466dbb966f5f0a8, EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord, RC_03baaf9011c29c7810216c701048afb6, RC_95110bc97f34f4c1561c8cbf2b5015b2, RC_03b2a2565369f3088e5267bce38cfba9, EN_171b22187ea6e4b12c9f086502740307EntityRecord, ST_d381fba44897ce4382b17d5149465d51Structure, ST_1bddfac19e9b0cef65924aa7568fd106Structure, RC_0b2176705fa164c9531eb643caf0e9d4, EN_d1d0320db36efbb094ad0082361435a0EntityRecord, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, ST_aa3e6001f162e602247a2e2cc13e2cf8Structure, EN_f81a3d226103fd013068b8763798067aEntityRecord } from "./ConectaProveedores.model.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";

class GetFolioApprovalRejectReasonAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_131b941598d8581e5466dbb966f5f0a8));
}
static fromStructure(str) {
return new GetFolioApprovalRejectReasonAggrRec(new GetFolioApprovalRejectReasonAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioApprovalRejectReasonAggrRec.init();

class GetFolioByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord, {
name: "Folio",
attrName: "folioAttr",
nameForJson: "Folio",
uniqueId: "cfeb2cf8-0ab6-83e7-d9a9-b5d02d9c9526"
}))));
}
static fromStructure(str) {
return new GetFolioByIdAggrRec(new GetFolioByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioByIdAggrRec.init();

class GetFolioCommentsByFolioIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_03baaf9011c29c7810216c701048afb6));
}
static fromStructure(str) {
return new GetFolioCommentsByFolioIdAggrRec(new GetFolioCommentsByFolioIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioCommentsByFolioIdAggrRec.init();

class GetFolioItemsByFolioIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_95110bc97f34f4c1561c8cbf2b5015b2));
}
static fromStructure(str) {
return new GetFolioItemsByFolioIdAggrRec(new GetFolioItemsByFolioIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioItemsByFolioIdAggrRec.init();

class GetOrderDetailAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_03b2a2565369f3088e5267bce38cfba9));
}
static fromStructure(str) {
return new GetOrderDetailAggrRec(new GetOrderDetailAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderDetailAggrRec.init();

class GetFolioObservationsByFolioIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_171b22187ea6e4b12c9f086502740307EntityRecord, {
name: "FolioObservations",
attrName: "folioObservationsAttr",
nameForJson: "FolioObservations",
uniqueId: "017cba02-e4fd-7f68-4606-081b7269a26b"
}))));
}
static fromStructure(str) {
return new GetFolioObservationsByFolioIdAggrRec(new GetFolioObservationsByFolioIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioObservationsByFolioIdAggrRec.init();


class GetSettingsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("IsActiveAmountValidation", "isActiveAmountValidationOut", "IsActiveAmountValidation", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("IsForceForeigner", "isForceForeignerOut", "IsForceForeigner", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("o_ForeignCurrencyMargin", "o_ForeignCurrencyMarginOut", "o_ForeignCurrencyMargin", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$BuiltinFunctions.integerToDecimal(10);
}, true), 
this.attr("o_NationalCurrencyMargin", "o_NationalCurrencyMarginOut", "o_NationalCurrencyMargin", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$BuiltinFunctions.integerToDecimal(10);
}, true), 
this.attr("o_IsActiveDEV_HU13008_Complement", "o_IsActiveDEV_HU13008_ComplementOut", "o_IsActiveDEV_HU13008_Complement", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("o_IsActiveDEV_HU13046", "o_IsActiveDEV_HU13046Out", "o_IsActiveDEV_HU13046", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetSettingsDataActRec.init();

class GetFolioFilesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("InvoiceMainFiles", "invoiceMainFilesOut", "InvoiceMainFiles", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_d381fba44897ce4382b17d5149465d51Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_d381fba44897ce4382b17d5149465d51Structure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetFolioFilesDataActRec(new GetFolioFilesDataActRec.RecordClass({
invoiceMainFilesOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioFilesDataActRec.init();

class GetOrderMainItemsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("List", "listOut", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_1bddfac19e9b0cef65924aa7568fd106Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_1bddfac19e9b0cef65924aa7568fd106Structure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetOrderMainItemsDataActRec(new GetOrderMainItemsDataActRec.RecordClass({
listOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderMainItemsDataActRec.init();

class GetSummaryDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_SummaryRec", "o_SummaryRecOut", "o_SummaryRec", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RC_0b2176705fa164c9531eb643caf0e9d4());
}, true, RC_0b2176705fa164c9531eb643caf0e9d4)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetSummaryDataActRec(new GetSummaryDataActRec.RecordClass({
o_SummaryRecOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSummaryDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_SummaryRec", "l_SummaryRecVar", "l_SummaryRec", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RC_0b2176705fa164c9531eb643caf0e9d4());
}, false, RC_0b2176705fa164c9531eb643caf0e9d4), 
this.attr("WithDatesError", "withDatesErrorVar", "WithDatesError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("WithQuantityError", "withQuantityErrorVar", "WithQuantityError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("WithFilesError", "withFilesErrorVar", "WithFilesError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("DatesQuantityPEPError", "datesQuantityPEPErrorVar", "DatesQuantityPEPError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("Withprorata", "withprorataVar", "Withprorata", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("firstUserIdentifier", "firstUserIdentifierVar", "firstUserIdentifier", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("Comments", "commentsVar", "Comments", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("InvoiceToCreate", "invoiceToCreateVar", "InvoiceToCreate", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new EN_d1d0320db36efbb094ad0082361435a0EntityRecord());
}, false, EN_d1d0320db36efbb094ad0082361435a0EntityRecord), 
this.attr("InvoiceForeignToCreate", "invoiceForeignToCreateVar", "InvoiceForeignToCreate", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_6f620840109ac6f721328b723ec0152cStructure());
}, false, ST_6f620840109ac6f721328b723ec0152cStructure), 
this.attr("FilesList", "filesListVar", "FilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("FilesListExtra", "filesListExtraVar", "FilesListExtra", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("ApproverValid", "approverValidVar", "ApproverValid", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("ApproverErrorMessage", "approverErrorMessageVar", "ApproverErrorMessage", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("MaxAmountError", "maxAmountErrorVar", "MaxAmountError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("LocalSelectedLines", "localSelectedLinesVar", "LocalSelectedLines", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))), 
this.attr("l_ImportAnticipo", "l_ImportAnticipoVar", "l_ImportAnticipo", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$DataTypes.Decimal.defaultValue;
}, false), 
this.attr("CreditNoteFilesList", "creditNoteFilesListVar", "CreditNoteFilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("l_IsOpenPopup", "l_IsOpenPopupVar", "l_IsOpenPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsOpenPopupComment", "l_IsOpenPopupCommentVar", "l_IsOpenPopupComment", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("HaveNewFiles", "haveNewFilesVar", "HaveNewFiles", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("NewFileNamesUploaded", "newFileNamesUploadedVar", "NewFileNamesUploaded", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("L_IsNational", "l_IsNationalVar", "L_IsNational", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("CreditNoteInvoiceToCreate", "creditNoteInvoiceToCreateVar", "CreditNoteInvoiceToCreate", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new EN_d1d0320db36efbb094ad0082361435a0EntityRecord());
}, false, EN_d1d0320db36efbb094ad0082361435a0EntityRecord), 
this.attr("CreditNote_IsNeeded", "creditNote_IsNeededVar", "CreditNote_IsNeeded", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("InvoiceExtendedToCreate", "invoiceExtendedToCreateVar", "InvoiceExtendedToCreate", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new EN_f81a3d226103fd013068b8763798067aEntityRecord());
}, false, EN_f81a3d226103fd013068b8763798067aEntityRecord), 
this.attr("OrderAccConceptsIdToCreate", "orderAccConceptsIdToCreateVar", "OrderAccConceptsIdToCreate", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("FolioId", "folioIdIn", "FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_folioIdInDataFetchStatus", "_folioIdInDataFetchStatus", "_folioIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_OrderId", "i_OrderIdIn", "i_OrderId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_LocalSelectedLines", "i_LocalSelectedLinesIn", "i_LocalSelectedLines", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))), 
this.attr("_i_LocalSelectedLinesInDataFetchStatus", "_i_LocalSelectedLinesInDataFetchStatus", "_i_LocalSelectedLinesInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFolioApprovalRejectReason", "getFolioApprovalRejectReasonAggr", "GetFolioApprovalRejectReason", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioApprovalRejectReasonAggrRec());
}, true, GetFolioApprovalRejectReasonAggrRec), 
this.attr("GetFolioById", "getFolioByIdAggr", "GetFolioById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioByIdAggrRec());
}, true, GetFolioByIdAggrRec), 
this.attr("GetFolioCommentsByFolioId", "getFolioCommentsByFolioIdAggr", "GetFolioCommentsByFolioId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioCommentsByFolioIdAggrRec());
}, true, GetFolioCommentsByFolioIdAggrRec), 
this.attr("GetFolioItemsByFolioId", "getFolioItemsByFolioIdAggr", "GetFolioItemsByFolioId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioItemsByFolioIdAggrRec());
}, true, GetFolioItemsByFolioIdAggrRec), 
this.attr("GetOrderDetail", "getOrderDetailAggr", "GetOrderDetail", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderDetailAggrRec());
}, true, GetOrderDetailAggrRec), 
this.attr("GetFolioObservationsByFolioId", "getFolioObservationsByFolioIdAggr", "GetFolioObservationsByFolioId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioObservationsByFolioIdAggrRec());
}, true, GetFolioObservationsByFolioIdAggrRec), 
this.attr("GetSettings", "getSettingsDataAct", "GetSettings", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSettingsDataActRec());
}, true, GetSettingsDataActRec), 
this.attr("GetFolioFiles", "getFolioFilesDataAct", "GetFolioFiles", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioFilesDataActRec());
}, true, GetFolioFilesDataActRec), 
this.attr("GetOrderMainItems", "getOrderMainItemsDataAct", "GetOrderMainItems", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderMainItemsDataActRec());
}, true, GetOrderMainItemsDataActRec), 
this.attr("GetSummary", "getSummaryDataAct", "GetSummary", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSummaryDataActRec());
}, true, GetSummaryDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
TextArea_Comments: OS$Model.ValidationWidgetRecord,
Input_TotalAmount: OS$Model.ValidationWidgetRecord,
Input_TotalAmount2: OS$Model.ValidationWidgetRecord,
Input_TotalAmount3: OS$Model.ValidationWidgetRecord,
Input_TotalAmount4: OS$Model.ValidationWidgetRecord,
Input_InvoicingAmount: OS$Model.ValidationWidgetRecord,
Input_TotalAmount8: OS$Model.ValidationWidgetRecord,
Input_TotalAmount5: OS$Model.ValidationWidgetRecord,
Input_TotalAmount9: OS$Model.ValidationWidgetRecord,
Input_TotalAmount10: OS$Model.ValidationWidgetRecord,
Input_PartialDeliveryAmount: OS$Model.ValidationWidgetRecord,
Input_InvoicingAmount2: OS$Model.ValidationWidgetRecord,
Input_TotalAmount6: OS$Model.ValidationWidgetRecord,
Input_TotalAmount7: OS$Model.ValidationWidgetRecord,
TextArea_l_IsOpenPopupComment: OS$Model.ValidationWidgetRecord
};
}

}

class Model extends 
OS$Model.BaseViewModel {
static getVariablesRecordConstructor() {
return VariablesRecord;
}

static getWidgetsRecordConstructor() {
return WidgetsRecord;
}

static get hasValidationWidgets() {return true;
}
setInputs(inputs) {
if("FolioId" in inputs) {
this.variables.folioIdIn = inputs.FolioId;
if("_folioIdInDataFetchStatus" in inputs) {
this.variables._folioIdInDataFetchStatus = inputs._folioIdInDataFetchStatus;
}

}

if("i_OrderId" in inputs) {
this.variables.i_OrderIdIn = inputs.i_OrderId;
if("_i_OrderIdInDataFetchStatus" in inputs) {
this.variables._i_OrderIdInDataFetchStatus = inputs._i_OrderIdInDataFetchStatus;
}

}

if("i_LocalSelectedLines" in inputs) {
this.variables.i_LocalSelectedLinesIn = inputs.i_LocalSelectedLines;
if("_i_LocalSelectedLinesInDataFetchStatus" in inputs) {
this.variables._i_LocalSelectedLinesInDataFetchStatus = inputs._i_LocalSelectedLinesInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


