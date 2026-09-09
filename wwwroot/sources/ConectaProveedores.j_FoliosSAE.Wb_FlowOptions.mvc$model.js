import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord } from "./WorkflowEngine.model.js";
import OutSystemsUI_Interaction_DropdownSearch_mvcModel from "./OutSystemsUI.Interaction.DropdownSearch.mvc$model.js";


class GetApprovalProcessesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ApprovalProcessesList", "approvalProcessesListOut", "ApprovalProcessesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord))());
}, true, (OS$GenericTypeCache.getGenericList(EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetApprovalProcessesDataActRec(new GetApprovalProcessesDataActRec.RecordClass({
approvalProcessesListOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetApprovalProcessesDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_ApprovalProcessId", "l_ApprovalProcessIdVar", "l_ApprovalProcessId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_IsMandatoryError", "l_IsMandatoryErrorVar", "l_IsMandatoryError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_ApplicantId", "i_ApplicantIdIn", "i_ApplicantId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_ApplicantIdInDataFetchStatus", "_i_ApplicantIdInDataFetchStatus", "_i_ApplicantIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_FolioId", "i_FolioIdIn", "i_FolioId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", "_i_FolioIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_MandatoryError", "i_MandatoryErrorIn", "i_MandatoryError", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_MandatoryErrorInDataFetchStatus", "_i_MandatoryErrorInDataFetchStatus", "_i_MandatoryErrorInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetApprovalProcesses", "getApprovalProcessesDataAct", "GetApprovalProcesses", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetApprovalProcessesDataActRec());
}, true, GetApprovalProcessesDataActRec)
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
Model._hasValidationWidgetsValue = OutSystemsUI_Interaction_DropdownSearch_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_ApplicantId" in inputs) {
this.variables.i_ApplicantIdIn = inputs.i_ApplicantId;
if("_i_ApplicantIdInDataFetchStatus" in inputs) {
this.variables._i_ApplicantIdInDataFetchStatus = inputs._i_ApplicantIdInDataFetchStatus;
}

}

if("i_FolioId" in inputs) {
this.variables.i_FolioIdIn = inputs.i_FolioId;
if("_i_FolioIdInDataFetchStatus" in inputs) {
this.variables._i_FolioIdInDataFetchStatus = inputs._i_FolioIdInDataFetchStatus;
}

}

if("i_MandatoryError" in inputs) {
this.variables.i_MandatoryErrorIn = inputs.i_MandatoryError;
if("_i_MandatoryErrorInDataFetchStatus" in inputs) {
this.variables._i_MandatoryErrorInDataFetchStatus = inputs._i_MandatoryErrorInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


