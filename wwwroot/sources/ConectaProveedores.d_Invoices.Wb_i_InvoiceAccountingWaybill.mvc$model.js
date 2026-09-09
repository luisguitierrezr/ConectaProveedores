import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_9bd576a05df3846c52ce88a606aff414EntityRecord } from "./ConectaProveedores.model.js";
import OutSystemsUI_Content_AccordionItem_mvcModel from "./OutSystemsUI.Content.AccordionItem.mvc$model.js";

class GetInvoiceWaybillAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_9bd576a05df3846c52ce88a606aff414EntityRecord, {
name: "InvoiceExtendedCartaPorte",
attrName: "invoiceExtendedCartaPorteAttr",
nameForJson: "InvoiceExtendedCartaPorte",
uniqueId: "79b83114-27bc-be4c-e4ec-be042bf03773"
}))));
}
static fromStructure(str) {
return new GetInvoiceWaybillAggrRec(new GetInvoiceWaybillAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceWaybillAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("i_InvoiceId", "i_InvoiceIdIn", "i_InvoiceId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_i_InvoiceIdInDataFetchStatus", "_i_InvoiceIdInDataFetchStatus", "_i_InvoiceIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("i_ExtendedClass", "i_ExtendedClassIn", "i_ExtendedClass", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("_i_ExtendedClassInDataFetchStatus", "_i_ExtendedClassInDataFetchStatus", "_i_ExtendedClassInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetInvoiceWaybill", "getInvoiceWaybillAggr", "GetInvoiceWaybill", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceWaybillAggrRec());
}, true, GetInvoiceWaybillAggrRec)
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
Model._hasValidationWidgetsValue = OutSystemsUI_Content_AccordionItem_mvcModel.hasValidationWidgets;
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

if("i_ExtendedClass" in inputs) {
this.variables.i_ExtendedClassIn = inputs.i_ExtendedClass;
if("_i_ExtendedClassInDataFetchStatus" in inputs) {
this.variables._i_ExtendedClassInDataFetchStatus = inputs._i_ExtendedClassInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


