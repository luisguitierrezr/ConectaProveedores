import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ST_ba28fce29317fb1a65969ecb0fce5c4bStructure } from "./ConectaProveedores.model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_Filename", "l_FilenameVar", "l_Filename", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_BinaryData", "l_BinaryDataVar", "l_BinaryData", true, false, OS$DataTypes.DataTypes.BinaryData, function () {
return OS$DataTypes.BinaryData.defaultValue;
}, false), 
this.attr("l_IsLoading", "l_IsLoadingVar", "l_IsLoading", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ProposalTempData", "l_ProposalTempDataVar", "l_ProposalTempData", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_ba28fce29317fb1a65969ecb0fce5c4bStructure());
}, false, ST_ba28fce29317fb1a65969ecb0fce5c4bStructure), 
this.attr("l_ValidationMessage", "l_ValidationMessageVar", "l_ValidationMessage", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_IsExecuting", "l_IsExecutingVar", "l_IsExecuting", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Upload: OS$Model.ValidationWidgetRecord,
Input_Filename: OS$Model.ValidationWidgetRecord,
ProposalTypeId: OS$Model.ValidationWidgetRecord,
Input_PaymentDate: OS$Model.ValidationWidgetRecord,
Input_Bank: OS$Model.ValidationWidgetRecord,
Input_Name: OS$Model.ValidationWidgetRecord
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


