import { Model as OS$Model, DataTypes as OS$DataTypes, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import { EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord } from "./ConectaProveedores.model.js";
import OutSystemsUI_Content_AccordionItem_mvcModel from "./OutSystemsUI.Content.AccordionItem.mvc$model.js";
import OutSystemsUI_Utilities_Separator_mvcModel from "./OutSystemsUI.Utilities.Separator.mvc$model.js";



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_ExtendedClass", "i_ExtendedClassIn", "i_ExtendedClass", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_ExtendedClassInDataFetchStatus", "_i_ExtendedClassInDataFetchStatus", "_i_ExtendedClassInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("InvoiceExtendedTaxList", "invoiceExtendedTaxListIn", "InvoiceExtendedTaxList", true, false, OS$DataTypes.DataTypes.RecordList, function () {
return OS$DataTypes.ImmutableBase.getData(new (OS$GenericTypeCache.getGenericList(EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord))());
}, false, (OS$GenericTypeCache.getGenericList(EN_9a1e28c9eaa6b8ab0560ccd355c7e0e5EntityRecord))), 
this.attr("_invoiceExtendedTaxListInDataFetchStatus", "_invoiceExtendedTaxListInDataFetchStatus", "_invoiceExtendedTaxListInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
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
Model._hasValidationWidgetsValue = (OutSystemsUI_Content_AccordionItem_mvcModel.hasValidationWidgets || OutSystemsUI_Utilities_Separator_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("i_ExtendedClass" in inputs) {
this.variables.i_ExtendedClassIn = inputs.i_ExtendedClass;
if("_i_ExtendedClassInDataFetchStatus" in inputs) {
this.variables._i_ExtendedClassInDataFetchStatus = inputs._i_ExtendedClassInDataFetchStatus;
}

}

if("InvoiceExtendedTaxList" in inputs) {
this.variables.invoiceExtendedTaxListIn = inputs.InvoiceExtendedTaxList;
if("_invoiceExtendedTaxListInDataFetchStatus" in inputs) {
this.variables._invoiceExtendedTaxListInDataFetchStatus = inputs._invoiceExtendedTaxListInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


