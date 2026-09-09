import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_def4a4b06f199364b3c4464c2355286a } from "./ConectaProveedores.model.js";
import OutSystemsUI_Interaction_ScrollableArea_mvcModel from "./OutSystemsUI.Interaction.ScrollableArea.mvc$model.js";
import Telcel_Theme_Utils_Wb_Status_mvcModel from "./Telcel_Theme.Utils.Wb_Status.mvc$model.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvcModel from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$model.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvcModel from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvcModel from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvcModel from "./ConectaProveedores.y_Utils.Wb_ConfirmPopup.mvc$model.js";

class GetFoliosBySupplierIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_def4a4b06f199364b3c4464c2355286a));
}
static fromStructure(str) {
return new GetFoliosBySupplierIdAggrRec(new GetFoliosBySupplierIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFoliosBySupplierIdAggrRec.init();



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
this.attr("l_ReInvokeToggler", "l_ReInvokeTogglerVar", "l_ReInvokeToggler", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_ColumnJSONVarGetFolios", "l_ColumnJSONVarGetFoliosVar", "l_ColumnJSONVarGetFolios", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("l_FolioIdSelectedToCancel", "l_FolioIdSelectedToCancelVar", "l_FolioIdSelectedToCancel", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_ShowCancellationConfirmPopup", "l_ShowCancellationConfirmPopupVar", "l_ShowCancellationConfirmPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("OrderId", "orderIdIn", "OrderId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_orderIdInDataFetchStatus", "_orderIdInDataFetchStatus", "_orderIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFoliosBySupplierId", "getFoliosBySupplierIdAggr", "GetFoliosBySupplierId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFoliosBySupplierIdAggrRec());
}, true, GetFoliosBySupplierIdAggrRec)
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
Model._hasValidationWidgetsValue = (((((OutSystemsUI_Interaction_ScrollableArea_mvcModel.hasValidationWidgets || Telcel_Theme_Utils_Wb_Status_mvcModel.hasValidationWidgets) || ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_CustomPagination_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_Wb_SetTableRecord_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("OrderId" in inputs) {
this.variables.orderIdIn = inputs.OrderId;
if("_orderIdInDataFetchStatus" in inputs) {
this.variables._orderIdInDataFetchStatus = inputs._orderIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


