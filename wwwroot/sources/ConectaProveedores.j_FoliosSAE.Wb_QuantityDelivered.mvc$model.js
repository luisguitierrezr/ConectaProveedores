import { Model as OS$Model, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { RC_d39c50b1f75893246aa84db474d82d50 } from "./ConectaProveedores.model.js";

class GetFolioItemsByOrderMainItemIdAggrRec extends 
OS$Model.AggregateRecord {
static attributesToDeclare() {
return [].concat(OS$Model.AggregateRecord.attributesToDeclare.call(this));
}

static get RecordListType() {return (OS$GenericTypeCache.getGenericList(RC_d39c50b1f75893246aa84db474d82d50));
}
static fromStructure(str) {
return new GetFolioItemsByOrderMainItemIdAggrRec(new GetFolioItemsByOrderMainItemIdAggrRec.RecordClass({
RecordListType: OS$DataTypes.ImmutableBase.getData(str)
}));
}

}

GetFolioItemsByOrderMainItemIdAggrRec.init();



class VariablesRecord extends 
OS$DataTypes.GenericRecord {
static attributesToDeclare() {
return [
this.attr("OrderMainItemID", "orderMainItemIDIn", "OrderMainItemID", true, false, OS$DataTypes.DataTypes.LongInteger, function () {
return OS$DataTypes.LongInteger.defaultValue;
}, false), 
this.attr("_orderMainItemIDInDataFetchStatus", "_orderMainItemIDInDataFetchStatus", "_orderMainItemIDInDataFetchStatus", true, false, OS$DataTypes.DataTypes.Integer, function () {
return /*Fetched*/ 1;
}, false), 
this.attr("GetFolioItemsByOrderMainItemId", "getFolioItemsByOrderMainItemIdAggr", "GetFolioItemsByOrderMainItemId", true, true, OS$DataTypes.DataTypes.Record, function () {
return OS$DataTypes.ImmutableBase.getData(new GetFolioItemsByOrderMainItemIdAggrRec());
}, true, GetFolioItemsByOrderMainItemIdAggrRec)
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

static get hasValidationWidgets() {return false;
}
setInputs(inputs) {
if("OrderMainItemID" in inputs) {
this.variables.orderMainItemIDIn = inputs.OrderMainItemID;
if("_orderMainItemIDInDataFetchStatus" in inputs) {
this.variables._orderMainItemIDInDataFetchStatus = inputs._orderMainItemIDInDataFetchStatus;
}

}

}

}

Model._hasValidationWidgetsValue = undefined;
export default new OS$Model.ModelFactory(Model);


