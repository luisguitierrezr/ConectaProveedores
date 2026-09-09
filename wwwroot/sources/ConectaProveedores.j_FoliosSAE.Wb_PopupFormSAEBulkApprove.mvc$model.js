import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { RC_9983883fbc26c5bf3e842f01355fd0c8 } from "./ConectaProveedores.model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_Comment", "l_CommentVar", "l_Comment", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_IsExecuting", "l_IsExecutingVar", "l_IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_FormApprovalLevelList", "l_FormApprovalLevelListIn", "l_FormApprovalLevelList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_9983883fbc26c5bf3e842f01355fd0c8))());
}, false, (OS$GenericTypeCache.getGenericList(RC_9983883fbc26c5bf3e842f01355fd0c8))), 
this.attr("_l_FormApprovalLevelListInDataFetchStatus", "_l_FormApprovalLevelListInDataFetchStatus", "_l_FormApprovalLevelListInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
TextArea_l_Comment: OS$Model.ValidationWidgetRecord
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
if("l_FormApprovalLevelList" in inputs) {
this.variables.l_FormApprovalLevelListIn = inputs.l_FormApprovalLevelList;
if("_l_FormApprovalLevelListInDataFetchStatus" in inputs) {
this.variables._l_FormApprovalLevelListInDataFetchStatus = inputs._l_FormApprovalLevelListInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


