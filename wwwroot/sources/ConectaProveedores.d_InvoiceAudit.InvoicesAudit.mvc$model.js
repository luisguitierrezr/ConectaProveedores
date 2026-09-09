import { Model as OS$Model, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_cad676a01e44d775889bfdee9f2eda1f } from "./ConectaProveedores.model.js";
import { EN_31f501c551d210017fcb34b5237e3390EntityRecord, EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord } from "./Organization.model.js";


class GetUserRegionDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("RegionId", "regionIdOut", "RegionId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, true), 
this.attr("IsCorp", "isCorpOut", "IsCorp", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetUserRegionDataActRec.init();

class GetInvoiceDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("InvoiceRecord", "invoiceRecordOut", "InvoiceRecord", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new RC_cad676a01e44d775889bfdee9f2eda1f());
}, true, RC_cad676a01e44d775889bfdee9f2eda1f), 
this.attr("HasDifferentRegions", "hasDifferentRegionsOut", "HasDifferentRegions", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, true), 
this.attr("Region", "regionOut", "Region", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new EN_31f501c551d210017fcb34b5237e3390EntityRecord());
}, true, EN_31f501c551d210017fcb34b5237e3390EntityRecord), 
this.attr("Supplier", "supplierOut", "Supplier", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord());
}, true, EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetInvoiceDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("HasSearched", "hasSearchedVar", "HasSearched", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("InvoiceName", "invoiceNameVar", "InvoiceName", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("GetUserRegion", "getUserRegionDataAct", "GetUserRegion", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetUserRegionDataActRec());
}, true, GetUserRegionDataActRec), 
this.attr("GetInvoice", "getInvoiceDataAct", "GetInvoice", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceDataActRec());
}, true, GetInvoiceDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Input_InvoiceName: OS$Model.ValidationWidgetRecord
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


