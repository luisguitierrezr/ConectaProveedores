import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { RC_d2eb0d0bdf3678ac335e4faafec1c741 } from "./ConectaProveedores.model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("SearchText", "searchTextVar", "SearchText", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("dummy", "dummyVar", "dummy", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("IsEnabled", "isEnabledIn", "IsEnabled", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isEnabledInDataFetchStatus", "_isEnabledInDataFetchStatus", "_isEnabledInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("ItemsList", "itemsListIn", "ItemsList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_d2eb0d0bdf3678ac335e4faafec1c741))());
}, false, (OS$GenericTypeCache.getGenericList(RC_d2eb0d0bdf3678ac335e4faafec1c741))), 
this.attr("_itemsListInDataFetchStatus", "_itemsListInDataFetchStatus", "_itemsListInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("MaxRecords", "maxRecordsIn", "MaxRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_maxRecordsInDataFetchStatus", "_maxRecordsInDataFetchStatus", "_maxRecordsInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("SelectedName", "selectedNameIn", "SelectedName", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_selectedNameInDataFetchStatus", "_selectedNameInDataFetchStatus", "_selectedNameInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_Prompt", "i_PromptIn", "i_Prompt", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_PromptInDataFetchStatus", "_i_PromptInDataFetchStatus", "_i_PromptInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_SupplierSearchText: OS$Model.ValidationWidgetRecord
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
if("IsEnabled" in inputs) {
this.variables.isEnabledIn = inputs.IsEnabled;
if("_isEnabledInDataFetchStatus" in inputs) {
this.variables._isEnabledInDataFetchStatus = inputs._isEnabledInDataFetchStatus;
}

}

if("ItemsList" in inputs) {
this.variables.itemsListIn = inputs.ItemsList;
if("_itemsListInDataFetchStatus" in inputs) {
this.variables._itemsListInDataFetchStatus = inputs._itemsListInDataFetchStatus;
}

}

if("MaxRecords" in inputs) {
this.variables.maxRecordsIn = inputs.MaxRecords;
if("_maxRecordsInDataFetchStatus" in inputs) {
this.variables._maxRecordsInDataFetchStatus = inputs._maxRecordsInDataFetchStatus;
}

}

if("SelectedName" in inputs) {
this.variables.selectedNameIn = inputs.SelectedName;
if("_selectedNameInDataFetchStatus" in inputs) {
this.variables._selectedNameInDataFetchStatus = inputs._selectedNameInDataFetchStatus;
}

}

if("i_Prompt" in inputs) {
this.variables.i_PromptIn = inputs.i_Prompt;
if("_i_PromptInDataFetchStatus" in inputs) {
this.variables._i_PromptInDataFetchStatus = inputs._i_PromptInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


