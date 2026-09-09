import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { RC_3b5a20a3b041a6f2c3616e35c15dcd14 } from "./ConectaProveedores.model.js";



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
this.attr("l_InvoiceApprovalLevelList", "l_InvoiceApprovalLevelListIn", "l_InvoiceApprovalLevelList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(RC_3b5a20a3b041a6f2c3616e35c15dcd14))());
}, false, (OS$GenericTypeCache.getGenericList(RC_3b5a20a3b041a6f2c3616e35c15dcd14))), 
this.attr("_l_InvoiceApprovalLevelListInDataFetchStatus", "_l_InvoiceApprovalLevelListInDataFetchStatus", "_l_InvoiceApprovalLevelListInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
if("l_InvoiceApprovalLevelList" in inputs) {
this.variables.l_InvoiceApprovalLevelListIn = inputs.l_InvoiceApprovalLevelList;
if("_l_InvoiceApprovalLevelListInDataFetchStatus" in inputs) {
this.variables._l_InvoiceApprovalLevelListInDataFetchStatus = inputs._l_InvoiceApprovalLevelListInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


