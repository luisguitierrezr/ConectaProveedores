import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure } from "./ConectaProveedores.model.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";


class GetSupplierDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("ExpedicionFiscal", "expedicionFiscalOut", "ExpedicionFiscal", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsNational", "isNationalOut", "IsNational", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Name", "nameOut", "Name", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("RFC", "rFCOut", "RFC", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("Society", "societyOut", "Society", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("SupplierNr", "supplierNrOut", "SupplierNr", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, true), 
this.attr("IsActiveDEV_TK395", "isActiveDEV_TK395Out", "IsActiveDEV_TK395", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetSupplierDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("ErrorMsg", "errorMsgVar", "ErrorMsg", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("FilesList", "filesListVar", "FilesList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))), 
this.attr("IsOpenPopupForeigner", "isOpenPopupForeignerVar", "IsOpenPopupForeigner", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("InvoiceForeign", "invoiceForeignVar", "InvoiceForeign", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_6f620840109ac6f721328b723ec0152cStructure());
}, false, ST_6f620840109ac6f721328b723ec0152cStructure), 
this.attr("ShowTitle", "showTitleIn", "ShowTitle", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_showTitleInDataFetchStatus", "_showTitleInDataFetchStatus", "_showTitleInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OrderId", "orderIdIn", "OrderId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_orderIdInDataFetchStatus", "_orderIdInDataFetchStatus", "_orderIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("OrderAccConceptsId", "orderAccConceptsIdIn", "OrderAccConceptsId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_orderAccConceptsIdInDataFetchStatus", "_orderAccConceptsIdInDataFetchStatus", "_orderAccConceptsIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("AccountingDataTypeId", "accountingDataTypeIdIn", "AccountingDataTypeId", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("_accountingDataTypeIdInDataFetchStatus", "_accountingDataTypeIdInDataFetchStatus", "_accountingDataTypeIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetSupplier", "getSupplierDataAct", "GetSupplier", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierDataActRec());
}, true, GetSupplierDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_Name: OS$Model.ValidationWidgetRecord,
Input_Name2: OS$Model.ValidationWidgetRecord,
Input_Name3: OS$Model.ValidationWidgetRecord,
Input_Name10: OS$Model.ValidationWidgetRecord,
Input_Name4: OS$Model.ValidationWidgetRecord,
Input_Name9: OS$Model.ValidationWidgetRecord,
Input_InvoiceDate: OS$Model.ValidationWidgetRecord,
Input_Name6: OS$Model.ValidationWidgetRecord,
Input_AmountByServiceType: OS$Model.ValidationWidgetRecord,
Input_Name12: OS$Model.ValidationWidgetRecord
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
if("ShowTitle" in inputs) {
this.variables.showTitleIn = inputs.ShowTitle;
if("_showTitleInDataFetchStatus" in inputs) {
this.variables._showTitleInDataFetchStatus = inputs._showTitleInDataFetchStatus;
}

}

if("OrderId" in inputs) {
this.variables.orderIdIn = inputs.OrderId;
if("_orderIdInDataFetchStatus" in inputs) {
this.variables._orderIdInDataFetchStatus = inputs._orderIdInDataFetchStatus;
}

}

if("OrderAccConceptsId" in inputs) {
this.variables.orderAccConceptsIdIn = inputs.OrderAccConceptsId;
if("_orderAccConceptsIdInDataFetchStatus" in inputs) {
this.variables._orderAccConceptsIdInDataFetchStatus = inputs._orderAccConceptsIdInDataFetchStatus;
}

}

if("AccountingDataTypeId" in inputs) {
this.variables.accountingDataTypeIdIn = inputs.AccountingDataTypeId;
if("_accountingDataTypeIdInDataFetchStatus" in inputs) {
this.variables._accountingDataTypeIdInDataFetchStatus = inputs._accountingDataTypeIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


