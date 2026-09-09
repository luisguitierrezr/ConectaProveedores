import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { RC_03b2a2565369f3088e5267bce38cfba9, RC_7170c97aaf61dfa14af07f5ef3cecd45, RC_0b2176705fa164c9531eb643caf0e9d4, EN_d1d0320db36efbb094ad0082361435a0EntityRecord, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, EN_f81a3d226103fd013068b8763798067aEntityRecord, ST_aa3e6001f162e602247a2e2cc13e2cf8Structure } from "./ConectaProveedores.model.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";

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


class GetFirstApproverListDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("FirstApproverList", "firstApproverListOut", "FirstApproverList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_7170c97aaf61dfa14af07f5ef3cecd45))());
}, true, (OS$GenericTypeCache.getGenericList(RC_7170c97aaf61dfa14af07f5ef3cecd45)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetFirstApproverListDataActRec(new GetFirstApproverListDataActRec.RecordClass({
firstApproverListOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFirstApproverListDataActRec.init();

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
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
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
this.attr("WithFilesError", "withFilesErrorVar", "WithFilesError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("WithProrata", "withProrataVar", "WithProrata", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("ApproverValid", "approverValidVar", "ApproverValid", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("ApproverErrorMessage", "approverErrorMessageVar", "ApproverErrorMessage", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("firstUserIdentifier", "firstUserIdentifierVar", "firstUserIdentifier", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("OrderAccConceptsIdToCreate", "orderAccConceptsIdToCreateVar", "OrderAccConceptsIdToCreate", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("DatesQuantityPEPError", "datesQuantityPEPErrorVar", "DatesQuantityPEPError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return true;
}, false), 
this.attr("MaxAmountError", "maxAmountErrorVar", "MaxAmountError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
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
this.attr("CreditNoteFilesList", "creditNoteFilesListVar", "CreditNoteFilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("CreditNoteInvoiceToCreate", "creditNoteInvoiceToCreateVar", "CreditNoteInvoiceToCreate", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new EN_d1d0320db36efbb094ad0082361435a0EntityRecord());
}, false, EN_d1d0320db36efbb094ad0082361435a0EntityRecord), 
this.attr("CreditNote_IsNeeded", "creditNote_IsNeededVar", "CreditNote_IsNeeded", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("L_IsNational", "l_IsNationalVar", "L_IsNational", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("InvoiceExtendedToCreate", "invoiceExtendedToCreateVar", "InvoiceExtendedToCreate", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new EN_f81a3d226103fd013068b8763798067aEntityRecord());
}, false, EN_f81a3d226103fd013068b8763798067aEntityRecord), 
this.attr("l_ImportAnticipo", "l_ImportAnticipoVar", "l_ImportAnticipo", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$DataTypes.Decimal.defaultValue;
}, false), 
this.attr("i_OrderId", "i_OrderIdIn", "i_OrderId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("LocalSelectedLines", "localSelectedLinesIn", "LocalSelectedLines", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_aa3e6001f162e602247a2e2cc13e2cf8Structure))), 
this.attr("_localSelectedLinesInDataFetchStatus", "_localSelectedLinesInDataFetchStatus", "_localSelectedLinesInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("AprovalProcessTypeId", "aprovalProcessTypeIdIn", "AprovalProcessTypeId", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_aprovalProcessTypeIdInDataFetchStatus", "_aprovalProcessTypeIdInDataFetchStatus", "_aprovalProcessTypeIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetOrderDetail", "getOrderDetailAggr", "GetOrderDetail", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderDetailAggrRec());
}, true, GetOrderDetailAggrRec), 
this.attr("GetFirstApproverList", "getFirstApproverListDataAct", "GetFirstApproverList", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFirstApproverListDataActRec());
}, true, GetFirstApproverListDataActRec), 
this.attr("GetSettings", "getSettingsDataAct", "GetSettings", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSettingsDataActRec());
}, true, GetSettingsDataActRec), 
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

if("LocalSelectedLines" in inputs) {
this.variables.localSelectedLinesIn = inputs.LocalSelectedLines;
if("_localSelectedLinesInDataFetchStatus" in inputs) {
this.variables._localSelectedLinesInDataFetchStatus = inputs._localSelectedLinesInDataFetchStatus;
}

}

if("AprovalProcessTypeId" in inputs) {
this.variables.aprovalProcessTypeIdIn = inputs.AprovalProcessTypeId;
if("_aprovalProcessTypeIdInDataFetchStatus" in inputs) {
this.variables._aprovalProcessTypeIdInDataFetchStatus = inputs._aprovalProcessTypeIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


