import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_dc345357879dcb92e41eacae4ac8926c } from "./ConectaProveedores.model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_mvcModel from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsPreviewFiles.mvc$model.js";

class RequisitionFilesByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_dc345357879dcb92e41eacae4ac8926c));
}
static fromStructure(str) {
return new RequisitionFilesByIdAggrRec(new RequisitionFilesByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

RequisitionFilesByIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_PreviewFilesToggler", "l_PreviewFilesTogglerVar", "l_PreviewFilesToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("RequisitionId", "requisitionIdIn", "RequisitionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_requisitionIdInDataFetchStatus", "_requisitionIdInDataFetchStatus", "_requisitionIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("RequisitionName", "requisitionNameIn", "RequisitionName", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_requisitionNameInDataFetchStatus", "_requisitionNameInDataFetchStatus", "_requisitionNameInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("RequisitionFilesById", "requisitionFilesByIdAggr", "RequisitionFilesById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RequisitionFilesByIdAggrRec());
}, true, RequisitionFilesByIdAggrRec)
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
Model._hasValidationWidgetsValue = ((OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets || OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets) || ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("RequisitionId" in inputs) {
this.variables.requisitionIdIn = inputs.RequisitionId;
if("_requisitionIdInDataFetchStatus" in inputs) {
this.variables._requisitionIdInDataFetchStatus = inputs._requisitionIdInDataFetchStatus;
}

}

if("RequisitionName" in inputs) {
this.variables.requisitionNameIn = inputs.RequisitionName;
if("_requisitionNameInDataFetchStatus" in inputs) {
this.variables._requisitionNameInDataFetchStatus = inputs._requisitionNameInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


