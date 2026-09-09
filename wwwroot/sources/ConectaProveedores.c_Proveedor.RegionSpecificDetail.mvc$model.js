import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_8fe6259afe1f49269695fecf5b2d7937 } from "./ConectaProveedores.model.js";
import OutSystemsUI_Interaction_ScrollableArea_mvcModel from "./OutSystemsUI.Interaction.ScrollableArea.mvc$model.js";
import Telcel_Theme_Utils_Wb_Status_mvcModel from "./Telcel_Theme.Utils.Wb_Status.mvc$model.js";
import OutSystemsUI_Navigation_Pagination_mvcModel from "./OutSystemsUI.Navigation.Pagination.mvc$model.js";

class GetInvoiceApprovalLevelsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_8fe6259afe1f49269695fecf5b2d7937));
}
static fromStructure(str) {
return new GetInvoiceApprovalLevelsAggrRec(new GetInvoiceApprovalLevelsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceApprovalLevelsAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("MaxRecords", "maxRecordsVar", "MaxRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 50;
}, false), 
this.attr("i_RegionId", "i_RegionIdIn", "i_RegionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_RegionIdInDataFetchStatus", "_i_RegionIdInDataFetchStatus", "_i_RegionIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_SupplierId", "i_SupplierIdIn", "i_SupplierId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_SupplierIdInDataFetchStatus", "_i_SupplierIdInDataFetchStatus", "_i_SupplierIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_CurrentRowNumber", "i_CurrentRowNumberIn", "i_CurrentRowNumber", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_i_CurrentRowNumberInDataFetchStatus", "_i_CurrentRowNumberInDataFetchStatus", "_i_CurrentRowNumberInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetInvoiceApprovalLevels", "getInvoiceApprovalLevelsAggr", "GetInvoiceApprovalLevels", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceApprovalLevelsAggrRec());
}, true, GetInvoiceApprovalLevelsAggrRec)
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
Model._hasValidationWidgetsValue = ((OutSystemsUI_Interaction_ScrollableArea_mvcModel.hasValidationWidgets || Telcel_Theme_Utils_Wb_Status_mvcModel.hasValidationWidgets) || OutSystemsUI_Navigation_Pagination_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_RegionId" in inputs) {
this.variables.i_RegionIdIn = inputs.i_RegionId;
if("_i_RegionIdInDataFetchStatus" in inputs) {
this.variables._i_RegionIdInDataFetchStatus = inputs._i_RegionIdInDataFetchStatus;
}

}

if("i_SupplierId" in inputs) {
this.variables.i_SupplierIdIn = inputs.i_SupplierId;
if("_i_SupplierIdInDataFetchStatus" in inputs) {
this.variables._i_SupplierIdInDataFetchStatus = inputs._i_SupplierIdInDataFetchStatus;
}

}

if("i_CurrentRowNumber" in inputs) {
this.variables.i_CurrentRowNumberIn = inputs.i_CurrentRowNumber;
if("_i_CurrentRowNumberInDataFetchStatus" in inputs) {
this.variables._i_CurrentRowNumberInDataFetchStatus = inputs._i_CurrentRowNumberInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


