import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_0c929027c696b201a1aceb2f23c1d74d } from "./ConectaProveedores.model.js";
import Telcel_Theme_Utils_Wb_ShortText_mvcModel from "./Telcel_Theme.Utils.Wb_ShortText.mvc$model.js";

class GetInvoiceApprovalsCurrentApproverAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_0c929027c696b201a1aceb2f23c1d74d));
}
static fromStructure(str) {
return new GetInvoiceApprovalsCurrentApproverAggrRec(new GetInvoiceApprovalsCurrentApproverAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetInvoiceApprovalsCurrentApproverAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("InvoiceId", "invoiceIdIn", "InvoiceId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_invoiceIdInDataFetchStatus", "_invoiceIdInDataFetchStatus", "_invoiceIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetInvoiceApprovalsCurrentApprover", "getInvoiceApprovalsCurrentApproverAggr", "GetInvoiceApprovalsCurrentApprover", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetInvoiceApprovalsCurrentApproverAggrRec());
}, true, GetInvoiceApprovalsCurrentApproverAggrRec)
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
Model._hasValidationWidgetsValue = Telcel_Theme_Utils_Wb_ShortText_mvcModel.hasValidationWidgets;
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


