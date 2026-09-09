import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions, DataConversion } from "@outsystems/runtime-core-js";
import { RC_c81aee5ce0504fe68694be6deb703b5e } from "./ConectaProveedores.model.js";
import { EN_17720044fda96c0c2d8d0760c429f48aEntityRecord } from "./Organization.model.js";
import { ST_382afa1d8361f400b6ea03403d75e294Structure } from "./TelcelIntegrations.model.js";
import UltimatePDF_PrintLayout_ScreenToPDF_mvcModel from "./UltimatePDF.PrintLayout.ScreenToPDF.mvc$model.js";
import UltimatePDF_PrintLayout_PrintLayout_mvcModel from "./UltimatePDF.PrintLayout.PrintLayout.mvc$model.js";
import OutSystemsUI_Utilities_Separator_mvcModel from "./OutSystemsUI.Utilities.Separator.mvc$model.js";
import ConectaProveedores_c_Proveedor_wb_ASDocumentPaymentDetail_mvcModel from "./ConectaProveedores.c_Proveedor.wb_ASDocumentPaymentDetail.mvc$model.js";

class GetSupplierUserByUserIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_c81aee5ce0504fe68694be6deb703b5e));
}
static fromStructure(str) {
return new GetSupplierUserByUserIdAggrRec(new GetSupplierUserByUserIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetSupplierUserByUserIdAggrRec.init();

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
this.attr("I_ACREEDOR", "i_ACREEDORIn", "I_ACREEDOR", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_ACREEDORInDataFetchStatus", "_i_ACREEDORInDataFetchStatus", "_i_ACREEDORInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("I_ANTICIPOS_HIGH", "i_ANTICIPOS_HIGHIn", "I_ANTICIPOS_HIGH", true, false, OS$DataTypes.DataTypes.Date, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_i_ANTICIPOS_HIGHInDataFetchStatus", "_i_ANTICIPOS_HIGHInDataFetchStatus", "_i_ANTICIPOS_HIGHInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("I_ANTICIPOS_LOW", "i_ANTICIPOS_LOWIn", "I_ANTICIPOS_LOW", true, false, OS$DataTypes.DataTypes.Date, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_i_ANTICIPOS_LOWInDataFetchStatus", "_i_ANTICIPOS_LOWInDataFetchStatus", "_i_ANTICIPOS_LOWInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("I_F_PARTABIE", "i_F_PARTABIEIn", "I_F_PARTABIE", true, false, OS$DataTypes.DataTypes.Date, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_i_F_PARTABIEInDataFetchStatus", "_i_F_PARTABIEInDataFetchStatus", "_i_F_PARTABIEInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("I_PCOMP_HIGH", "i_PCOMP_HIGHIn", "I_PCOMP_HIGH", true, false, OS$DataTypes.DataTypes.Date, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_i_PCOMP_HIGHInDataFetchStatus", "_i_PCOMP_HIGHInDataFetchStatus", "_i_PCOMP_HIGHInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("I_PCOMP_LOW", "i_PCOMP_LOWIn", "I_PCOMP_LOW", true, false, OS$DataTypes.DataTypes.Date, function () {
return OS$DataTypes.DateTime.defaultValue;
}, false), 
this.attr("_i_PCOMP_LOWInDataFetchStatus", "_i_PCOMP_LOWInDataFetchStatus", "_i_PCOMP_LOWInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("I_REGION", "i_REGIONIn", "I_REGION", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_REGIONInDataFetchStatus", "_i_REGIONInDataFetchStatus", "_i_REGIONInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("I_SOCIEDAD", "i_SOCIEDADIn", "I_SOCIEDAD", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_SOCIEDADInDataFetchStatus", "_i_SOCIEDADInDataFetchStatus", "_i_SOCIEDADInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("SupplierId", "supplierIdIn", "SupplierId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_supplierIdInDataFetchStatus", "_supplierIdInDataFetchStatus", "_supplierIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetSupplierUserByUserId", "getSupplierUserByUserIdAggr", "GetSupplierUserByUserId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetSupplierUserByUserIdAggrRec());
}, true, GetSupplierUserByUserIdAggrRec), 
this.attr("GetPaymentTerms", "getPaymentTermsAggr", "GetPaymentTerms", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetPaymentTermsAggrRec());
}, true, GetPaymentTermsAggrRec), 
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
Model._hasValidationWidgetsValue = (((UltimatePDF_PrintLayout_ScreenToPDF_mvcModel.hasValidationWidgets || UltimatePDF_PrintLayout_PrintLayout_mvcModel.hasValidationWidgets) || OutSystemsUI_Utilities_Separator_mvcModel.hasValidationWidgets) || ConectaProveedores_c_Proveedor_wb_ASDocumentPaymentDetail_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("I_ACREEDOR" in inputs) {
this.variables.i_ACREEDORIn = DataConversion.ServerDataConverter.from(inputs.I_ACREEDOR, OS$DataTypes.DataTypes.Text);
}

if("I_ANTICIPOS_HIGH" in inputs) {
this.variables.i_ANTICIPOS_HIGHIn = DataConversion.ServerDataConverter.from(inputs.I_ANTICIPOS_HIGH, OS$DataTypes.DataTypes.Date);
}

if("I_ANTICIPOS_LOW" in inputs) {
this.variables.i_ANTICIPOS_LOWIn = DataConversion.ServerDataConverter.from(inputs.I_ANTICIPOS_LOW, OS$DataTypes.DataTypes.Date);
}

if("I_F_PARTABIE" in inputs) {
this.variables.i_F_PARTABIEIn = DataConversion.ServerDataConverter.from(inputs.I_F_PARTABIE, OS$DataTypes.DataTypes.Date);
}

if("I_PCOMP_HIGH" in inputs) {
this.variables.i_PCOMP_HIGHIn = DataConversion.ServerDataConverter.from(inputs.I_PCOMP_HIGH, OS$DataTypes.DataTypes.Date);
}

if("I_PCOMP_LOW" in inputs) {
this.variables.i_PCOMP_LOWIn = DataConversion.ServerDataConverter.from(inputs.I_PCOMP_LOW, OS$DataTypes.DataTypes.Date);
}

if("I_REGION" in inputs) {
this.variables.i_REGIONIn = DataConversion.ServerDataConverter.from(inputs.I_REGION, OS$DataTypes.DataTypes.Text);
}

if("I_SOCIEDAD" in inputs) {
this.variables.i_SOCIEDADIn = DataConversion.ServerDataConverter.from(inputs.I_SOCIEDAD, OS$DataTypes.DataTypes.Text);
}

if("SupplierId" in inputs) {
this.variables.supplierIdIn = DataConversion.ServerDataConverter.from(inputs.SupplierId, OS$DataTypes.DataTypes.LongInteger);
}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


