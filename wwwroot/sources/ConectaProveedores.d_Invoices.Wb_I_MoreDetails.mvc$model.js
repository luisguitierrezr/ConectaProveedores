import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord, RC_b64650646295f01a3e7c46ac44009d3c } from "./ConectaProveedores.model.js";
import OutSystemsUI_Adaptive_Columns2_mvcModel from "./OutSystemsUI.Adaptive.Columns2.mvc$model.js";

class LatestInvoiceCommentAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord, {
name: "InvoiceComment",
attrName: "invoiceCommentAttr",
nameForJson: "InvoiceComment",
uniqueId: "85ff0b93-1557-17e6-346b-97d39d3b0222"
}))));
}
static fromStructure(str) {
return new LatestInvoiceCommentAggrRec(new LatestInvoiceCommentAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

LatestInvoiceCommentAggrRec.init();

class MoreDetailsAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_b64650646295f01a3e7c46ac44009d3c));
}
static fromStructure(str) {
return new MoreDetailsAggrRec(new MoreDetailsAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

MoreDetailsAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("TableSort", "tableSortVar", "TableSort", true, false, OS$DataTypes.DataTypes.Text, function () {
return "";
}, false), 
this.attr("InvoiceId", "invoiceIdIn", "InvoiceId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_invoiceIdInDataFetchStatus", "_invoiceIdInDataFetchStatus", "_invoiceIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("LatestInvoiceComment", "latestInvoiceCommentAggr", "LatestInvoiceComment", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new LatestInvoiceCommentAggrRec());
}, true, LatestInvoiceCommentAggrRec), 
this.attr("MoreDetails", "moreDetailsAggr", "MoreDetails", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new MoreDetailsAggrRec());
}, true, MoreDetailsAggrRec)
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
Model._hasValidationWidgetsValue = OutSystemsUI_Adaptive_Columns2_mvcModel.hasValidationWidgets;
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("InvoiceId" in inputs) {
this.variables.invoiceIdIn = inputs.InvoiceId;
if("_invoiceIdInDataFetchStatus" in inputs) {
this.variables._invoiceIdInDataFetchStatus = inputs._invoiceIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


