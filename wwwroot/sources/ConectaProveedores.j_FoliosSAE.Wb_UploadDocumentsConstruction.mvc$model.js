import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure, ST_b2fd0f57faec93f17ef861f417f1cd5cStructure, ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure } from "./ConectaProveedores.model.js";
import BigUpload_BigUpload_wb_BigUploadMultipleFiles_mvcModel from "./BigUpload.BigUpload.wb_BigUploadMultipleFiles.mvc$model.js";
import OutSystemsUI_Content_Tag_mvcModel from "./OutSystemsUI.Content.Tag.mvc$model.js";
import Telcel_Theme_Utils_Wb_ShortText_mvcModel from "./Telcel_Theme.Utils.Wb_ShortText.mvc$model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ErrorMsg", "errorMsgVar", "ErrorMsg", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("FilesList", "filesListVar", "FilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("ListAux", "listAuxVar", "ListAux", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_b2fd0f57faec93f17ef861f417f1cd5cStructure))), 
this.attr("l_ErrorMsgAlreadySent", "l_ErrorMsgAlreadySentVar", "l_ErrorMsgAlreadySent", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("List", "listIn", "List", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure))), 
this.attr("_listInDataFetchStatus", "_listInDataFetchStatus", "_listInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OrderNumber", "orderNumberIn", "OrderNumber", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_orderNumberInDataFetchStatus", "_orderNumberInDataFetchStatus", "_orderNumberInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsUpdate", "isUpdateIn", "IsUpdate", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isUpdateInDataFetchStatus", "_isUpdateInDataFetchStatus", "_isUpdateInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {};
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

static get hasValidationWidgets() {if((Model._hasValidationWidgetsValue === undefined)) {
Model._hasValidationWidgetsValue = (((BigUpload_BigUpload_wb_BigUploadMultipleFiles_mvcModel.hasValidationWidgets || OutSystemsUI_Content_Tag_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_ShortText_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("List" in inputs) {
this.variables.listIn = inputs.List;
if("_listInDataFetchStatus" in inputs) {
this.variables._listInDataFetchStatus = inputs._listInDataFetchStatus;
}

}

if("OrderNumber" in inputs) {
this.variables.orderNumberIn = inputs.OrderNumber;
if("_orderNumberInDataFetchStatus" in inputs) {
this.variables._orderNumberInDataFetchStatus = inputs._orderNumberInDataFetchStatus;
}

}

if("IsUpdate" in inputs) {
this.variables.isUpdateIn = inputs.IsUpdate;
if("_isUpdateInDataFetchStatus" in inputs) {
this.variables._isUpdateInDataFetchStatus = inputs._isUpdateInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


