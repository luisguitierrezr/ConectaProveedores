import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { ST_b2fd0f57faec93f17ef861f417f1cd5cStructure, ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvcModel from "./ConectaProveedores.y_Utils.Wb_MultiFileUpload.mvc$model.js";
import OutSystemsUI_Content_Tag_mvcModel from "./OutSystemsUI.Content.Tag.mvc$model.js";
import Telcel_Theme_Utils_Wb_ShortText_mvcModel from "./Telcel_Theme.Utils.Wb_ShortText.mvc$model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";


class GetApproverDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("o_IsFirstApprover", "o_IsFirstApproverOut", "o_IsFirstApprover", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetApproverDataActRec(new GetApproverDataActRec.RecordClass({
o_IsFirstApproverOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetApproverDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ErrorMsg", "errorMsgVar", "ErrorMsg", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
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
this.attr("FilesList", "filesListIn", "FilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("_filesListInDataFetchStatus", "_filesListInDataFetchStatus", "_filesListInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_FolioId", "i_FolioIdIn", "i_FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetApprover", "getApproverDataAct", "GetApprover", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetApproverDataActRec());
}, true, GetApproverDataActRec)
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
Model._hasValidationWidgetsValue = (((ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvcModel.hasValidationWidgets || OutSystemsUI_Content_Tag_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_ShortText_mvcModel.hasValidationWidgets) || OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets);
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

if("FilesList" in inputs) {
this.variables.filesListIn = inputs.FilesList;
if("_filesListInDataFetchStatus" in inputs) {
this.variables._filesListInDataFetchStatus = inputs._filesListInDataFetchStatus;
}

}

if("i_FolioId" in inputs) {
this.variables.i_FolioIdIn = inputs.i_FolioId;
if("_i_FolioIdInDataFetchStatus" in inputs) {
this.variables._i_FolioIdInDataFetchStatus = inputs._i_FolioIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


