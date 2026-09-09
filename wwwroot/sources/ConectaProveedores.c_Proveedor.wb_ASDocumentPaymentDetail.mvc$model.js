import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { ST_99acd807840db0272ca95b7e5ca3fca1Structure } from "./ConectaBapi.model.js";
import { EN_17720044fda96c0c2d8d0760c429f48aEntityRecord } from "./Organization.model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("L_T_FAC_PAG", "l_T_FAC_PAGVar", "L_T_FAC_PAG", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_99acd807840db0272ca95b7e5ca3fca1Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_99acd807840db0272ca95b7e5ca3fca1Structure))), 
this.attr("L_T_FAC_PAGOriginal", "l_T_FAC_PAGOriginalVar", "L_T_FAC_PAGOriginal", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_99acd807840db0272ca95b7e5ca3fca1Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_99acd807840db0272ca95b7e5ca3fca1Structure))), 
this.attr("l_Keyword", "l_KeywordVar", "l_Keyword", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("i_T_FAC_PAG", "i_T_FAC_PAGIn", "i_T_FAC_PAG", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(ST_99acd807840db0272ca95b7e5ca3fca1Structure))());
}, false, (OS$GenericTypeCache.getGenericList(ST_99acd807840db0272ca95b7e5ca3fca1Structure))), 
this.attr("_i_T_FAC_PAGInDataFetchStatus", "_i_T_FAC_PAGInDataFetchStatus", "_i_T_FAC_PAGInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_PaymentTerms", "i_PaymentTermsIn", "i_PaymentTerms", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(EN_17720044fda96c0c2d8d0760c429f48aEntityRecord))());
}, false, (OS$GenericTypeCache.getGenericList(EN_17720044fda96c0c2d8d0760c429f48aEntityRecord))), 
this.attr("_i_PaymentTermsInDataFetchStatus", "_i_PaymentTermsInDataFetchStatus", "_i_PaymentTermsInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_ShowFilter", "i_ShowFilterIn", "i_ShowFilter", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("_i_ShowFilterInDataFetchStatus", "_i_ShowFilterInDataFetchStatus", "_i_ShowFilterInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false)
].concat(OS$DataTypes.GenericRecord.attributesToDeclare.call(this));
}

}

VariablesRecord.init();

class WidgetsRecord extends 
OS$Model.BaseWidgetRecordMap {
static getWidgetsType() {
return {
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
if("i_T_FAC_PAG" in inputs) {
this.variables.i_T_FAC_PAGIn = inputs.i_T_FAC_PAG;
if("_i_T_FAC_PAGInDataFetchStatus" in inputs) {
this.variables._i_T_FAC_PAGInDataFetchStatus = inputs._i_T_FAC_PAGInDataFetchStatus;
}

}

if("i_PaymentTerms" in inputs) {
this.variables.i_PaymentTermsIn = inputs.i_PaymentTerms;
if("_i_PaymentTermsInDataFetchStatus" in inputs) {
this.variables._i_PaymentTermsInDataFetchStatus = inputs._i_PaymentTermsInDataFetchStatus;
}

}

if("i_ShowFilter" in inputs) {
this.variables.i_ShowFilterIn = inputs.i_ShowFilter;
if("_i_ShowFilterInDataFetchStatus" in inputs) {
this.variables._i_ShowFilterInDataFetchStatus = inputs._i_ShowFilterInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


