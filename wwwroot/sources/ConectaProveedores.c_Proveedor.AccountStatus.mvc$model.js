import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { RC_3f6ba4c81bcd03d8108335ecd7631ff4, RC_5df7bb5aa64fe06d5d087faa4a2fd561 } from "./ConectaProveedores.model.js";
import { EN_17720044fda96c0c2d8d0760c429f48aEntityRecord, EN_31f501c551d210017fcb34b5237e3390EntityRecord } from "./Organization.model.js";
import { ST_382afa1d8361f400b6ea03403d75e294Structure } from "./TelcelIntegrations.model.js";
import { ST_9f44b824af1405b8fbe038a5a393bb86Structure } from "./ConectaBapi.model.js";

class GetSupplierUserByUserIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_3f6ba4c81bcd03d8108335ecd7631ff4));
}
static fromStructure(str) {
return new GetSupplierUserByUserIdAggrRec(new GetSupplierUserByUserIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSupplierUserByUserIdAggrRec.init();

class GetSupplierDetailsBySupplierIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_5df7bb5aa64fe06d5d087faa4a2fd561));
}
static fromStructure(str) {
return new GetSupplierDetailsBySupplierIdAggrRec(new GetSupplierDetailsBySupplierIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSupplierDetailsBySupplierIdAggrRec.init();

class GetPaymentTermsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_17720044fda96c0c2d8d0760c429f48aEntityRecord, {
name: "PaymentTerms",
attrName: "paymentTermsAttr",
nameForJson: "PaymentTerms",
uniqueId: "5526bab1-a997-40bd-870d-de6a69ba3d9a"
}))));
}
static fromStructure(str) {
return new GetPaymentTermsAggrRec(new GetPaymentTermsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetPaymentTermsAggrRec.init();

class GetRegionsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_31f501c551d210017fcb34b5237e3390EntityRecord, {
name: "Region",
attrName: "regionAttr",
nameForJson: "Region",
uniqueId: "deb85dc3-6640-fa92-8dae-5df2493065d0"
}))));
}
static fromStructure(str) {
return new GetRegionsAggrRec(new GetRegionsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetRegionsAggrRec.init();


class GetSapDataDataActRec extends 
OS$Model.DataSourceRecord {
static attributesToDeclare() {
return [
this.attr("List", "listOut", "List", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new ST_382afa1d8361f400b6ea03403d75e294Structure());
}, true, ST_382afa1d8361f400b6ea03403d75e294Structure), 
this.attr("Totalenmonedanacional", "totalenmonedanacionalOut", "Totalenmonedanacional", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$BuiltinFunctions.integerToDecimal(0);
}, true), 
this.attr("Importetotaldefacturasmonedaextranjera", "importetotaldefacturasmonedaextranjeraOut", "Importetotaldefacturasmonedaextranjera", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$BuiltinFunctions.integerToDecimal(0);
}, true), 
this.attr("Totalenmonedanacional2", "totalenmonedanacional2Out", "Totalenmonedanacional2", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$BuiltinFunctions.integerToDecimal(0);
}, true), 
this.attr("Importetotaldefacturasmonedaextranjera2", "importetotaldefacturasmonedaextranjera2Out", "Importetotaldefacturasmonedaextranjera2", true, false, OS$DataTypes.DataTypes.Decimal, function () {
return OS$BuiltinFunctions.integerToDecimal(0);
}, true)
].concat(OS$Model.DataSourceRecord.attributesToDeclare.call(this));
}

}

GetSapDataDataActRec.init();


class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("SupplierDetailIdentifier", "supplierDetailIdentifierVar", "SupplierDetailIdentifier", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("ViewDetail", "viewDetailVar", "ViewDetail", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("RegionSelected", "regionSelectedVar", "RegionSelected", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("MaxRecords", "maxRecordsVar", "MaxRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 20;
}, false), 
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("StartIndex", "startIndexVar", "StartIndex", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("L_FACTPENPAG", "l_FACTPENPAGVar", "L_FACTPENPAG", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_9f44b824af1405b8fbe038a5a393bb86Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_9f44b824af1405b8fbe038a5a393bb86Structure))), 
this.attr("L_FACTPENPAGFiltered", "l_FACTPENPAGFilteredVar", "L_FACTPENPAGFiltered", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_9f44b824af1405b8fbe038a5a393bb86Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_9f44b824af1405b8fbe038a5a393bb86Structure))), 
this.attr("TotalRecords", "totalRecordsVar", "TotalRecords", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("InvoiceTextNumber", "invoiceTextNumberVar", "InvoiceTextNumber", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("DateTime", "dateTimeVar", "DateTime", true, false, OS$DataTypes.DataTypes.DateTime, function () {
return OS$BuiltinFunctions.currDateTime();
}, false), 
this.attr("l_Tab", "l_TabVar", "l_Tab", true, false, OS$DataTypes.DataTypes.Integer, function () {
return 0;
}, false), 
this.attr("GetSupplierUserByUserId", "getSupplierUserByUserIdAggr", "GetSupplierUserByUserId", true, false, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierUserByUserIdAggrRec());
}, true, GetSupplierUserByUserIdAggrRec), 
this.attr("GetSupplierDetailsBySupplierId", "getSupplierDetailsBySupplierIdAggr", "GetSupplierDetailsBySupplierId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierDetailsBySupplierIdAggrRec());
}, true, GetSupplierDetailsBySupplierIdAggrRec), 
this.attr("GetPaymentTerms", "getPaymentTermsAggr", "GetPaymentTerms", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPaymentTermsAggrRec());
}, true, GetPaymentTermsAggrRec), 
this.attr("GetRegions", "getRegionsAggr", "GetRegions", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetRegionsAggrRec());
}, true, GetRegionsAggrRec), 
this.attr("GetSapData", "getSapDataDataAct", "GetSapData", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSapDataDataActRec());
}, true, GetSapDataDataActRec)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
Dropdown1: OS$Model.ValidationWidgetRecord,
Dropdown2: OS$Model.ValidationWidgetRecord,
Input1: OS$Model.ValidationWidgetRecord,
Input2: OS$Model.ValidationWidgetRecord,
Input3: OS$Model.ValidationWidgetRecord,
Input4: OS$Model.ValidationWidgetRecord,
Input5: OS$Model.ValidationWidgetRecord,
Input_InvoiceTextNumber: OS$Model.ValidationWidgetRecord
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


