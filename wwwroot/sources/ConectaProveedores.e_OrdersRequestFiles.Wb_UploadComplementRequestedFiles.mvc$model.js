import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord } from "./ConectaProveedores.model.js";
import ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_mvcModel from "./ConectaProveedores.e_OrdersRequestFiles.wb_RejectReason.mvc$model.js";
import ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvcModel from "./ConectaProveedores.d_Invoices.Wb_InvoicesFilesPreview.mvc$model.js";
import ConectaProveedores_e_Orders_Wb_OrderFilesPreview_mvcModel from "./ConectaProveedores.e_Orders.Wb_OrderFilesPreview.mvc$model.js";
import Telcel_Theme_Utils_Wb_Status_mvcModel from "./Telcel_Theme.Utils.Wb_Status.mvc$model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_mvcModel from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementFile.mvc$model.js";


class GetOrderRequestFilesDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("RequestFiles", "requestFilesOut", "RequestFiles", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord))());
}, true, (OS$GenericTypeCache.getGenericList(EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord)))
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

static fromStructure(str) {
return new GetOrderRequestFilesDataActRec(new GetOrderRequestFilesDataActRec.RecordClass({
requestFilesOut: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderRequestFilesDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_RequestFileId", "l_RequestFileIdVar", "l_RequestFileId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("ShowPopup", "showPopupVar", "ShowPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("i_OrderId", "i_OrderIdIn", "i_OrderId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetOrderRequestFiles", "getOrderRequestFilesDataAct", "GetOrderRequestFiles", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderRequestFilesDataActRec());
}, true, GetOrderRequestFilesDataActRec)
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
Model._hasValidationWidgetsValue = (((((ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_mvcModel.hasValidationWidgets || ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvcModel.hasValidationWidgets) || ConectaProveedores_e_Orders_Wb_OrderFilesPreview_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_Status_mvcModel.hasValidationWidgets) || OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets) || ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFile_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_OrderId" in inputs) {
this.variables.i_OrderIdIn = inputs.i_OrderId;
if("_i_OrderIdInDataFetchStatus" in inputs) {
this.variables._i_OrderIdInDataFetchStatus = inputs._i_OrderIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


