import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_03baaf9011c29c7810216c701048afb6, EN_171b22187ea6e4b12c9f086502740307EntityRecord, RC_03b2a2565369f3088e5267bce38cfba9, RC_79a64780c4264a7ff3588d1347b5f259, EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord, RC_95110bc97f34f4c1561c8cbf2b5015b2, EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord, ST_1bddfac19e9b0cef65924aa7568fd106Structure, ST_714c559a98f1e1080cbf60de3228e843Structure, RC_0b2176705fa164c9531eb643caf0e9d4, ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, RC_1c2482ce6cd4b83ca44ec0510b231d44, ST_b2fd0f57faec93f17ef861f417f1cd5cStructure, ST_aa3e6001f162e602247a2e2cc13e2cf8Structure } from "./ConectaProveedores.model.js";

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

class GetApprovalListAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_79a64780c4264a7ff3588d1347b5f259));
}
static fromStructure(str) {
return new GetApprovalListAggrRec(new GetApprovalListAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetApprovalListAggrRec.init();

class GetFolioExtendedByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_a068be6d15bdd7253c79d3c9b7f78f6bEntityRecord, {
name: "FolioExtended",
attrName: "folioExtendedAttr",
nameForJson: "FolioExtended",
uniqueId: "ad92b2c2-1722-8db1-0c71-baf90a615ea5"
}))));
}
static fromStructure(str) {
return new GetFolioExtendedByIdAggrRec(new GetFolioExtendedByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioExtendedByIdAggrRec.init();

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

class GetMinutesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("KeyValueList", "keyValueListOut", "KeyValueList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_714c559a98f1e1080cbf60de3228e843Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_714c559a98f1e1080cbf60de3228e843Structure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetMinutesDataActRec(new GetMinutesDataActRec.RecordClass({
keyValueListOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetMinutesDataActRec.init();

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

class GetMinutesDocumentsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("List", "listOut", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure))), 
this.attr("FilesList2", "filesList2Out", "FilesList2", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetMinutesDocumentsDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_IsApplyToAll", "l_IsApplyToAllVar", "l_IsApplyToAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("DeliveryDate", "deliveryDateVar", "DeliveryDate", true, false, OS$DataTypes.DataTypes.Date, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("l_SummaryRec", "l_SummaryRecVar", "l_SummaryRec", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RC_0b2176705fa164c9531eb643caf0e9d4());
}, false, RC_0b2176705fa164c9531eb643caf0e9d4), 
this.attr("WithDatesError", "withDatesErrorVar", "WithDatesError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("WithQuantityError", "withQuantityErrorVar", "WithQuantityError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("WithPaymentError", "withPaymentErrorVar", "WithPaymentError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("WithFilesError", "withFilesErrorVar", "WithFilesError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("WithConceptMinutesError", "withConceptMinutesErrorVar", "WithConceptMinutesError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("WithApprovalProcessError", "withApprovalProcessErrorVar", "WithApprovalProcessError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("DatesQuantityPEPError", "datesQuantityPEPErrorVar", "DatesQuantityPEPError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("Withprorata", "withprorataVar", "Withprorata", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("Comments", "commentsVar", "Comments", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("FilesListExtra", "filesListExtraVar", "FilesListExtra", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("MinuteSelected", "minuteSelectedVar", "MinuteSelected", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("ConstructionStruct", "constructionStructVar", "ConstructionStruct", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RC_1c2482ce6cd4b83ca44ec0510b231d44());
}, false, RC_1c2482ce6cd4b83ca44ec0510b231d44), 
this.attr("MinuteDocumentTypeList", "minuteDocumentTypeListVar", "MinuteDocumentTypeList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure))), 
this.attr("MaxAmountError", "maxAmountErrorVar", "MaxAmountError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("LocalSelectedLines", "localSelectedLinesVar", "LocalSelectedLines", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))), 
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
this.attr("FilesList", "filesListIn", "FilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("_filesListInDataFetchStatus", "_filesListInDataFetchStatus", "_filesListInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFolioCommentsByFolioId", "getFolioCommentsByFolioIdAggr", "GetFolioCommentsByFolioId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioCommentsByFolioIdAggrRec());
}, true, GetFolioCommentsByFolioIdAggrRec), 
this.attr("GetFolioObservationsByFolioId", "getFolioObservationsByFolioIdAggr", "GetFolioObservationsByFolioId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioObservationsByFolioIdAggrRec());
}, true, GetFolioObservationsByFolioIdAggrRec), 
this.attr("GetOrderDetail", "getOrderDetailAggr", "GetOrderDetail", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderDetailAggrRec());
}, true, GetOrderDetailAggrRec), 
this.attr("GetApprovalList", "getApprovalListAggr", "GetApprovalList", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetApprovalListAggrRec());
}, true, GetApprovalListAggrRec), 
this.attr("GetFolioExtendedById", "getFolioExtendedByIdAggr", "GetFolioExtendedById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioExtendedByIdAggrRec());
}, true, GetFolioExtendedByIdAggrRec), 
this.attr("GetFolioItemsByFolioId", "getFolioItemsByFolioIdAggr", "GetFolioItemsByFolioId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioItemsByFolioIdAggrRec());
}, true, GetFolioItemsByFolioIdAggrRec), 
this.attr("GetFolioById", "getFolioByIdAggr", "GetFolioById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioByIdAggrRec());
}, true, GetFolioByIdAggrRec), 
this.attr("GetOrderMainItems", "getOrderMainItemsDataAct", "GetOrderMainItems", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderMainItemsDataActRec());
}, true, GetOrderMainItemsDataActRec), 
this.attr("GetMinutes", "getMinutesDataAct", "GetMinutes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetMinutesDataActRec());
}, true, GetMinutesDataActRec), 
this.attr("GetSummary", "getSummaryDataAct", "GetSummary", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSummaryDataActRec());
}, true, GetSummaryDataActRec), 
this.attr("GetMinutesDocuments", "getMinutesDocumentsDataAct", "GetMinutesDocuments", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetMinutesDocumentsDataActRec());
}, true, GetMinutesDocumentsDataActRec)
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
Input_TotalAmount5: OS$Model.ValidationWidgetRecord,
Input_TotalAmount8: OS$Model.ValidationWidgetRecord,
Input_TotalAmount9: OS$Model.ValidationWidgetRecord,
Input_TotalAmount10: OS$Model.ValidationWidgetRecord,
Input_PartialDeliveryAmount: OS$Model.ValidationWidgetRecord,
Input_InvoicingAmount2: OS$Model.ValidationWidgetRecord,
Input_TotalAmount6: OS$Model.ValidationWidgetRecord,
Input_TotalAmount7: OS$Model.ValidationWidgetRecord,
DropdownConceptMinutes: OS$Model.ValidationWidgetRecord,
Checkbox1: OS$Model.ValidationWidgetRecord,
Input_AdvPaymentValue: OS$Model.ValidationWidgetRecord,
Checkbox2: OS$Model.ValidationWidgetRecord,
Input_CreditNoteValue: OS$Model.ValidationWidgetRecord,
Checkbox3: OS$Model.ValidationWidgetRecord,
Input_VoucherValue: OS$Model.ValidationWidgetRecord,
Checkbox4: OS$Model.ValidationWidgetRecord,
Input_PEP: OS$Model.ValidationWidgetRecord,
Input_DeliveryDateLine: OS$Model.ValidationWidgetRecord,
Input_InvoiceQtt: OS$Model.ValidationWidgetRecord,
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

if("FilesList" in inputs) {
this.variables.filesListIn = inputs.FilesList;
if("_filesListInDataFetchStatus" in inputs) {
this.variables._filesListInDataFetchStatus = inputs._filesListInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


