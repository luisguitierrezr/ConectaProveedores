import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { ST_a158c76eb93396680623c04244f48b6cStructure, ST_b453bea0930035904f55a74692afd3a8Structure } from "./ConectaProveedores.model.js";
import OutSystemsUI_Utilities_AlignCenter_mvcModel from "./OutSystemsUI.Utilities.AlignCenter.mvc$model.js";
import OutSystemsUI_Content_Tooltip_mvcModel from "./OutSystemsUI.Content.Tooltip.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvcModel from "./ConectaProveedores.y_Utils.Wb_CustomFileUpload.mvc$model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("l_File", "l_FileVar", "l_File", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_a158c76eb93396680623c04244f48b6cStructure());
}, false, ST_a158c76eb93396680623c04244f48b6cStructure), 
this.attr("l_Valid", "l_ValidVar", "l_Valid", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_b453bea0930035904f55a74692afd3a8Structure());
}, false, ST_b453bea0930035904f55a74692afd3a8Structure), 
this.attr("i_InvoiceId", "i_InvoiceIdIn", "i_InvoiceId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_InvoiceIdInDataFetchStatus", "_i_InvoiceIdInDataFetchStatus", "_i_InvoiceIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("SupplierNumber", "supplierNumberIn", "SupplierNumber", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_supplierNumberInDataFetchStatus", "_supplierNumberInDataFetchStatus", "_supplierNumberInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("TotalAmount", "totalAmountIn", "TotalAmount", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$DataTypes.Decimal.defaultValue;
}, false), 
this.attr("_totalAmountInDataFetchStatus", "_totalAmountInDataFetchStatus", "_totalAmountInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_InvoiceAccountingId", "i_InvoiceAccountingIdIn", "i_InvoiceAccountingId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_InvoiceAccountingIdInDataFetchStatus", "_i_InvoiceAccountingIdInDataFetchStatus", "_i_InvoiceAccountingIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
Model._hasValidationWidgetsValue = ((OutSystemsUI_Utilities_AlignCenter_mvcModel.hasValidationWidgets || OutSystemsUI_Content_Tooltip_mvcModel.hasValidationWidgets) || ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvcModel.hasValidationWidgets);
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

if("SupplierNumber" in inputs) {
this.variables.supplierNumberIn = inputs.SupplierNumber;
if("_supplierNumberInDataFetchStatus" in inputs) {
this.variables._supplierNumberInDataFetchStatus = inputs._supplierNumberInDataFetchStatus;
}

}

if("TotalAmount" in inputs) {
this.variables.totalAmountIn = inputs.TotalAmount;
if("_totalAmountInDataFetchStatus" in inputs) {
this.variables._totalAmountInDataFetchStatus = inputs._totalAmountInDataFetchStatus;
}

}

if("i_InvoiceAccountingId" in inputs) {
this.variables.i_InvoiceAccountingIdIn = inputs.i_InvoiceAccountingId;
if("_i_InvoiceAccountingIdInDataFetchStatus" in inputs) {
this.variables._i_InvoiceAccountingIdInDataFetchStatus = inputs._i_InvoiceAccountingIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


