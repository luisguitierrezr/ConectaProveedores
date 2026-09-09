import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ST_f54c1d1bac41c2667837ac97bb484830Structure } from "./ConectaProveedores.model.js";
import OutSystemsUI_Adaptive_Columns2_mvcModel from "./OutSystemsUI.Adaptive.Columns2.mvc$model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ValidationReport", "validationReportIn", "ValidationReport", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_f54c1d1bac41c2667837ac97bb484830Structure());
}, false, ST_f54c1d1bac41c2667837ac97bb484830Structure), 
this.attr("_validationReportInDataFetchStatus", "_validationReportInDataFetchStatus", "_validationReportInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("IsFromRequisition", "isFromRequisitionIn", "IsFromRequisition", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_isFromRequisitionInDataFetchStatus", "_isFromRequisitionInDataFetchStatus", "_isFromRequisitionInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
Model._hasValidationWidgetsValue = OutSystemsUI_Adaptive_Columns2_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("ValidationReport" in inputs) {
this.variables.validationReportIn = inputs.ValidationReport;
if("_validationReportInDataFetchStatus" in inputs) {
this.variables._validationReportInDataFetchStatus = inputs._validationReportInDataFetchStatus;
}

}

if("IsFromRequisition" in inputs) {
this.variables.isFromRequisitionIn = inputs.IsFromRequisition;
if("_isFromRequisitionInDataFetchStatus" in inputs) {
this.variables._isFromRequisitionInDataFetchStatus = inputs._isFromRequisitionInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


