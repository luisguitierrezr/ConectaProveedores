import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord } from "./ConectaProveedores.model.js";
import OutSystemsUI_Content_Tag_mvcModel from "./OutSystemsUI.Content.Tag.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_FilesList_mvcModel from "./ConectaProveedores.y_Utils.Wb_FilesList.mvc$model.js";

class GetOrderRequestFileByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord, {
name: "OrderRequestFile",
attrName: "orderRequestFileAttr",
nameForJson: "OrderRequestFile",
uniqueId: "73d8126c-722e-2b4d-d662-dab2bf1a72d1"
}))));
}
static fromStructure(str) {
return new GetOrderRequestFileByIdAggrRec(new GetOrderRequestFileByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderRequestFileByIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("IsOpenPopupOtherFiles", "isOpenPopupOtherFilesVar", "IsOpenPopupOtherFiles", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("OrderRequestFileId", "orderRequestFileIdIn", "OrderRequestFileId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_orderRequestFileIdInDataFetchStatus", "_orderRequestFileIdInDataFetchStatus", "_orderRequestFileIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetOrderRequestFileById", "getOrderRequestFileByIdAggr", "GetOrderRequestFileById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderRequestFileByIdAggrRec());
}, true, GetOrderRequestFileByIdAggrRec)
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
Model._hasValidationWidgetsValue = (OutSystemsUI_Content_Tag_mvcModel.hasValidationWidgets || ConectaProveedores_y_Utils_Wb_FilesList_mvcModel.hasValidationWidgets);
}

return Model._hasValidationWidgetsValue;
}
setInputs(inputs) {
if("OrderRequestFileId" in inputs) {
this.variables.orderRequestFileIdIn = inputs.OrderRequestFileId;
if("_orderRequestFileIdInDataFetchStatus" in inputs) {
this.variables._orderRequestFileIdInDataFetchStatus = inputs._orderRequestFileIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


