import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { EN_096339be3ef098b3762e8897e3a1c095EntityRecord } from "./ConectaProveedores.model.js";
import OutSystemsUI_Content_Tag_mvcModel from "./OutSystemsUI.Content.Tag.mvc$model.js";
import ConectaProveedores_y_Utils_Wb_FilesList_mvcModel from "./ConectaProveedores.y_Utils.Wb_FilesList.mvc$model.js";

class GetOrderFileByIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList((OS$GenericTypeCache.getImplicitRecord(EN_096339be3ef098b3762e8897e3a1c095EntityRecord, {
name: "OrderFile",
attrName: "orderFileAttr",
nameForJson: "OrderFile",
uniqueId: "a7394a35-3dc1-b7f6-36aa-ced209e66116"
}))));
}
static fromStructure(str) {
return new GetOrderFileByIdAggrRec(new GetOrderFileByIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetOrderFileByIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("IsOpenPopupOtherFiles", "isOpenPopupOtherFilesVar", "IsOpenPopupOtherFiles", true, false, OS$DataTypes.DataTypes.Boolean, function () {
return false;
}, false), 
this.attr("OrderFileId", "orderFileIdIn", "OrderFileId", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_orderFileIdInDataFetchStatus", "_orderFileIdInDataFetchStatus", "_orderFileIdInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetOrderFileById", "getOrderFileByIdAggr", "GetOrderFileById", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetOrderFileByIdAggrRec());
}, true, GetOrderFileByIdAggrRec)
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
if("OrderFileId" in inputs) {
this.variables.orderFileIdIn = inputs.OrderFileId;
if("_orderFileIdInDataFetchStatus" in inputs) {
this.variables._orderFileIdInDataFetchStatus = inputs._orderFileIdInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


