import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_79a64780c4264a7ff3588d1347b5f259, RC_03b2a2565369f3088e5267bce38cfba9, ST_714c559a98f1e1080cbf60de3228e843Structure, RC_0b2176705fa164c9531eb643caf0e9d4, ST_b2fd0f57faec93f17ef861f417f1cd5cStructure, EN_d1d0320db36efbb094ad0082361435a0EntityRecord, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, RC_1c2482ce6cd4b83ca44ec0510b231d44, ST_aa3e6001f162e602247a2e2cc13e2cf8Structure } from "./ConectaProveedores.model.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";

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

class GetSettingsDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_IsActiveDEV_HU13008_Complement", "o_IsActiveDEV_HU13008_ComplementOut", "o_IsActiveDEV_HU13008_Complement", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetSettingsDataActRec(new GetSettingsDataActRec.RecordClass({
o_IsActiveDEV_HU13008_ComplementOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSettingsDataActRec.init();

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
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure))());
}, true, (OS$GenericTypeCache.getGenericList(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetMinutesDocumentsDataActRec(new GetMinutesDocumentsDataActRec.RecordClass({
listOut: OS$DataTypes.ImmutableBase.getData(str)
}));
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
this.attr("MaxAmountError", "maxAmountErrorVar", "MaxAmountError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("DatesQuantityPEPError", "datesQuantityPEPErrorVar", "DatesQuantityPEPError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("WithFilesError", "withFilesErrorVar", "WithFilesError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("WithDatesError", "withDatesErrorVar", "WithDatesError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("WithQuantityError", "withQuantityErrorVar", "WithQuantityError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("WithPaymentError", "withPaymentErrorVar", "WithPaymentError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("WithConceptMinutesError", "withConceptMinutesErrorVar", "WithConceptMinutesError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("WithApprovalProcessError", "withApprovalProcessErrorVar", "WithApprovalProcessError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("Withprorata", "withprorataVar", "Withprorata", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
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
this.attr("MinuteSelected", "minuteSelectedVar", "MinuteSelected", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("ConstructionStruct", "constructionStructVar", "ConstructionStruct", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RC_1c2482ce6cd4b83ca44ec0510b231d44());
}, false, RC_1c2482ce6cd4b83ca44ec0510b231d44), 
this.attr("MinuteDocumentTypeList", "minuteDocumentTypeListVar", "MinuteDocumentTypeList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure))), 
this.attr("l_ApprovalProcessId", "l_ApprovalProcessIdVar", "l_ApprovalProcessId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("i_OrderId", "i_OrderIdIn", "i_OrderId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ApplicantId", "applicantIdIn", "ApplicantId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_applicantIdInDataFetchStatus", "_applicantIdInDataFetchStatus", "_applicantIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("LocalSelectedLines", "localSelectedLinesIn", "LocalSelectedLines", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))), 
this.attr("_localSelectedLinesInDataFetchStatus", "_localSelectedLinesInDataFetchStatus", "_localSelectedLinesInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetApprovalList", "getApprovalListAggr", "GetApprovalList", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetApprovalListAggrRec());
}, true, GetApprovalListAggrRec), 
this.attr("GetOrderDetail", "getOrderDetailAggr", "GetOrderDetail", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderDetailAggrRec());
}, true, GetOrderDetailAggrRec), 
this.attr("GetMinutes", "getMinutesDataAct", "GetMinutes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetMinutesDataActRec());
}, true, GetMinutesDataActRec), 
this.attr("GetSettings", "getSettingsDataAct", "GetSettings", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSettingsDataActRec());
}, true, GetSettingsDataActRec), 
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
Form: OS$Model.ValidationWidgetRecord,
SwitchIsApplyToAll: OS$Model.ValidationWidgetRecord,
Input_DeliveryDate: OS$Model.ValidationWidgetRecord,
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
Input_InvoiceQtt: OS$Model.ValidationWidgetRecord
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
if("i_OrderId" in inputs) {
this.variables.i_OrderIdIn = inputs.i_OrderId;
if("_i_OrderIdInDataFetchStatus" in inputs) {
this.variables._i_OrderIdInDataFetchStatus = inputs._i_OrderIdInDataFetchStatus;
}

}

if("ApplicantId" in inputs) {
this.variables.applicantIdIn = inputs.ApplicantId;
if("_applicantIdInDataFetchStatus" in inputs) {
this.variables._applicantIdInDataFetchStatus = inputs._applicantIdInDataFetchStatus;
}

}

if("LocalSelectedLines" in inputs) {
this.variables.localSelectedLinesIn = inputs.LocalSelectedLines;
if("_localSelectedLinesInDataFetchStatus" in inputs) {
this.variables._localSelectedLinesInDataFetchStatus = inputs._localSelectedLinesInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


