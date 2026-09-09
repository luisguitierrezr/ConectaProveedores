import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";



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
this.attr("InvoiceId", "invoiceIdIn", "InvoiceId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_invoiceIdInDataFetchStatus", "_invoiceIdInDataFetchStatus", "_invoiceIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_InvoiceApprovalLevelId", "i_InvoiceApprovalLevelIdIn", "i_InvoiceApprovalLevelId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_InvoiceApprovalLevelIdInDataFetchStatus", "_i_InvoiceApprovalLevelIdInDataFetchStatus", "_i_InvoiceApprovalLevelIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
if("InvoiceId" in inputs) {
this.variables.invoiceIdIn = inputs.InvoiceId;
if("_invoiceIdInDataFetchStatus" in inputs) {
this.variables._invoiceIdInDataFetchStatus = inputs._invoiceIdInDataFetchStatus;
}

}

if("i_InvoiceApprovalLevelId" in inputs) {
this.variables.i_InvoiceApprovalLevelIdIn = inputs.i_InvoiceApprovalLevelId;
if("_i_InvoiceApprovalLevelIdInDataFetchStatus" in inputs) {
this.variables._i_InvoiceApprovalLevelIdInDataFetchStatus = inputs._i_InvoiceApprovalLevelIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


