import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_f5e2444cde8ccebe1d8b8fbec7a36039 } from "./ConectaProveedores.model.js";
import OutSystemsUI_Interaction_ScrollableArea_mvcModel from "./OutSystemsUI.Interaction.ScrollableArea.mvc$model.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvcModel from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$model.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvcModel from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvcModel from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$model.js";

class GetInvoiceItemsByInvoiceIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_f5e2444cde8ccebe1d8b8fbec7a36039));
}
static fromStructure(str) {
return new GetInvoiceItemsByInvoiceIdAggrRec(new GetInvoiceItemsByInvoiceIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceItemsByInvoiceIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_ColumnJSONVar", "l_ColumnJSONVarVar", "l_ColumnJSONVar", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_CountAfterFetch", "l_CountAfterFetchVar", "l_CountAfterFetch", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_Loading", "l_LoadingVar", "l_Loading", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ReInvokeToggler", "l_ReInvokeTogglerVar", "l_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_StartIndex", "l_StartIndexVar", "l_StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_TableSort", "l_TableSortVar", "l_TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("i_InvoiceId", "i_InvoiceIdIn", "i_InvoiceId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_InvoiceIdInDataFetchStatus", "_i_InvoiceIdInDataFetchStatus", "_i_InvoiceIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetInvoiceItemsByInvoiceId", "getInvoiceItemsByInvoiceIdAggr", "GetInvoiceItemsByInvoiceId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceItemsByInvoiceIdAggrRec());
}, true, GetInvoiceItemsByInvoiceIdAggrRec)
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
Model._hasValidationWidgetsValue = (((OutSystemsUI_Interaction_ScrollableArea_mvcModel.hasValidationWidgets || ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_CustomPagination_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_Wb_SetTableRecord_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_InvoiceId" in inputs) {
this.variables.i_InvoiceIdIn = inputs.i_InvoiceId;
if("_i_InvoiceIdInDataFetchStatus" in inputs) {
this.variables._i_InvoiceIdInDataFetchStatus = inputs._i_InvoiceIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


