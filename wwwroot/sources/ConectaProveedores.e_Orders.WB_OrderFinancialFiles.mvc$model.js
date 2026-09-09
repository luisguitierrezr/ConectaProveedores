import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_2563c789f5f898fb1c6cb65b6b599fae, RC_47b8b3c05056f6c3d5b8f5b05dd1c032 } from "./ConectaProveedores.model.js";
import ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_mvcModel from "./ConectaProveedores.e_OrdersRequestFiles.wb_RejectReason.mvc$model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import Telcel_Theme_Utils_Wb_Status_mvcModel from "./Telcel_Theme.Utils.Wb_Status.mvc$model.js";
import ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvcModel from "./ConectaProveedores.d_Invoices.Wb_InvoicesFilesPreview.mvc$model.js";
import ConectaProveedores_e_Orders_Wb_OrderFilesPreview_mvcModel from "./ConectaProveedores.e_Orders.Wb_OrderFilesPreview.mvc$model.js";
import ConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_mvcModel from "./ConectaProveedores.e_Orders.Wb_OrderFinancialFilesPreview.mvc$model.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_mvcModel from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementFinancialFileWithoutAcc.mvc$model.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_mvcModel from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadOrderContractDocuments.mvc$model.js";

class GetOrderAccountingsByOrderIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_2563c789f5f898fb1c6cb65b6b599fae));
}
static fromStructure(str) {
return new GetOrderAccountingsByOrderIdAggrRec(new GetOrderAccountingsByOrderIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderAccountingsByOrderIdAggrRec.init();

class GetOrderFileByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_47b8b3c05056f6c3d5b8f5b05dd1c032));
}
static fromStructure(str) {
return new GetOrderFileByIdAggrRec(new GetOrderFileByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderFileByIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_ShowPopupFinancial", "l_ShowPopupFinancialVar", "l_ShowPopupFinancial", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_OrderAccConceptsId", "l_OrderAccConceptsIdVar", "l_OrderAccConceptsId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_AccountingDataTypeId", "l_AccountingDataTypeIdVar", "l_AccountingDataTypeId", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("l_ShowContractPopup", "l_ShowContractPopupVar", "l_ShowContractPopup", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("l_OrderContractFile", "l_OrderContractFileVar", "l_OrderContractFile", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("l_OrderRequestFileIdSelected", "l_OrderRequestFileIdSelectedVar", "l_OrderRequestFileIdSelected", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("i_OrderId", "i_OrderIdIn", "i_OrderId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", "_i_OrderIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetOrderAccountingsByOrderId", "getOrderAccountingsByOrderIdAggr", "GetOrderAccountingsByOrderId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderAccountingsByOrderIdAggrRec());
}, true, GetOrderAccountingsByOrderIdAggrRec), 
this.attr("GetOrderFileById", "getOrderFileByIdAggr", "GetOrderFileById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderFileByIdAggrRec());
}, true, GetOrderFileByIdAggrRec)
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
Model._hasValidationWidgetsValue = (((((((ConectaProveedores_e_OrdersRequestFiles_wb_RejectReason_mvcModel.hasValidationWidgets || OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets) || Telcel_Theme_Utils_Wb_Status_mvcModel.hasValidationWidgets) || ConectaProveedores_d_Invoices_Wb_InvoicesFilesPreview_mvcModel.hasValidationWidgets) || ConectaProveedores_e_Orders_Wb_OrderFilesPreview_mvcModel.hasValidationWidgets) || ConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_mvcModel.hasValidationWidgets) || ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_mvcModel.hasValidationWidgets) || ConectaProveedores_e_OrdersRequestFiles_Wb_UploadOrderContractDocuments_mvcModel.hasValidationWidgets);
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


