import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_269041044ca0bb6901788ecb5d297c5eEntityRecord, RC_d920d0aa189b36e12964653ae47b2e42, EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord, RC_4d06af040e4a89ed9c35b745b328b97d } from "./ConectaProveedores.model.js";
import { EN_327b52812b8badb247bde4975c10d441EntityRecord } from "./Common.model.js";
import { EN_a6239c65aa61ed4530d18a92034301bbEntityRecord, EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord } from "./Organization.model.js";

class GetSpecialApprovalsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_269041044ca0bb6901788ecb5d297c5eEntityRecord, {
name: "SpecialApproval",
attrName: "specialApprovalAttr",
nameForJson: "SpecialApproval",
uniqueId: "34acf115-5396-4937-c377-a82c97a2edf5"
}))));
}
static fromStructure(str) {
return new GetSpecialApprovalsAggrRec(new GetSpecialApprovalsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSpecialApprovalsAggrRec.init();

class GetCurrenciesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_327b52812b8badb247bde4975c10d441EntityRecord, {
name: "Currency",
attrName: "currencyAttr",
nameForJson: "Currency",
uniqueId: "0468f02f-35e6-ccd6-a092-f321c5d8a88e"
}))));
}
static fromStructure(str) {
return new GetCurrenciesAggrRec(new GetCurrenciesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetCurrenciesAggrRec.init();

class GetInvoicesSAPAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_d920d0aa189b36e12964653ae47b2e42));
}
static fromStructure(str) {
return new GetInvoicesSAPAggrRec(new GetInvoicesSAPAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoicesSAPAggrRec.init();

class GetFrequenciesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_a6239c65aa61ed4530d18a92034301bbEntityRecord, {
name: "Frequency",
attrName: "frequencyAttr",
nameForJson: "Frequency",
uniqueId: "f2c609d8-58f8-411e-75fb-edee60c5dddf"
}))));
}
static fromStructure(str) {
return new GetFrequenciesAggrRec(new GetFrequenciesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFrequenciesAggrRec.init();

class GetInvoiceStatusAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord, {
name: "InvoiceStatus",
attrName: "invoiceStatusAttr",
nameForJson: "InvoiceStatus",
uniqueId: "6edb17c5-bf63-452f-f4ac-24d41991a940"
}))));
}
static fromStructure(str) {
return new GetInvoiceStatusAggrRec(new GetInvoiceStatusAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceStatusAggrRec.init();

class GetAccountingDataTypesAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord, {
name: "AccountingDataType",
attrName: "accountingDataTypeAttr",
nameForJson: "AccountingDataType",
uniqueId: "a222d17a-2b10-e551-d257-fa2f5892499c"
}))));
}
static fromStructure(str) {
return new GetAccountingDataTypesAggrRec(new GetAccountingDataTypesAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetAccountingDataTypesAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_ColumnJSONVar", "l_ColumnJSONVarVar", "l_ColumnJSONVar", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_CountAfterFetch", "l_CountAfterFetchVar", "l_CountAfterFetch", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_Loading", "l_LoadingVar", "l_Loading", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ReInvokeToggler", "l_ReInvokeTogglerVar", "l_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_StartIndex", "l_StartIndexVar", "l_StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_TableSort", "l_TableSortVar", "l_TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_IsSelected", "l_IsSelectedVar", "l_IsSelected", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsSelectAll", "l_IsSelectAllVar", "l_IsSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_IsShowSelectAll", "l_IsShowSelectAllVar", "l_IsShowSelectAll", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ShowFilters", "l_ShowFiltersVar", "l_ShowFilters", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("SelectedIds", "selectedIdsVar", "SelectedIds", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_ShowDetails", "l_ShowDetailsVar", "l_ShowDetails", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_InvoiceId", "l_InvoiceIdVar", "l_InvoiceId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("IsAnyBulkApprovable", "isAnyBulkApprovableVar", "IsAnyBulkApprovable", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_FolioId", "l_FolioIdVar", "l_FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_AmountFromText", "l_AmountFromTextVar", "l_AmountFromText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_AmountToText", "l_AmountToTextVar", "l_AmountToText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_TotalsList", "l_TotalsListVar", "l_TotalsList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_4d06af040e4a89ed9c35b745b328b97d))());
}, false, (OS$GenericTypeCache.getGenericList(RC_4d06af040e4a89ed9c35b745b328b97d))), 
this.attr("l_IsCalculating", "l_IsCalculatingVar", "l_IsCalculating", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_TotalSelected", "l_TotalSelectedVar", "l_TotalSelected", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("GetSpecialApprovals", "getSpecialApprovalsAggr", "GetSpecialApprovals", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSpecialApprovalsAggrRec());
}, true, GetSpecialApprovalsAggrRec), 
this.attr("GetCurrencies", "getCurrenciesAggr", "GetCurrencies", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetCurrenciesAggrRec());
}, true, GetCurrenciesAggrRec), 
this.attr("GetInvoicesSAP", "getInvoicesSAPAggr", "GetInvoicesSAP", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoicesSAPAggrRec());
}, true, GetInvoicesSAPAggrRec), 
this.attr("GetFrequencies", "getFrequenciesAggr", "GetFrequencies", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFrequenciesAggrRec());
}, true, GetFrequenciesAggrRec), 
this.attr("GetInvoiceStatus", "getInvoiceStatusAggr", "GetInvoiceStatus", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceStatusAggrRec());
}, true, GetInvoiceStatusAggrRec), 
this.attr("GetAccountingDataTypes", "getAccountingDataTypesAggr", "GetAccountingDataTypes", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetAccountingDataTypesAggrRec());
}, true, GetAccountingDataTypesAggrRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_InvoiceNumber: OS$Model.ValidationWidgetRecord,
Input_FolioNumber: OS$Model.ValidationWidgetRecord,
InvoiceStatusFilter: OS$Model.ValidationWidgetRecord,
OrderNumberFilter: OS$Model.ValidationWidgetRecord,
UserNameFilter: OS$Model.ValidationWidgetRecord,
ProjectFilter: OS$Model.ValidationWidgetRecord,
PeriodFilter: OS$Model.ValidationWidgetRecord,
FrequencyFilter: OS$Model.ValidationWidgetRecord,
BusinessValueCategoryFilter: OS$Model.ValidationWidgetRecord,
BusinessValueSubcategoryFilter: OS$Model.ValidationWidgetRecord,
Input_PaymentDate: OS$Model.ValidationWidgetRecord,
Input_AmountML3: OS$Model.ValidationWidgetRecord,
Input_AmountML2: OS$Model.ValidationWidgetRecord,
CurrencyFilter: OS$Model.ValidationWidgetRecord,
Input_InvoiceDate: OS$Model.ValidationWidgetRecord,
Input_ArrivalDate: OS$Model.ValidationWidgetRecord,
CFDITypeFilter3: OS$Model.ValidationWidgetRecord,
CFDITypeFilter4: OS$Model.ValidationWidgetRecord,
Checkbox_IsSelectAll: OS$Model.ValidationWidgetRecord,
Checkbox_IsSelected: OS$Model.ValidationWidgetRecord
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
}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


